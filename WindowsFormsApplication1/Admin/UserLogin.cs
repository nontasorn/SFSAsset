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
using System.IO;
using System.Security.Cryptography;
using WindowsFormsApplication1.Class;

namespace WindowsFormsApplication1.Admin
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlTransaction Tr;
        StringBuilder Sb;
        SqlDataReader Sdr;
        string userId;
        

        private void Create_User_Btn_Click(object sender, EventArgs e)
        {
            if (txt_Create_Employee_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter employee ID", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Employee_ID.Focus();
                return;
            }
            if (txt_Create_Password.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your password", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Password.Focus();
                return;
            }

            if (txt_Create_Password.Text.Trim() != txt_Create_Reenter_Password.Text.Trim())
            {
                MessageBox.Show("These password don't match", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Reenter_Password.Focus();
                txt_Create_Reenter_Password.SelectAll();
                return;
            }
            if (MessageBox.Show("คุณต้องการเพิ่ม UserName ใหม่ ใช่หรือไม่?", "Asset Management Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                byte[] CurrentIV = new byte[] { 51, 52, 53, 54, 55, 56, 57, 58 };
                byte[] CurrentKey;

                if (txt_Create_Employee_ID.Text.Length == 8)
                {
                    CurrentKey = Encoding.ASCII.GetBytes(txt_Create_Employee_ID.Text);
                }
                else if (txt_Create_Employee_ID.Text.Length > 8)
                {
                    CurrentKey = Encoding.ASCII.GetBytes(txt_Create_Employee_ID.Text.Substring(0, 8));
                }
                else
                {
                    string AddString = txt_Create_Employee_ID.Text.Substring(0, 1);
                    int TotalLoop = 8 - Convert.ToInt32(txt_Create_Employee_ID.Text.Length);
                    string tmpKey = txt_Create_Employee_ID.Text;
                    for (int i = 1; i <= TotalLoop; i++)
                    {
                        tmpKey = tmpKey + AddString;
                    }
                    CurrentKey = Encoding.ASCII.GetBytes(tmpKey);
                }

                DESCryptoServiceProvider desCrypt = new DESCryptoServiceProvider();
                desCrypt.IV = CurrentIV;
                desCrypt.Key = CurrentKey;

                MemoryStream ms = new MemoryStream();
                ms.Position = 0;

                ICryptoTransform Ict = desCrypt.CreateEncryptor();
                CryptoStream cs = new CryptoStream(ms, Ict, CryptoStreamMode.Write);

                byte[] arrByte = Encoding.ASCII.GetBytes(txt_Create_Password.Text);
                cs.Write(arrByte, 0, arrByte.Length);
                cs.FlushFinalBlock();
                cs.Close();

                string PwdWithEncrypt;
                PwdWithEncrypt = Convert.ToBase64String(ms.ToArray());
                try
                {
                    Sb = new StringBuilder();
                    Sb.Append("INSERT INTO User_Login (User_ID,User_Password )");
                    Sb.Append(" VALUES (@User_ID,@User_Password)");
                    string sqlAdd;
                    sqlAdd = Sb.ToString();


                    Cmd = new SqlCommand();
                    Cmd.CommandText = sqlAdd;
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Conn;
                    Cmd.Transaction = Tr;
                    Cmd.Parameters.Clear();
                    Cmd.Parameters.Add("@User_ID", SqlDbType.NChar).Value = txt_Create_Employee_ID.Text.Trim();
                    Cmd.Parameters.Add("@User_Password", SqlDbType.NVarChar).Value = PwdWithEncrypt;
                    

                    Cmd.ExecuteNonQuery();
                    Tr.Commit();
                    //ShowAllUserName();

                    MessageBox.Show("เพิ่ม UserName ใหม่ เรียบร้อยแล้ว !!!", "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Create_Employee_ID.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("คุณป้อน UserName ซ้ำกับของเดิมที่มีอยู่ !!! " + ex.Message, "Asset Management Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Tr.Rollback();
                }

            }
            
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            string strConn;
            strConn = DBConnString.strConn;        
            //strConn = "Data Source=192.168.1.13;Initial Catalog=ASSET; Persist Security Info=True;User ID=sa";
            Conn = new SqlConnection();
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = strConn;
            Conn.Open();
            userId = DBConnString.sUserIdLogin;
        }
    }
}
