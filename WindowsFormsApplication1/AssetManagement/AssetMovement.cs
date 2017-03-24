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
        int AssetMovementId;

        internal string MovementID // this value for edit
        {
            set { AssetId = value; }
        }

        private void CreateAsset_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to movement asset       " + txtAssetNo.Text.Trim() + " yes/no?", "Asset Management Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE Asset ");
                    Sbd.Append("SET Owner = @To_Owner,");
                    Sbd.Append("Base = @To_Base,");
                    Sbd.Append("Location = @To_Location,");
                    Sbd.Append("Asset_Status = @To_Status, ");
                    Sbd.Append("Modified_By = @Modified_By, ");
                    Sbd.Append("Modified_Date = @Modified_Date, ");
                    Sbd.Append("Amend = @Amend ");
                    Sbd.Append("WHERE  Asset_No_System = @Asset_No_System");
                    
                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@To_Owner", SqlDbType.NChar).Value = cboOwner.SelectedValue.ToString();
                    Cmd.Parameters.Add("@To_Base", SqlDbType.NChar).Value = cboBase.SelectedValue.ToString();
                    Cmd.Parameters.Add("@To_Location", SqlDbType.NChar).Value = cboLocation.SelectedValue.ToString();
                    Cmd.Parameters.Add("@To_Status", SqlDbType.NChar).Value = cboStatus.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Asset_No_System", SqlDbType.NVarChar).Value = txt_Sys_Asset.Text.Trim();
                    Cmd.Parameters.Add("@Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = Convert.ToInt64(txtAmend.Text.Trim()) + 1;
                    
                    Cmd.ExecuteNonQuery();

                    // Insert to movement for first time created asset

                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Asset_Movement ");
                    Sbd.Append("(Asset_Movement_Id,");
                    Sbd.Append("Asset_No_System,");
                    Sbd.Append("Asset_No,");
                    Sbd.Append("Fixed_Asset_No,");
                    Sbd.Append("From_Owner,");
                    Sbd.Append("From_Base,");
                    Sbd.Append("From_Location,");
                    Sbd.Append("From_Status,");
                    Sbd.Append("Remarks,");
                    Sbd.Append("MovementDate,");
                    Sbd.Append("Movement_By,");
                    Sbd.Append("To_Owner,");
                    Sbd.Append("To_Base,");
                    Sbd.Append("To_Location,");
                    Sbd.Append("To_Status,");
                    Sbd.Append("Asste_Move_RunId) ");

                    Sbd.Append("VALUES ");

                    Sbd.Append("(@Asset_Movement_Id,");
                    Sbd.Append("@Asset_No_System,");
                    Sbd.Append("@Asset_No,");
                    Sbd.Append("@Fixed_Asset_No,");
                    Sbd.Append("@From_Owner,");
                    Sbd.Append("@From_Base,");
                    Sbd.Append("@From_Location,");
                    Sbd.Append("@From_Status,");
                    Sbd.Append("@Remarks,");
                    Sbd.Append("@MovementDate,");
                    Sbd.Append("@Movement_By,");
                    Sbd.Append("@To_Owner,");
                    Sbd.Append("@To_Base,");
                    Sbd.Append("@To_Location,");
                    Sbd.Append("@To_Status,");
                    Sbd.Append("@Asste_Move_RunId) ");
                    sqlSaveStHead = Sbd.ToString();

                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@Asset_Movement_Id", SqlDbType.NVarChar).Value = txtAssetMovementId.Text.Trim();
                    Cmd.Parameters.Add("@Asset_No_System", SqlDbType.NVarChar).Value = txt_Sys_Asset.Text.Trim();
                    Cmd.Parameters.Add("@Asset_No", SqlDbType.NVarChar).Value = txtAssetNo.Text.Trim();
                    Cmd.Parameters.Add("@Fixed_Asset_No", SqlDbType.NVarChar).Value = txtFixAssetNo.Text.Trim();
                    Cmd.Parameters.Add("@From_Owner", SqlDbType.NChar).Value = cboOwner.SelectedValue.ToString();
                    Cmd.Parameters.Add("@From_Base", SqlDbType.NChar).Value = cboBase.SelectedValue.ToString();
                    Cmd.Parameters.Add("@From_Location", SqlDbType.NChar).Value = cboLocation.SelectedValue.ToString();
                    Cmd.Parameters.Add("@From_Status", SqlDbType.NChar).Value = cboStatus.SelectedValue.ToString();
                    Cmd.Parameters.Add("@To_Owner", SqlDbType.NChar).Value = cboOwner.SelectedValue.ToString();
                    Cmd.Parameters.Add("@To_Base", SqlDbType.NChar).Value = cboBase.SelectedValue.ToString();
                    Cmd.Parameters.Add("@To_Location", SqlDbType.NChar).Value = cboLocation.SelectedValue.ToString();
                    Cmd.Parameters.Add("@To_Status", SqlDbType.NChar).Value = cboStatus.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarksForMoveTo.Text.Trim();
                    Cmd.Parameters.Add("@MovementDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Movement_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Asste_Move_RunId", SqlDbType.Int).Value = AssetMovementId;
                    Cmd.ExecuteNonQuery();


                    MessageBox.Show("Record asset successfully", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    DialogResult dlg = MessageBox.Show("ต้องการพิมพ์ เอกสาร Asset Movement หรือไม่!!!", "ผลการทำงาน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlg == DialogResult.OK)
                    {


                        frmAssetMovementReport rpt = new frmAssetMovementReport();
                        rpt.StartPosition = FormStartPosition.CenterScreen;   // กำหนด frm ย่อย ให้อยู่ตรงกลาง
                        rpt.Asset_Sys = txt_Sys_Asset.Text.Trim();
                        rpt.ShowDialog();

                    }
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to record asset" + ex.Message, "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
                
                
                
            }
            
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
            Max_Asset_Movement();
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
            txtAmend.Text = dt.Rows[0]["Amend"].ToString();

        }
        private void Max_Asset_Movement()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(Asset_Movement_Id,6,8)) AS Asset_No_System FROM Asset_Movement");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                AssetMovementId = 1;
            }
            else
            {
                AssetMovementId = Convert.ToInt32(id.ToString());
                AssetMovementId++;
            }
            string strMax = "";
            strMax = String.Format("{0:0000}", Convert.ToInt16(AssetMovementId.ToString()));
            txtAssetMovementId.Text = "M" + DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + strMax;

            Cmd.Parameters.Clear();
        }
    }
}
