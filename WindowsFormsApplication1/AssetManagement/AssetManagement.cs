﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Class;
using System.Data.SqlClient;


namespace WindowsFormsApplication1.AssetManagement
{
    public partial class AssetManagement : Form
    {
        public AssetManagement()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string userId;
        string AssetId;
        int CheckResult;

        private void AssetManagement_Load(object sender, EventArgs e)
        {
            string strConn;
            strConn = DBConnString.strConn;
            Conn = new SqlConnection();
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = strConn;
            Conn.Open();
            userId = DBConnString.sUserIdLogin;
            ShowAsset();
        }

        private void ShowAsset()
        {
            dgv_ViewAsset.Columns.Clear();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("ASSET_MANAGEMENT", Conn); //
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ds");


            DataGridViewCheckBoxColumn chkColSelect = new DataGridViewCheckBoxColumn();

            dgv_ViewAsset.DataSource = ds.Tables["ds"];
            HeadData();
            dgv_ViewAsset.ClearSelection();
            lbl_Asset_Count.Text = "Asset " + dgv_ViewAsset.Rows.Count.ToString() + " รายการ ";
            
        }

        private void HeadData()
        {
            if (dgv_ViewAsset.RowCount > 0)
            {

                dgv_ViewAsset.Columns[0].HeaderText = "#";
                dgv_ViewAsset.Columns[1].HeaderText = "Asset No";
                dgv_ViewAsset.Columns[2].HeaderText = "Fixed Asset No";
                dgv_ViewAsset.Columns[3].HeaderText = "Asset Details";
                dgv_ViewAsset.Columns[4].HeaderText = "Type";
                dgv_ViewAsset.Columns[5].HeaderText = "Brand";
                dgv_ViewAsset.Columns[6].HeaderText = "Purchase Date";
                dgv_ViewAsset.Columns[7].HeaderText = "Status";
                dgv_ViewAsset.Columns[8].HeaderText = "Expire Date";
                dgv_ViewAsset.Columns[9].HeaderText = "Created By";
                dgv_ViewAsset.Columns[10].HeaderText = "Created Date";
                dgv_ViewAsset.Columns[11].HeaderText = "Modified By";
                dgv_ViewAsset.Columns[12].HeaderText = "Modified Date";
                dgv_ViewAsset.Columns[13].HeaderText = "Amend";


                FixColumnWidthdgvHead();

                dgv_ViewAsset.Columns[6].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewAsset.Columns[8].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewAsset.Columns[10].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewAsset.Columns[12].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");

            }
        }
        private void FixColumnWidthdgvHead()
        {
            int w = dgv_ViewAsset.Width;
            dgv_ViewAsset.Columns[0].Width = 50;
            dgv_ViewAsset.Columns[1].Width = 100;
            dgv_ViewAsset.Columns[2].Width = 100;
            dgv_ViewAsset.Columns[3].Width = 250;
            dgv_ViewAsset.Columns[4].Width = 100;
            dgv_ViewAsset.Columns[5].Width = 100;
            dgv_ViewAsset.Columns[6].Width = 100;
            dgv_ViewAsset.Columns[7].Width = 100;
            dgv_ViewAsset.Columns[8].Width = 100;
            dgv_ViewAsset.Columns[9].Width = 100;
            dgv_ViewAsset.Columns[10].Width = 100;
            dgv_ViewAsset.Columns[11].Width = 100;
            dgv_ViewAsset.Columns[12].Width = 100;
            dgv_ViewAsset.Columns[13].Width = 50;
        }

        private void dgv_ViewAsset_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            AssetId = dgv_ViewAsset.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            DataDetail();
        }
        private void DataDetail()
        {
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("AASSET_MOVEMENT_DETAILS " + AssetId);
            if (dt.Rows.Count > 0)
            {
                dgv_ViewAssetMovement.DataSource = dt;
                CheckResult = dt.Rows.Count;
                DetailData();
                
            }
            else
            {
                CheckResult = 0;
                dgv_ViewAssetMovement.DataSource = null;
                
            }
            lbl_Asset_Count.Text = CheckResult.ToString() + "  รายการ";
        }

        private void AssetMovement_Btn_Click(object sender, EventArgs e)
        {
            if (AssetId == null)
            {
                MessageBox.Show("กรุณาเลือกรายการก่อนค่ะ");
            }
            else
            {
                AssetMovement frm = new AssetMovement();
                
                //AdditionalCredit.frmCreateAddCredit frm = new AdditionalCredit.frmCreateAddCredit();
                Close();
                frm.MovementID = AssetId.ToString();
                frm.ShowDialog();
                
            }

        }
        private void DetailData()
        {
            if (dgv_ViewAsset.RowCount > 0)
            {

                dgv_ViewAssetMovement.Columns[0].HeaderText = "Asset Movement Id";
                dgv_ViewAssetMovement.Columns[1].HeaderText = "Asset No";
                dgv_ViewAssetMovement.Columns[2].HeaderText = "Fixed Asset No";
                dgv_ViewAssetMovement.Columns[3].HeaderText = "From Owner";
                dgv_ViewAssetMovement.Columns[4].HeaderText = "To Owner";
                dgv_ViewAssetMovement.Columns[5].HeaderText = "From Base";
                dgv_ViewAssetMovement.Columns[6].HeaderText = "To Base";
                dgv_ViewAssetMovement.Columns[7].HeaderText = "From Location";
                dgv_ViewAssetMovement.Columns[8].HeaderText = "To Location";
                dgv_ViewAssetMovement.Columns[9].HeaderText = "From Status";
                dgv_ViewAssetMovement.Columns[10].HeaderText = "To Status";
                dgv_ViewAssetMovement.Columns[11].HeaderText = "Remarks";
                dgv_ViewAssetMovement.Columns[12].HeaderText = "Movement By";
                dgv_ViewAssetMovement.Columns[13].HeaderText = "Movement Date";


                FixColumnWidthdgvDetail();

                dgv_ViewAssetMovement.Columns[13].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                

            }
        }
        private void FixColumnWidthdgvDetail()
        {
            int w = dgv_ViewAssetMovement.Width;
            dgv_ViewAssetMovement.Columns[0].Width = 100;
            dgv_ViewAssetMovement.Columns[1].Width = 100;
            dgv_ViewAssetMovement.Columns[2].Width = 100;
            dgv_ViewAssetMovement.Columns[3].Width = 100;
            dgv_ViewAssetMovement.Columns[4].Width = 100;
            dgv_ViewAssetMovement.Columns[5].Width = 100;
            dgv_ViewAssetMovement.Columns[6].Width = 100;
            dgv_ViewAssetMovement.Columns[7].Width = 100;
            dgv_ViewAssetMovement.Columns[8].Width = 100;
            dgv_ViewAssetMovement.Columns[9].Width = 100;
            dgv_ViewAssetMovement.Columns[10].Width = 100;
            dgv_ViewAssetMovement.Columns[11].Width = 250;
            dgv_ViewAssetMovement.Columns[12].Width = 100;
            dgv_ViewAssetMovement.Columns[13].Width = 100;
        }
    }
}
