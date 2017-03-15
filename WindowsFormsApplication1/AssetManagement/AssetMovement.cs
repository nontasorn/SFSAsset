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
    public partial class AssetMovement : Form
    {
        public AssetMovement()
        {
            InitializeComponent();
        }
        string AssetId;
        SqlConnection Conn;
        SqlCommand Cmd;
        string userId;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        DataTable dt;
        SqlTransaction Tr;

        internal string MovementID // this value for edit
        {
            set { AssetId = value; }
        }

        private void CreateAsset_Btn_Click(object sender, EventArgs e)
        {

        }

        private void AssetMovement_Load(object sender, EventArgs e)
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
            ShowHeadEdit();
            cmb_Base();
            cmb_Location();
            cmb_Status();
            cmb_OWNER();
            txt_Sys_Asset.Text = AssetId;
        }
        private void cmb_Status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Status_Id,Status_Name FROM Status");

            string sqlIni = Sbd.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dtUser = new DataTable();
                dtUser.Load(Sdr);

                cboStatus.BeginUpdate();
                cboStatus.DisplayMember = "Status_Name";
                cboStatus.ValueMember = "Status_Id";
                cboStatus.DataSource = dtUser;
                cboStatus.EndUpdate();
                cboStatus.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void cmb_Base()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Base_ID,Base_Name FROM Base");

            string sqlIni = Sbd.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dtUser = new DataTable();
                dtUser.Load(Sdr);

                cboBase.BeginUpdate();
                cboBase.DisplayMember = "Base_Name";
                cboBase.ValueMember = "Base_ID";
                cboBase.DataSource = dtUser;
                cboBase.EndUpdate();
                cboBase.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cmb_Location()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Location_ID,Location_Name FROM Location");

            string sqlIni = Sbd.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dtUser = new DataTable();
                dtUser.Load(Sdr);

                cboLocation.BeginUpdate();
                cboLocation.DisplayMember = "Location_Name";
                cboLocation.ValueMember = "Location_ID";
                cboLocation.DataSource = dtUser;
                cboLocation.EndUpdate();
                cboLocation.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cmb_OWNER()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Employee_ID,(Employee_FirstName+'  '+Employee_LastName) AS OWNER FROM Employee");

            string sqlIni = Sbd.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dtUser = new DataTable();
                dtUser.Load(Sdr);

                cboOwner.BeginUpdate();
                cboOwner.DisplayMember = "OWNER";
                cboOwner.ValueMember = "Employee_ID";
                cboOwner.DataSource = dtUser;
                cboOwner.EndUpdate();
                cboOwner.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void ShowHeadEdit()
        {
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("ASSET_SHOW " + AssetId.ToString());

            txtAssetNo.Text = dt.Rows[0]["Asset_No"].ToString();
            txtFixAssetNo.Text = dt.Rows[0]["Fixed_Asset_No"].ToString();
            txtAssetDetails.Text = dt.Rows[0]["Asset_Details"].ToString();

            txtOwner.Text = dt.Rows[0]["Asset_TypeName"].ToString();
            txtBase.Text = dt.Rows[0]["Asset_Brand"].ToString();
            txtLocation.Text = dt.Rows[0]["Asset_Purchase"].ToString();
            txtStatus.Text = dt.Rows[0]["Status_Name"].ToString();
            txtRemark.Text = dt.Rows[0]["Asste_Expire_Date"].ToString();

        }
    }
}
