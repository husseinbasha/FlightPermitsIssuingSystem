namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Users_AdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_New_UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LandingPermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landingTakeOffPermitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overFlyPermitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Users_AdministrationToolStripMenuItem
            // 
            this.Users_AdministrationToolStripMenuItem.Name = "Users_AdministrationToolStripMenuItem";
            this.Users_AdministrationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.Users_AdministrationToolStripMenuItem.Text = "Users_Administration";
            this.Users_AdministrationToolStripMenuItem.Click += new System.EventHandler(this.إدارةالمستخدمينToolStripMenuItem_Click);
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_New_UserToolStripMenuItem,
            this.Users_AdministrationToolStripMenuItem});
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.UsersToolStripMenuItem.Text = "Users";
            // 
            // Add_New_UserToolStripMenuItem
            // 
            this.Add_New_UserToolStripMenuItem.Name = "Add_New_UserToolStripMenuItem";
            this.Add_New_UserToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.Add_New_UserToolStripMenuItem.Text = "Add_New_User";
            this.Add_New_UserToolStripMenuItem.Click += new System.EventHandler(this.إضافةمستخدمجديدToolStripMenuItem_Click);
            // 
            // PermissionsToolStripMenuItem
            // 
            this.PermissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LandingPermissionToolStripMenuItem,
            this.landingTakeOffPermitsToolStripMenuItem,
            this.overFlyPermitsToolStripMenuItem});
            this.PermissionsToolStripMenuItem.Name = "PermissionsToolStripMenuItem";
            this.PermissionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.PermissionsToolStripMenuItem.Text = " Permissions";
            // 
            // LandingPermissionToolStripMenuItem
            // 
            this.LandingPermissionToolStripMenuItem.Name = "LandingPermissionToolStripMenuItem";
            this.LandingPermissionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.LandingPermissionToolStripMenuItem.Text = "LandingPermits";
            this.LandingPermissionToolStripMenuItem.Click += new System.EventHandler(this.getPermissionToolStripMenuItem_Click);
            // 
            // landingTakeOffPermitsToolStripMenuItem
            // 
            this.landingTakeOffPermitsToolStripMenuItem.Name = "landingTakeOffPermitsToolStripMenuItem";
            this.landingTakeOffPermitsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.landingTakeOffPermitsToolStripMenuItem.Text = "LandingTakeOffPermits";
            this.landingTakeOffPermitsToolStripMenuItem.Click += new System.EventHandler(this.landingTakeOffPermitsToolStripMenuItem_Click);
            // 
            // overFlyPermitsToolStripMenuItem
            // 
            this.overFlyPermitsToolStripMenuItem.Name = "overFlyPermitsToolStripMenuItem";
            this.overFlyPermitsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.overFlyPermitsToolStripMenuItem.Text = "OverFlyPermits";
            this.overFlyPermitsToolStripMenuItem.Click += new System.EventHandler(this.overFlyPermitsToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LogOutToolStripMenuItem.Text = "LogOut";
            // 
            // RestoreToolStripMenuItem
            // 
            this.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem";
            this.RestoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RestoreToolStripMenuItem.Text = "Restore";
            // 
            // BackUsToolStripMenuItem
            // 
            this.BackUsToolStripMenuItem.Name = "BackUsToolStripMenuItem";
            this.BackUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BackUsToolStripMenuItem.Text = "BackUp";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoginToolStripMenuItem.Text = "Login";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالدخولToolStripMenuItem_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.BackUsToolStripMenuItem,
            this.RestoreToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.PermissionsToolStripMenuItem,
            this.UsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 315);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "OverflyingPermision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem Users_AdministrationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_New_UserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem PermissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LandingPermissionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem RestoreToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem BackUsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem landingTakeOffPermitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overFlyPermitsToolStripMenuItem;
    }
}

