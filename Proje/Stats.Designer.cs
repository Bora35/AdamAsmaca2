namespace Proje
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.StatsMenu = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // StatsMenu
            // 
            this.StatsMenu.BackColor = System.Drawing.Color.Green;
            this.StatsMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StatsMenu.LineColor = System.Drawing.Color.White;
            this.StatsMenu.Location = new System.Drawing.Point(12, 12);
            this.StatsMenu.Name = "StatsMenu";
            this.StatsMenu.Size = new System.Drawing.Size(346, 636);
            this.StatsMenu.TabIndex = 0;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1575, 660);
            this.Controls.Add(this.StatsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.Text = "Adam Asmaca - İstatistikler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView StatsMenu;
    }
}