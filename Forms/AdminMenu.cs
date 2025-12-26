using Nusantara.Api.Connectors;
using Nusantara.Api.Models;
using Nusantara.Data;
using Nusantara.Services;
using Nusantara.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Models;
namespace Nusantara.Forms
{
    public partial class AdminMenu : Form
    {
        Models.Member? loggedMember = null;
      
        public AdminMenu(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = "Nusantara System (Administrator: " +
                loggedMember.MemberId + " - " + loggedMember.FullName + ")";
        }
        public void route(System.Windows.Forms.Control control)
        {
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(control);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            // LoadData();
        }
        private void AcrossPage_Load(object sender, EventArgs e)
        {
            // LoadData();
        }


        private void AdminMenu_Load(object sender, EventArgs e)
        {
            route(new DashboardAdminPage(loggedMember));
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new MemberPage());
        }

        private void accesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ProductPage());
        }

        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ApprovalPage(loggedMember));
        }

        private void acrossCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            this.Close();
        }
    }
}
