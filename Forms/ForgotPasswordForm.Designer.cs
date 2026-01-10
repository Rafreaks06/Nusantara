namespace Nusantara.Forms
{
    partial class ForgotPasswordForm
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
            textUsername = new TextBox();
            textQuest1 = new TextBox();
            textQuest2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSubmit = new Button();
            buttonBack = new Button();
            label4 = new Label();
            textPassword = new TextBox();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(53, 80);
            textUsername.Margin = new Padding(4, 5, 4, 5);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(327, 31);
            textUsername.TabIndex = 0;
            // 
            // textQuest1
            // 
            textQuest1.Location = new Point(53, 167);
            textQuest1.Margin = new Padding(4, 5, 4, 5);
            textQuest1.Name = "textQuest1";
            textQuest1.Size = new Size(327, 31);
            textQuest1.TabIndex = 1;
            // 
            // textQuest2
            // 
            textQuest2.Location = new Point(407, 167);
            textQuest2.Margin = new Padding(4, 5, 4, 5);
            textQuest2.Name = "textQuest2";
            textQuest2.Size = new Size(327, 31);
            textQuest2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 4;
            label2.Text = "What is Your Fav Color?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(250, 25);
            label3.TabIndex = 5;
            label3.Text = "Who is Your Fav Artist/Singer?";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(53, 218);
            buttonSubmit.Margin = new Padding(4, 5, 4, 5);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(107, 38);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(169, 218);
            buttonBack.Margin = new Padding(4, 5, 4, 5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(107, 38);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(53, 318);
            textPassword.Margin = new Padding(4, 5, 4, 5);
            textPassword.Name = "textPassword";
            textPassword.ReadOnly = true;
            textPassword.Size = new Size(474, 31);
            textPassword.TabIndex = 8;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(781, 415);
            Controls.Add(label4);
            Controls.Add(textPassword);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textQuest2);
            Controls.Add(textQuest1);
            Controls.Add(textUsername);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ForgotPasswordForm";
            Text = "Forgot Password";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textQuest1;
        private TextBox textQuest2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSubmit;
        private Button buttonBack;
        private Label label4;
        private TextBox textPassword;
    }
}