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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Toolstrip_Create_User = new System.Windows.Forms.ToolStrip();
            this.dgv_ViewAsset = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgv_ViewAssetMovement = new System.Windows.Forms.DataGridView();
            this.lbl_Asset_Count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AssetMovementReportBtn = new System.Windows.Forms.ToolStripButton();
            this.EditAsset_Btn = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.AssetMovement_Btn = new System.Windows.Forms.ToolStripButton();
            this.SearchBtn = new System.Windows.Forms.ToolStripButton();
            this.Toolstrip_Create_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAsset)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAssetMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolstrip_Create_User
            // 
            this.Toolstrip_Create_User.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Toolstrip_Create_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAsset_Btn,
            this.RefreshBtn,
            this.AssetMovement_Btn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtSearch,
            this.SearchBtn});
            this.Toolstrip_Create_User.Location = new System.Drawing.Point(0, 0);
            this.Toolstrip_Create_User.Name = "Toolstrip_Create_User";
            this.Toolstrip_Create_User.Size = new System.Drawing.Size(984, 39);
            this.Toolstrip_Create_User.TabIndex = 23;
            this.Toolstrip_Create_User.Text = "toolStrip2";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewAsset.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ViewAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewAsset.Size = new System.Drawing.Size(978, 295);
            this.dgv_ViewAsset.TabIndex = 24;
            this.dgv_ViewAsset.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewAsset_CellMouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewAsset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewAssetMovement, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Asset_Count, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.11969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 619);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AssetMovementReportBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 548);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 39);
            this.toolStrip1.TabIndex = 135;
            this.toolStrip1.Text = "toolStrip2";
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
            this.dgv_ViewAssetMovement.Location = new System.Drawing.Point(3, 333);
            this.dgv_ViewAssetMovement.MultiSelect = false;
            this.dgv_ViewAssetMovement.Name = "dgv_ViewAssetMovement";
            this.dgv_ViewAssetMovement.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewAssetMovement.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ViewAssetMovement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewAssetMovement.Size = new System.Drawing.Size(978, 192);
            this.dgv_ViewAssetMovement.TabIndex = 25;
            this.dgv_ViewAssetMovement.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewAssetMovement_CellMouseUp);
            // 
            // lbl_Asset_Count
            // 
            this.lbl_Asset_Count.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Asset_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Asset_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Asset_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Asset_Count.Location = new System.Drawing.Point(3, 301);
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
            this.label1.Location = new System.Drawing.Point(3, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 134;
            this.label1.Text = "Asset Movement : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 36);
            this.toolStripLabel1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 39);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // AssetMovementReportBtn
            // 
            this.AssetMovementReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetMovementReportBtn.Image = global::WindowsFormsApplication1.Properties.Resources.edit_file_icon;
            this.AssetMovementReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AssetMovementReportBtn.Name = "AssetMovementReportBtn";
            this.AssetMovementReportBtn.Size = new System.Drawing.Size(204, 36);
            this.AssetMovementReportBtn.Text = "Asset Movement Report";
            this.AssetMovementReportBtn.Click += new System.EventHandler(this.AssetMovementReportBtn_Click);
            // 
            // EditAsset_Btn
            // 
            this.EditAsset_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAsset_Btn.Image = global::WindowsFormsApplication1.Properties.Resources.edit_file_icon;
            this.EditAsset_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditAsset_Btn.Name = "EditAsset_Btn";
            this.EditAsset_Btn.Size = new System.Drawing.Size(110, 36);
            this.EditAsset_Btn.Text = "Edit Asset";
            this.EditAsset_Btn.Click += new System.EventHandler(this.EditAsset_Btn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Image = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(96, 36);
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
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
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = global::WindowsFormsApplication1.Properties.Resources.search2;
            this.SearchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(91, 36);
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AssetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 658);
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
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AssetMovementReportBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton SearchBtn;
    }
}