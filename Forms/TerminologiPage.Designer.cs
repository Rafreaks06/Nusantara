namespace Nusantara.Forms
{
    partial class TerminologiPage
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
            labelExchangeRate = new Label();
            labelInhouseFee = new Label();
            labelAccessFee = new Label();
            SuspendLayout();
            // 
            // labelExchangeRate
            // 
            labelExchangeRate.AutoSize = true;
            labelExchangeRate.Location = new Point(122, 587);
            labelExchangeRate.Name = "labelExchangeRate";
            labelExchangeRate.Size = new Size(126, 25);
            labelExchangeRate.TabIndex = 0;
            labelExchangeRate.Text = "Exchange Rate";
            // 
            // labelInhouseFee
            // 
            labelInhouseFee.AutoSize = true;
            labelInhouseFee.Location = new Point(510, 587);
            labelInhouseFee.Name = "labelInhouseFee";
            labelInhouseFee.Size = new Size(107, 25);
            labelInhouseFee.TabIndex = 1;
            labelInhouseFee.Text = "Inhouse Fee";
            // 
            // labelAccessFee
            // 
            labelAccessFee.AutoSize = true;
            labelAccessFee.Location = new Point(928, 587);
            labelAccessFee.Name = "labelAccessFee";
            labelAccessFee.Size = new Size(97, 25);
            labelAccessFee.TabIndex = 2;
            labelAccessFee.Text = "Access Fee";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelAccessFee);
            Controls.Add(labelInhouseFee);
            Controls.Add(labelExchangeRate);
            Name = "TerminologiPage";
            Size = new Size(1211, 755);
            Load += TerminologiPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelExchangeRate;
        private Label labelInhouseFee;
        private Label labelAccessFee;
    }
}
