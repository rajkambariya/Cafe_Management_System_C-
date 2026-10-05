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
    public partial class ucReservation : UserControl
    {
        connection conn;

        public ucReservation()
        {
            conn = new connection();
            conn.cnn = new SqlConnection(conn.cnstr);
            InitializeComponent();
        }
        //SqlDataAdapter da;
        //SqlCommand cmd;
        //SqlConnection cnn=new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");

        int rvs_id;
        DataTable dt= new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt4 = new DataTable();
        void loadMyData()
        {
            dt3.Rows.Clear();
            //"select *from tblreservation";
            string sql ="SELECT r.rvs_id As ID,c.name AS Name,c.phone AS Phone,t.table_Id AS TableNumber,t.Noseat AS NumberOfSeats,r.rvsDate As Date,r.starttime as sTime,r.S_am_pm as am_pm,r.endtime as eTime,r.E_am_pm as am_pm,r.Guests,r.rvsStatus as Status  FROM tblreservation r JOIN"; 
                   sql+=" tblcustomer c ON r.CustomerName = c.customer_id JOIN tblTable t ON r.TableID = t.table_Id";
                //"SELECT a.login_id,a.login_pass,b.roll_name,a.join_date,a.salary FROM tblUserMaster a JOIN tblRollMaster b ON a.User_roll=b.roll_id";
//            conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt3 = new DataTable();
            conn.da.Fill(dt3);

            DGVRVS.DataSource = dt3;

            
        }
        void loadTable(int[] var,int num)
        {
            
            dt1.Rows.Clear();
            for(int i=0;i<=num-1;i++)
            {
            string sql = "select table_id from tblTable where table_id =" + var[i];
         
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
         
            conn.da.Fill(dt1);
            cmbAVltable.ValueMember = "table_id";
            cmbAVltable.DisplayMember = "table_id";
            cmbAVltable.DataSource = dt1;
            }
                // DGVRVS.DataSource = dt1;
           
        }

           
        private void ucReservation_Load(object sender, EventArgs e)
        {
            cmbCin.SelectedIndex = 0;
            cmbCout.SelectedIndex = 0;
        }

        private void DGVRVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRvsAdd_Click(object sender, EventArgs e)
        {
            
            if (txtRVSCname.Text=="")
            {
                MessageBox.Show("FILL THE FILEDS!!");
            }
            else
            {
                string sql = "insert into tblreservation(CustomerName,contact,TableID,rvsDate,starttime,S_am_pm,endtime,E_am_pm,Guests,rvsStatus) values";
                sql += "(@una,@con,@tbl,@date,@starttime,@S_am_pm,@endtime,@E_am_pm,@gust,@acti)";

                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                    conn.cmd.Parameters.AddWithValue("@una", txtRVSCname.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@con", txtRVSCname.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@tbl", cmbAVltable.SelectedValue);
                    conn.cmd.Parameters.AddWithValue("@date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    conn.cmd.Parameters.AddWithValue("@starttime", txtRVSCinTime.Text.Trim() );
                    conn.cmd.Parameters.AddWithValue("@S_am_pm", cmbCin.Text);
                    conn.cmd.Parameters.AddWithValue("@endtime", txtRVSCoutTime.Text.Trim());
                    conn.cmd.Parameters.AddWithValue("@E_am_pm", cmbCout.Text);
                    conn.cmd.Parameters.AddWithValue("@gust", cmbRvsgustes.Value);
                    conn.cmd.Parameters.AddWithValue("@acti", "1");
                    
                    //cmd = new SqlCommand(sql, cnn);
                   conn. da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();

                    conn.da.Fill(dt);
                    MessageBox.Show("inserted");
                    loadMyData();
                }
            }
           
        }

        private void btnRvsClear_Click(object sender, EventArgs e)
        {
            txtRVSCname.Clear();
            txtRVSCoutTime.Clear();
            cmbAVltable.SelectedIndex = 0; 
            txtRVSCinTime.Clear();
            lblTblAlloted.Text = "Table Alloted:";

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRVSCname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnRvsIDshow_Click(object sender, EventArgs e)
        {
            if (txtRvsId.Text == "")
            {
                MessageBox.Show("fill the Fileds!! ");
                           }
            else
            {
                string sql = "select name As Name,phone as Phone ,customer_id As ID from tblcustomer where name='" + txtRvsId.Text.ToString() + "'";

                conn.cmd = new SqlCommand(sql, conn.cnn);
                conn.da = new SqlDataAdapter(conn.cmd);
                dt2 = new DataTable();

                conn.da.Fill(dt2);

                dataGridView1.DataSource = dt2;
 
            }

        }

        private void btnAvlTable_Click(object sender, EventArgs e)
        {
            loadMyData();

        }

        private void btnDBCHECK_Click(object sender, EventArgs e)
        {
            
               
            
        }

        private void chkRvs_Click(object sender, EventArgs e)
        {

            if (txtRVSCinTime.Text == "" || txtRVSCoutTime.Text == "")
            {
                MessageBox.Show("FILL THE FILEDS!!");
            }
            else
            {
                int cin = int.Parse(txtRVSCinTime.Text.Trim());
                int cout = int.Parse(txtRVSCoutTime.Text.Trim());
                dt.Rows.Clear();
                int[] var1 = new int[10];
                // MessageBox.Show(txtRVSCinTime.Text.Trim() + cmbCin.Text +lblTO.Text+" "+ txtRVSCoutTime .Text.Trim()+ cmbCout.Text);
                string sql = "SELECT table_Id FROM tblTable WHERE table_Id not IN ( SELECT TableID FROM tblReservation WHERE endtime> " + cin + "  AND starttime< " + cout + "AND rvsDate='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND rvsStatus=1 AND S_am_pm='" + cmbCin.Text + "' AND E_am_pm='" + cmbCout.Text + "' )";




                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                    //MessageBox.Show();
                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                    conn.da.Fill(dt);
                    // MessageBox.Show(dt.Rows.Count+"" + txtRVSCinTime.Text.Trim() + cmbCin.Text + lblTO.Text + " " + txtRVSCoutTime.Text.Trim() + cmbCout.Text + "' AND rvsDate='" + dateTimePicker1.Value.ToString("dd-MM-yyyy"));
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        var1[i] = int.Parse(dt.Rows[i][0].ToString());
                        // MessageBox.Show(var1[i].ToString());
                    }

                }
                //DGVRVS.DataSource = dt;
               
               loadTable(var1,dt.Rows.Count);
              //  txtRVSCinTime.Text = txtRVSCoutTime.Text;
                //txtRVSCoutTime.Clear();
            }
        }

        private void btnRvsUpdate_Click(object sender, EventArgs e)
        {
            if (txtRVSCname.Text == "")
            {
                MessageBox.Show("FILL THE FILEDS!!");
            }
            else
            {
                
                string sql = "Update tblreservation set TableID=@tbl,rvsDate=@date,starttime=@starttime,endtime=@endtime,S_am_pm=@S_am_pm,E_am_pm=@E_am_pm,Guests=@gust,rvsStatus=@acti where rvs_id="+rvs_id;


                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                   // conn.cmd.Parameters.AddWithValue("@una", txtRvsId.Text.ToString());
                    //cmd.Parameters.AddWithValue("@con");//txtAdminSecUpass.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@tbl", cmbAVltable.SelectedValue);
                    conn.cmd.Parameters.AddWithValue("@gust", cmbRvsgustes.Value);
                    conn.cmd.Parameters.AddWithValue("@date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    conn.cmd.Parameters.AddWithValue("@starttime", txtRVSCinTime.Text.Trim() );
                    conn.cmd.Parameters.AddWithValue("@S_am_pm", cmbCin.Text);
                    conn.cmd.Parameters.AddWithValue("@endtime", txtRVSCoutTime.Text.Trim());
                    conn.cmd.Parameters.AddWithValue("@E_am_pm", cmbCout.Text);
                    //conn.cmd.Parameters.AddWithValue("@time", txtRVSCinTime.Text.Trim() + cmbCin.Text + lblTO.Text + " " + txtRVSCoutTime.Text.Trim() + cmbCout.Text);
                    conn.cmd.Parameters.AddWithValue("@acti", "1");

                    //cmd = new SqlCommand(sql, cnn);
                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();

                    conn.da.Fill(dt);
                    MessageBox.Show("Updated!!");
                    loadMyData();
                }
                //sql = "Update tblcustomer set name=@una where customer_id=" + txtRvsId.Text.ToString();
                //using (conn.cmd = new SqlCommand(sql,conn.cnn))
                //{
                //    conn.cmd.Parameters.AddWithValue("@una", txtRVSCname.Text.ToString());
                //    conn.da = new SqlDataAdapter(conn.cmd);
                //    dt = new DataTable();

                //    conn.da.Fill(dt);
                //    //   MessageBox.Show("Updated!!");
                 loadMyData();
                //}   
            }

        }

        private void btnRvsCancel_Click(object sender, EventArgs e)
        {
            string sql = "Update tblreservation SET rvsStatus='false' WHERE rvs_id=" + rvs_id;


            using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {

                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                MessageBox.Show("CheckEd   OUT!!");
                loadMyData();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Delete from tblreservation  WHERE rvs_id=" + rvs_id;


            using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {

                conn.da = new SqlDataAdapter(conn.cmd);
               // dt = new DataTable();
                conn.da.Fill(dt);
                MessageBox.Show("Recored Deleted@!!");
                loadMyData();
            }



        }

        private void DGVRVS_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rvs_id = int.Parse(DGVRVS.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtRvsId.Text = DGVRVS.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRVSCinTime.Text = DGVRVS.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtRVSCoutTime.Text= DGVRVS.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbCin.Text = DGVRVS.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbCout.Text=    DGVRVS.Rows[e.RowIndex].Cells[9].Value.ToString();
            // txtRVSCinTime.Text = DGVRVS.Rows[e.RowIndex].Cells[6].Value.ToString();
            string dateText = DGVRVS.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dateText);
            string var1;
            var1 = DGVRVS.Rows[e.RowIndex].Cells[3].Value.ToString();
            //cmbAVltable.SelectedValue = int.Parse(var1);
            lblTblAlloted.Text = "Table Alloted:" + var1;

        }

        private void txtRVSCinTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;

            if (a == 8) return;
            if (a < 48 || a > 57 )
                {
                    e.Handled = true; 
                }
                
        }

        private void txtRVSCinTime_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtRVSCoutTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;

            if (a == 8) return;
            if (a < 48 || a > 57)
            {
                e.Handled = true;
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRVSCname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRVSCoutTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDuration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTO_Click(object sender, EventArgs e)
        {

        }

        private void cmbCin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbRvsgustes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTblAlloted_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbAVltable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}