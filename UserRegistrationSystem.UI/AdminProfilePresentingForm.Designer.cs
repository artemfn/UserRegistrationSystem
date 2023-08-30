namespace UserRegistrationSystem.UI
{
    partial class AdminProfilePresentingForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProfileDataPanel = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TittlePassowrdLabel = new System.Windows.Forms.Label();
            this.TittleKeyLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TittleAdminLabel = new System.Windows.Forms.Label();
            this.ProfileDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(284, 103);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileDataPanel
            // 
            this.ProfileDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileDataPanel.Controls.Add(this.KeyLabel);
            this.ProfileDataPanel.Controls.Add(this.TittleKeyLabel);
            this.ProfileDataPanel.Controls.Add(this.PasswordLabel);
            this.ProfileDataPanel.Controls.Add(this.TittlePassowrdLabel);
            this.ProfileDataPanel.Location = new System.Drawing.Point(12, 106);
            this.ProfileDataPanel.Name = "ProfileDataPanel";
            this.ProfileDataPanel.Size = new System.Drawing.Size(260, 214);
            this.ProfileDataPanel.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(107, 13);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(16, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "...";
            // 
            // TittlePassowrdLabel
            // 
            this.TittlePassowrdLabel.AutoSize = true;
            this.TittlePassowrdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TittlePassowrdLabel.Location = new System.Drawing.Point(12, 13);
            this.TittlePassowrdLabel.Name = "TittlePassowrdLabel";
            this.TittlePassowrdLabel.Size = new System.Drawing.Size(53, 13);
            this.TittlePassowrdLabel.TabIndex = 1;
            this.TittlePassowrdLabel.Text = "Password";
            this.TittlePassowrdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TittleKeyLabel
            // 
            this.TittleKeyLabel.AutoSize = true;
            this.TittleKeyLabel.Location = new System.Drawing.Point(12, 47);
            this.TittleKeyLabel.Name = "TittleKeyLabel";
            this.TittleKeyLabel.Size = new System.Drawing.Size(85, 13);
            this.TittleKeyLabel.TabIndex = 6;
            this.TittleKeyLabel.Text = "IdentifikationKey";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(107, 47);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(16, 13);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "...";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(13, 326);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(259, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TittleAdminLabel
            // 
            this.TittleAdminLabel.AutoSize = true;
            this.TittleAdminLabel.Location = new System.Drawing.Point(12, 9);
            this.TittleAdminLabel.Name = "TittleAdminLabel";
            this.TittleAdminLabel.Size = new System.Drawing.Size(36, 13);
            this.TittleAdminLabel.TabIndex = 6;
            this.TittleAdminLabel.Text = "Admin";
            // 
            // AdminProfilePresentingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.TittleAdminLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProfileDataPanel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AdminProfilePresentingForm";
            this.Text = "AdminProfilePresentingForm";
            this.ProfileDataPanel.ResumeLayout(false);
            this.ProfileDataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel ProfileDataPanel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label TittlePassowrdLabel;
        private System.Windows.Forms.Label TittleKeyLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TittleAdminLabel;
    }
}