namespace Nusantara.Forms.PublicMenus
{
    partial class InhousePage
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
            labelMyBenef = new Label();
            label7 = new Label();
            dgvOutgoing = new DataGridView();
            label6 = new Label();
            dgvIncoming = new DataGridView();
            buttonClear = new Button();
            buttonSubmit = new Button();
            textRemarks = new TextBox();
            label5 = new Label();
            textTransRef = new TextBox();
            label4 = new Label();
            textAmount = new TextBox();
            label3 = new Label();
            textBenef = new TextBox();
            label2 = new Label();
            textBalance = new TextBox();
            label1 = new Label();
            timerInbox = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).BeginInit();
            SuspendLayout();
            // 
            // labelMyBenef
            // 
            labelMyBenef.AutoSize = true;
            labelMyBenef.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMyBenef.Location = new Point(37, 37);
            labelMyBenef.Margin = new Padding(4, 0, 4, 0);
            labelMyBenef.Name = "labelMyBenef";
            labelMyBenef.Size = new Size(105, 25);
            labelMyBenef.TabIndex = 33;
            labelMyBenef.Text = "My Benef: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(384, 342);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 32;
            label7.Text = "Outgoing";
            // 
            // dgvOutgoing
            // 
            dgvOutgoing.AllowUserToAddRows = false;
            dgvOutgoing.AllowUserToDeleteRows = false;
            dgvOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutgoing.Location = new Point(384, 372);
            dgvOutgoing.Margin = new Padding(4, 5, 4, 5);
            dgvOutgoing.Name = "dgvOutgoing";
            dgvOutgoing.ReadOnly = true;
            dgvOutgoing.RowHeadersWidth = 62;
            dgvOutgoing.Size = new Size(980, 252);
            dgvOutgoing.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 37);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 30;
            label6.Text = "Incoming";
            // 
            // dgvIncoming
            // 
            dgvIncoming.AllowUserToAddRows = false;
            dgvIncoming.AllowUserToDeleteRows = false;
            dgvIncoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncoming.Location = new Point(384, 67);
            dgvIncoming.Margin = new Padding(4, 5, 4, 5);
            dgvIncoming.Name = "dgvIncoming";
            dgvIncoming.ReadOnly = true;
            dgvIncoming.RowHeadersWidth = 62;
            dgvIncoming.Size = new Size(980, 255);
            dgvIncoming.TabIndex = 29;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(200, 585);
            buttonClear.Margin = new Padding(4, 5, 4, 5);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(139, 38);
            buttonClear.TabIndex = 28;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(37, 585);
            buttonSubmit.Margin = new Padding(4, 5, 4, 5);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(139, 38);
            buttonSubmit.TabIndex = 27;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // textRemarks
            // 
            textRemarks.Location = new Point(40, 488);
            textRemarks.Margin = new Padding(4, 5, 4, 5);
            textRemarks.Multiline = true;
            textRemarks.Name = "textRemarks";
            textRemarks.Size = new Size(297, 69);
            textRemarks.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 452);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 25;
            label5.Text = "Remarks";
            // 
            // textTransRef
            // 
            textTransRef.Location = new Point(40, 395);
            textTransRef.Margin = new Padding(4, 5, 4, 5);
            textTransRef.Name = "textTransRef";
            textTransRef.ReadOnly = true;
            textTransRef.Size = new Size(297, 31);
            textTransRef.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 360);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 23;
            label4.Text = "Transfer Ref";
            // 
            // textAmount
            // 
            textAmount.Location = new Point(40, 303);
            textAmount.Margin = new Padding(4, 5, 4, 5);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(297, 31);
            textAmount.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 268);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 21;
            label3.Text = "Amount";
            // 
            // textBenef
            // 
            textBenef.Location = new Point(40, 213);
            textBenef.Margin = new Padding(4, 5, 4, 5);
            textBenef.Name = "textBenef";
            textBenef.Size = new Size(297, 31);
            textBenef.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 19;
            label2.Text = "Beneficiary";
            // 
            // textBalance
            // 
            textBalance.Location = new Point(40, 122);
            textBalance.Margin = new Padding(4, 5, 4, 5);
            textBalance.Name = "textBalance";
            textBalance.ReadOnly = true;
            textBalance.Size = new Size(297, 31);
            textBalance.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 17;
            label1.Text = "Balance";
            // 
            // timerInbox
            // 
            timerInbox.Interval = 10000;
            // 
            // InhousePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelMyBenef);
            Controls.Add(label7);
            Controls.Add(dgvOutgoing);
            Controls.Add(label6);
            Controls.Add(dgvIncoming);
            Controls.Add(buttonClear);
            Controls.Add(buttonSubmit);
            Controls.Add(textRemarks);
            Controls.Add(label5);
            Controls.Add(textTransRef);
            Controls.Add(label4);
            Controls.Add(textAmount);
            Controls.Add(label3);
            Controls.Add(textBenef);
            Controls.Add(label2);
            Controls.Add(textBalance);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "InhousePage";
            Size = new Size(1406, 693);
            Load += InhousePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMyBenef;
        private Label label7;
        private DataGridView dgvOutgoing;
        private Label label6;
        private DataGridView dgvIncoming;
        private Button buttonClear;
        private Button buttonSubmit;
        private TextBox textRemarks;
        private Label label5;
        private TextBox textTransRef;
        private Label label4;
        private TextBox textAmount;
        private Label label3;
        private TextBox textBenef;
        private Label label2;
        private TextBox textBalance;
        private Label label1;
        private System.Windows.Forms.Timer timerInbox;
    }
}
