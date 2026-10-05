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
    public partial class ucCustomer : UserControl
    {
        connection conn;
        public ucCustomer()
        {
            conn = new connection();
            conn.cnn = new SqlConnection(conn.cnstr);
            InitializeComponent();
        }
        

        DataTable dt = new DataTable();
        int cust_id;
        
        void loadMyData()
        {
            dt.Rows.Clear();
            string sql = "SELECT customer_id As CustomerId ,name as Name,phone As Phone,registered_date As RegisteredDate,status As Status from tblcustomer";

           
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);
            DGVCustomer.DataSource = dt;

           
        }
        void clearMydata()
        {
            txtCustname.Clear();
            CmbCusStatus.SelectedIndex = 0;
             txtCustNumb.Clear();
         }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            loadMyData();
            DGVCustomer.ReadOnly = true;
            CmbCusStatus.SelectedIndex = 0;
            DGVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCustAdd_Click(object sender, EventArgs e)
        {


            if (txtCustname.Text == "" || txtCustNumb.Text == "" || CmbCusStatus.SelectedIndex == 0)
            {
                MessageBox.Show("FILL THE FILEDS!!");
            }
            else
            {
                string sql = "select  name from tblcustomer where name=@una";
                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                    conn.cmd.Parameters.AddWithValue("@una", txtCustname.Text.ToString());


                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                 conn.da.Fill(dt);
                }
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("User Allready existed!!");
                        
                }
                else
                {

                sql = "insert into tblcustomer values(@una,@phone,@date,@acti)";

                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                    conn.cmd.Parameters.AddWithValue("@una", txtCustname.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@phone", txtCustNumb.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    conn.cmd.Parameters.AddWithValue("@acti", CmbCusStatus.Text);


                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                    conn.da.Fill(dt);
                    MessageBox.Show("inserted");
                    loadMyData();
                    clearMydata();
                }
            }
            }
        }

        private void btnCustUpdate_Click(object sender, EventArgs e)
        {
            if (btnCustUpdate.Text == "Edit")
            {
                btnCustAdd.Enabled = false;
                btnCustDelete.Enabled = false;

                btnCustUpdate.Text = "Update";
                btnCustClear.Text = "Cancel";
            }
            else
            {
                if (txtCustname.Text == "" || txtCustNumb.Text == "" || CmbCusStatus.SelectedIndex == 0)
                {
                    MessageBox.Show("FILL THE FILEDS!!");
                }
                else
                {
                    //MessageBox.Show(CmbCusStatus.SelectedItem.ToString());
                    // return;
                    dt.Rows.Clear();
                    string sql = "update tblcustomer set name=@una,phone=@phone,registered_date=@date,status=@acti where customer_id=" + cust_id;

                    using (conn.cmd = new SqlCommand(sql, conn.cnn))
                    {
                        conn.cmd.Parameters.AddWithValue("@una", txtCustname.Text.ToString());
                        conn.cmd.Parameters.AddWithValue("@phone", txtCustNumb.Text.ToString());
                        conn.cmd.Parameters.AddWithValue("@date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                        conn.cmd.Parameters.AddWithValue("@acti", CmbCusStatus.SelectedItem.ToString());


                        conn.da = new SqlDataAdapter(conn.cmd);
                        dt = new DataTable();
                        conn.da.Fill(dt);
                        MessageBox.Show("UPDATED");
                        loadMyData();
                        clearMydata();
                    }
                    btnCustUpdate.Text = "Edit";
                    btnCustClear.Text = "Clear";
                    btnCustAdd.Enabled = true;
                    btnCustDelete.Enabled = true;
                
                }
            }
                }

                private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    DGVCustomer.ReadOnly = false;
                }

                private void btnCustClear_Click(object sender, EventArgs e)
                {
                    clearMydata();
                    if (btnCustClear.Text == "Cancel")
                    {
                        btnCustAdd.Enabled = true;
                        btnCustClear.Text = "Clear";
                        btnCustUpdate.Text = "Edit";
                        btnCustDelete.Enabled = true;
                    }
                }

                private void btnCustDelete_Click(object sender, EventArgs e)
                {
                    
                    string sql = "Delete from tblcustomer  where customer_id=" + cust_id;

                    
                    using (conn.cmd = new SqlCommand(sql, conn.cnn))
                    {
                    
                        conn.da = new SqlDataAdapter(conn.cmd);
                        dt = new DataTable();
                        conn.da.Fill(dt);
                        MessageBox.Show("DELETED!!");
                        loadMyData();
                        clearMydata();
                    }
        }

        private void txtAdminSearch_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            string sql = "select customer_id As CustomerId , name as Name,phone As Phone ,registered_date As RegisteredDate ,status As Status from tblcustomer where name LIKE '" + txtAdminSearch.Text.Trim().ToString() + "%'";

          //  conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);

            DGVCustomer.DataSource = dt;
            
        }

        private void DGVCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVCustomer.ReadOnly == false)
            {
                cust_id = int.Parse(DGVCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCustname.Text = (DGVCustomer.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtCustNumb.Text = (DGVCustomer.Rows[e.RowIndex].Cells[2].Value.ToString());
                if ("True" == DGVCustomer.Rows[e.RowIndex].Cells[4].Value.ToString())
                {
                    CmbCusStatus.SelectedIndex = 1;
                }
                else
                {
                    CmbCusStatus.SelectedIndex = 2;
                }
                DateTime date = DateTime.Parse(DGVCustomer.Rows[e.RowIndex].Cells[3].Value.ToString());

                dateTimePicker1.Value = date;
            }
        }
    }
}
