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
            lblExchange.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExchange.Location = new Point(88, 25);
            lblExchange.Margin = new Padding(2, 0, 2, 0);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(109, 20);
            lblExchange.TabIndex = 0;
            lblExchange.Text = "Exchange USD";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(12, 74);
            lblAmount.Margin = new Padding(2, 0, 2, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(16, 100);
            lblRate.Margin = new Padding(2, 0, 2, 0);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(30, 15);
            lblRate.TabIndex = 2;
            lblRate.Text = "Rate";
            // 
            // lblSub_Total
            // 
            lblSub_Total.AutoSize = true;
            lblSub_Total.Location = new Point(12, 129);
            lblSub_Total.Margin = new Padding(2, 0, 2, 0);
            lblSub_Total.Name = "lblSub_Total";
            lblSub_Total.Size = new Size(55, 15);
            lblSub_Total.TabIndex = 3;
            lblSub_Total.Text = "Sub Total";
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(16, 156);
            lblFee.Margin = new Padding(2, 0, 2, 0);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(25, 15);
            lblFee.TabIndex = 4;
            lblFee.Text = "Fee";
            //lblFee.Click += lblFee_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(16, 187);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(88, 66);
            txtAmount.Margin = new Padding(2, 2, 2, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(165, 23);
            txtAmount.TabIndex = 6;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(88, 92);
            txtRate.Margin = new Padding(2, 2, 2, 2);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(165, 23);
            txtRate.TabIndex = 7;
            // 
            // txtSub_Total
            // 
            txtSub_Total.Location = new Point(88, 121);
            txtSub_Total.Margin = new Padding(2, 2, 2, 2);
            txtSub_Total.Name = "txtSub_Total";
            txtSub_Total.ReadOnly = true;
            txtSub_Total.Size = new Size(165, 23);
            txtSub_Total.TabIndex = 8;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(88, 148);
            txtFee.Margin = new Padding(2, 2, 2, 2);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(165, 23);
            txtFee.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(88, 179);
            txtTotal.Margin = new Padding(2, 2, 2, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(165, 23);
            txtTotal.TabIndex = 10;
            // 
            // btnSubmite
            // 
            btnSubmite.Location = new Point(57, 239);
            btnSubmite.Margin = new Padding(2, 2, 2, 2);
            btnSubmite.Name = "btnSubmite";
            btnSubmite.Size = new Size(78, 20);
            btnSubmite.TabIndex = 11;
            btnSubmite.Text = "Submit";
            btnSubmite.UseVisualStyleBackColor = true;
            btnSubmite.Click += btnSubmite_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(164, 239);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 20);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "ExchangePage";
            Size = new Size(400, 474);
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
