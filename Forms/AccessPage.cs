using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Services;

namespace Nusantara.Forms
{
    public partial class AccessPage : UserControl
    {
        private Member? loggedMember;
        public AccessPage(Member? member)
        {
            InitializeComponent();
            loggedMember = member;
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            MemberRelationshipService memberService = new MemberService(db);
            AccessService accessService = new AccessService(db);
            string accessList = string.Join(",", checkedListBoxAccess.CheckedItems.Cast<string>());
            int id = comboboxMember.SelectedValue as int? ?? 0;
            Member? member = id != 0 ? memberService.FindById(id) : null;
            if (member == null)
            {
                Access? access = accessService.findByMemberId(member.Id);
                if (access != null)
                {
                    await accessService.update(access, accessList);

                }
                else
                {
                    await accessService.newOne(access, accessList);
                }
                loadAccessList(db);
                clearField();
            }
            else
            {
                MessageBox.Show("invalid member", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearField()
        {
            for (int i = 0; i < checkedListBoxAccess.Items.Count; i++)
            {
                checkedListBoxAccess.SetItemChecked(i, false);
            }
            comboboxMember.SelectedIndex = null;
            labelFullName.Text = "-";
            labelAddress.Text = "-";
            labelEmail.Text = "-";
            labelJoinDate.Text = "-";
            labelPhone.Text = "-";
            labelPhoneAlt.Text = "-";
        }

        private void checkedListBoxAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool n = checkedListBoxAccess.GetItemChecked(0);
            if (n)
            {
                for (int i = 1; i < checkedListBoxAccess.Items.Count; i++)
                {
                    checkedListBoxAccess.SetItemChecked(i, true);
                }
                //checkedListBoxAccess.SetItemChecked(1, true);
                //checkedListBoxAccess.SetItemChecked(2, true);
                //checkedListBoxAccess.SetItemChecked(3, true);
                //checkedListBoxAccess.SetItemChecked(4, true);
                //checkedListBoxAccess.SetItemChecked(5, true);
            }
        }
        private void AccessPage_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            loadMember(db);
            loadAccessList(db);
        }
        private void loadMember(AppDbContext db)
        {
            var memberService = new MemberService(db);
            MemberBindingSource.DataSource = memberService.SetDropdown;
            comboboxMember.DisplayMember = "DisplayName";
            comboboxMember.ValueMember = "Id";
        }
        private void loadAccessList(AppDbContext db)
        {
            var acessService = new AccessService(db);
            accessBindingSource.DataSource = AccessService.setGridView();
            dataGridViewAccess.Columns[0].DataPropertyName = "id";
            dataGridViewAccess.Columns[0].Visible = false;
            dataGridViewAccess.Columns[1].DataPropertyName = "DisplayMember";
            dataGridViewAccess.Columns[2].DataPropertyName = "AccessList";
            dataGridViewAccess.Columns[2].Width = 220;
            dataGridViewAccess.Columns[3].DataPropertyName = "updateOn";
        }

        private void comboboxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService memberService = new MemberService(db);
            int id = comboboxMember.SelectedValue as int? ?? 0;
            Member? member = id != 0 ? memberService.FindById(id) : null;
            if (member != null)
            {
                labelFullName.Text = member.FullName;
                labelAddress.Text = member.Address;
                labelEmail.Text = member.Email;
                labelJoinDate.Text = member.JoinData.ToString("f");
                labelPhone.Text = member.Phone;
                labelPhoneAlt.Text = member.PhoneAlt;
            }
            else
            {
                labelFullName.Text = "-";
                labelAddress.Text = "-";
                labelEmail.Text = "-";
                labelJoinDate.Text = "-";
                labelPhone.Text = "-";
                labelPhoneAlt.Text = "-";
            }
        }

        private void dataGridViewAccess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int accessId = int.Parse(dataGridViewAccess.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                AccessService accessService = new AccessService(db);
                Access? access = accessService.findByMemberId(accessId);
                if (access != null)
                {
                    comboboxMember.SelectedValue = access.MemberId;
                    string[] accessList = access.AccessList.Split(',');
                    for (int i = 0; i < accessList.Length; i++)
                    {
                        if (accessList[i].Trim() == "Grant All")
                            checkedListBoxAccess.SetItemChecked(0, true);

                        if (accessList[i].Trim() == "Loan")
                            checkedListBoxAccess.SetItemChecked(1, true);
                        if (accessList[i].Trim() == "Saving")
                            checkedListBoxAccess.SetItemChecked(2, true);
                        if (accessList[i].Trim() == "Transfer - Inhouse")
                            checkedListBoxAccess.SetItemChecked(3, true);
                        if (accessList[i].Trim() == "Transfer - Accross")
                            checkedListBoxAccess.SetItemChecked(4, true);
                        if (accessList[i].Trim() == "Exchange")
                            checkedListBoxAccess.SetItemChecked(5, true);
                    }
                }
            }
        }

        private void AccessPage_Load_1(object sender, EventArgs e)
        {

        }
    }

}

