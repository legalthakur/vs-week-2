namespace loginproject
{
    partial class Form2
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
            this.tradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyValuationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tradingToolStripMenuItem,
            this.blotterToolStripMenuItem,
            this.allocationToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.dailyValuationToolStripMenuItem,
            this.portfolioManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tradingToolStripMenuItem
            // 
            this.tradingToolStripMenuItem.Name = "tradingToolStripMenuItem";
            this.tradingToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tradingToolStripMenuItem.Text = "Trading Ticket";
            this.tradingToolStripMenuItem.Click += new System.EventHandler(this.tradingToolStripMenuItem_Click);
            // 
            // blotterToolStripMenuItem
            // 
            this.blotterToolStripMenuItem.Name = "blotterToolStripMenuItem";
            this.blotterToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.blotterToolStripMenuItem.Text = "Blotter";
            this.blotterToolStripMenuItem.Click += new System.EventHandler(this.blotterToolStripMenuItem_Click);
            // 
            // allocationToolStripMenuItem
            // 
            this.allocationToolStripMenuItem.Name = "allocationToolStripMenuItem";
            this.allocationToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.allocationToolStripMenuItem.Text = "Allocation";
            this.allocationToolStripMenuItem.Click += new System.EventHandler(this.allocationToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.closingToolStripMenuItem.Text = "Closing";
            // 
            // dailyValuationToolStripMenuItem
            // 
            this.dailyValuationToolStripMenuItem.Name = "dailyValuationToolStripMenuItem";
            this.dailyValuationToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.dailyValuationToolStripMenuItem.Text = "Daily Valuation";
            // 
            // portfolioManagementToolStripMenuItem
            // 
            this.portfolioManagementToolStripMenuItem.Name = "portfolioManagementToolStripMenuItem";
            this.portfolioManagementToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.portfolioManagementToolStripMenuItem.Text = "Portfolio Management";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(739, 24);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blotterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyValuationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioManagementToolStripMenuItem;
    }
}