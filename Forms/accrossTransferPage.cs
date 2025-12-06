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

    }
}
