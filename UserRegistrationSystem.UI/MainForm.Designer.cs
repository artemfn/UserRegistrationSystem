namespace UserRegistrationSystem.UI
{
    partial class MainForm
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
            this.EntitiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntitiesMenu,
            this.ProfileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EntitiesMenu
            // 
            this.EntitiesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersMenuItem,
            this.AdminsMenuItem});
            this.EntitiesMenu.Name = "EntitiesMenu";
            this.EntitiesMenu.Size = new System.Drawing.Size(113, 19);
            this.EntitiesMenu.Text = "Entities";
            // 
            // UsersMenuItem
            // 
            this.UsersMenuItem.Name = "UsersMenuItem";
            this.UsersMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UsersMenuItem.Text = "Users";
            this.UsersMenuItem.Click += new System.EventHandler(this.UsersMenuItem_Click);
            // 
            // AdminsMenuItem
            // 
            this.AdminsMenuItem.Name = "AdminsMenuItem";
            this.AdminsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AdminsMenuItem.Text = "Admins";
            this.AdminsMenuItem.Click += new System.EventHandler(this.AdminsMenuItem_Click);
            // 
            // ProfileMenu
            // 
            this.ProfileMenu.Name = "ProfileMenu";
            this.ProfileMenu.Size = new System.Drawing.Size(113, 19);
            this.ProfileMenu.Text = "My profile";
            this.ProfileMenu.Click += new System.EventHandler(this.ProfileMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EntitiesMenu;
        private System.Windows.Forms.ToolStripMenuItem UsersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfileMenu;
    }
}