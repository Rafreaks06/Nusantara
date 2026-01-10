namespace Nusantara.Forms.AdminMenus
{
    partial class ApprovalPage
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
            comboProduct = new ComboBox();
            label1 = new Label();
            dataGridViewApproval = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).BeginInit();
            SuspendLayout();
            // 
            // comboProduct
            // 
            comboProduct.FormattingEnabled = true;
            comboProduct.Items.AddRange(new object[] { "--Choose--", "Loan", "Saving", "Across Registration" });
            comboProduct.Location = new Point(20, 68);
            comboProduct.Margin = new Padding(4, 5, 4, 5);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(288, 33);
            comboProduct.TabIndex = 0;
            comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // dataGridViewApproval
            // 
            dataGridViewApproval.AllowUserToAddRows = false;
            dataGridViewApproval.AllowUserToDeleteRows = false;
            dataGridViewApproval.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApproval.Location = new Point(20, 135);
            dataGridViewApproval.Margin = new Padding(4, 5, 4, 5);
            dataGridViewApproval.Name = "dataGridViewApproval";
            dataGridViewApproval.ReadOnly = true;
            dataGridViewApproval.RowHeadersWidth = 62;
            dataGridViewApproval.Size = new Size(930, 250);
            dataGridViewApproval.TabIndex = 2;
            dataGridViewApproval.CellClick += dataGridViewApproval_CellClick;
            // 
            // ApprovalPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridViewApproval);
            Controls.Add(label1);
            Controls.Add(comboProduct);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ApprovalPage";
            Size = new Size(974, 432);
            Load += ApprovalPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboProduct;
        private Label label1;
        private DataGridView dataGridViewApproval;
    }
}
