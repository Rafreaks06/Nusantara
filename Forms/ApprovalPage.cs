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
using Nusantara.Services;
using BraveHeroCooperation.Utils;

namespace Nusantara.Forms
{
    public partial class ApprovalPage : UserControl
    {
        public ApprovalPage()
        {
            loggedMember = Member;
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
                loanService loanService = new LoanService(db);
                dataGridApprovalPage.AutoGenerateColumns = true;
                dataGridApprovalPage.DataSource = await loanService.LoadsApproval();

                dataGridApprovalPage.Columns[0].DataPropertyName = "Id";
                dataGridApprovalPage.Columns[1].DataPropertyName = "LoanId";
                dataGridApprovalPage.Columns[2].DataPropertyName = "CreatedOn";
                dataGridApprovalPage.Columns[3].DataPropertyName = "Amount";
                dataGridApprovalPage.Columns[4].DataPropertyName = "Outstanding";
                dataGridApprovalPage.Columns[5].DataPropertyName = "Interest";
                dataGridApprovalPage.Columns[6].DataPropertyName = "Tenor";
                dataGridApprovalPage.Columns[7].DataPropertyName = "Member";
                dataGridApprovalPage.Columns[8].DataPropertyName = "KtpPath";
                dataGridApprovalPage.Columns[9].DataPropertyName = "KkPath";
                dataGridApprovalPage.Columns[10].DataPropertyName = "SlipGajiPath";
                dataGridApprovalPage.Columns[11].DataPropertyName = "Amount";

                dataGridApprovalPage.Columns[0].Visible = false;
                dataGridApprovalPage.Columns[1].HeaderText = "Loan Id";
                dataGridApprovalPage.Columns[2].HeaderText = "Created On";
                dataGridApprovalPage.Columns[3].HeaderText = "Amount";
                dataGridApprovalPage.Columns[4].HeaderText = "Outstanding";
                dataGridApprovalPage.Columns[5].HeaderText = "Interest";
                dataGridApprovalPage.Columns[6].HeaderText = "Tenor";
                dataGridApprovalPage.Columns[7].HeaderText = "Member";
                dataGridApprovalPage.Columns[8].HeaderText = "Ktp";
                dataGridApprovalPage.Columns[9].HeaderText = "Kk";
                dataGridApprovalPage.Columns[10].HeaderText = "Slip Gaji";
                dataGridApprovalPage.Columns[11].HeaderText = "Join Date";

                for (int i = 11; i < dataGridApprovalPage.Columns.Count; i++)
                {
                    dataGridApprovalPage.Columns[i].Visible = false;
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
                        path = dataGridApprovalPage.Rows[e.RowIndex].Cells[8].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 9)
                    {
                        path = dataGridApprovalPage.Rows[e.RowIndex].Cells[9].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 10)
                    {
                        path = dataGridApprovalPage.Rows[e.RowIndex].Cells[10].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else
                    {
                        LoanService loanService = new LoanService(db);
                        DialogResult result = MessageBox.Show("Approve?", "Decision", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        int idLoan = int.Parse(dataGridApprovalPage.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (result == DialogResult.Yes)
                            loanService.SetApproval(idLoan, true);
                        else if (result == DialogResult.No)
                            loanService.SetApproval(idLoan, false);

                        cmbProduct.SelectedIndex = 0;
                        cmbProduct.SelectedIndex = 1;
                    }
                }
            }
        }
    }
}
