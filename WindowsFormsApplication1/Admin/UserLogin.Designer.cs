namespace WindowsFormsApplication1.Admin
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.Toolstrip_Create_User = new System.Windows.Forms.ToolStrip();
            this.txt_Create_Reenter_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Create_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Create_Employee_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Create_User_Btn = new System.Windows.Forms.ToolStripButton();
            this.Clear_User_Btn = new System.Windows.Forms.ToolStripButton();
            this.Toolstrip_Create_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolstrip_Create_User
            // 
            this.Toolstrip_Create_User.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Toolstrip_Create_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_User_Btn,
            this.Clear_User_Btn});
            this.Toolstrip_Create_User.Location = new System.Drawing.Point(0, 0);
            this.Toolstrip_Create_User.Name = "Toolstrip_Create_User";
            this.Toolstrip_Create_User.Size = new System.Drawing.Size(984, 39);
            this.Toolstrip_Create_User.TabIndex = 7;
            this.Toolstrip_Create_User.Text = "toolStrip2";
            // 
            // txt_Create_Reenter_Password
            // 
            this.txt_Create_Reenter_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Create_Reenter_Password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Create_Reenter_Password.Location = new System.Drawing.Point(353, 189);
            this.txt_Create_Reenter_Password.Name = "txt_Create_Reenter_Password";
            this.txt_Create_Reenter_Password.PasswordChar = '*';
            this.txt_Create_Reenter_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Create_Reenter_Password.Size = new System.Drawing.Size(195, 26);
            this.txt_Create_Reenter_Password.TabIndex = 139;
            this.txt_Create_Reenter_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 142;
            this.label2.Text = "Reenter Password :";
            // 
            // txt_Create_Password
            // 
            this.txt_Create_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Create_Password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Create_Password.Location = new System.Drawing.Point(353, 143);
            this.txt_Create_Password.Name = "txt_Create_Password";
            this.txt_Create_Password.PasswordChar = '*';
            this.txt_Create_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Create_Password.Size = new System.Drawing.Size(195, 26);
            this.txt_Create_Password.TabIndex = 138;
            this.txt_Create_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Password :";
            // 
            // txt_Create_Employee_ID
            // 
            this.txt_Create_Employee_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Create_Employee_ID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Create_Employee_ID.Location = new System.Drawing.Point(353, 92);
            this.txt_Create_Employee_ID.Name = "txt_Create_Employee_ID";
            this.txt_Create_Employee_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Create_Employee_ID.Size = new System.Drawing.Size(195, 26);
            this.txt_Create_Employee_ID.TabIndex = 134;
            this.txt_Create_Employee_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 140;
            this.label7.Text = "Employee ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 129);
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // Create_User_Btn
            // 
            this.Create_User_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_User_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Create_User_Btn.Image")));
            this.Create_User_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_User_Btn.Name = "Create_User_Btn";
            this.Create_User_Btn.Size = new System.Drawing.Size(124, 36);
            this.Create_User_Btn.Text = "Create User";
            this.Create_User_Btn.Click += new System.EventHandler(this.Create_User_Btn_Click);
            // 
            // Clear_User_Btn
            // 
            this.Clear_User_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_User_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Clear_User_Btn.Image")));
            this.Clear_User_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear_User_Btn.Name = "Clear_User_Btn";
            this.Clear_User_Btn.Size = new System.Drawing.Size(114, 36);
            this.Clear_User_Btn.Text = "Clear Data";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Create_Reenter_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Create_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Create_Employee_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Toolstrip_Create_User);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.Toolstrip_Create_User.ResumeLayout(false);
            this.Toolstrip_Create_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Toolstrip_Create_User;
        private System.Windows.Forms.ToolStripButton Create_User_Btn;
        private System.Windows.Forms.ToolStripButton Clear_User_Btn;
        private System.Windows.Forms.TextBox txt_Create_Reenter_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Create_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Create_Employee_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}