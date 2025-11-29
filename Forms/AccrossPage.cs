using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Api.Connectors;
using Nusantara.Api.Models;
using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Services;

namespace Nusantara.Forms
{
    public partial class AccrossPage : UserControl
    {
        public AccrossPage()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            AppDbContext appDbContext = new AppDbContext();
            ConfigurationService configurationService = new ConfigurationService(appDbContext);
            Configuration? configuration = await configurationService.GetConfig();

            string message = "";

            connectorGet connectorGet = new connectorGet();
            CoopApiResponse? coopApiResponse = await connectorGet.GetCoopAsync();

            if (coopApiResponse != null && coopApiResponse.ResponseCode == "00")
            {
                dgvCoop.Rows.Clear();

                foreach (var coop in coopApiResponse.CoopList)
                {
                    dgvCoop.Rows.Add(
                        coop.Code,
                        coop.Name,
                        coop.Address
                    );
                }
            }
            else
            {
                message =
                    coopApiResponse != null
                    ? coopApiResponse.ResponseCode + " - " + coopApiResponse.ResponseMessage
                    : "Did not get data";
            }
            BalanceApiResponse? balanceApiResponse =
    await connectorGet.GetBalancesByCoopAsync(configuration.terminologi3);

            if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
            {
                dgvBalance.Rows.Clear();

                foreach (var balance in balanceApiResponse.BalanceList)
                {
                    dgvBalance.Rows.Add(
                        balance.Member.Code,
                        balance.Member.Name,
                        balance.Amount
                    );
                }
            }
            else
            {
                message =
                    balanceApiResponse != null
                    ? balanceApiResponse.ResponseCode + " - " + balanceApiResponse.ResponseMessage
                    : "Did not get data";
            }


            TransferApiResponse? transferApiResponse =
                await connectorGet.GetTransfersByCoopAsync(configuration.terminologi3);

            if (transferApiResponse != null && transferApiResponse.ResponseCode == "00")
            {
                dgvTransfer.Rows.Clear();

                foreach (var transfer in transferApiResponse.TransferList)
                {
                    dgvTransfer.Rows.Add(
                        transfer.Code,
                        transfer.CoopCode,
                        transfer.CodeOrigin,
                        transfer.CodeBenef,
                        transfer.Amount,
                        transfer.Remarks
                    );
                }
            }
            else
            {
                message =
                    transferApiResponse != null
                    ? transferApiResponse.ResponseCode + " - " + transferApiResponse.ResponseMessage
                    : "Did not get data";
            }
            if (message != "")
            {
                MessageBox.Show("Failed to load data from API.\nError: " + message);
            }
        }

        private async void AccrossPage_Load(object sender, EventArgs e)
        {
            string message = "";
            AppDbContext db = new AppDbContext();
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationService configurationService = new ConfigurationService(db);

            Configuration configuration = await configurationService.GetConfig();
            if (configuration == null)
            {
                message = "Configuration not found!";
            }

            if (configuration != null)
            {
                if (configuration.terminologi3 == null || configuration.terminologi3 == "")
                {
                    DialogResult result = MessageBox.Show(
                        "Not registered yet. Register Now?",
                        "Register Across",
                        MessageBoxButtons.OKCancel
                    );

                    if (result == DialogResult.OK)
                    {
                        CoopApiResponse coopApiResponse = await connectorPost.CoopRegistrationAsync(
                            new CoopPayload
                            {
                                name = "Brave Hero Cooperation",
                                address = "Jakarta",
                                code = ""
                            }
                        );

                        if (coopApiResponse != null && coopApiResponse.CoopCode != null)
                        {
                            configuration.terminologi3 = coopApiResponse.CoopCode;
                            configurationService.Update(configuration);

                            LoadData();
                        }
                        else
                        {
                            message = "Failed to register coop to across system: "
                                      + coopApiResponse?.ResponseMessage;
                        }
                    }
                    else
                    {
                        LoadData();
                    }
                }
                else
                {
                    LoadData();
                }
            }
        }
    }
    }
