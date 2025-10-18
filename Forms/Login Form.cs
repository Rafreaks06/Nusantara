using Nusantara.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nusantara.Forms
{
    public partial class LoginForm : Form
    {
        public Member? LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public void SetSuccessAlert(string message)
        {
            lblValidasi.Text = message;
            lblValidasi.Visible = true;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lblValidasi.Visible = false;

            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var user = await auth.LoginAsync(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                LoggedInUser = user;

                if (LoggedInUser.level == "admin")
                {
                    this.Hide();
                    var form = new AdminForm(LoggedInUser);
                    form.ShowDialog();
                }
                else
                {
                    var accessService = new AccessService(db);
                    var access = await accessService.GetAccess(user.Id);

                    if (access == null)
                    {
                        lblValidasi.Text = "Access Is Not Granted By Admin!";
                        lblValidasi.ForeColor = Color.Red;
                        lblValidasi.Visible = true;
                    }
                    else
                    {
                        this.Hide();
                        var form = new HomeForm(LoggedInUser);
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                lblValidasi.Text = "Invalid Credentials";
                lblValidasi.ForeColor = Color.Red;
                lblValidasi.Visible = true;
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form = new ForgotPasswordForm();
            form.ShowDialog();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new RegistrationForm();
            form.ShowDialog();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
