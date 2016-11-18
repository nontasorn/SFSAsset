using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.Class;

namespace WindowsFormsApplication1.AssetManagement
{
    public partial class CreateAsset : Form
    {
        public CreateAsset()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        string userId;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        DataTable dt;
        SqlTransaction Tr;
        int AssetId;
        private void CreateAsset_Load(object sender, EventArgs e)
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
            Max_Asset_No_System();
            cmb_AssetType();
            cmb_Base();
            cmb_Location();
            cmb_Status();
            cmb_OWNER();
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
        private void cmb_AssetType()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Asset_Type_ID,Asset_TypeName FROM Asset_Type");

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

                cboAssetType.BeginUpdate();
                cboAssetType.DisplayMember = "Asset_TypeName";
                cboAssetType.ValueMember = "Asset_Type_ID";
                cboAssetType.DataSource = dtUser;
                cboAssetType.EndUpdate();
                cboAssetType.SelectedIndex = 0;

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

        private void CreateAsset_Btn_Click(object sender, EventArgs e)
        {

            if (txtAssetNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Asset No", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAssetNo.Focus();
                return;
            }

            if (txtAssetDetails.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Asset Details", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAssetDetails.Focus();
                return;
            }
            if (txtAssetBrand.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Brand", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAssetBrand.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new asset       " + txtAssetNo.Text.Trim() + " yes/no?", "Asset Management Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Asset ");
                    Sbd.Append("(Asset_No_System,");
                    Sbd.Append("Asset_No,");
                    Sbd.Append("Fixed_Asset_No,");
                    Sbd.Append("Asset_Details,");
                    Sbd.Append("Asset_Type,");
                    Sbd.Append("Asset_Brand,");
                    Sbd.Append("Asset_Purchase,");
                    Sbd.Append("Asste_Expire_Date,");
                    Sbd.Append("Owner,");
                    Sbd.Append("Base,");
                    Sbd.Append("Location,");
                    Sbd.Append("Status,");
                    Sbd.Append("Remarks,");
                    Sbd.Append("Create_By,");
                    Sbd.Append("Create_Date,");
                    Sbd.Append("Modified_By,");
                    Sbd.Append("Modified_Date,");
                    Sbd.Append("Amend)");
                 

                    Sbd.Append("VALUES ");

                    Sbd.Append("(@Asset_No_System,");
                    Sbd.Append("@Asset_No,");
                    Sbd.Append("@Fixed_Asset_No,");
                    Sbd.Append("@Asset_Details,");
                    Sbd.Append("@Asset_Type,");
                    Sbd.Append("@Asset_Brand,");
                    Sbd.Append("@Asset_Purchase,");
                    Sbd.Append("@Asste_Expire_Date,");
                    Sbd.Append("@Owner,");
                    Sbd.Append("@Base,");
                    Sbd.Append("@Location,");
                    Sbd.Append("@Status,");
                    Sbd.Append("@Remarks,");
                    Sbd.Append("@Create_By,");
                    Sbd.Append("@Create_Date,");
                    Sbd.Append("@Modified_By,");
                    Sbd.Append("@Modified_Date,");
                    Sbd.Append("@Amend)");
                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;


                    Cmd.Parameters.Add("@Asset_No_System", SqlDbType.Int).Value = txt_Sys_Asset.Text.Trim();
                    Cmd.Parameters.Add("@Asset_No", SqlDbType.NVarChar).Value = txtAssetNo.Text.Trim();

                    Cmd.Parameters.Add("@Fixed_Asset_No", SqlDbType.NVarChar).Value = txtFixAssetNo.Text.Trim();
                    Cmd.Parameters.Add("@Asset_Details", SqlDbType.NVarChar).Value = txtAssetDetails.Text.Trim();
                    Cmd.Parameters.Add("@Asset_Type", SqlDbType.NChar).Value = cboAssetType.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Asset_Brand", SqlDbType.NVarChar).Value = txtAssetBrand.Text.Trim(); ;
                    Cmd.Parameters.Add("@Asset_Purchase", SqlDbType.DateTime).Value = dtPurchaseDate.Value.ToShortDateString();
                    Cmd.Parameters.Add("@Asste_Expire_Date", SqlDbType.DateTime).Value = dtExpireDate.Value.ToShortDateString();
                    Cmd.Parameters.Add("@Owner", SqlDbType.NChar).Value = cboOwner.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Base", SqlDbType.NChar).Value = cboBase.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Location", SqlDbType.NChar).Value = cboLocation.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Status", SqlDbType.NChar).Value = cboStatus.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text.Trim();
                    Cmd.Parameters.Add("@Create_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Assign course successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    //ClearDetails();
                    Max_Asset_No_System(); // max ID
                    //DataHead_Grade(); // show all grade details

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to assign course" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Max_Asset_No_System()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(Asset_No_System) AS Asset_No_System FROM Asset");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                AssetId = 0;
            }
            else
            {
                AssetId = Convert.ToInt32(id.ToString());
                AssetId++;
            }
            //string strMax = "";
            //strMax = String.Format("{0:0000}", Convert.ToInt16(AssetId.ToString()));
            //txtAssignID.Text = "ASS" + DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + strMax;
            txt_Sys_Asset.Text = AssetId.ToString().Trim();
            Cmd.Parameters.Clear();

        }
    }
}
