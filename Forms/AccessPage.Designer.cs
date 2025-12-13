namespace Nusantara.Forms
{
    partial class AccessPage
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
            comboboxMember = new ComboBox();
            label1 = new Label();
            buttonSubmit = new Button();
            GroupBox = new GroupBox();
            lblPhone = new Label();
            lblAddress = new Label();
            lblPhoneAlt = new Label();
            lblEmail = new Label();
            lblJoinDate = new Label();
            lblFullName = new Label();
            labelAddress = new Label();
            labelPhoneAlt = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelJoinDate = new Label();
            labelFullName = new Label();
            dataGridViewAccess = new DataGridView();
            label8 = new Label();
            checkedListBoxAccess = new CheckedListBox();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).BeginInit();
            SuspendLayout();
            // 
            // comboboxMember
            // 
            comboboxMember.FormattingEnabled = true;
            comboboxMember.Location = new Point(51, 75);
            comboboxMember.Name = "comboboxMember";
            comboboxMember.Size = new Size(289, 33);
            comboboxMember.TabIndex = 0;
            comboboxMember.SelectedIndexChanged += comboboxMember_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 1;
            label1.Text = "Member";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(405, 75);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(133, 34);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(lblPhone);
            GroupBox.Controls.Add(lblAddress);
            GroupBox.Controls.Add(lblPhoneAlt);
            GroupBox.Controls.Add(lblEmail);
            GroupBox.Controls.Add(lblJoinDate);
            GroupBox.Controls.Add(lblFullName);
            GroupBox.Controls.Add(labelAddress);
            GroupBox.Controls.Add(labelPhoneAlt);
            GroupBox.Controls.Add(labelPhone);
            GroupBox.Controls.Add(labelEmail);
            GroupBox.Controls.Add(labelJoinDate);
            GroupBox.Controls.Add(labelFullName);
            GroupBox.Location = new Point(37, 485);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(580, 303);
            GroupBox.TabIndex = 10;
            GroupBox.TabStop = false;
            GroupBox.Text = "Details";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(217, 166);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(24, 25);
            lblPhone.TabIndex = 12;
            lblPhone.Text = "...";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(217, 248);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(24, 25);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "...";
            // 
            // lblPhoneAlt
            // 
            lblPhoneAlt.AutoSize = true;
            lblPhoneAlt.Location = new Point(217, 206);
            lblPhoneAlt.Name = "lblPhoneAlt";
            lblPhoneAlt.Size = new Size(24, 25);
            lblPhoneAlt.TabIndex = 10;
            lblPhoneAlt.Text = "...";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(217, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(24, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "...";
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(217, 79);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(24, 25);
            lblJoinDate.TabIndex = 7;
            lblJoinDate.Text = "...";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(217, 37);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(24, 25);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "...";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(14, 248);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(77, 25);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Address";
            // 
            // labelPhoneAlt
            // 
            labelPhoneAlt.AutoSize = true;
            labelPhoneAlt.Location = new Point(17, 206);
            labelPhoneAlt.Name = "labelPhoneAlt";
            labelPhoneAlt.Size = new Size(84, 25);
            labelPhoneAlt.TabIndex = 4;
            labelPhoneAlt.Text = "PhoneAlt";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(16, 166);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(62, 25);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(16, 122);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(16, 79);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(80, 25);
            labelJoinDate.TabIndex = 1;
            labelJoinDate.Text = "JoinDate";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(13, 37);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(86, 25);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "FullName";
            // 
            // dataGridViewAccess
            // 
            dataGridViewAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccess.Location = new Point(616, 83);
            dataGridViewAccess.Name = "dataGridViewAccess";
            dataGridViewAccess.RowHeadersWidth = 62;
            dataGridViewAccess.Size = new Size(963, 713);
            dataGridViewAccess.TabIndex = 11;
            dataGridViewAccess.CellContentClick += dataGridViewAccess_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(625, 46);
            label8.Name = "label8";
            label8.Size = new Size(80, 26);
            label8.TabIndex = 12;
            label8.Text = "Access";
            // 
            // checkedListBoxAccess
            // 
            checkedListBoxAccess.FormattingEnabled = true;
            checkedListBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer-Inhouse", "Transfer-Accross", "Exchange" });
            checkedListBoxAccess.Location = new Point(37, 168);
            checkedListBoxAccess.Name = "checkedListBoxAccess";
            checkedListBoxAccess.Size = new Size(573, 256);
            checkedListBoxAccess.TabIndex = 13;
            checkedListBoxAccess.SelectedIndexChanged += checkedListBoxAccess_SelectedIndexChanged;
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(checkedListBoxAccess);
            Controls.Add(label8);
            Controls.Add(dataGridViewAccess);
            Controls.Add(GroupBox);
            Controls.Add(buttonSubmit);
            Controls.Add(label1);
            Controls.Add(comboboxMember);
            Name = "AccessPage";
            Size = new Size(1568, 806);
            Load += AccessPage_Load_1;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboboxMember;
        private Label label1;
        private Button buttonSubmit;
        private GroupBox GroupBox;
        private Label labelFullName;
        private Label labelJoinDate;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelPhoneAlt;
        private Label labelAddress;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblPhoneAlt;
        private Label lblEmail;
        private Label lblJoinDate;
        private DataGridView dataGridViewAccess;
        private Label label8;
        private CheckedListBox checkedListBoxAccess;
        private Label lblPhone;
    }
}
