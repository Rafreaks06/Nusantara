namespace Nusantara.Forms.AdminMenus
{
    partial class ProductPage
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
            dataGridViewLoan = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanMasterBindingSource = new BindingSource(components);
            dataGridViewSaving = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tenorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            savingMasterBindingSource = new BindingSource(components);
            textBoxName = new TextBox();
            label1 = new Label();
            comboMode = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textInterest = new TextBox();
            label4 = new Label();
            textFine = new TextBox();
            label5 = new Label();
            textTenor = new TextBox();
            label6 = new Label();
            textAdminFee = new TextBox();
            label7 = new Label();
            textMinAmount = new TextBox();
            label8 = new Label();
            textMaxAmount = new TextBox();
            labelId = new Label();
            buttonSubmit = new Button();
            buttonNew = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).BeginInit();
            ((System.ComponentModel.ISupportInitialize)savingMasterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.AllowUserToAddRows = false;
            dataGridViewLoan.AllowUserToDeleteRows = false;
            dataGridViewLoan.AutoGenerateColumns = false;
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, interestDataGridViewTextBoxColumn, tenorDataGridViewTextBoxColumn });
            dataGridViewLoan.DataSource = loanMasterBindingSource;
            dataGridViewLoan.Location = new Point(19, 303);
            dataGridViewLoan.Margin = new Padding(4, 5, 4, 5);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.ReadOnly = true;
            dataGridViewLoan.RowHeadersWidth = 62;
            dataGridViewLoan.Size = new Size(534, 338);
            dataGridViewLoan.TabIndex = 0;
            dataGridViewLoan.CellClick += dataGridViewLoan_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn.MinimumWidth = 8;
            interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            interestDataGridViewTextBoxColumn.ReadOnly = true;
            interestDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenorDataGridViewTextBoxColumn
            // 
            tenorDataGridViewTextBoxColumn.DataPropertyName = "Tenor";
            tenorDataGridViewTextBoxColumn.HeaderText = "Tenor";
            tenorDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenorDataGridViewTextBoxColumn.Name = "tenorDataGridViewTextBoxColumn";
            tenorDataGridViewTextBoxColumn.ReadOnly = true;
            tenorDataGridViewTextBoxColumn.Width = 150;
            // 
            // loanMasterBindingSource
            // 
            loanMasterBindingSource.DataSource = typeof(Models.LoanMaster);
            // 
            // dataGridViewSaving
            // 
            dataGridViewSaving.AllowUserToAddRows = false;
            dataGridViewSaving.AllowUserToDeleteRows = false;
            dataGridViewSaving.AutoGenerateColumns = false;
            dataGridViewSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaving.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, interestDataGridViewTextBoxColumn1, tenorDataGridViewTextBoxColumn1 });
            dataGridViewSaving.DataSource = savingMasterBindingSource;
            dataGridViewSaving.Location = new Point(563, 303);
            dataGridViewSaving.Margin = new Padding(4, 5, 4, 5);
            dataGridViewSaving.Name = "dataGridViewSaving";
            dataGridViewSaving.ReadOnly = true;
            dataGridViewSaving.RowHeadersWidth = 62;
            dataGridViewSaving.Size = new Size(529, 338);
            dataGridViewSaving.TabIndex = 1;
            dataGridViewSaving.CellClick += dataGridViewSaving_CellClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // interestDataGridViewTextBoxColumn1
            // 
            interestDataGridViewTextBoxColumn1.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn1.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn1.MinimumWidth = 8;
            interestDataGridViewTextBoxColumn1.Name = "interestDataGridViewTextBoxColumn1";
            interestDataGridViewTextBoxColumn1.ReadOnly = true;
            interestDataGridViewTextBoxColumn1.Width = 150;
            // 
            // tenorDataGridViewTextBoxColumn1
            // 
            tenorDataGridViewTextBoxColumn1.DataPropertyName = "Tenor";
            tenorDataGridViewTextBoxColumn1.HeaderText = "Tenor";
            tenorDataGridViewTextBoxColumn1.MinimumWidth = 8;
            tenorDataGridViewTextBoxColumn1.Name = "tenorDataGridViewTextBoxColumn1";
            tenorDataGridViewTextBoxColumn1.ReadOnly = true;
            tenorDataGridViewTextBoxColumn1.Width = 150;
            // 
            // savingMasterBindingSource
            // 
            savingMasterBindingSource.DataSource = typeof(Models.SavingMaster);
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(19, 58);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(261, 31);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // comboMode
            // 
            comboMode.FormattingEnabled = true;
            comboMode.Items.AddRange(new object[] { "--Choose--", "Loan", "Saving" });
            comboMode.Location = new Point(290, 58);
            comboMode.Margin = new Padding(4, 5, 4, 5);
            comboMode.Name = "comboMode";
            comboMode.Size = new Size(263, 33);
            comboMode.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Mode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 7;
            label3.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(563, 58);
            textInterest.Margin = new Padding(4, 5, 4, 5);
            textInterest.Name = "textInterest";
            textInterest.Size = new Size(255, 31);
            textInterest.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(833, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 9;
            label4.Text = "Interest Fine";
            // 
            // textFine
            // 
            textFine.Location = new Point(829, 58);
            textFine.Margin = new Padding(4, 5, 4, 5);
            textFine.Name = "textFine";
            textFine.Size = new Size(261, 31);
            textFine.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 107);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 11;
            label5.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(19, 137);
            textTenor.Margin = new Padding(4, 5, 4, 5);
            textTenor.Name = "textTenor";
            textTenor.Size = new Size(261, 31);
            textTenor.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 107);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 13;
            label6.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(290, 137);
            textAdminFee.Margin = new Padding(4, 5, 4, 5);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.Size = new Size(261, 31);
            textAdminFee.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(566, 107);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 15;
            label7.Text = "Minimum Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(561, 137);
            textMinAmount.Margin = new Padding(4, 5, 4, 5);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.Size = new Size(261, 31);
            textMinAmount.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(837, 107);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(161, 25);
            label8.TabIndex = 17;
            label8.Text = "Maximum Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(833, 137);
            textMaxAmount.Margin = new Padding(4, 5, 4, 5);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.Size = new Size(261, 31);
            textMaxAmount.TabIndex = 16;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(290, 208);
            labelId.Margin = new Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(24, 25);
            labelId.TabIndex = 18;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(17, 202);
            buttonSubmit.Margin = new Padding(4, 5, 4, 5);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(107, 38);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(133, 202);
            buttonNew.Margin = new Padding(4, 5, 4, 5);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(107, 38);
            buttonNew.TabIndex = 20;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 273);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 25);
            label9.TabIndex = 21;
            label9.Text = "Master Loan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(567, 273);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(124, 25);
            label10.TabIndex = 22;
            label10.Text = "Master Saving";
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(buttonNew);
            Controls.Add(buttonSubmit);
            Controls.Add(labelId);
            Controls.Add(label8);
            Controls.Add(textMaxAmount);
            Controls.Add(label7);
            Controls.Add(textMinAmount);
            Controls.Add(label6);
            Controls.Add(textAdminFee);
            Controls.Add(label5);
            Controls.Add(textTenor);
            Controls.Add(label4);
            Controls.Add(textFine);
            Controls.Add(label3);
            Controls.Add(textInterest);
            Controls.Add(label2);
            Controls.Add(comboMode);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(dataGridViewSaving);
            Controls.Add(dataGridViewLoan);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductPage";
            Size = new Size(1116, 665);
            Load += ProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).EndInit();
            ((System.ComponentModel.ISupportInitialize)savingMasterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLoan;
        private DataGridView dataGridViewSaving;
        private TextBox textBoxName;
        private Label label1;
        private ComboBox comboMode;
        private Label label2;
        private Label label3;
        private TextBox textInterest;
        private Label label4;
        private TextBox textFine;
        private Label label5;
        private TextBox textTenor;
        private Label label6;
        private TextBox textAdminFee;
        private Label label7;
        private TextBox textMinAmount;
        private Label label8;
        private TextBox textMaxAmount;
        private Label labelId;
        private Button buttonSubmit;
        private Button buttonNew;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn;
        private BindingSource loanMasterBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn1;
        private BindingSource savingMasterBindingSource;
        private Label label9;
        private Label label10;
    }
}
