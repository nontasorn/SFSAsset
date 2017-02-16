namespace WindowsFormsApplication1.AssetManagement
{
    partial class ViewAssetDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_ViewAsset = new System.Windows.Forms.DataGridView();
            this.Toolstrip_Create_User = new System.Windows.Forms.ToolStrip();
            this.Seet_Movement_Menu = new System.Windows.Forms.ToolStripButton();
            this.lbl_Count_Movement = new System.Windows.Forms.Label();
            this.lbl_Course_Count_Asset = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAsset)).BeginInit();
            this.Toolstrip_Create_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewAsset, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 470);
            this.tableLayoutPanel1.TabIndex = 136;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 238);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(978, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgv_ViewAsset
            // 
            this.dgv_ViewAsset.AllowUserToAddRows = false;
            this.dgv_ViewAsset.AllowUserToDeleteRows = false;
            this.dgv_ViewAsset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ViewAsset.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewAsset.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewAsset.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewAsset.MultiSelect = false;
            this.dgv_ViewAsset.Name = "dgv_ViewAsset";
            this.dgv_ViewAsset.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewAsset.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ViewAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewAsset.Size = new System.Drawing.Size(978, 229);
            this.dgv_ViewAsset.TabIndex = 1;
            // 
            // Toolstrip_Create_User
            // 
            this.Toolstrip_Create_User.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Toolstrip_Create_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Seet_Movement_Menu});
            this.Toolstrip_Create_User.Location = new System.Drawing.Point(0, 0);
            this.Toolstrip_Create_User.Name = "Toolstrip_Create_User";
            this.Toolstrip_Create_User.Size = new System.Drawing.Size(984, 39);
            this.Toolstrip_Create_User.TabIndex = 139;
            this.Toolstrip_Create_User.Text = "toolStrip2";
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
            // lbl_Count_Movement
            // 
            this.lbl_Count_Movement.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Count_Movement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Count_Movement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Count_Movement.ForeColor = System.Drawing.Color.White;
            this.lbl_Count_Movement.Location = new System.Drawing.Point(3, 540);
            this.lbl_Count_Movement.Name = "lbl_Count_Movement";
            this.lbl_Count_Movement.Size = new System.Drawing.Size(211, 19);
            this.lbl_Count_Movement.TabIndex = 138;
            this.lbl_Count_Movement.Text = "Movement Count : ";
            this.lbl_Count_Movement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Course_Count_Asset
            // 
            this.lbl_Course_Count_Asset.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Course_Count_Asset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Course_Count_Asset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Course_Count_Asset.ForeColor = System.Drawing.Color.White;
            this.lbl_Course_Count_Asset.Location = new System.Drawing.Point(3, 45);
            this.lbl_Course_Count_Asset.Name = "lbl_Course_Count_Asset";
            this.lbl_Course_Count_Asset.Size = new System.Drawing.Size(211, 19);
            this.lbl_Course_Count_Asset.TabIndex = 137;
            this.lbl_Course_Count_Asset.Text = "Asset Count : ";
            this.lbl_Course_Count_Asset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewAssetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Toolstrip_Create_User);
            this.Controls.Add(this.lbl_Count_Movement);
            this.Controls.Add(this.lbl_Course_Count_Asset);
            this.Name = "ViewAssetDetails";
            this.Text = "ViewAssetDetails";
            this.Load += new System.EventHandler(this.ViewAssetDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAsset)).EndInit();
            this.Toolstrip_Create_User.ResumeLayout(false);
            this.Toolstrip_Create_User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgv_ViewAsset;
        private System.Windows.Forms.ToolStrip Toolstrip_Create_User;
        private System.Windows.Forms.ToolStripButton Seet_Movement_Menu;
        internal System.Windows.Forms.Label lbl_Count_Movement;
        internal System.Windows.Forms.Label lbl_Course_Count_Asset;

    }
}