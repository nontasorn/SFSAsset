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
            SqlCommand cmd = new SqlCommand("ASSET_MANAGEMENT", Conn); // Change from STATEMENT_SHOWDEBTOR_FOR_CLEAR to STATEMENT
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@CustomerId", SqlDbType.NVarChar).Value = txtidCustomer.Text.Trim();


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ds");


            DataGridViewCheckBoxColumn chkColSelect = new DataGridViewCheckBoxColumn();
            /*chkColSelect.Name = "chkSelect";
            chkColSelect.TrueValue = true;
            chkColSelect.Width = 130;
            chkColSelect.DisplayIndex = 18;
            chkColSelect.FlatStyle = FlatStyle.Popup;
            dgvStatement.Columns.Add(chkColSelect);*/

            dgv_ViewAsset.DataSource = ds.Tables["ds"];
            //SetDgvStatement();
            dgv_ViewAsset.ClearSelection();
            lbl_Asset_Count.Text = "Asset " + dgv_ViewAsset.Rows.Count.ToString() + " รายการ ";
            
        }
    }
}
