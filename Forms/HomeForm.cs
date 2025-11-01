using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Data;
using Nusantara.Models;
using Nusantara.Services;

namespace Nusantara.Forms
{
    public partial class HomeForm : Form
    {
        Member loggedMember;
        string title;
        public HomeForm(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = this.Text + "- User :" + loggedMember.FullName + "(" + loggedMember.MemberId + ")";
            title = this.Text;

            route(new DashboardPage(loggedMember));
        }
        public void route(System.Windows.Forms.Control control)
        {
            this.PanelDisplay.Controls.Clear();
            this.PanelDisplay.Dock = DockStyle.Fill;
            this.PanelDisplay.Controls.Add(control);
        }
        public void autoDisableMenu()
        {
            loanToolStripMenuItem.Enabled = false;
            savingToolStripMenuItem.Enabled = false;
            transferToolStripMenuItem.Enabled = false;
            exchangeToolStripMenuItem.Enabled = false;
            inhouseToolStripMenuItem.Enabled = false;
            accrossToolStripMenuItem.Enabled = false;

            loanToolStripMenuItem.ToolTipText = "Disable";
            savingToolStripMenuItem.ToolTipText = "Disable";
            transferToolStripMenuItem.ToolTipText = "Disable";
            exchangeToolStripMenuItem.ToolTipText = "Disable";
            inhouseToolStripMenuItem.ToolTipText = "Disable";
            accrossToolStripMenuItem.ToolTipText = "Disable";
        }
        public void grantAllMenu()
        {
            loanToolStripMenuItem.Enabled = true;
            savingToolStripMenuItem.Enabled = true;
            transferToolStripMenuItem.Enabled = true;
            exchangeToolStripMenuItem.Enabled = true;
            inhouseToolStripMenuItem.Enabled = true;
            accrossToolStripMenuItem.Enabled = true;
        }
        public void grantAccess()
        {
            AppDbContext db = new AppDbContext();
            AccessService accessService = new AccessService(db);
            Access? access = accessService.findByMemberId(loggedMember.MemberId);
            if (access != null)
            {
                var listaccess = access.AccessList.Split(',');
                for (int i = 0; i < listaccess.Length; i++)
                {
                    var accessName = listaccess[i];
                    var accessSegment = accessName.Trim();
                    if (accessSegment == "Grant All")
                    {
                        grantAllMenu();
                        break;
                    }
                    if (accessSegment.Contains("-"))
                    {
                        var parts = accessSegment.Split('-');
                        if (parts.Length > 1)
                            accessSegment = parts[1].Trim();
                    }
                    foreach (ToolStripMenuItem menuItem in MenuHome.Items)
                    {
                        if (menuItem.Text != null && menuItem.Text.Contains(accessSegment))
                        {
                            menuItem.Enabled = true;
                            menuItem.ToolTipText = "";
                        }
                        else
                        {
                            foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
                            {
                                if (subItem.Text != null && subItem.Text.Contains(accessSegment))
                                {
                                    subItem.Enabled = true;
                                    subItem.ToolTipText = "";
                                }
                            }
                        }
                    }
                }
            }
        }


        private void definitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new TerminologiPage(loggedMember));
        }
        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void HomeForm_load(object sender, EventArgs e)
        {
            autoDisableMenu();
            grantAccess();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title;
            route(new DashboardPage(loggedMember));
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + "<< Profile Page >>";
            route(new ProfilePage(loggedMember));
        }
        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + "<< Loan Page >>";
            route(new LoanPage(loggedMember));
        }

        private void HomeForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}