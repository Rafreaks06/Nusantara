namespace Nusantara.Forms
{
    partial class AccrossPage
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
            dgvTransfer = new DataGridView();
            dgvBalance = new DataGridView();
            dgvCoop = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnrefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            SuspendLayout();
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Location = new Point(36, 386);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 62;
            dgvTransfer.Size = new Size(1220, 299);
            dgvTransfer.TabIndex = 17;
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(741, 52);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.RowHeadersWidth = 62;
            dgvBalance.Size = new Size(515, 299);
            dgvBalance.TabIndex = 16;
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Location = new Point(40, 52);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 62;
            dgvCoop.Size = new Size(649, 299);
            dgvCoop.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 358);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 14;
            label3.Text = "Transfer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(757, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 13;
            label2.Text = "Member";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 12;
            label1.Text = "Coop";
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(567, 712);
            btnrefresh.Margin = new Padding(4, 5, 4, 5);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(107, 38);
            btnrefresh.TabIndex = 18;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // AccrossPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnrefresh);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvBalance);
            Controls.Add(dgvCoop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccrossPage";
            Size = new Size(1293, 778);
            Load += AccrossPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTransfer;
        private DataGridView dgvBalance;
        private DataGridView dgvCoop;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnrefresh;
    }
}
