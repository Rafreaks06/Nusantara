namespace Nusantara.Forms
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
            label1 = new Label();
            label2 = new Label();
            txtTerminologi3 = new RichTextBox();
            label3 = new Label();
            textExchangeRate = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textInhouseFee = new TextBox();
            label6 = new Label();
            textAccrossFee = new TextBox();
            buttonUpdate = new Button();
            txtTerminologi1 = new RichTextBox();
            textTerminologi2 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Terminologi 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 25);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 2;
            label2.Text = "Terminologi 2";
            // 
            // txtTerminologi3
            // 
            txtTerminologi3.Location = new Point(718, 62);
            txtTerminologi3.Name = "txtTerminologi3";
            txtTerminologi3.Size = new Size(296, 396);
            txtTerminologi3.TabIndex = 5;
            txtTerminologi3.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 25);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 4;
            label3.Text = "Terminologi 3";
            // 
            // textExchangeRate
            // 
            textExchangeRate.Location = new Point(34, 515);
            textExchangeRate.Name = "textExchangeRate";
            textExchangeRate.Size = new Size(292, 31);
            textExchangeRate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 481);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 7;
            label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 481);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 9;
            label5.Text = "Inhouse Fee";
            // 
            // textInhouseFee
            // 
            textInhouseFee.Location = new Point(373, 515);
            textInhouseFee.Name = "textInhouseFee";
            textInhouseFee.Size = new Size(292, 31);
            textInhouseFee.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(718, 481);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 11;
            label6.Text = "Accross Fee";
            // 
            // textAccrossFee
            // 
            textAccrossFee.Location = new Point(718, 515);
            textAccrossFee.Name = "textAccrossFee";
            textAccrossFee.Size = new Size(292, 31);
            textAccrossFee.TabIndex = 10;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.MenuHighlight;
            buttonUpdate.ForeColor = SystemColors.Control;
            buttonUpdate.Location = new Point(373, 587);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(296, 38);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // txtTerminologi1
            // 
            txtTerminologi1.Location = new Point(34, 62);
            txtTerminologi1.Name = "txtTerminologi1";
            txtTerminologi1.Size = new Size(292, 396);
            txtTerminologi1.TabIndex = 1;
            txtTerminologi1.Text = "";
            // 
            // textTerminologi2
            // 
            textTerminologi2.Location = new Point(377, 62);
            textTerminologi2.Name = "textTerminologi2";
            textTerminologi2.Size = new Size(292, 396);
            textTerminologi2.TabIndex = 13;
            textTerminologi2.Text = "";
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textTerminologi2);
            Controls.Add(buttonUpdate);
            Controls.Add(label6);
            Controls.Add(textAccrossFee);
            Controls.Add(label5);
            Controls.Add(textInhouseFee);
            Controls.Add(label4);
            Controls.Add(textExchangeRate);
            Controls.Add(txtTerminologi3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTerminologi1);
            Controls.Add(label1);
            Name = "ConfigPage";
            Size = new Size(1041, 705);
            Load += ConfigPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTerminologi1;
        private RichTextBox richTerminologi2;
        private Label label2;
        private RichTextBox txtTerminologi3;
        private Label label3;
        private TextBox textExchangeRate;
        private Label label4;
        private Label label5;
        private TextBox textInhouseFee;
        private Label label6;
        private TextBox textAccrossFee;
        private Button buttonUpdate;
        private RichTextBox txtTerminologi1;
        private RichTextBox textTerminologi2;
    }
}
