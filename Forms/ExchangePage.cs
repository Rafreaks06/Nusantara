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
    public partial class ExchangePage : UserControl
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

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal rate = Convert.ToDecimal(txtRate.Text);
                decimal fee = Convert.ToDecimal(txtFee.Text);
                decimal total = (amount * rate) + fee;
                txtTotal.Text = total.ToString("0.00");
            }
            catch (Exception)
            {
                txtTotal.Text = "0.00";
            }
        }

    }
}
