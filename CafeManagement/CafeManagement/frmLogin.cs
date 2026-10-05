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
namespace CafeManagement
{
    public partial class frmLogin : Form
    {
       connection conn; 
        public frmLogin()
        {
            InitializeComponent();
            conn = new connection();
        }

    
        private void log_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ChkLogPass_CheckedChanged(object sender, EventArgs e)
        {
            txtLogUpass.PasswordChar = ChkLogPass.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        void data()
        {
            string sql1 = "select User_roll from tblUserMaster";
            sql1 += " where login_id='" + txtLogUName.Text.ToString() + "' ";
            sql1 += " AND login_pass=" + txtLogUpass.Text.ToString();
            sql1 += " AND IsActive=1 And User_roll=3";
   
            DataTable dt=conn.get_data(sql1);
            if (dt.Rows.Count >= 1)
            {
                Class1.roll = true;
            }
            else
            {
                Class1.roll = false;
            }
 
            string sql = "select login_id, login_pass from tblUserMaster";
            sql += " where login_id='" + txtLogUName.Text.ToString() + "' ";
            sql += " AND login_pass=" + txtLogUpass.Text.ToString();
            sql += " AND IsActive=1";
  
            dt = conn.get_data(sql);
            //MessageBox.Show(dt.Rows.Count.ToString());
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Successful Login");
                frmDashBoard frmd = new frmDashBoard();
                frmd.Show();
            }
            else
            {
                MessageBox.Show("User does not Exist!!");
                frmLogin frm = new frmLogin();
                frm.Show();

            }
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtLogUName.Text == "" || txtLogUpass.Text == "")
            {
                MessageBox.Show("fill the field");
            }
            else
            {
                data();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
