namespace Nusantara.Forms
{
    partial class TerminologiPage
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
            labelTerminologi1 = new Label();
            labelTerminologi2 = new Label();
            labelTerminologi3 = new Label();
            SuspendLayout();
            // 
            // labelTerminologi1
            // 
            labelTerminologi1.AutoSize = true;
            labelTerminologi1.Location = new Point(122, 587);
            labelTerminologi1.Name = "labelTerminologi1";
            labelTerminologi1.Size = new Size(126, 25);
            labelTerminologi1.TabIndex = 0;
            labelTerminologi1.Text = "Exchange Rate";
            // 
            // labelTerminologi2
            // 
            labelTerminologi2.AutoSize = true;
            labelTerminologi2.Location = new Point(510, 587);
            labelTerminologi2.Name = "labelTerminologi2";
            labelTerminologi2.Size = new Size(107, 25);
            labelTerminologi2.TabIndex = 1;
            labelTerminologi2.Text = "Inhouse Fee";
            // 
            // labelTerminologi3
            // 
            labelTerminologi3.AutoSize = true;
            labelTerminologi3.Location = new Point(928, 587);
            labelTerminologi3.Name = "labelTerminologi3";
            labelTerminologi3.Size = new Size(97, 25);
            labelTerminologi3.TabIndex = 2;
            labelTerminologi3.Text = "Access Fee";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTerminologi3);
            Controls.Add(labelTerminologi2);
            Controls.Add(labelTerminologi1);
            Name = "TerminologiPage";
            Size = new Size(1211, 755);
            Load += TerminologiPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTerminologi1;
        private Label labelTerminologi2;
        private Label labelTerminologi3;
    }
}
