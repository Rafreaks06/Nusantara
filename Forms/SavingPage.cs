using BraveHeroCooperation.Utils;
using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nusantara.Forms
{
    public partial class SavingPage : UserControl
    {
        Member loggedmember;
        public SavingPage(Member member)
        {
            loggedmember = member;
            InitializeComponent();
        }

        private void txtAdmin_Fee_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMin_Amount_Click(object sender, EventArgs e)
        {

        }

        private void lblDocument_KK_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_KK_Click(object sender, EventArgs e)
        {
            txtDocument_KK.Text = FileHelper.UploadDocument("KK");
        }
        private void SavingPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();
            LoadSavingGrid(db);
        }
        private void SetSavingDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            LoanMasterBindingSource.DataSource = productService.SetDropDownSaving();
            cmbSaving_Type.DisplayMember = "DisplayName";
            cmbSaving_Type.ValueMember = "Id";
        }
        private void SetDefaultField()
        {
            cmbSaving_Type.SelectedIndex = 0;

            btnShow_KTP.Visible = false;
            btnShow_KK.Visible = false;
            btnShow.Visible = false;

            btnBrowse_KTP.Visible = true;
            btnBrowse_KK.Visible = true;
            btnBrowse.Visible = true;
        }

        private void SetChosenField()
        {
            btnShow_KTP.Visible = true;
            btnShow_KK.Visible = true;
            btnShow.Visible = true;

            btnBrowse_KTP.Visible = false;
            btnBrowse_KK.Visible = false;
            btnBrowse.Visible = false;
        }
        private void ResetField()
        {
            txtDocument_KK.Text = "";
            txtDocument_KTP.Text = "";
            txtDocument_Slip_Gaji.Text = "";
            txtDue_Date.Text = "";
	        txtAmount.Text = "";
            ResetDropDown();
            txtLoanId.Text = RandomNumberGenetror.GetString("123456790", 6);

            lblID.Text = "";
        }

        private void ResetDropDown()
        {
            txtInterest.Text = "";
            txtInterest_Fine.Text = "";
            txtTenor.Text = "";
            txtAdmin_Fee.Text = "";
            txtMin_Amount.Text = "";
            txtMax_Amount.Text = "";

        }

        private async void LoadSavingGrid(AppDbContext db)
        {
            SavingService savingService = new SavingService(db);
            loanBindingSource.DataSource = await savingService.LoadSavingGrid(logged Member);
            dgv_Saving.Columns[0].DataPropertyName = "id";
            dgv_Saving.Columns[1].DataPropertyName = "SavingId";
            dgv_Saving.Columns[2].DataPropertyName = "Amount";
            dgv_Saving.Columns[3].DataPropertyName = "Tenor";

            dgv_Saving.Columns[0].Visible = false;
            dgv_Saving.Columns[1].HeaderText = "Saving ID";
            dgv_Saving.Columns[2].HeaderText = "Amount";
            dgv_Saving.Columns[3].HeaderText = "Tenor";

        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSaving_Type.SelectedIndex == 0)
                ResetDropDown();

            if (cmbSaving_Type.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(cmbSaving_Type.SelectedValue.ToString());

                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);

                if (loanMaster != null)
                {
                    txtInterest.Text = loanMaster.Interest.ToString();
                    txtInterest_Fine.Text = loanMaster.Fine.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtAdmin_Fee.Text = loanMaster.AdminFee.ToString();
                    txtMin_Amount.Text = loanMaster.MinAmount.ToString();
                    txtMax_Amount.Text = loanMaster.MaxAmount.ToString();
                }
            }
            else
            {
                ResetDropDown();
            }
        }



    }
}
