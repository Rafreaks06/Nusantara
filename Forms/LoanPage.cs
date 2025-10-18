using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nusantara.Forms
{
    public partial class LoanPage : UserControl
    {
        MemberAccessException LoggedMember;
        instalmentForm? instalmentForm;
        public LoanPage(Member member)
        {
            LoggedMember = member;
            InitializeComponent();
        }

        private void txtIntrestFine_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentKtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnktp_Click(object sender, EventArgs e)
        {
            txtDocumentKtp.Text = FileHelper.UploadDocument("KTP");
        }

        private void btnKK_Click(object sender, EventArgs e)
        {
            txtDocumentKK.Text = FileHelper.UploadDocument("KK");
        }

        private void btnGaji_Click(object sender, EventArgs e)
        {
            txtDocumentGaji.Text = FileHelper.UploadDocument("Slip Gaji");
        }

        private void LoanPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();
            LoaddatagridLoan(db);
            HideInstallment();
        }


        private void SetLoanDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            LoanMasterBindingSource.DataSource = productService.SetDropdownLoan();
            comboLoanType.DisplayerMember = "DisplayName";
            comboLoanType.ValueMember = "Id";
        }
        private void comboLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLoanType.SelectedIndex == 0)
            {
                ResetDropDown();
            }
            else
            {
                int idLoanMaster = int.Parse(comboLoanType.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);
                if (loanMaster != null)
                {
                    textInterest.Text = loanMaster.Interest.ToString();
                    txtInterestFine.Text = loanMaster.Fine.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtAdminFee.Text = loanMaster.AdminFee.ToString();
                    txtMinAmount.Text = loanMaster.MinAmount.ToString();
                    txtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropDown();
                }


            }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            btnApplyLoan.Enabled = true;
            comboLoanType.SelectedIndex = 0;
            comboLoanType.Enabled = true;
            HideInstallment();

        }
        private void SetDefaultField()
        {
            comboLoanType.SelectedIndex = 0;
            btnShowKtp.Visible = false;
            btnShowKK.Visible = false;
            btnShowGaji.Visible = false;
            btnktp.Visible = true;
            btnKK.Visible = true;
            btnGaji.Visible = true;
        }

        private void SetChosenField()
        {
            btnShowKtp.Visible = true;
            btnShowKK.Visible = true;
            btnShowGaji.Visible = true;
            btnktp.Visible = false;
            btnKK.Visible = false;
            btnGaji.Visible = false;
        }

        private void ResetField()
        {
            txtDocumentKtp.Text = "";
            txtDocClip.Text = "";
            txtDocumentGaji.Text = "";
            txtDueDate.Text = "";
            txtAmount.Text = "";
            ResetDropdown();
            txtLoan.Text = RandomNumberGenerator.GetString("1234567890", 6);
            lblId.Text = "";
        }
        private async async LoadLoanGrid(AppDbContext db)
        {
            LoanService loanService = new LoanService(db);
            loanBindingSource.DataSource = await loanService.LoadLoanGridId(LoggedMember.Id);
            datagridLoan.Columns[0].DataPropertyName = "Id";
            datagridLoan.Columns[1].DataPropertyName = "LoanId";
            datagridLoan.Columns[2].DataPropertyName = "Outstanding";
            datagridLoan.Columns[0].DataPropertyName = "tenorLeft";

            datagridLoan.Columns[0].Visible = false;
            datagridLoan.Columns[1].HeaderText = "Loan Id";
            datagridLoan.Columns[2].HeaderText = "outstanding";
            datagridLoan.Columns[3].HeaderText = "Tenor Left";
        }

        private async void datagridLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = int.Parse(datagridLoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                AppDbContext db = new AppDbContext();
                LoanService loanService = new LoanService(db);
                Loan? loan = await loanService.findBy(Id);
                if (loan != null)
                {
                    if (loan.IsAppoved)
                    {
                        SetChosenField();
                        txtDocumentKK.Text = loan.KkpPath;
                        txtDocumentKtp.Text = loan.KtpPath;
                        txtDocumentGaji.Text = loan.Path;
                        txtDueDate.Text = loan.DueDate.ToString;
                        txtInterestFine.Text = loan.Interest.ToString;
                        txtAmount.Text = loan.Amount.ToString();
                        txtTenor.Text = loan.Tenor.ToString();
                        txtAdminFee.text = loan.AdminFee.ToString();
                        txtMinAmount.Text = "";
                        txtMaxAmount.Text = "";
                        lblId.Text = loan.id.ToString();
                        comboLoanType.SelectedIndex = 0;
                        comboLoanType.Enabled = false;
                        if (instalmentForm == null)

                            instalmentForm = new installmentForm(loggedMember, 0);
                        instalmentForm.setloan(loan.Id);
                        instalmentForm.Show();

                        btnApplyLoan.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Your Loan Is Not Approved yet.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        HideInstallment();

                    }
                else
                    {
                        HideInstallment();
                    }
                }
            }
        }

        private async Task btnApplyLoan_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoanService loanService = new LoanService(db);
            decimal amount = decimal.Parse(txtAmount.Text);
            decimal minamount = decimal.Parse(txtMinAmount.Text);
            decimal maxamount = decimal.Parse(txtMaxAmount.Text);
            if (amount > maxamount || amount < minamount)
            {
                MessageBox.Show("invalid amount", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                await loanService.saveourUodate(LoggedMember, txtAmount.Text, txtDocumentKK.Text, txtDocumentKtp, txtDocumentGaji,
                    txtDueDate, txtTenor, txtAdminFee);
                LoadLoanGrid(db);
                ResetField();
            }


        }
        private void HideInstallment()
        {
            if (installmentForm == null)
                installmentForm = new InstallmentForm(loggedMember, 0);
            installmentForm.SetLoan(0);
            installmentForm.Hide();
        }

        private void ResetDropDown()
        {
            txtInterestFine.Text = "";
            textInterest.Text = "";
            txtTenor.Text = "";
            txtAdminFee.Text = "";
            txtMinAmount.Text = "";
            txtMaxAmount.Text = "";
        }

        private void textInterest_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnReload_Click(object sender, EventArgs e)
        {
            AppContext db = new AppDbContext();
            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();

            LoaddatagridLoan(db);
            HideInstallment();
        }
    }