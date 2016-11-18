namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.lblUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Menu_Employee_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.memuDataMain = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Home = new System.Windows.Forms.MenuStrip();
            this.Toolstrip_Create_User = new System.Windows.Forms.ToolStrip();
            this.ViewAsset_Menu = new System.Windows.Forms.ToolStripButton();
            this.CreateAsset = new System.Windows.Forms.ToolStripButton();
            this.Seet_Movement_Menu = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.Menu_Home.SuspendLayout();
            this.Toolstrip_Create_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 571);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "Login :";
            // 
            // Menu_Employee_Management2
            // 
            this.Menu_Employee_Management2.Name = "Menu_Employee_Management2";
            this.Menu_Employee_Management2.Size = new System.Drawing.Size(232, 22);
            this.Menu_Employee_Management2.Text = "Employee Management";
            this.Menu_Employee_Management2.Click += new System.EventHandler(this.Menu_Employee_Management2_Click);
            // 
            // Menu_Employee1
            // 
            this.Menu_Employee1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Employee_Management2});
            this.Menu_Employee1.Name = "Menu_Employee1";
            this.Menu_Employee1.Size = new System.Drawing.Size(142, 22);
            this.Menu_Employee1.Text = "Employee";
            // 
            // Menu_Administration
            // 
            this.Menu_Administration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Employee1});
            this.Menu_Administration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_Administration.Name = "Menu_Administration";
            this.Menu_Administration.Size = new System.Drawing.Size(113, 24);
            this.Menu_Administration.Text = "Administration";
            // 
            // memuDataMain
            // 
            this.memuDataMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memuDataMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memuDataMain.Name = "memuDataMain";
            this.memuDataMain.Size = new System.Drawing.Size(115, 24);
            this.memuDataMain.Text = "Fundamental";
            // 
            // Menu_Home
            // 
            this.Menu_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Menu_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memuDataMain,
            this.Menu_Administration});
            this.Menu_Home.Location = new System.Drawing.Point(0, 0);
            this.Menu_Home.Name = "Menu_Home";
            this.Menu_Home.Size = new System.Drawing.Size(1074, 28);
            this.Menu_Home.TabIndex = 18;
            this.Menu_Home.Text = "menuStrip1";
            // 
            // Toolstrip_Create_User
            // 
            this.Toolstrip_Create_User.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Toolstrip_Create_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewAsset_Menu,
            this.CreateAsset,
            this.Seet_Movement_Menu});
            this.Toolstrip_Create_User.Location = new System.Drawing.Point(0, 28);
            this.Toolstrip_Create_User.Name = "Toolstrip_Create_User";
            this.Toolstrip_Create_User.Size = new System.Drawing.Size(1074, 39);
            this.Toolstrip_Create_User.TabIndex = 21;
            this.Toolstrip_Create_User.Text = "toolStrip2";
            // 
            // ViewAsset_Menu
            // 
            this.ViewAsset_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAsset_Menu.Image = global::WindowsFormsApplication1.Properties.Resources.Open_Folder_Full_icon;
            this.ViewAsset_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewAsset_Menu.Name = "ViewAsset_Menu";
            this.ViewAsset_Menu.Size = new System.Drawing.Size(116, 36);
            this.ViewAsset_Menu.Text = "View Asset";
            // 
            // CreateAsset
            // 
            this.CreateAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAsset.Image = global::WindowsFormsApplication1.Properties.Resources.Open_Folder_Add_icon;
            this.CreateAsset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateAsset.Name = "CreateAsset";
            this.CreateAsset.Size = new System.Drawing.Size(129, 36);
            this.CreateAsset.Text = "Create Asset";
            this.CreateAsset.Click += new System.EventHandler(this.CreateAsset_Click);
            // 
            // Seet_Movement_Menu
            // 
            this.Seet_Movement_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seet_Movement_Menu.Image = global::WindowsFormsApplication1.Properties.Resources.order_icon;
            this.Seet_Movement_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Seet_Movement_Menu.Name = "Seet_Movement_Menu";
            this.Seet_Movement_Menu.Size = new System.Drawing.Size(155, 36);
            this.Seet_Movement_Menu.Text = "Asset Movement";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 596);
            this.Controls.Add(this.Toolstrip_Create_User);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Menu_Home);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Menu_Home.ResumeLayout(false);
            this.Menu_Home.PerformLayout();
            this.Toolstrip_Create_User.ResumeLayout(false);
            this.Toolstrip_Create_User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel lblUser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee_Management2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Administration;
        private System.Windows.Forms.ToolStripMenuItem memuDataMain;
        private System.Windows.Forms.MenuStrip Menu_Home;
        private System.Windows.Forms.ToolStrip Toolstrip_Create_User;
        private System.Windows.Forms.ToolStripButton ViewAsset_Menu;
        private System.Windows.Forms.ToolStripButton Seet_Movement_Menu;
        private System.Windows.Forms.ToolStripButton CreateAsset;
    }
}