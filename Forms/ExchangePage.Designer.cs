namespace Nusantara.Forms
{
    partial class ExchangePage
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
            lblExchange = new Label();
            lblAmount = new Label();
            lblRate = new Label();
            lblSub_Total = new Label();
            lblFee = new Label();
            lblTotal = new Label();
            txtAmount = new TextBox();
            txtRate = new TextBox();
            txtSub_Total = new TextBox();
            txtFee = new TextBox();
            txtTotal = new TextBox();
            btnSubmite = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblExchange
            // 
            lblExchange.AutoSize = true;
            lblExchange.Location = new Point(125, 41);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(126, 25);
            lblExchange.TabIndex = 0;
            lblExchange.Text = "Exchange USD";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(23, 103);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(23, 157);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(47, 25);
            lblRate.TabIndex = 2;
            lblRate.Text = "Rate";
            // 
            // lblSub_Total
            // 
            lblSub_Total.AutoSize = true;
            lblSub_Total.Location = new Point(23, 201);
            lblSub_Total.Name = "lblSub_Total";
            lblSub_Total.Size = new Size(85, 25);
            lblSub_Total.TabIndex = 3;
            lblSub_Total.Text = "Sub Total";
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(31, 249);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(39, 25);
            lblFee.TabIndex = 4;
            lblFee.Text = "Fee";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(31, 298);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(125, 110);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(234, 31);
            txtAmount.TabIndex = 6;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(125, 154);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(234, 31);
            txtRate.TabIndex = 7;
            // 
            // txtSub_Total
            // 
            txtSub_Total.Location = new Point(125, 202);
            txtSub_Total.Name = "txtSub_Total";
            txtSub_Total.ReadOnly = true;
            txtSub_Total.Size = new Size(234, 31);
            txtSub_Total.TabIndex = 8;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(125, 246);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(234, 31);
            txtFee.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(125, 298);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(234, 31);
            txtTotal.TabIndex = 10;
            // 
            // btnSubmite
            // 
            btnSubmite.Location = new Point(81, 398);
            btnSubmite.Name = "btnSubmite";
            btnSubmite.Size = new Size(112, 34);
            btnSubmite.TabIndex = 11;
            btnSubmite.Text = "Submite";
            btnSubmite.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(234, 398);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(btnSubmite);
            Controls.Add(txtTotal);
            Controls.Add(txtFee);
            Controls.Add(txtSub_Total);
            Controls.Add(txtRate);
            Controls.Add(txtAmount);
            Controls.Add(lblTotal);
            Controls.Add(lblFee);
            Controls.Add(lblSub_Total);
            Controls.Add(lblRate);
            Controls.Add(lblAmount);
            Controls.Add(lblExchange);
            Name = "ExchangePage";
            Size = new Size(400, 474);
            Load += ExchangePage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExchange;
        private Label lblAmount;
        private Label lblRate;
        private Label lblSub_Total;
        private Label lblFee;
        private Label lblTotal;
        private TextBox txtAmount;
        private TextBox txtRate;
        private TextBox txtSub_Total;
        private TextBox txtFee;
        private TextBox txtTotal;
        private Button btnSubmite;
        private Button btnClear;
    }
}
