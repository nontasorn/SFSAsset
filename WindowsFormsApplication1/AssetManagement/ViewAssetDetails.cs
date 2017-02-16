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
    public partial class ViewAssetDetails : Form
    {
        public ViewAssetDetails()
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

        private void ViewAssetDetails_Load(object sender, EventArgs e)
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
            AssetDetails();
        }
        private void AssetDetails()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("A.Asset_No,");
            Sbd.Append("A.Fixed_Asset_No,");
            Sbd.Append("A.Asset_Details,");
            Sbd.Append("T.Asset_TypeName,");
            Sbd.Append("A.Asset_Brand,");
            Sbd.Append("A.Asset_Purchase,");
            Sbd.Append("A.Asste_Expire_Date,");
            Sbd.Append("A.Remarks, ");
            Sbd.Append("(E.Employee_FirstName+'  '+E.Employee_LastName) AS Created_By,");
            Sbd.Append("A.Create_Date,");
            Sbd.Append("Modified_By,");
            Sbd.Append("A.Amend,");
            Sbd.Append("A.ComputerName,");
            Sbd.Append("S.Status_Name,");
            Sbd.Append("B.Base_Name,");
            Sbd.Append("L.Location_Name,");
            Sbd.Append("(E2.Employee_FirstName+'  '+E2.Employee_LastName) AS Owner ");
            Sbd.Append("FROM Asset A ");
            Sbd.Append("LEFT JOIN Asset_Type T ");
            Sbd.Append("ON A.Asset_Type = T.Asset_Type_ID ");
            Sbd.Append("LEFT JOIN Base B ");
            Sbd.Append("ON A.Base = B.Base_ID ");
            Sbd.Append("LEFT JOIN Location L ");
            Sbd.Append("ON L.Location_ID = A.Location ");
            Sbd.Append("LEFT JOIN Employee E ");
            Sbd.Append("ON E.Employee_ID = A.Create_By ");
            Sbd.Append("LEFT JOIN Status S ");
            Sbd.Append("ON S.Status_Id = A.Asset_Status ");
            Sbd.Append("LEFT JOIN Employee E2 ");
            Sbd.Append("ON E2.Employee_ID = A.Create_By ");


            string sqlProduct = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandText = sqlProduct;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);
                dgv_ViewAsset.DataSource = dt;
                //dgv_ViewGrade_Format();
            }
            else
            {
                dgv_ViewAsset.DataSource = null;

            }
            Sdr.Close();
        }
    }
}
