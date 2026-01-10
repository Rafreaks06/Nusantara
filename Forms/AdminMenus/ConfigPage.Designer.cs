namespace Nusantara.Forms.AdminMenus
{
    partial class ConfigPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textExchangeRate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textInhouseFee = new TextBox();
            label3 = new Label();
            textAccrossFee = new TextBox();
            label4 = new Label();
            textTerminologi1 = new TextBox();
            label5 = new Label();
            textTerminologi2 = new TextBox();
            label6 = new Label();
            textTerminologi3 = new TextBox();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // textExchangeRate
            // 
            textExchangeRate.Location = new Point(20, 418);
            textExchangeRate.Margin = new Padding(4, 5, 4, 5);
            textExchangeRate.Name = "textExchangeRate";
            textExchangeRate.Size = new Size(251, 31);
            textExchangeRate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 388);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 1;
            label1.Text = "Exchange Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 388);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 3;
            label2.Text = "Inhouse Fee";
            // 
            // textInhouseFee
            // 
            textInhouseFee.Location = new Point(281, 418);
            textInhouseFee.Margin = new Padding(4, 5, 4, 5);
            textInhouseFee.Name = "textInhouseFee";
            textInhouseFee.Size = new Size(251, 31);
            textInhouseFee.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 388);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "Accross Fee";
            // 
            // textAccrossFee
            // 
            textAccrossFee.Location = new Point(543, 418);
            textAccrossFee.Margin = new Padding(4, 5, 4, 5);
            textAccrossFee.Name = "textAccrossFee";
            textAccrossFee.Size = new Size(251, 31);
            textAccrossFee.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 7;
            label4.Text = "Terminologi 1";
            // 
            // textTerminologi1
            // 
            textTerminologi1.Location = new Point(20, 47);
            textTerminologi1.Margin = new Padding(4, 5, 4, 5);
            textTerminologi1.Multiline = true;
            textTerminologi1.Name = "textTerminologi1";
            textTerminologi1.Size = new Size(251, 334);
            textTerminologi1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 17);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 9;
            label5.Text = "Terminologi 2";
            // 
            // textTerminologi2
            // 
            textTerminologi2.Location = new Point(281, 47);
            textTerminologi2.Margin = new Padding(4, 5, 4, 5);
            textTerminologi2.Multiline = true;
            textTerminologi2.Name = "textTerminologi2";
            textTerminologi2.Size = new Size(251, 334);
            textTerminologi2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 17);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 11;
            label6.Text = "Terminologi 3";
            // 
            // textTerminologi3
            // 
            textTerminologi3.Location = new Point(543, 47);
            textTerminologi3.Margin = new Padding(4, 5, 4, 5);
            textTerminologi3.Multiline = true;
            textTerminologi3.Name = "textTerminologi3";
            textTerminologi3.Size = new Size(251, 334);
            textTerminologi3.TabIndex = 10;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(356, 482);
            buttonUpdate.Margin = new Padding(4, 5, 4, 5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(107, 38);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(buttonUpdate);
            Controls.Add(label6);
            Controls.Add(textTerminologi3);
            Controls.Add(label5);
            Controls.Add(textTerminologi2);
            Controls.Add(label4);
            Controls.Add(textTerminologi1);
            Controls.Add(label3);
            Controls.Add(textAccrossFee);
            Controls.Add(label2);
            Controls.Add(textInhouseFee);
            Controls.Add(label1);
            Controls.Add(textExchangeRate);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConfigPage";
            Size = new Size(821, 543);
            Load += ConfigPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textExchangeRate;
        private Label label1;
        private Label label2;
        private TextBox textInhouseFee;
        private Label label3;
        private TextBox textAccrossFee;
        private Label label4;
        private TextBox textTerminologi1;
        private Label label5;
        private TextBox textTerminologi2;
        private Label label6;
        private TextBox textTerminologi3;
        private Button buttonUpdate;
    }
}
