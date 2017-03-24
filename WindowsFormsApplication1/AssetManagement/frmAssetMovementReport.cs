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
    public partial class frmAssetMovementReport : Form
    {
        public frmAssetMovementReport()
        {
            InitializeComponent();
        }
        

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string userId;
        string strAsset_Sys;

        internal string Asset_Sys
        {
            set { strAsset_Sys = value; }
        }

        private void frmAssetMovementReport_Load(object sender, EventArgs e)
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

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("ASSET_SHOW" + strAsset_Sys.ToString(), Conn); //
            
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ds");
            Conn.Close();

            /*
            Statement.CtrInvoiceReport Ctr = new CtrInvoiceReport();
            Ctr.SetDataSource(SaleDataset.Tables[0]);
            CrvVC.ReportSource = Ctr;
            CrvVC.Refresh();
            CrvVC.Show();
             * */
        }
    }
}
