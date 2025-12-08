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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nusantara.Forms
{
    public partial class ProductPage : UserControl
    {
        public ProductPage()
        {
            InitializeComponent();
        }
        private void ProductPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoadGrids(db);
        }

        private void LoadGrids(AppDbContext db)
        {
            ProductService service = new ProductService(db);
            dataGridViewLoan.DataSource = service.LoadLoanGrid();
            dataGridViewSaving.DataSource = service.LoadSavingGrid();

            dataGridViewLoan.Columns[0].Visible = false;
            dataGridViewSaving.Columns[0].Visible = false;

            dataGridViewLoan.Columns[1].DataPropertyName = "Id";
            dataGridViewLoan.Columns[2].DataPropertyName = "Name";
            dataGridViewLoan.Columns[3].DataPropertyName = "Interest";
            dataGridViewLoan.Columns[4].DataPropertyName = "Tenor";

            dataGridViewSaving.Columns[1].DataPropertyName = "Id";
            dataGridViewSaving.Columns[2].DataPropertyName = "Name";
            dataGridViewSaving.Columns[3].DataPropertyName = "Interest";
            dataGridViewSaving.Columns[4].DataPropertyName = "Tenor";
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ProductService service = new ProductService(db);
            if (comboBoxMode.SelectedIndex == 0) // Loan
            {
                await service.saveOrUpdateLoan(labelId.Text,textFine.Text, textAdminFee.Text, textBoxName.Text,
                    textInterest.Text, textMaxAmount.Text,
                    textMinAmount.Text, textTenor.Text);

                
            }
            else // Saving
            {
                await service.saveOrUpdateSaving(labelId.Text, textFine.Text, textAdminFee.Text, textBoxName.Text,
                    textInterest.Text, textMaxAmount.Text,
                    textMinAmount.Text, textTenor.Text);

              
            }
            clearField();
            LoadGrids(db);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void clearField()
        {
            labelId.Text = "";
            textAdminFee.Text = "";
            textBoxName.Text = "";
            textFine.Text = ""; // This seems unused in the submit logic shown
            textInterest.Text = "";
            textMaxAmount.Text = "";
            textMinAmount.Text = "";
            textTenor.Text = "";
            comboBoxMode.Enabled = true;
            buttonSubmit.Enabled = true;
        }

        private async void dataGridViewLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridViewLoan.Rows[e.RowIndex].Cells[0].Value);
                labelId.Text = id.ToString();

                AppDbContext db = new AppDbContext();
                ProductService service = new ProductService(db);
                LoanMaster loanMaster = await service.findLoanById(id);

                labelId.Text = loanMaster.Id.ToString();
                textAdminFee.Text = loanMaster.AdminFee.ToString();
                textBoxName.Text = loanMaster.Name.ToString();
                textFine.Text = loanMaster.Fine.ToString();
                textInterest.Text = loanMaster.Interest.ToString();
                textMaxAmount.Text = loanMaster.MaxAmount.ToString();
                textMinAmount.Text = loanMaster.MinAmount.ToString();
                textTenor.Text = loanMaster.Tenor.ToString();
                comboBoxMode.SelectedIndex = 0;
                buttonSubmit.Enabled = false;
            }
        }

        private async void dataGridViewSaving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridViewLoan.Rows[e.RowIndex].Cells[0].Value);
                labelId.Text = id.ToString();
                AppDbContext db = new AppDbContext();
                ProductService service = new ProductService(db);
                SavingMaster savingMaster = await service.findSavingById(id);

                labelId.Text = savingMaster.id.ToString();
                textAdminFee.Text = savingMaster.AdminFee.ToString();
                textBoxName.Text = savingMaster.name.ToString();
                textFine.Text = savingMaster.fine.ToString();
                textInterest.Text = savingMaster.interest.ToString();
                textMaxAmount.Text = savingMaster.maxAmount.ToString();
                textMinAmount.Text = savingMaster.MinAmount.ToString();
                textTenor.Text = savingMaster.Tenor.ToString();
                comboBoxMode.SelectedIndex = 1;
                buttonSubmit.Enabled = false;
            }
        }

    }
}
