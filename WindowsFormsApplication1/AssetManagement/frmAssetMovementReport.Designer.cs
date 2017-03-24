namespace WindowsFormsApplication1.AssetManagement
{
    partial class frmAssetMovementReport
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
            this.CrvAssetMovement = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvAssetMovement
            // 
            this.CrvAssetMovement.ActiveViewIndex = -1;
            this.CrvAssetMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvAssetMovement.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvAssetMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvAssetMovement.Location = new System.Drawing.Point(0, 0);
            this.CrvAssetMovement.Name = "CrvAssetMovement";
            this.CrvAssetMovement.Size = new System.Drawing.Size(984, 562);
            this.CrvAssetMovement.TabIndex = 0;
            // 
            // frmAssetMovementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.CrvAssetMovement);
            this.Name = "frmAssetMovementReport";
            this.Text = "frmAssetMovementReport";
            this.Load += new System.EventHandler(this.frmAssetMovementReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvAssetMovement;
    }
}