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
            label1 = new Label();
            txtQuest2 = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtQuest1 = new TextBox();
            buttonSubmit = new Button();
            buttonBack = new Button();
            label5 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 167);
            label1.Name = "label1";
            label1.Size = new Size(258, 25);
            label1.TabIndex = 0;
            label1.Text = "What is your fav Artist/Singer ?";
            // 
            // txtQuest2
            // 
            txtQuest2.Location = new Point(582, 205);
            txtQuest2.Name = "txtQuest2";
            txtQuest2.Size = new Size(521, 31);
            txtQuest2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 76);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(99, 114);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(451, 31);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 167);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 4;
            label3.Text = "What is your fav Colour ?";
            // 
            // txtQuest1
            // 
            txtQuest1.Location = new Point(99, 205);
            txtQuest1.Name = "txtQuest1";
            txtQuest1.Size = new Size(451, 31);
            txtQuest1.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.MenuHighlight;
            buttonSubmit.ForeColor = SystemColors.ButtonHighlight;
            buttonSubmit.Location = new Point(100, 272);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(184, 34);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ControlDarkDark;
            buttonBack.ForeColor = SystemColors.ControlLightLight;
            buttonBack.Location = new Point(302, 272);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 34);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 335);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 363);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(450, 31);
            txtPassword.TabIndex = 10;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 538);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(txtQuest1);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(txtQuest2);
            Controls.Add(label1);
            Name = "ForgotPasswordForm";
            Text = "Forgot your password";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtQuest2;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtQuest1;
        private Button buttonSubmit;
        private Button buttonBack;
        private Label label5;
        private TextBox txtPassword;
    }
}