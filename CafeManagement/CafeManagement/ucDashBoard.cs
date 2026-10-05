using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class ucDashBoard : UserControl
    {
        connection conn;
        public ucDashBoard()
        {
            conn = new connection();
            conn.cnn = new SqlConnection(conn.cnstr);
            InitializeComponent();
        }
        //SqlDataAdapter da;
        //SqlCommand cmd;
        //SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");

        DataTable dt = new DataTable();
        int var;
        private void ucDashBoard_Load(object sender, EventArgs e)
        {
            cmbCin.SelectedIndex = 0;
            cmbCout.SelectedIndex = 0;
            dt.Rows.Clear();

            string sql = "select table_id from tblTable where IsActive=1";


            using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {

                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
            }
            var = dt.Rows.Count;
           }

        private void btnCHECKout_Click(object sender, EventArgs e)
        {
           
        }

        private void DGVDBavlTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDBCHECK_Click(object sender, EventArgs e)
        {
            int cin=int.Parse(txtRVSCinTime.Text.Trim());
            int cout= int.Parse(txtRVSCoutTime.Text.Trim());    
            dt.Rows.Clear();

            string sql = "SELECT table_Id FROM tblTable WHERE table_Id not IN ( SELECT TableID FROM tblReservation WHERE endtime> " + cin + "  AND starttime< " + cout + "AND rvsDate='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND rvsStatus=1 AND S_am_pm='" + cmbCin.Text + "' AND E_am_pm='" + cmbCout.Text + "' )";
                //"select rvs_id from tblreservation where rvsTime='" + txtRVSCinTime.Text.Trim() + cmbCin.Text + lblTO.Text + " " + txtRVSCoutTime.Text.Trim() + cmbCout.Text + "' AND rvsDate=@date AND rvsStatus=1";
                //"SELECT * FROM Table1 WHERE ( endtime>=" + cin + " AND newEnd< " + cout + " )";
                    
                    
             //


                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                    {
                        //conn.cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        conn.da = new SqlDataAdapter(conn.cmd);
                        dt = new DataTable();
                        conn.da.Fill(dt);
                    }
                    if (dt.Rows.Count < var)
                    {
                        lblAvilable.Text = "Avilable :" + "YES" + " , AVILABLE Table: " + (var - dt.Rows.Count);
                            
                    }
                    else
                    {
                                                              
                        lblAvilable.Text = "Avilable :" + "NO" + " \n occupied Table:" + dt.Rows.Count;
                    }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
