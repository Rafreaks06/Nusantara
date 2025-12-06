using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Services;

namespace Nusantara.Forms
{
    public partial class TerminologiPage : UserControl
    {
        private Member? loggedMember;
        public TerminologiPage(Member? member)
        {
            InitializeComponent();
            loggedMember = member;
        }
        private async void TerminologiPage_Load(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(context);
            Configuration configuration = await configService.GetConfig();
            if (configuration != null)
            {
                labelTerminologi1.Text = configuration.terminologi1;
                labelTerminologi2.Text = configuration.terminologi2;
                labelTerminologi3.Text = configuration.terminologi3;
                labelTerminologi1.Text += configuration.exchangeRate.ToString();
                labelTerminologi3.Text += configuration.transferInhouseFee.ToString();
                labelTerminologi2.Text += configuration.transferAcrossFee.ToString();

            }
        }
    }
}
