namespace Nusantara.Forms
{
    partial class AdminMenu
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
            paneldisplay = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            configurationToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            accesToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            approvalToolStripMenuItem = new ToolStripMenuItem();
            acrossCooperationToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // paneldisplay
            // 
            paneldisplay.BackColor = SystemColors.ButtonShadow;
            paneldisplay.Location = new Point(37, 84);
            paneldisplay.Margin = new Padding(4, 5, 4, 5);
            paneldisplay.Name = "paneldisplay";
            paneldisplay.Size = new Size(639, 297);
            paneldisplay.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, memberToolStripMenuItem, accesToolStripMenuItem, productToolStripMenuItem, approvalToolStripMenuItem, acrossCooperationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1295, 35);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurationToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 29);
            fileToolStripMenuItem.Text = "File ";
            // 
            // configurationToolStripMenuItem
            // 
            configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            configurationToolStripMenuItem.Size = new Size(223, 34);
            configurationToolStripMenuItem.Text = "Configuration";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(223, 34);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(95, 29);
            memberToolStripMenuItem.Text = "Member";
            // 
            // accesToolStripMenuItem
            // 
            accesToolStripMenuItem.Name = "accesToolStripMenuItem";
            accesToolStripMenuItem.Size = new Size(81, 29);
            accesToolStripMenuItem.Text = "Access";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(90, 29);
            productToolStripMenuItem.Text = "Product";
            // 
            // approvalToolStripMenuItem
            // 
            approvalToolStripMenuItem.Name = "approvalToolStripMenuItem";
            approvalToolStripMenuItem.Size = new Size(101, 29);
            approvalToolStripMenuItem.Text = "Approval";
            // 
            // acrossCooperationToolStripMenuItem
            // 
            acrossCooperationToolStripMenuItem.Name = "acrossCooperationToolStripMenuItem";
            acrossCooperationToolStripMenuItem.Size = new Size(185, 29);
            acrossCooperationToolStripMenuItem.Text = "Across Cooperation";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(37, 416);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 297);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(754, 84);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 297);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 54);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 5;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(754, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 6;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 386);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 7;
            label3.Text = "Transfer";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(paneldisplay);
            Controls.Add(menuStrip1);
            Name = "AdminMenu";
            Size = new Size(1295, 774);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paneldisplay;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem accesToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem approvalToolStripMenuItem;
        private ToolStripMenuItem acrossCooperationToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
