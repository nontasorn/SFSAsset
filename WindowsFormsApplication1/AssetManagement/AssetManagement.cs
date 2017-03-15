using System;
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
                //CheckResult = dt.Rows.Count;
                //HeadDetail();
            }
            else
            {
                //CheckResult = 0;
                dgv_ViewAssetMovement.DataSource = null;
            }
            //Count.Text = CheckResult.ToString() + "  รายการ";
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
                frm.MovementID = AssetId.ToString();
                frm.ShowDialog();
            }

        }
    }
}
