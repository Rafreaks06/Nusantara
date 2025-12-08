using System;
using System.Linq;
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
            using var db = new AppDbContext();

            MemberService memberService = new MemberService(db);
            AccessService accessService = new AccessService(db);

            string accessList = string.Join(",", checkedListBoxAccess.CheckedItems.Cast<string>());

            int id = comboboxMember.SelectedValue != null ? Convert.ToInt32(comboboxMember.SelectedValue) : 0;

            Member? member = id != 0 ? memberService.FindById(id) : null;

            if (member != null)
            {
                // ambil access by memberId
                Access? access = accessService.findByMemberId(member.Id);

                if (access != null)
                {
                    await accessService.update(access, accessList);
                }
                else
                {
                    await accessService.newOne(null, member, accessList);
                }

                loadAccessList(db);
                clearField();
            }
            else
            {
                MessageBox.Show("Invalid member", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearField()
        {
            for (int i = 0; i < checkedListBoxAccess.Items.Count; i++)
                checkedListBoxAccess.SetItemChecked(i, false);

            comboboxMember.SelectedIndex = -1;

            labelFullName.Text = "-";
            labelAddress.Text = "-";
            labelEmail.Text = "-";
            labelJoinDate.Text = "-";
            labelPhone.Text = "-";
            labelPhoneAlt.Text = "-";
        }

        private void checkedListBoxAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxAccess.Items.Count > 0 && checkedListBoxAccess.GetItemChecked(0))
            {
                for (int i = 1; i < checkedListBoxAccess.Items.Count; i++)
                    checkedListBoxAccess.SetItemChecked(i, true);
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

            try
            {
                comboboxMember.DataSource = memberService.SetDropdown;
            }
            catch
            {
                comboboxMember.DataSource = db.Members
                    .Select(m => new { m.Id, DisplayName = m.FullName })
                    .ToList();
            }

            comboboxMember.DisplayMember = "DisplayName";
            comboboxMember.ValueMember = "Id";
        }

        private void loadAccessList(AppDbContext db)
        {
            var accessService = new AccessService(db);

            // gunakan instance method setGridView()
            var grid = accessService.setGridView();
            dataGridViewAccess.DataSource = grid;

            if (dataGridViewAccess.Columns.Count >= 4)
            {
                dataGridViewAccess.Columns[0].DataPropertyName = "Id";
                dataGridViewAccess.Columns[0].Visible = false;

                dataGridViewAccess.Columns[1].DataPropertyName = "DisplayMember";

                dataGridViewAccess.Columns[2].DataPropertyName = "AccessList";
                dataGridViewAccess.Columns[2].Width = 220;

                dataGridViewAccess.Columns[3].DataPropertyName = "updateOn";
            }
        }

        private void comboboxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            int id = comboboxMember.SelectedValue != null ? Convert.ToInt32(comboboxMember.SelectedValue) : 0;

            Member? member = id != 0 ? db.Members.Find(id) : null;

            if (member != null)
            {
                labelFullName.Text = member.FullName;
                labelAddress.Text = member.Address;
                labelEmail.Text = member.Email;
                labelJoinDate.Text = member.JoinDate.ToString("f");
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
                int accessId = Convert.ToInt32(dataGridViewAccess.Rows[e.RowIndex].Cells[0].Value);

                using var db = new AppDbContext();
                Access? access = db.Accesses.Find(accessId); // by ID, bukan MemberId

                if (access != null)
                {
                    comboboxMember.SelectedValue = access.MemberId;

                    for (int i = 0; i < checkedListBoxAccess.Items.Count; i++)
                        checkedListBoxAccess.SetItemChecked(i, false);

                    foreach (var item in access.AccessList.Split(','))
                    {
                        string trimmed = item.Trim();

                        if (trimmed == "Grant All") checkedListBoxAccess.SetItemChecked(0, true);
                        if (trimmed == "Loan") checkedListBoxAccess.SetItemChecked(1, true);
                        if (trimmed == "Saving") checkedListBoxAccess.SetItemChecked(2, true);
                        if (trimmed == "Transfer - Inhouse") checkedListBoxAccess.SetItemChecked(3, true);
                        if (trimmed == "Transfer - Accross") checkedListBoxAccess.SetItemChecked(4, true);
                        if (trimmed == "Exchange") checkedListBoxAccess.SetItemChecked(5, true);
                    }
                }
            }
        }
    }
}
