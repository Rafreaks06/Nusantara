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
            txtBalance = new TextBox();
            lblBeneficiary = new Label();
            lblAmount = new Label();
            lblTransfer = new Label();
            lblRemarks = new Label();
            txtBeneficiary = new TextBox();
            txtAmount = new TextBox();
            txtTransfer = new TextBox();
            txtRemarks = new TextBox();
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
            // txtBalance
            // 
            txtBalance.Location = new Point(20, 52);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(228, 31);
            txtBalance.TabIndex = 1;
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
            // txtBeneficiary
            // 
            txtBeneficiary.Location = new Point(25, 135);
            txtBeneficiary.Name = "txtBeneficiary";
            txtBeneficiary.Size = new Size(223, 31);
            txtBeneficiary.TabIndex = 6;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(25, 197);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(223, 31);
            txtAmount.TabIndex = 7;
            // 
            // txtTransfer
            // 
            txtTransfer.Location = new Point(25, 272);
            txtTransfer.Name = "txtTransfer";
            txtTransfer.Size = new Size(223, 31);
            txtTransfer.TabIndex = 8;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(25, 353);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(223, 31);
            txtRemarks.TabIndex = 9;
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
            btnSubmit.Click += btnSubmit_Click;
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
            Controls.Add(txtRemarks);
            Controls.Add(txtTransfer);
            Controls.Add(txtAmount);
            Controls.Add(txtBeneficiary);
            Controls.Add(lblRemarks);
            Controls.Add(lblTransfer);
            Controls.Add(lblAmount);
            Controls.Add(lblBeneficiary);
            Controls.Add(txtBalance);
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
        private TextBox txtBalance;
        private Label lblBeneficiary;
        private Label lblAmount;
        private Label lblTransfer;
        private Label lblRemarks;
        private TextBox txtBeneficiary;
        private TextBox txtAmount;
        private TextBox txtTransfer;
        private TextBox txtRemarks;
        private Label lblIncoming;
        private Label lblOutgoing;
        private DataGridView dgvIncoming;
        private DataGridView dgvOutgoing;
        private Button btnSubmit;
        private Button btnClear;
    }
}
