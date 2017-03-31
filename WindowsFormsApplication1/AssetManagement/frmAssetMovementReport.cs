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
using CrystalDecisions.CrystalReports.Engine;
using System.Collections;



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
        string strAssetMovementId;

        internal string Asset_Sys
        {
            set { strAssetMovementId = value; }
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

            Data();

            /*
            Statement.CtrInvoiceReport Ctr = new CtrInvoiceReport();
            Ctr.SetDataSource(SaleDataset.Tables[0]);
            CrvVC.ReportSource = Ctr;
            CrvVC.Refresh();
            CrvVC.Show();
             * */
        }

        private void Data()
        {
            //DataTable dt = Class.DBConnString.clsDB.QueryDataTable("AranalysisReport " + txtidCustomer.Text.Trim() + ',' + "'" + dtStartDate.Value.ToString() + "'" + ',' + "'" + dtEndDate.Value.ToString() + "'");

            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("AASSET_MOVEMENT_REPORT " + strAssetMovementId.ToString());
            CryAssetMovement Ctr = new CryAssetMovement();
            Ctr.SetDataSource(dt);
            CrvAssetMovement.ReportSource = Ctr;
            CrvAssetMovement.Refresh();
            CrvAssetMovement.Show();
        }
    }
}
