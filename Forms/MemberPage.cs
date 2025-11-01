using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using Nusantara.Services;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Forms
{
    public partial class MemberPage : UserControl
    {
        public MemberPage()
        {
            InitializeComponent();
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            loadGridMember();
            string? id = lblMemberId.Text;
            if (id == null || id == "" || id == "...")
            {
                button1.Visible = false;
            }
        }
        private void loadGridMember()
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            memberBindingSource.DataSource = service.SetGrid();
            dataGridViewMemberPage.Columns[0].DataPropertyName = "Id";
            dataGridViewMemberPage.Columns[0].Visible = false;
            dataGridViewMemberPage.Columns[1].DataPropertyName = "MemberId";
            dataGridViewMemberPage.Columns[2].DataPropertyName = "FullName";
            dataGridViewMemberPage.Columns[3].DataPropertyName = "ModDate";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            int memberId = int.Parse(lblMemberId.Text);
            Member? member = service.FindById(memberId);
            if (member != null)
            {
                if (cmbStatus.SelectedIndex == 0)
                    member.IsActive = true;
                else
                    member.IsActive = false;

                member.ModDate = DateTime.UtcNow;
                service.Update(member);
            }
            loadGridMember();
        }

        private void dataGridMemberPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int memberId = int.Parse(dataGridViewMemberPage.Rows[e.RowIndex].Cells[0].Value.ToString()!);
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            Member? member = service.FindById(memberId);
            if (member != null)
            {
                label3.Text = member.FullName;
                label4.Text = member.Email;
                label5.Text = member.Phone;
                label6.Text = member.PhoneAlt;
                label7.Text = member.Address;
                label8.Text = member.JoinDate.ToString("f");
                label1.Text = member.MemberId;
                label2.Text = member.IdCard;
                lblMemberId.Text = member.Id.ToString();
                if (member.IsActive)
                cmbStatus.SelectedIndex = 0;
                else
                    cmbStatus.SelectedIndex = 1;

                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }
    }
}
