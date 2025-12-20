namespace Nusantara.Forms
{
    partial class SavingPage
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
            components = new System.ComponentModel.Container();
            lblSaving_ID = new Label();
            txtSaving_ID = new TextBox();
            lblSaving_Type = new Label();
            lblAdmin_Fee = new Label();
            lblMin_Amount = new Label();
            lblInterest_Fine = new Label();
            lblDue_Date = new Label();
            lblDocument_KK = new Label();
            cmbSaving_Type = new ComboBox();
            txtAdmin_Fee = new TextBox();
            txtMin_Amount = new TextBox();
            txtInterest_Fine = new TextBox();
            txtDue_Date = new TextBox();
            txtDocument_KK = new TextBox();
            lblAmount = new Label();
            lblInterest = new Label();
            lblTenor = new Label();
            lblMax_Amount = new Label();
            lblDocument_KTP = new Label();
            txtAmount = new TextBox();
            txtInterest = new TextBox();
            txtTenor = new TextBox();
            txtMax_Amount = new TextBox();
            txtDocument_KTP = new TextBox();
            btnBrowse_KK = new Button();
            btnShow_KK = new Button();
            btnBrowse_KTP = new Button();
            btnShow_KTP = new Button();
            lblDocument_Slip_Gaji = new Label();
            txtDocument_Slip_Gaji = new TextBox();
            btnBrowse = new Button();
            btnShow = new Button();
            btnApply_Saving = new Button();
            btnNew_Saving = new Button();
            lblSaving = new Label();
            dgv_Saving = new DataGridView();
            btnReload = new Button();
            lblID = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgv_Saving).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblSaving_ID
            // 
            lblSaving_ID.AutoSize = true;
            lblSaving_ID.Location = new Point(31, 33);
            lblSaving_ID.Name = "lblSaving_ID";
            lblSaving_ID.Size = new Size(88, 25);
            lblSaving_ID.TabIndex = 0;
            lblSaving_ID.Text = "Saving ID";
            // 
            // txtSaving_ID
            // 
            txtSaving_ID.Location = new Point(31, 62);
            txtSaving_ID.Name = "txtSaving_ID";
            txtSaving_ID.ReadOnly = true;
            txtSaving_ID.Size = new Size(220, 31);
            txtSaving_ID.TabIndex = 1;
            // 
            // lblSaving_Type
            // 
            lblSaving_Type.AutoSize = true;
            lblSaving_Type.Location = new Point(31, 107);
            lblSaving_Type.Name = "lblSaving_Type";
            lblSaving_Type.Size = new Size(107, 25);
            lblSaving_Type.TabIndex = 2;
            lblSaving_Type.Text = "Saving Type";
            // 
            // lblAdmin_Fee
            // 
            lblAdmin_Fee.AutoSize = true;
            lblAdmin_Fee.Location = new Point(34, 182);
            lblAdmin_Fee.Name = "lblAdmin_Fee";
            lblAdmin_Fee.Size = new Size(97, 25);
            lblAdmin_Fee.TabIndex = 3;
            lblAdmin_Fee.Text = "Admin Fee";
            // 
            // lblMin_Amount
            // 
            lblMin_Amount.AutoSize = true;
            lblMin_Amount.Location = new Point(39, 262);
            lblMin_Amount.Name = "lblMin_Amount";
            lblMin_Amount.Size = new Size(112, 25);
            lblMin_Amount.TabIndex = 4;
            lblMin_Amount.Text = "Min Amount";
            lblMin_Amount.Click += lblMin_Amount_Click;
            // 
            // lblInterest_Fine
            // 
            lblInterest_Fine.AutoSize = true;
            lblInterest_Fine.Location = new Point(34, 335);
            lblInterest_Fine.Name = "lblInterest_Fine";
            lblInterest_Fine.Size = new Size(108, 25);
            lblInterest_Fine.TabIndex = 5;
            lblInterest_Fine.Text = "Interest Fine";
            // 
            // lblDue_Date
            // 
            lblDue_Date.AutoSize = true;
            lblDue_Date.Location = new Point(39, 407);
            lblDue_Date.Name = "lblDue_Date";
            lblDue_Date.Size = new Size(86, 25);
            lblDue_Date.TabIndex = 6;
            lblDue_Date.Text = "Due Date";
            // 
            // lblDocument_KK
            // 
            lblDocument_KK.AutoSize = true;
            lblDocument_KK.Location = new Point(39, 478);
            lblDocument_KK.Name = "lblDocument_KK";
            lblDocument_KK.Size = new Size(120, 25);
            lblDocument_KK.TabIndex = 7;
            lblDocument_KK.Text = "Document KK";
            lblDocument_KK.Click += lblDocument_KK_Click;
            // 
            // cmbSaving_Type
            // 
            cmbSaving_Type.FormattingEnabled = true;
            cmbSaving_Type.Location = new Point(34, 133);
            cmbSaving_Type.Name = "cmbSaving_Type";
            cmbSaving_Type.Size = new Size(217, 33);
            cmbSaving_Type.TabIndex = 8;
            // 
            // txtAdmin_Fee
            // 
            txtAdmin_Fee.Location = new Point(39, 218);
            txtAdmin_Fee.Name = "txtAdmin_Fee";
            txtAdmin_Fee.ReadOnly = true;
            txtAdmin_Fee.Size = new Size(214, 31);
            txtAdmin_Fee.TabIndex = 9;
            txtAdmin_Fee.TextChanged += txtAdmin_Fee_TextChanged;
            // 
            // txtMin_Amount
            // 
            txtMin_Amount.Location = new Point(39, 290);
            txtMin_Amount.Name = "txtMin_Amount";
            txtMin_Amount.ReadOnly = true;
            txtMin_Amount.Size = new Size(214, 31);
            txtMin_Amount.TabIndex = 10;
            // 
            // txtInterest_Fine
            // 
            txtInterest_Fine.Location = new Point(39, 363);
            txtInterest_Fine.Name = "txtInterest_Fine";
            txtInterest_Fine.ReadOnly = true;
            txtInterest_Fine.Size = new Size(217, 31);
            txtInterest_Fine.TabIndex = 11;
            // 
            // txtDue_Date
            // 
            txtDue_Date.Location = new Point(39, 435);
            txtDue_Date.Name = "txtDue_Date";
            txtDue_Date.Size = new Size(217, 31);
            txtDue_Date.TabIndex = 12;
            // 
            // txtDocument_KK
            // 
            txtDocument_KK.Location = new Point(39, 507);
            txtDocument_KK.Name = "txtDocument_KK";
            txtDocument_KK.ReadOnly = true;
            txtDocument_KK.Size = new Size(217, 31);
            txtDocument_KK.TabIndex = 13;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(296, 33);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 14;
            lblAmount.Text = "Amount";
            // 
            // lblInterest
            // 
            lblInterest.AutoSize = true;
            lblInterest.Location = new Point(296, 107);
            lblInterest.Name = "lblInterest";
            lblInterest.Size = new Size(71, 25);
            lblInterest.TabIndex = 15;
            lblInterest.Text = "Interest";
            // 
            // lblTenor
            // 
            lblTenor.AutoSize = true;
            lblTenor.Location = new Point(296, 182);
            lblTenor.Name = "lblTenor";
            lblTenor.Size = new Size(55, 25);
            lblTenor.TabIndex = 16;
            lblTenor.Text = "Tenor";
            // 
            // lblMax_Amount
            // 
            lblMax_Amount.AutoSize = true;
            lblMax_Amount.Location = new Point(301, 262);
            lblMax_Amount.Name = "lblMax_Amount";
            lblMax_Amount.Size = new Size(115, 25);
            lblMax_Amount.TabIndex = 17;
            lblMax_Amount.Text = "Max Amount";
            // 
            // lblDocument_KTP
            // 
            lblDocument_KTP.AutoSize = true;
            lblDocument_KTP.Location = new Point(301, 335);
            lblDocument_KTP.Name = "lblDocument_KTP";
            lblDocument_KTP.Size = new Size(129, 25);
            lblDocument_KTP.TabIndex = 18;
            lblDocument_KTP.Text = "Document KTP";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(296, 62);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(213, 31);
            txtAmount.TabIndex = 19;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(296, 137);
            txtInterest.Name = "txtInterest";
            txtInterest.ReadOnly = true;
            txtInterest.Size = new Size(213, 31);
            txtInterest.TabIndex = 20;
            // 
            // txtTenor
            // 
            txtTenor.Location = new Point(296, 218);
            txtTenor.Name = "txtTenor";
            txtTenor.ReadOnly = true;
            txtTenor.Size = new Size(213, 31);
            txtTenor.TabIndex = 21;
            // 
            // txtMax_Amount
            // 
            txtMax_Amount.Location = new Point(301, 290);
            txtMax_Amount.Name = "txtMax_Amount";
            txtMax_Amount.ReadOnly = true;
            txtMax_Amount.Size = new Size(213, 31);
            txtMax_Amount.TabIndex = 22;
            // 
            // txtDocument_KTP
            // 
            txtDocument_KTP.Location = new Point(301, 363);
            txtDocument_KTP.Name = "txtDocument_KTP";
            txtDocument_KTP.ReadOnly = true;
            txtDocument_KTP.Size = new Size(213, 31);
            txtDocument_KTP.TabIndex = 23;
            // 
            // btnBrowse_KK
            // 
            btnBrowse_KK.Location = new Point(41, 552);
            btnBrowse_KK.Name = "btnBrowse_KK";
            btnBrowse_KK.Size = new Size(101, 35);
            btnBrowse_KK.TabIndex = 24;
            btnBrowse_KK.Text = "Browse";
            btnBrowse_KK.UseVisualStyleBackColor = true;
            btnBrowse_KK.Click += btnBrowse_KK_Click;
            // 
            // btnShow_KK
            // 
            btnShow_KK.Location = new Point(159, 553);
            btnShow_KK.Name = "btnShow_KK";
            btnShow_KK.Size = new Size(97, 33);
            btnShow_KK.TabIndex = 25;
            btnShow_KK.Text = "Show";
            btnShow_KK.UseVisualStyleBackColor = true;
            // 
            // btnBrowse_KTP
            // 
            btnBrowse_KTP.Location = new Point(314, 407);
            btnBrowse_KTP.Name = "btnBrowse_KTP";
            btnBrowse_KTP.Size = new Size(90, 35);
            btnBrowse_KTP.TabIndex = 26;
            btnBrowse_KTP.Text = "Browse";
            btnBrowse_KTP.UseVisualStyleBackColor = true;
            // 
            // btnShow_KTP
            // 
            btnShow_KTP.Location = new Point(424, 407);
            btnShow_KTP.Name = "btnShow_KTP";
            btnShow_KTP.Size = new Size(90, 35);
            btnShow_KTP.TabIndex = 27;
            btnShow_KTP.Text = "Show";
            btnShow_KTP.UseVisualStyleBackColor = true;
            // 
            // lblDocument_Slip_Gaji
            // 
            lblDocument_Slip_Gaji.AutoSize = true;
            lblDocument_Slip_Gaji.Location = new Point(301, 478);
            lblDocument_Slip_Gaji.Name = "lblDocument_Slip_Gaji";
            lblDocument_Slip_Gaji.Size = new Size(163, 25);
            lblDocument_Slip_Gaji.TabIndex = 28;
            lblDocument_Slip_Gaji.Text = "Document Slip Gaji";
            // 
            // txtDocument_Slip_Gaji
            // 
            txtDocument_Slip_Gaji.Location = new Point(301, 507);
            txtDocument_Slip_Gaji.Name = "txtDocument_Slip_Gaji";
            txtDocument_Slip_Gaji.ReadOnly = true;
            txtDocument_Slip_Gaji.Size = new Size(213, 31);
            txtDocument_Slip_Gaji.TabIndex = 29;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(301, 552);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(87, 33);
            btnBrowse.TabIndex = 30;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(419, 543);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(90, 33);
            btnShow.TabIndex = 31;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // btnApply_Saving
            // 
            btnApply_Saving.Location = new Point(124, 612);
            btnApply_Saving.Name = "btnApply_Saving";
            btnApply_Saving.Size = new Size(154, 33);
            btnApply_Saving.TabIndex = 32;
            btnApply_Saving.Text = "Apply Saving";
            btnApply_Saving.UseVisualStyleBackColor = true;
            btnApply_Saving.Click += btnApply_Saving_Click;
            // 
            // btnNew_Saving
            // 
            btnNew_Saving.Location = new Point(314, 612);
            btnNew_Saving.Name = "btnNew_Saving";
            btnNew_Saving.Size = new Size(141, 33);
            btnNew_Saving.TabIndex = 33;
            btnNew_Saving.Text = "New Saving";
            btnNew_Saving.UseVisualStyleBackColor = true;
            // 
            // lblSaving
            // 
            lblSaving.AutoSize = true;
            lblSaving.Location = new Point(551, 33);
            lblSaving.Name = "lblSaving";
            lblSaving.Size = new Size(65, 25);
            lblSaving.TabIndex = 34;
            lblSaving.Text = "Saving";
            // 
            // dgv_Saving
            // 
            dgv_Saving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Saving.Location = new Point(541, 61);
            dgv_Saving.Name = "dgv_Saving";
            dgv_Saving.RowHeadersWidth = 62;
            dgv_Saving.Size = new Size(490, 500);
            dgv_Saving.TabIndex = 35;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(751, 612);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(111, 33);
            btnReload.TabIndex = 36;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(184, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 25);
            lblID.TabIndex = 37;
            lblID.Text = "...";
            // 
            // SavingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblID);
            Controls.Add(btnReload);
            Controls.Add(dgv_Saving);
            Controls.Add(lblSaving);
            Controls.Add(btnNew_Saving);
            Controls.Add(btnApply_Saving);
            Controls.Add(btnShow);
            Controls.Add(btnBrowse);
            Controls.Add(txtDocument_Slip_Gaji);
            Controls.Add(lblDocument_Slip_Gaji);
            Controls.Add(btnShow_KTP);
            Controls.Add(btnBrowse_KTP);
            Controls.Add(btnShow_KK);
            Controls.Add(btnBrowse_KK);
            Controls.Add(txtDocument_KTP);
            Controls.Add(txtMax_Amount);
            Controls.Add(txtTenor);
            Controls.Add(txtInterest);
            Controls.Add(txtAmount);
            Controls.Add(lblDocument_KTP);
            Controls.Add(lblMax_Amount);
            Controls.Add(lblTenor);
            Controls.Add(lblInterest);
            Controls.Add(lblAmount);
            Controls.Add(txtDocument_KK);
            Controls.Add(txtDue_Date);
            Controls.Add(txtInterest_Fine);
            Controls.Add(txtMin_Amount);
            Controls.Add(txtAdmin_Fee);
            Controls.Add(cmbSaving_Type);
            Controls.Add(lblDocument_KK);
            Controls.Add(lblDue_Date);
            Controls.Add(lblInterest_Fine);
            Controls.Add(lblMin_Amount);
            Controls.Add(lblAdmin_Fee);
            Controls.Add(lblSaving_Type);
            Controls.Add(txtSaving_ID);
            Controls.Add(lblSaving_ID);
            Name = "SavingPage";
            Size = new Size(1059, 663);
            ((System.ComponentModel.ISupportInitialize)dgv_Saving).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaving_ID;
        private TextBox txtSaving_ID;
        private Label lblSaving_Type;
        private Label lblAdmin_Fee;
        private Label lblMin_Amount;
        private Label lblInterest_Fine;
        private Label lblDue_Date;
        private Label lblDocument_KK;
        private ComboBox cmbSaving_Type;
        private TextBox txtAdmin_Fee;
        private TextBox txtMin_Amount;
        private TextBox txtInterest_Fine;
        private TextBox txtDue_Date;
        private TextBox txtDocument_KK;
        private Label lblAmount;
        private Label lblInterest;
        private Label lblTenor;
        private Label lblMax_Amount;
        private Label lblDocument_KTP;
        private TextBox txtAmount;
        private TextBox txtInterest;
        private TextBox txtTenor;
        private TextBox txtMax_Amount;
        private TextBox txtDocument_KTP;
        private Button btnBrowse_KK;
        private Button btnShow_KK;
        private Button btnBrowse_KTP;
        private Button btnShow_KTP;
        private Label lblDocument_Slip_Gaji;
        private TextBox txtDocument_Slip_Gaji;
        private Button btnBrowse;
        private Button btnShow;
        private Button btnApply_Saving;
        private Button btnNew_Saving;
        private Label lblSaving;
        private DataGridView dgv_Saving;
        private Button btnReload;
        private Label lblID;
        private BindingSource bindingSource1;
    }
}
