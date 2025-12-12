namespace Nusantara.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            btnRegistrasion = new Button();
            linkForgetPassword = new LinkLabel();
            lblValidasi = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(252, 34);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(88, 32);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(203, 82);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(203, 106);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(179, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(203, 135);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(203, 159);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Highlight;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(202, 196);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(105, 20);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnRegistrasion
            // 
            btnRegistrasion.BackColor = SystemColors.WindowFrame;
            btnRegistrasion.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrasion.Location = new Point(203, 229);
            btnRegistrasion.Margin = new Padding(2);
            btnRegistrasion.Name = "btnRegistrasion";
            btnRegistrasion.Size = new Size(104, 20);
            btnRegistrasion.TabIndex = 6;
            btnRegistrasion.Text = "Registrasion";
            btnRegistrasion.UseVisualStyleBackColor = false;
            btnRegistrasion.Click += btnRegistrasion_Click;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.Location = new Point(360, 196);
            linkForgetPassword.Margin = new Padding(2, 0, 2, 0);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(94, 15);
            linkForgetPassword.TabIndex = 7;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Forget Password";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // lblValidasi
            // 
            lblValidasi.AutoSize = true;
            lblValidasi.Location = new Point(203, 5);
            lblValidasi.Margin = new Padding(2, 0, 2, 0);
            lblValidasi.Name = "lblValidasi";
            lblValidasi.Size = new Size(16, 15);
            lblValidasi.TabIndex = 8;
            lblValidasi.Text = "...";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(560, 270);
            Controls.Add(lblValidasi);
            Controls.Add(linkForgetPassword);
            Controls.Add(btnRegistrasion);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblLogin);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Button btnRegistrasion;
        private LinkLabel linkForgetPassword;
        private Label lblValidasi;
    }
}