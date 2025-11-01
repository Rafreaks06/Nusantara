using Nusantara.Data;
using Nusantara.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nusantara.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);//EA1C1B
            var password = await auth.ResetPasswordAsync(txtUsername.Text, txtQuest1.Text, txtQuest2.Text);
            if (password == "")
            {
                MessageBox.Show("Invalid username or the answer", "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPassword.Text = password;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
