using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Api.Connectors;
using Nusantara.Api.Models;
using Nusantara.Services;

namespace Nusantara.Forms
{
    public partial class accrossTransferPage : UserControl
    {
        public accrossTransferPage(Member member)
        {
            loggedMmember = member;
            InitializeComponent();
        }


        private void accrossTransferPage_Load(object sender, EventArgs e)
        {
            timerInBox.Enabled = false;
            if (LoggedMember.ReferenceId == null || LoggedMember.ReferenceId == "" || LoggedMember.ReferenceId == "~-")
            {
                DialogResult result = MessageBox.Show("You do not have a privilege to Use Across Transfer. Registration Now?", "Invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    String message;
                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }
                    MessageBox.Show(message, "Registration Info", MessageBoxButtons.OK);
                }
            }
            else
            {
                timerInBox.Enabled = true;
            }
        }

        private async Task<string> MemberRegistration(AppDbContext db)
        {
            string message = "Success";

            MemberService memberService = new MemberService(db);
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationService configurationService = new ConfigurationService(db);

            Configuration? configuration = await configurationService.GetConfig();
            if (configuration == null)
                return "Configuration not found";

            if (configuration.terminologi3 == null || configuration.terminologi3 == "")
                return "Coop not registered to Across System. Please contact administrator.";

            try
            {
                var loggedMember = memberService.GetLoggedMember();
                if (loggedMember == null)
                    return "No logged member.";

                MemberApiResponse? memberApiResponse = await connectorPost.MemberRegistrationAsync(
                    new MemberPayload
                    {
                        name = loggedMember.FullName,
                        address = loggedMember.Address,
                        code = loggedMember.MemberId,
                        coopCode = configuration.terminologi3
                    }
                );

                if (memberApiResponse != null && memberApiResponse.ResponseCode == "00")
                {
                    loggedMember.ReferenceId = configuration.terminologi3;
                    memberService.Update(loggedMember);

                    balanceService balanceService = new balanceService(db);
                    balanceService.setBalance(loggedMember.MemberId);

                    timerInbox.Enabled = true;
                }
                else
                {
                    message = "Failed to register member to across system: "
                              + memberApiResponse?.ResponseMessage;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config2 = await configService.GetConfig();
            ConnectorPost connectorPost = new ConnectorPost();
            double transferAmount = Double.Parse(textAmount.Text);

            TransferApiResponse2? response = await connectorPost.TransferAsync(
                new TransferPayload
                {
                    amount = transferAmount,
                    benefCode = textBenef.Text,
                    coopCode = loggedMember.ReferenceId,
                    memberCode = loggedMember.MemberId,
                    fee = Double.Parse(config2.transferAcrossFee.ToString()),
                    remarks = textRemarks.Text,
                    transRef = textTransRef.Text,
                }
            );

            if (response != null && response.ResponseCode == "00")
            {
                BalanceService balanceService = new BalanceService(db);
                Balance? balance = await balanceService.getBalance(loggedMember.MemberId);

                if (balance != null)
                {
                    balance.Amount = Decimal.Parse(transferAmount.ToString());
                    balance.UpdateOn = DateTime.Now;
                    balance.TransactionName = "Across Transfer";
                    balance.Flow = "OUT";
                    balanceService.Update(balance);

                    BalanceApiResponse? balanceApiResponse =
                        await connectorPost.BalanceUpdateAsync(
                            new BalancePayload
                            {
                                amount = Double.Parse(balance.Amount.ToString()),
                                memberCode = loggedMember.MemberId,
                            }
                        );

                    if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
                    {
                        MessageBox.Show("Transfer Successful", "Success");
                    }
                }
            }
        }
        private void timerInbox_Tick(object sender, EventArgs e)
        {
            timerInbox.Stop();
            try 
            {
                //timerInbox.Start();
                Console.WriteLine("Retrieving ... ");
                ConnectorGet connectorGet = new ConnectorGet();
                TransferApiResponse? responseOutgoing = await connectorGet.GetOutgoingByMemberAsync(loggedMember.MemberId);
                if (responseOutgoing != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvOutgoing.DataSource = responseOutgoing.TransferList;
                    dgvOutgoing.Columns["Id"].Visible = false;
                    dgvOutgoing.Columns["MemberCode"].Visible = false;
                    dgvOutgoing.Columns["BenefCode"].HeaderText = "Beneficiary";
                    dgvOutgoing.Columns["CoopCode"].Visible = false;
                    dgvOutgoing.Columns["updateOn"].Visible = false;
                    dgvOutgoing.Columns["TransferRef"].HeaderText = "Reference";
                    dgvOutgoing.Columns["TransferDate"].HeaderText = "Date";
                    dgvOutgoing.Columns["Amount"].HeaderText = "Amount";
                    dgvOutgoing.Columns["Fee"].HeaderText = "Fee";
                    dgvOutgoing.Columns["Remarks"].HeaderText = "Remarks";
                    dgvOutgoing.Columns["TransactionCode"].HeaderText = "Transaction Code";
                }
                String benefCode = loggedMember.ReferenceId + "-" + LoggedMember.MemberId;
                TransferApiResponse? responseIncoming = await connectorGet.GetIncomingByMemberAsync(loggedMember.MemberId);
                if (responseOutgoing != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvIncoming.Columns["Id"].Visible = false;
                    dgvIncoming.Columns["MemberCode"].HeaderText = "Member Code";
                    dgvIncoming.Columns["BenefCode"].Visible = false;
                    dgvIncoming.Columns["CoopCode"].HeaderText = "Coop Code";
                    dgvIncoming.Columns["updateOn"].Visible = false;
                    dgvIncoming.Columns["TransferRef"].HeaderText = "Reference";
                    dgvIncoming.Columns["TransferDate"].HeaderText = "Date";
                    dgvIncoming.Columns["Amount"].HeaderText = "Amount";
                    dgvIncoming.Columns["Fee"].HeaderText = "Fee";
                    dgvIncoming.Columns["Remarks"].HeaderText = "Remarks";
                    dgvIncoming.Columns["TransactionCode"].HeaderText = "Transaction Code";
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                timerInbox.Start();
            }
>>>>>>> e500343f97d82dc85154671d715c4da5d91c46ef
        }
    }
}
