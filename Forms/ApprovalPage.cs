using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Models;
using Nusantara.Data;

namespace Nusantara.Forms
{
    public partial class ApprovalPage : UserControl
    {
        public ApprovalPage()
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void ApprovalPage_Load(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = 0;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            if (cmbProduct.SelectedIndex == 1)
            {
                LoanService loanService = new LoanService(db);
                dataGridViewApproval.AutoGenerateColumns = true;
                dataGridViewApproval.DataSource = await loanService.LoadsApproval();

                dataGridViewApproval.Columns[0].DataPropertyName = "Id";
                dataGridViewApproval.Columns[1].DataPropertyName = "LoanId";
                dataGridViewApproval.Columns[2].DataPropertyName = "CreatedOn";
                dataGridViewApproval.Columns[3].DataPropertyName = "Amount";
                dataGridViewApproval.Columns[4].DataPropertyName = "Outstanding";
                dataGridViewApproval.Columns[5].DataPropertyName = "Interest";
                dataGridViewApproval.Columns[6].DataPropertyName = "Tenor";
                dataGridViewApproval.Columns[7].DataPropertyName = "Member";
                dataGridViewApproval.Columns[8].DataPropertyName = "KtpPath";
                dataGridViewApproval.Columns[9].DataPropertyName = "KkPath";
                dataGridViewApproval.Columns[10].DataPropertyName = "SlipGajiPath";
                dataGridViewApproval.Columns[11].DataPropertyName = "Amount";

                dataGridViewApproval.Columns[0].Visible = false;
                dataGridViewApproval.Columns[1].HeaderText = "Loan Id";
                dataGridViewApproval.Columns[2].HeaderText = "Created On";
                dataGridViewApproval.Columns[3].HeaderText = "Amount";
                dataGridViewApproval.Columns[4].HeaderText = "Outstanding";
                dataGridViewApproval.Columns[5].HeaderText = "Interest";
                dataGridViewApproval.Columns[6].HeaderText = "Tenor";
                dataGridViewApproval.Columns[7].HeaderText = "Member";
                dataGridViewApproval.Columns[8].HeaderText = "Ktp";
                dataGridViewApproval.Columns[9].HeaderText = "Kk";
                dataGridViewApproval.Columns[10].HeaderText = "Slip Gaji";
                dataGridViewApproval.Columns[11].HeaderText = "Join Date";

                for (int i = 11; i < dataGridViewApproval.Columns.Count; i++)
                {
                    dataGridViewApproval.Columns[i].Visible = false;
                }
            }
        }

        private void dataGridApprovalPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AppDbContext db = new AppDbContext();
            if (cmbProduct.SelectedIndex == 1)
            {
                if (e.RowIndex >= 0)
                {
                    string path;
                    if (e.ColumnIndex == 8)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[8].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 9)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[9].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 10)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[10].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else
                    {
                        LoanService loanService = new LoanService(db);
                        DialogResult result = MessageBox.Show("Approve?", "Decision", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        int idLoan = int.Parse(dataGridViewApproval.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (result == DialogResult.Yes)
                            loanService.SetApproval(idLoan, true);
                        else if (result == DialogResult.No)
                            loanService.SetApproval(idLoan, false);

                        cmbProduct.SelectedIndex = 0;
                        cmbProduct.SelectedIndex = 1;
                    }
                }
    }
