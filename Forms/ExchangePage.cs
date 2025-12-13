using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nusantara.Forms
{
    public partial class ExchangePage: UserControl
    {
        Member LoggedMember;
        public ExchangePage(Member member)
        {
            LoggedMember = member;
            InitializeComponent();
        }
        private async void ExchangePage_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "0";

            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config = await configService.GetConfig();

            txtFee.Text = config != null ? config.transferAccessFee.ToString() : "0";
            txtRate.Text = config != null ? config.exchangeRate.ToString() : "0";
        }

    }
}
