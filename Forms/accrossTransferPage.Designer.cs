namespace Nusantara.Forms
{
    partial class accrossTransferPage
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
            lblBalance = new Label();
            textBox1 = new TextBox();
            lblBeneficiary = new Label();
            lblAmount = new Label();
            lblTransfer = new Label();
            lblRemarks = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            lblIncoming = new Label();
            lblOutgoing = new Label();
            dgvIncoming = new DataGridView();
            dgvOutgoing = new DataGridView();
            btnSubmit = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).BeginInit();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(20, 24);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(71, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 31);
            textBox1.TabIndex = 1;
            // 
            // lblBeneficiary
            // 
            lblBeneficiary.AutoSize = true;
            lblBeneficiary.Location = new Point(20, 96);
            lblBeneficiary.Name = "lblBeneficiary";
            lblBeneficiary.Size = new Size(96, 25);
            lblBeneficiary.TabIndex = 2;
            lblBeneficiary.Text = "Beneficiary";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(25, 169);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.Location = new Point(25, 244);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new Size(105, 25);
            lblTransfer.TabIndex = 4;
            lblTransfer.Text = "Transfer Rell";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(25, 316);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(79, 25);
            lblRemarks.TabIndex = 5;
            lblRemarks.Text = "Remarks";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(25, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 31);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(25, 353);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 31);
            textBox5.TabIndex = 9;
            // 
            // lblIncoming
            // 
            lblIncoming.AutoSize = true;
            lblIncoming.Location = new Point(388, 15);
            lblIncoming.Name = "lblIncoming";
            lblIncoming.Size = new Size(87, 25);
            lblIncoming.TabIndex = 10;
            lblIncoming.Text = "Incoming";
            // 
            // lblOutgoing
            // 
            lblOutgoing.AutoSize = true;
            lblOutgoing.Location = new Point(388, 244);
            lblOutgoing.Name = "lblOutgoing";
            lblOutgoing.Size = new Size(89, 25);
            lblOutgoing.TabIndex = 11;
            lblOutgoing.Text = "Outgoing";
            // 
            // dgvIncoming
            // 
            dgvIncoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncoming.Location = new Point(388, 43);
            dgvIncoming.Name = "dgvIncoming";
            dgvIncoming.RowHeadersWidth = 62;
            dgvIncoming.Size = new Size(283, 192);
            dgvIncoming.TabIndex = 12;
            // 
            // dgvOutgoing
            // 
            dgvOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutgoing.Location = new Point(388, 272);
            dgvOutgoing.Name = "dgvOutgoing";
            dgvOutgoing.RowHeadersWidth = 62;
            dgvOutgoing.Size = new Size(283, 186);
            dgvOutgoing.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(42, 425);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(207, 425);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // accrossTransferPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(dgvOutgoing);
            Controls.Add(dgvIncoming);
            Controls.Add(lblOutgoing);
            Controls.Add(lblIncoming);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblRemarks);
            Controls.Add(lblTransfer);
            Controls.Add(lblAmount);
            Controls.Add(lblBeneficiary);
            Controls.Add(textBox1);
            Controls.Add(lblBalance);
            Name = "accrossTransferPage";
            Size = new Size(713, 491);
            Load += accrossTransferPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private TextBox textBox1;
        private Label lblBeneficiary;
        private Label lblAmount;
        private Label lblTransfer;
        private Label lblRemarks;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblIncoming;
        private Label lblOutgoing;
        private DataGridView dgvIncoming;
        private DataGridView dgvOutgoing;
        private Button btnSubmit;
        private Button btnClear;
    }
}
