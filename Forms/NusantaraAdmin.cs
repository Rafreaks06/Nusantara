using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Forms;
using Nusantara.Models;
namespace Nusantara.Forms
{
    public partial class NusantaraAdmin : Form
    {
        Member? loggedMember = null;

        public NusantaraAdmin(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = "Nusantara Cooperation(Administrator: " +
                loggedMember.MemberId + " _ " + loggedMember.FullName + ")";
        }
        public void route(System.Windows.Forms.Control control)
        {
            this.paneldisplay.Controls.Clear();
            this.paneldisplay.Dock = DockStyle.Fill;
            this.paneldisplay.Controls.Add(control);
        }
        private void admin_form_Load(object sender, EventArgs e)
        {
            route(new DashboardAdminPage(loggedMember));

        }

        private void accesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ConfigPage());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new MemberPage());
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ProductPage());
        }

        private void acrossCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccrossPage());
        }

        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ApprovalPage(loggedMember));
        }

        private void paneldisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
