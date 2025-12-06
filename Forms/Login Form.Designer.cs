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
            lblLogin.Location = new Point(360, 57);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(131, 48);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(290, 137);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(290, 177);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 31);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(290, 225);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(290, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Highlight;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(288, 327);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 34);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnRegistrasion
            // 
            btnRegistrasion.BackColor = SystemColors.WindowFrame;
            btnRegistrasion.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrasion.Location = new Point(290, 381);
            btnRegistrasion.Name = "btnRegistrasion";
            btnRegistrasion.Size = new Size(148, 34);
            btnRegistrasion.TabIndex = 6;
            btnRegistrasion.Text = "Registrasion";
            btnRegistrasion.UseVisualStyleBackColor = false;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.Location = new Point(514, 327);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(144, 25);
            linkForgetPassword.TabIndex = 7;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Forget Password";
            // 
            // lblValidasi
            // 
            lblValidasi.AutoSize = true;
            lblValidasi.Location = new Point(290, 9);
            lblValidasi.Name = "lblValidasi";
            lblValidasi.Size = new Size(24, 25);
            lblValidasi.TabIndex = 8;
            lblValidasi.Text = "...";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
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