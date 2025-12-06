using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Forms
{
    public partial class accrossTransferPage : UserControl
    {
        public accrossTransferPage(Member member)
        {
            loggedMmember = member;
            InitializeComponent();
        }

        private void accrossTransferPage_Load(object sender, EventArgs e)
        {
            timerInBox.Enabled = false;
            if (LoggedMember.ReferenceId == null || LoggedMember.ReferenceId == "" || LoggedMember.ReferenceId == "~-")
            {
                DialogResult result = MessageBox.Show("You do not have a privilege to Use Across Transfer. Registration Now?", "Invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    String message;
                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }
                    MessageBox.Show(message, "Registration Info", MessageBoxButtons.OK);
                }
            }
            else
            {
                timerInBox.Enabled = true;
            }
        }
    }
}
