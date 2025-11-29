namespace Nusantara.Forms
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
            lblProduct = new Label();
            cmbProduct = new ComboBox();
            dataGridApprovalPage = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridApprovalPage).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(45, 37);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(74, 25);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(45, 65);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(351, 33);
            cmbProduct.TabIndex = 1;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // dataGridApprovalPage
            // 
            dataGridApprovalPage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridApprovalPage.Location = new Point(45, 123);
            dataGridApprovalPage.Name = "dataGridApprovalPage";
            dataGridApprovalPage.RowHeadersWidth = 62;
            dataGridApprovalPage.Size = new Size(644, 225);
            dataGridApprovalPage.TabIndex = 2;
            dataGridApprovalPage.CellContentClick += dataGridApprovalPage_CellContentClick;
            // 
            // ApprovalPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridApprovalPage);
            Controls.Add(cmbProduct);
            Controls.Add(lblProduct);
            Name = "ApprovalPage";
            Size = new Size(928, 527);
            Load += ApprovalPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridApprovalPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private ComboBox cmbProduct;
        private DataGridView dataGridApprovalPage;
    }
}
