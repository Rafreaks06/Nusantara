namespace Nusantara.Forms
{
    partial class HomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuHome = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            terminologiToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem = new ToolStripMenuItem();
            savingToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            inhouseToolStripMenuItem = new ToolStripMenuItem();
            accrossToolStripMenuItem = new ToolStripMenuItem();
            exchangeToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            PanelDisplay = new Panel();
            MenuHome.SuspendLayout();
            SuspendLayout();
            // 
            // MenuHome
            // 
            MenuHome.ImageScalingSize = new Size(24, 24);
            MenuHome.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, profileToolStripMenuItem, loanToolStripMenuItem, savingToolStripMenuItem, transferToolStripMenuItem, exchangeToolStripMenuItem, historyToolStripMenuItem });
            MenuHome.Location = new Point(0, 0);
            MenuHome.Name = "MenuHome";
            MenuHome.Padding = new Padding(4, 1, 0, 1);
            MenuHome.Size = new Size(959, 24);
            MenuHome.TabIndex = 1;
            MenuHome.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, terminologiToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(137, 22);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // terminologiToolStripMenuItem
            // 
            terminologiToolStripMenuItem.Name = "terminologiToolStripMenuItem";
            terminologiToolStripMenuItem.Size = new Size(137, 22);
            terminologiToolStripMenuItem.Text = "Terminologi";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(137, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(53, 22);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // loanToolStripMenuItem
            // 
            loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            loanToolStripMenuItem.Size = new Size(45, 22);
            loanToolStripMenuItem.Text = "Loan";
            // 
            // savingToolStripMenuItem
            // 
            savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            savingToolStripMenuItem.Size = new Size(54, 22);
            savingToolStripMenuItem.Text = "Saving";
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inhouseToolStripMenuItem, accrossToolStripMenuItem });
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(60, 22);
            transferToolStripMenuItem.Text = "Transfer";
            // 
            // inhouseToolStripMenuItem
            // 
            inhouseToolStripMenuItem.Name = "inhouseToolStripMenuItem";
            inhouseToolStripMenuItem.Size = new Size(116, 22);
            inhouseToolStripMenuItem.Text = "Inhouse";
            // 
            // accrossToolStripMenuItem
            // 
            accrossToolStripMenuItem.Name = "accrossToolStripMenuItem";
            accrossToolStripMenuItem.Size = new Size(116, 22);
            accrossToolStripMenuItem.Text = "Accross";
            // 
            // exchangeToolStripMenuItem
            // 
            exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            exchangeToolStripMenuItem.Size = new Size(70, 22);
            exchangeToolStripMenuItem.Text = "Exchange";
            exchangeToolStripMenuItem.Click += exchangeToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(57, 22);
            historyToolStripMenuItem.Text = "History";
            // 
            // PanelDisplay
            // 
            PanelDisplay.Location = new Point(0, 22);
            PanelDisplay.Margin = new Padding(2, 2, 2, 2);
            PanelDisplay.Name = "PanelDisplay";
            PanelDisplay.Size = new Size(1096, 428);
            PanelDisplay.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 449);
            Controls.Add(PanelDisplay);
            Controls.Add(MenuHome);
            MainMenuStrip = MenuHome;
            Margin = new Padding(2, 2, 2, 2);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load_1;
            MenuHome.ResumeLayout(false);
            MenuHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MenuHome;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem terminologiToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem savingToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem inhouseToolStripMenuItem;
        private ToolStripMenuItem accrossToolStripMenuItem;
        private Panel PanelDisplay;
    }
}