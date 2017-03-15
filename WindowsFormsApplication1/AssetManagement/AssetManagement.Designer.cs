namespace WindowsFormsApplication1.AssetManagement
{
    partial class AssetManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Toolstrip_Create_User = new System.Windows.Forms.ToolStrip();
            this.EditAsset_Btn = new System.Windows.Forms.ToolStripButton();
            this.AssetMovement_Btn = new System.Windows.Forms.ToolStripButton();
            this.dgv_ViewAsset = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_ViewAssetMovement = new System.Windows.Forms.DataGridView();
            this.lbl_Asset_Count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Toolstrip_Create_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAsset)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAssetMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolstrip_Create_User
            // 
            this.Toolstrip_Create_User.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Toolstrip_Create_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAsset_Btn,
            this.toolStripButton1,
            this.AssetMovement_Btn});
            this.Toolstrip_Create_User.Location = new System.Drawing.Point(0, 0);
            this.Toolstrip_Create_User.Name = "Toolstrip_Create_User";
            this.Toolstrip_Create_User.Size = new System.Drawing.Size(984, 39);
            this.Toolstrip_Create_User.TabIndex = 23;
            this.Toolstrip_Create_User.Text = "toolStrip2";
            // 
            // EditAsset_Btn
            // 
            this.EditAsset_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAsset_Btn.Image = global::WindowsFormsApplication1.Properties.Resources.edit_file_icon;
            this.EditAsset_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditAsset_Btn.Name = "EditAsset_Btn";
            this.EditAsset_Btn.Size = new System.Drawing.Size(110, 36);
            this.EditAsset_Btn.Text = "Edit Asset";
            // 
            // AssetMovement_Btn
            // 
            this.AssetMovement_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetMovement_Btn.Image = global::WindowsFormsApplication1.Properties.Resources.Open_Folder_Add_icon;
            this.AssetMovement_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AssetMovement_Btn.Name = "AssetMovement_Btn";
            this.AssetMovement_Btn.Size = new System.Drawing.Size(155, 36);
            this.AssetMovement_Btn.Text = "Asset Movement";
            this.AssetMovement_Btn.Click += new System.EventHandler(this.AssetMovement_Btn_Click);
            // 
            // dgv_ViewAsset
            // 
            this.dgv_ViewAsset.AllowUserToAddRows = false;
            this.dgv_ViewAsset.AllowUserToDeleteRows = false;
            this.dgv_ViewAsset.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewAsset.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewAsset.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewAsset.MultiSelect = false;
            this.dgv_ViewAsset.Name = "dgv_ViewAsset";
            this.dgv_ViewAsset.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewAsset.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ViewAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewAsset.Size = new System.Drawing.Size(978, 306);
            this.dgv_ViewAsset.TabIndex = 24;
            this.dgv_ViewAsset.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewAsset_CellMouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewAsset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewAssetMovement, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Asset_Count, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.24138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.758621F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 523);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // dgv_ViewAssetMovement
            // 
            this.dgv_ViewAssetMovement.AllowUserToAddRows = false;
            this.dgv_ViewAssetMovement.AllowUserToDeleteRows = false;
            this.dgv_ViewAssetMovement.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewAssetMovement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewAssetMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewAssetMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewAssetMovement.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewAssetMovement.Location = new System.Drawing.Point(3, 341);
            this.dgv_ViewAssetMovement.MultiSelect = false;
            this.dgv_ViewAssetMovement.Name = "dgv_ViewAssetMovement";
            this.dgv_ViewAssetMovement.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewAssetMovement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ViewAssetMovement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewAssetMovement.Size = new System.Drawing.Size(978, 158);
            this.dgv_ViewAssetMovement.TabIndex = 25;
            // 
            // lbl_Asset_Count
            // 
            this.lbl_Asset_Count.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Asset_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Asset_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Asset_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Asset_Count.Location = new System.Drawing.Point(3, 312);
            this.lbl_Asset_Count.Name = "lbl_Asset_Count";
            this.lbl_Asset_Count.Size = new System.Drawing.Size(139, 19);
            this.lbl_Asset_Count.TabIndex = 133;
            this.lbl_Asset_Count.Text = "Asset : ";
            this.lbl_Asset_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 134;
            this.label1.Text = "Asset Movement : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(96, 36);
            this.toolStripButton1.Text = "Refresh";
            // 
            // AssetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Toolstrip_Create_User);
            this.Name = "AssetManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssetManagement";
            this.Load += new System.EventHandler(this.AssetManagement_Load);
            this.Toolstrip_Create_User.ResumeLayout(false);
            this.Toolstrip_Create_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAsset)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAssetMovement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Toolstrip_Create_User;
        private System.Windows.Forms.ToolStripButton EditAsset_Btn;
        private System.Windows.Forms.ToolStripButton AssetMovement_Btn;
        private System.Windows.Forms.DataGridView dgv_ViewAsset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_ViewAssetMovement;
        internal System.Windows.Forms.Label lbl_Asset_Count;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}