namespace WindowsFormsApp1
{
    partial class NavigationForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.crystalReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonernameSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crystalReportsToolStripMenuItem,
            this.connectedModeToolStripMenuItem,
            this.disconnectedModeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // crystalReportsToolStripMenuItem
            // 
            this.crystalReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.caseToolStripMenuItem});
            this.crystalReportsToolStripMenuItem.Name = "crystalReportsToolStripMenuItem";
            this.crystalReportsToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.crystalReportsToolStripMenuItem.Text = "crystal reports";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.viewReportsToolStripMenuItem.Text = "view prisoner";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.viewToolStripMenuItem.Text = "view visits";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.caseToolStripMenuItem.Text = "case search";
            this.caseToolStripMenuItem.Click += new System.EventHandler(this.caseToolStripMenuItem_Click);
            // 
            // connectedModeToolStripMenuItem
            // 
            this.connectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitFunctionToolStripMenuItem,
            this.visitSelectionToolStripMenuItem,
            this.visitorFunctionToolStripMenuItem,
            this.visitorSelectionToolStripMenuItem});
            this.connectedModeToolStripMenuItem.Name = "connectedModeToolStripMenuItem";
            this.connectedModeToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.connectedModeToolStripMenuItem.Text = "Connected Mode";
            this.connectedModeToolStripMenuItem.Click += new System.EventHandler(this.connectedModeToolStripMenuItem_Click);
            // 
            // visitFunctionToolStripMenuItem
            // 
            this.visitFunctionToolStripMenuItem.Name = "visitFunctionToolStripMenuItem";
            this.visitFunctionToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.visitFunctionToolStripMenuItem.Text = "visit function";
            this.visitFunctionToolStripMenuItem.Click += new System.EventHandler(this.visitFunctionToolStripMenuItem_Click);
            // 
            // visitSelectionToolStripMenuItem
            // 
            this.visitSelectionToolStripMenuItem.Name = "visitSelectionToolStripMenuItem";
            this.visitSelectionToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.visitSelectionToolStripMenuItem.Text = "visit selection";
            this.visitSelectionToolStripMenuItem.Click += new System.EventHandler(this.visitSelectionToolStripMenuItem_Click);
            // 
            // visitorFunctionToolStripMenuItem
            // 
            this.visitorFunctionToolStripMenuItem.Name = "visitorFunctionToolStripMenuItem";
            this.visitorFunctionToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.visitorFunctionToolStripMenuItem.Text = "visitor function";
            this.visitorFunctionToolStripMenuItem.Click += new System.EventHandler(this.visitorFunctionToolStripMenuItem_Click);
            // 
            // visitorSelectionToolStripMenuItem
            // 
            this.visitorSelectionToolStripMenuItem.Name = "visitorSelectionToolStripMenuItem";
            this.visitorSelectionToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.visitorSelectionToolStripMenuItem.Text = "visitor selection";
            this.visitorSelectionToolStripMenuItem.Click += new System.EventHandler(this.visitorSelectionToolStripMenuItem_Click);
            // 
            // disconnectedModeToolStripMenuItem
            // 
            this.disconnectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caseToolStripMenuItem1,
            this.prisonerToolStripMenuItem,
            this.prisonernameSearchToolStripMenuItem});
            this.disconnectedModeToolStripMenuItem.Name = "disconnectedModeToolStripMenuItem";
            this.disconnectedModeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.disconnectedModeToolStripMenuItem.Text = "Disconnected Mode";
            this.disconnectedModeToolStripMenuItem.Click += new System.EventHandler(this.disconnectedModeToolStripMenuItem_Click);
            // 
            // caseToolStripMenuItem1
            // 
            this.caseToolStripMenuItem1.Name = "caseToolStripMenuItem1";
            this.caseToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.caseToolStripMenuItem1.Text = "Case";
            this.caseToolStripMenuItem1.Click += new System.EventHandler(this.caseToolStripMenuItem1_Click);
            // 
            // prisonerToolStripMenuItem
            // 
            this.prisonerToolStripMenuItem.Name = "prisonerToolStripMenuItem";
            this.prisonerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.prisonerToolStripMenuItem.Text = "prisoner";
            this.prisonerToolStripMenuItem.Click += new System.EventHandler(this.prisonerToolStripMenuItem_Click);
            // 
            // prisonernameSearchToolStripMenuItem
            // 
            this.prisonernameSearchToolStripMenuItem.Name = "prisonernameSearchToolStripMenuItem";
            this.prisonernameSearchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.prisonernameSearchToolStripMenuItem.Text = "Prisoner Search";
            this.prisonernameSearchToolStripMenuItem.Click += new System.EventHandler(this.prisonernameSearchToolStripMenuItem_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.Load += new System.EventHandler(this.NavigationForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem crystalReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prisonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisonernameSearchToolStripMenuItem;
    }
}