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

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Menu_Employee_Management2_Click(object sender, EventArgs e)
        {
            Admin.UserLogin frm = new Admin.UserLogin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CreateAsset_Click(object sender, EventArgs e)
        {
            AssetManagement.CreateAsset frm = new AssetManagement.CreateAsset();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text= DBConnString.sUserlogin;
            this.Activate();
        }

        private void ViewAsset_Menu_Click(object sender, EventArgs e)
        {
            AssetManagement.AssetManagement frm = new AssetManagement.AssetManagement();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
