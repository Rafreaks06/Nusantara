namespace Nusantara.Forms
{
    partial class LoanPage
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
            txtLoan = new TextBox();
            txtAdminFee = new TextBox();
            txtMinAmount = new TextBox();
            txtInterestFine = new TextBox();
            txtDueDate = new TextBox();
            txtDocumentKK = new TextBox();
            txtDocumentGaji = new TextBox();
            txtDocumentKtp = new TextBox();
            txtMaxAmount = new TextBox();
            txtTenor = new TextBox();
            textInterest = new TextBox();
            txtAmount = new TextBox();
            btnktp = new Button();
            btnShowKtp = new Button();
            btnShowKK = new Button();
            btnKK = new Button();
            btnShowGaji = new Button();
            btnGaji = new Button();
            btnNewLoan = new Button();
            btnApplyLoan = new Button();
            Loan = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            datagridLoan = new DataGridView();
            btnReload = new Button();
            label2 = new Label();
            comboLoanType = new ComboBox();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridLoan).BeginInit();
            SuspendLayout();
            // 
            // txtLoan
            // 
            txtLoan.Location = new Point(46, 42);
            txtLoan.Name = "txtLoan";
            txtLoan.Size = new Size(204, 23);
            txtLoan.TabIndex = 0;
            txtLoan.TextChanged += txtLoan_TextChanged;
            // 
            // txtAdminFee
            // 
            txtAdminFee.Location = new Point(46, 152);
            txtAdminFee.Name = "txtAdminFee";
            txtAdminFee.Size = new Size(204, 23);
            txtAdminFee.TabIndex = 2;
            // 
            // txtMinAmount
            // 
            txtMinAmount.Location = new Point(46, 204);
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(204, 23);
            txtMinAmount.TabIndex = 3;
            // 
            // txtInterestFine
            // 
            txtInterestFine.Location = new Point(46, 262);
            txtInterestFine.Name = "txtInterestFine";
            txtInterestFine.Size = new Size(204, 23);
            txtInterestFine.TabIndex = 4;
            txtInterestFine.TextChanged += txtIntrestFine_TextChanged;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(46, 323);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(204, 23);
            txtDueDate.TabIndex = 5;
            // 
            // txtDocumentKK
            // 
            txtDocumentKK.Location = new Point(46, 375);
            txtDocumentKK.Name = "txtDocumentKK";
            txtDocumentKK.Size = new Size(204, 23);
            txtDocumentKK.TabIndex = 6;
            // 
            // txtDocumentGaji
            // 
            txtDocumentGaji.Location = new Point(296, 375);
            txtDocumentGaji.Name = "txtDocumentGaji";
            txtDocumentGaji.Size = new Size(204, 23);
            txtDocumentGaji.TabIndex = 13;
            // 
            // txtDocumentKtp
            // 
            txtDocumentKtp.Location = new Point(296, 262);
            txtDocumentKtp.Name = "txtDocumentKtp";
            txtDocumentKtp.Size = new Size(204, 23);
            txtDocumentKtp.TabIndex = 11;
            txtDocumentKtp.TextChanged += txtDocumentKtp_TextChanged;
            // 
            // txtMaxAmount
            // 
            txtMaxAmount.Location = new Point(296, 204);
            txtMaxAmount.Name = "txtMaxAmount";
            txtMaxAmount.Size = new Size(204, 23);
            txtMaxAmount.TabIndex = 10;
            // 
            // txtTenor
            // 
            txtTenor.Location = new Point(296, 152);
            txtTenor.Name = "txtTenor";
            txtTenor.Size = new Size(204, 23);
            txtTenor.TabIndex = 9;
            // 
            // textInterest
            // 
            textInterest.Location = new Point(296, 98);
            textInterest.Name = "textInterest";
            textInterest.Size = new Size(204, 23);
            textInterest.TabIndex = 8;
            textInterest.TextChanged += textInterest_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(296, 42);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(204, 23);
            txtAmount.TabIndex = 7;
            // 
            // btnktp
            // 
            btnktp.Location = new Point(296, 302);
            btnktp.Name = "btnktp";
            btnktp.Size = new Size(75, 23);
            btnktp.TabIndex = 15;
            btnktp.Text = "Browse";
            btnktp.UseVisualStyleBackColor = true;
            btnktp.Click += btnktp_Click;
            // 
            // btnShowKtp
            // 
            btnShowKtp.Location = new Point(414, 302);
            btnShowKtp.Name = "btnShowKtp";
            btnShowKtp.Size = new Size(75, 23);
            btnShowKtp.TabIndex = 16;
            btnShowKtp.Text = "Show";
            btnShowKtp.UseVisualStyleBackColor = true;
            // 
            // btnShowKK
            // 
            btnShowKK.Location = new Point(164, 420);
            btnShowKK.Name = "btnShowKK";
            btnShowKK.Size = new Size(75, 23);
            btnShowKK.TabIndex = 18;
            btnShowKK.Text = "Show";
            btnShowKK.UseVisualStyleBackColor = true;
            // 
            // btnKK
            // 
            btnKK.Location = new Point(46, 420);
            btnKK.Name = "btnKK";
            btnKK.Size = new Size(75, 23);
            btnKK.TabIndex = 17;
            btnKK.Text = "Browse";
            btnKK.UseVisualStyleBackColor = true;
            btnKK.Click += btnKK_Click;
            // 
            // btnShowGaji
            // 
            btnShowGaji.Location = new Point(414, 420);
            btnShowGaji.Name = "btnShowGaji";
            btnShowGaji.Size = new Size(75, 23);
            btnShowGaji.TabIndex = 20;
            btnShowGaji.Text = "Show";
            btnShowGaji.UseVisualStyleBackColor = true;
            // 
            // btnGaji
            // 
            btnGaji.Location = new Point(296, 420);
            btnGaji.Name = "btnGaji";
            btnGaji.Size = new Size(75, 23);
            btnGaji.TabIndex = 19;
            btnGaji.Text = "Browse";
            btnGaji.UseVisualStyleBackColor = true;
            btnGaji.Click += btnGaji_Click;
            // 
            // btnNewLoan
            // 
            btnNewLoan.Location = new Point(296, 472);
            btnNewLoan.Name = "btnNewLoan";
            btnNewLoan.Size = new Size(119, 23);
            btnNewLoan.TabIndex = 22;
            btnNewLoan.Text = "New Loan";
            btnNewLoan.UseVisualStyleBackColor = true;
            btnNewLoan.Click += btnNewLoan_Click;
            // 
            // btnApplyLoan
            // 
            btnApplyLoan.Location = new Point(164, 472);
            btnApplyLoan.Name = "btnApplyLoan";
            btnApplyLoan.Size = new Size(120, 23);
            btnApplyLoan.TabIndex = 21;
            btnApplyLoan.Text = "Apply Loan";
            btnApplyLoan.UseVisualStyleBackColor = true;
            // 
            // Loan
            // 
            Loan.AutoSize = true;
            Loan.Location = new Point(46, 24);
            Loan.Name = "Loan";
            Loan.Size = new Size(33, 15);
            Loan.TabIndex = 24;
            Loan.Text = "Loan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 80);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 25;
            label1.Text = "Loan Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 134);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 26;
            label3.Text = "Admin Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 186);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 27;
            label4.Text = "Min Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 244);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 28;
            label5.Text = "Interest Fine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 306);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 29;
            label6.Text = "Due Date ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 357);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 30;
            label7.Text = "Document KK";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 24);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 31;
            label8.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 80);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 32;
            label9.Text = "Interest";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(296, 134);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 33;
            label10.Text = "Tenor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(296, 186);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 34;
            label11.Text = "Max Amount";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(296, 244);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 35;
            label12.Text = "Document Ktp";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(296, 357);
            label13.Name = "label13";
            label13.Size = new Size(108, 15);
            label13.TabIndex = 36;
            label13.Text = "Document Slip Gaji";
            // 
            // datagridLoan
            // 
            datagridLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridLoan.Location = new Point(548, 51);
            datagridLoan.Name = "datagridLoan";
            datagridLoan.Size = new Size(453, 347);
            datagridLoan.TabIndex = 37;
            datagridLoan.CellContentClick += datagridLoan_CellContentClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(723, 420);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(104, 23);
            btnReload.TabIndex = 38;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(548, 24);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 39;
            label2.Text = "Loan";
            // 
            // comboLoanType
            // 
            comboLoanType.FormattingEnabled = true;
            comboLoanType.Location = new Point(46, 108);
            comboLoanType.Name = "comboLoanType";
            comboLoanType.Size = new Size(204, 23);
            comboLoanType.TabIndex = 40;
            comboLoanType.SelectedIndexChanged += comboLoanType_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(206, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(12, 15);
            lblId.TabIndex = 41;
            lblId.Text = "_";
            lblId.Visible = false;
            lblId.Click += label14_Click;
            // 
            // LoanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblId);
            Controls.Add(comboLoanType);
            Controls.Add(label2);
            Controls.Add(btnReload);
            Controls.Add(datagridLoan);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Loan);
            Controls.Add(btnNewLoan);
            Controls.Add(btnApplyLoan);
            Controls.Add(btnShowGaji);
            Controls.Add(btnGaji);
            Controls.Add(btnShowKK);
            Controls.Add(btnKK);
            Controls.Add(btnShowKtp);
            Controls.Add(btnktp);
            Controls.Add(txtDocumentGaji);
            Controls.Add(txtDocumentKtp);
            Controls.Add(txtMaxAmount);
            Controls.Add(txtTenor);
            Controls.Add(textInterest);
            Controls.Add(txtAmount);
            Controls.Add(txtDocumentKK);
            Controls.Add(txtDueDate);
            Controls.Add(txtInterestFine);
            Controls.Add(txtMinAmount);
            Controls.Add(txtAdminFee);
            Controls.Add(txtLoan);
            Name = "LoanPage";
            Size = new Size(1026, 521);
            Load += LoanPage_Load;
            ((System.ComponentModel.ISupportInitialize)datagridLoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoan;
        private TextBox txtLoanType;
        private TextBox txtAdminFee;
        private TextBox txtMinAmount;
        private TextBox txtInterestFine;
        private TextBox txtDueDate;
        private TextBox txtDocumentKK;
        private TextBox txtDocumentGaji;
        private TextBox txtDocumentKtp;
        private TextBox txtMaxAmount;
        private TextBox txtTenor;
        private TextBox textInterest;
        private TextBox txtAmount;
        private Button btnktp;
        private Button btnShowKtp;
        private Button btnShowKK;
        private Button btnKK;
        private Button btnShowGaji;
        private Button btnGaji;
        private Button btnNewLoan;
        private Button btnApplyLoan;
        private Label Loan;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView datagridLoan;
        private Button btnReload;
        private Label label2;
        private ComboBox comboLoanType;
        private Label lblId;
    }
}
