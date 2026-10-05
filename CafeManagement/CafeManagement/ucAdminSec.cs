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
    public partial class ucAdminSec : UserControl
    {

        connection conn;
        public ucAdminSec()
        {
            conn = new connection();
            conn.cnn = new SqlConnection(conn.cnstr);
            InitializeComponent();

        }

        //SqlDataAdapter da;
        //SqlCommand cmd;
        //SqlConnection cnn;
        int id, pro_type, var1, subtype;
        string var,subid;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        void loadMyMainCat()
        {

            dt.Rows.Clear();
            string sql = "SELECT Main_pro_type_name FROM tblMainProTypes where IsActive=1 ";

            // conn.cnn = new SqlConnection(conn.cnstr);
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt5 = new DataTable();
            conn.da.Fill(dt5);
            cmbMainType.ValueMember = "Main_pro_type_name";
            cmbMainType.DisplayMember = "Main_pro_type_name";
            //MessageBox.Show("FILL THE FILEDS!!");
            cmbMainType.DataSource = dt5;


        }
        public void loadMyData()
        {
            dt.Rows.Clear();
            string sql = "SELECT a.id,a.login_id,a.login_pass,b.roll_name,a.join_date,a.salary,a.IsActive FROM tblUserMaster a JOIN tblRollMaster b ON a.User_roll=b.roll_id ";

            // conn.cnn = new SqlConnection(conn.cnstr);
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);

            DGVAdminSec.DataSource = dt;


        }
        void getRoll()
        {
            dt2.Rows.Clear();
            //======================================================================================================================
            string sql = "select roll_name from tblRollMaster where IsActive=1";
            //======================================================================================================================
            conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt2 = new DataTable();
            conn.da.Fill(dt2);
            cmbAdminSecURoll.DisplayMember = "roll_name";
            cmbAdminSecURoll.ValueMember = "roll_name";
            cmbAdminSecURoll.DataSource = dt2;
            getRoll(cmbAdminSecURoll.Text);
        }

        void clearMydata()
        {
            txtAdminSecUid.Clear();
            cmbAdminSecURoll.SelectedIndex = 0;
            //cmbAdminSecURoll.Text = string.Empty;
            //cmbAdminSecURoll.Items.Clear();
            //cmbAdminSecURoll.DataSource = null; 
            cmbAdminSecUStatus.SelectedIndex = 0;
            txtAdminSecUpass.Clear();
            txtAdminUSalary.Clear();
            btnProUpdate.Text = "Edit";
            btnProClear.Text = "Clear";
      
            //getRoll(cmbAdminSecURoll.Text);
        }
        void getRoll(string roll)
        {
            dt3.Rows.Clear();
            //======================================================================================================================
            string sql = "select roll_id from tblRollMaster where roll_name='" + roll + "' And IsActive=1";
            //======================================================================================================================
            //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt3 = new DataTable();
            conn.da.Fill(dt3);
            var1 = int.Parse(dt3.Rows[0][0].ToString());
        }


        private void ucAdminSec_Load(object sender, EventArgs e)
        {
            DGVAdminSec.ReadOnly = true;
            loadMyMainCat();
            getRoll();
            pnlType.Hide();
            loadMyData();
            pnlTable.Hide();
            //cmbAdminSecURoll.SelectedIndex = 0;
            cmbAdminSecUStatus.SelectedIndex = 0;
            cmbPproTyStat.SelectedIndex = 0;
            //  DGVAdminSec.AutoGenerateColumns = false;
            DGVAdminSec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVTAble.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProTypeDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //loadMyMainCat();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnProDelete.Enabled = true;//var = DGVAdminSec.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtAdminSecUpass.Text = DGVAdminSec.Rows[e.RowIndex].Cells[1].Value.ToString();
            //cmbAdminSecURoll.SelectedItem = DGVAdminSec.Rows[e.RowIndex].Cells[2].Value.ToString();
            ////cmbAdminSecUStatus.SelectedItem = DGVAdminSec.Rows[e.RowIndex].Cells[5].Value.ToString(); 
            // txtAdminUSalary.Text = DGVAdminSec.Rows[e.RowIndex].Cells[4].Value.ToString();

            //   //MessageBox.Show(DGVAdminSec.Rows[e.RowIndex].Cells[4].Value.ToString());

        }

        private void btnProAdd_Click(object sender, EventArgs e)
        {


            if (txtAdminSecUid.Text == "" || txtAdminSecUpass.Text == "" || txtAdminUSalary.Text == "" || cmbAdminSecURoll.SelectedIndex == -1)
            {
                MessageBox.Show("FILL THE FILEDS!!");
            }
            else
            {
                string sql = "insert into tblusermaster select max(id)+1,@una,@upa,@roll,@date,@salary,@acti from tblusermaster";

                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                    conn.cmd.Parameters.AddWithValue("@una", txtAdminSecUid.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@upa", txtAdminSecUpass.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@roll", var1);
                    conn.cmd.Parameters.AddWithValue("@date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    conn.cmd.Parameters.AddWithValue("@salary", txtAdminUSalary.Text.ToString());
                    conn.cmd.Parameters.AddWithValue("@acti", "1");


                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                    conn.da.Fill(dt);
                    MessageBox.Show("inserted" + dt.Rows.Count + "");

                    loadMyData();
                    clearMydata();
                }
            }
        }

        private void btnProClear_Click(object sender, EventArgs e)
        {
            clearMydata();
            if (btnProClear.Text == "Clear")
            {
                btnProAdd.Enabled = true;
                DGVAdminSec .ReadOnly = true;  
                btnProDelete.Enabled = true;
            }
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            if (btnProUpdate.Text == "Edit")
            {
                btnProAdd.Enabled = false;
                btnProDelete.Enabled=false;
                DGVAdminSec.ReadOnly = false;
                btnProUpdate.Text = "Update";
                btnProClear.Text = "Cancel";
            }
            else
            {

                if (txtAdminSecUid.Text == "" || txtAdminSecUpass.Text == "" || txtAdminUSalary.Text == "" || cmbAdminSecURoll.SelectedIndex == 0 || cmbAdminSecUStatus.SelectedIndex == 0)
                {
                    MessageBox.Show("FILL THE FILEDS!!");
                }
                else
                {
                    dt4.Rows.Clear();
                    if (DialogResult.Yes == MessageBox.Show("are you sure? you want to update?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {

                        if (txtAdminSecUid.Text == "" || txtAdminSecUpass.Text == "" || txtAdminUSalary.Text == "" || cmbAdminSecURoll.Text == "" || cmbAdminSecUStatus.SelectedIndex == 0)
                        {
                            MessageBox.Show("FILL THE FILEDS!!");
                        }
                        else
                        {
                            string sql = "Update tblUserMaster SET login_id= @una,login_pass=@upa,User_roll=@roll,join_date=@date,salary=@salary,IsActive=@acti WHERE id='" + var + "'";


                            using (conn.cmd = new SqlCommand(sql, conn.cnn))
                            {
                                conn.cmd.Parameters.AddWithValue("@una", txtAdminSecUid.Text.ToString());
                                conn.cmd.Parameters.AddWithValue("@upa", txtAdminSecUpass.Text.ToString());
                                conn.cmd.Parameters.AddWithValue("@roll", var1);
                                conn.cmd.Parameters.AddWithValue("@date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                                conn.cmd.Parameters.AddWithValue("@salary", txtAdminUSalary.Text.ToString());
                                conn.cmd.Parameters.AddWithValue("@acti", cmbAdminSecUStatus.SelectedItem.ToString());

                                //cmd = new SqlCommand(sql, cnn);
                                conn.da = new SqlDataAdapter(conn.cmd);
                                dt4 = new DataTable();
                                conn.da.Fill(dt4);
                                MessageBox.Show("UPDATED!!");
                                loadMyData();
                                clearMydata();
                            }
                        }
                    }
                    btnProUpdate.Text = "Edit";
                    btnProClear.Text = "Clear";
                    btnProAdd.Enabled = true;
                    btnProDelete.Enabled = true;
                
                }
            }
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
          //  dt.Rows.Clear();
            if (DialogResult.Yes == MessageBox.Show("are you sure? you want to Delete?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                
                string sql = "DELETE from tblUserMaster  WHERE id='" + var + "'";

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
        }

        private void txtAdminSearch_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            string sql = "SELECT a.id,a.login_id,a.login_pass,b.roll_name,a.join_date,a.salary,a.IsActive FROM tblUserMaster a JOIN tblRollMaster b ON a.User_roll=b.roll_id WHERE login_id LIKE '" + txtAdminSearch.Text.Trim().ToString() + "%' AND a.IsActive=1";

            conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);

            DGVAdminSec.DataSource = dt;
        }

        private void btnAddProType_Click(object sender, EventArgs e)
        {
            pnlType.Show();
            pnlType.Dock = DockStyle.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlType.Hide();

        }
        void loadMyData(string tbl)
        {
            dt.Rows.Clear();
            string sql = "SELECT  * from " + tbl + " where IsActive=1";


            conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);

            DGVProTypeDetail.DataSource = dt;


        }
        void loadMytable()
        {
            dt.Rows.Clear();
            string sql = "SELECT  * from tblTable where IsActive=1";

            //  conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);

            DGVTAble.DataSource = dt;


        }

        void getSubtype(string type)
        {
            dt6.Rows.Clear();
            //======================================================================================================================
            string sql = "select Main_pro_type_id from tblMainProTypes where Main_pro_type_name ='" + type + "' AND IsActive=1";
            //======================================================================================================================
            conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt6 = new DataTable();
            conn.da.Fill(dt6);
            subtype = int.Parse(dt6.Rows[0][0].ToString());
            //MessageBox.Show("" + subtype);
        }
        private void rdbMainType_CheckedChanged(object sender, EventArgs e)
        {
            loadMyData("tblMainProTypes");
            cmbMainType.Hide();
            lblproType.Hide();
            btnUpdate.Hide();

        }

        private void rdbSubType_CheckedChanged(object sender, EventArgs e)
        {
            loadMyData("tblSubProTypes");
            cmbMainType.Show();
            lblproType.Show();
            btnUpdate.Show();

        }
        void getProtype(string type)
        {
            dt.Rows.Clear();
            //======================================================================================================================
            string sql = "select Main_pro_type_id from tblMainProTypes where Main_pro_type_name ='" + type + "'";
            //======================================================================================================================
            //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);
            pro_type = int.Parse(dt.Rows[0][0].ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (rdbMainType.Checked)
            {

                if (txtProTyName.Text == "" || cmbPproTyStat.SelectedIndex == 0)
                {
                    MessageBox.Show("Fill the FILED!!!");
                }
                else
                {
                    dt.Rows.Clear();
                    string sql = "insert into tblMainProTypes values ('" + txtProTyName.Text.ToString() + "','" + cmbPproTyStat.Text + "')";

                    //cmd.Parameters.AddWithValue(@name", );
                    //cmd.Parameters.AddWithValue("@acti",cmbPproTyStat.Text);
                    //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
                    conn.cmd = new SqlCommand(sql, conn.cnn);
                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                    conn.da.Fill(dt);
                    loadMyData("tblMainProTypes");
                    MessageBox.Show("DATA INSERTED!!!");

                }

            }
            else
            {

                cmbMainType.SelectedItem = "Beverages";
                if (txtProTyName.Text == "" || cmbPproTyStat.SelectedIndex == 0)
                {
                    MessageBox.Show("Fill the FILED!!!");

                }
                else
                {
                    dt.Rows.Clear();
                    string sql = "insert into tblSubProTypes values (" + subtype + ",'" + txtProTyName.Text.ToString() + "','" + cmbPproTyStat.Text + "')";

                    //cmd.Parameters.AddWithValue(@name", );
                    //cmd.Parameters.AddWithValue("@acti",cmbPproTyStat.Text);
                    // conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
                    conn.cmd = new SqlCommand(sql, conn.cnn);
                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                    conn.da.Fill(dt);
                    loadMyData("tblSubProTypes");
                    MessageBox.Show("DATA INSERTED!!!");
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rdbMainType.Checked)
            {
                dt.Rows.Clear();
                string sql = "update  tblMainProTypes  set isActive=0 where main_pro_type_id=" + id;

                //cmd.Parameters.AddWithValue(@name", );
                //cmd.Parameters.AddWithValue("@acti",cmbPproTyStat.Text);
                //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
                conn.cmd = new SqlCommand(sql, conn.cnn);
                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                loadMyData("tblMainProTypes");
                MessageBox.Show("DATA DELETED!!!");
            }
            else
            {
                dt.Rows.Clear();
                string sql = "update  tblSubProTypes  set isActive=0 where sub_pro_type_id=" + id;

                //cmd.Parameters.AddWithValue(@name", );
                //cmd.Parameters.AddWithValue("@acti",cmbPproTyStat.Text);
                //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
                conn.cmd = new SqlCommand(sql, conn.cnn);
                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                loadMyData("tblSubProTypes");
                MessageBox.Show("DATA DELETED!!!");
            }



        }

        private void DGVProTypeDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(DGVProTypeDetail.Rows[e.RowIndex].Cells[0].Value.ToString());
        }



        private void btntblAdd_Click(object sender, EventArgs e)
        {
            if (txtSeat.Text == "" || cmbSeatStat.SelectedIndex == 0)
            {
                MessageBox.Show("Fill the FILED!!!");

            }
            else
            {
                dt.Rows.Clear();
                string sql = "insert into tblTable  select MAX(table_id)+1,'" + txtSeat.Text.ToString() + "','" + cmbSeatStat.Text + "' from tblTable";

                //cmd.Parameters.AddWithValue(@name", );
                //cmd.Parameters.AddWithValue("@acti",cmbPproTyStat.Text);
                //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
                conn.cmd = new SqlCommand(sql, conn.cnn);
                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                loadMytable();
                MessageBox.Show("DATA INSERTED!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlTable.Hide();
        }

        private void btntblDel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("are you sure? you want to Delete?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dt.Rows.Clear();
                string sql = "delete from tblTable where table_id=" + id;
                
                //cmd.Parameters.AddWithValue(@name", );
                //cmd.Parameters.AddWithValue("@acti",cmbPproTyStat.Text);
                //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
                conn.cmd = new SqlCommand(sql, conn.cnn);
                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                loadMytable();
                MessageBox.Show("DATA DELETED!!!");

            }


        }

        private void DGVTAble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMytable();
            pnlTable.Show();
            pnlTable.Dock = DockStyle.Fill;
        }

        private void cmbAdminSecURoll_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (cmbAdminSecURoll.SelectedItem != null)
            {
                getRoll(cmbAdminSecURoll.Text);
            }
        }

        private void DGVAdminSec_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var = DGVAdminSec.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (DGVAdminSec.ReadOnly == false)
            {
                txtAdminSecUid.Text = DGVAdminSec.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAdminSecUpass.Text = DGVAdminSec.Rows[e.RowIndex].Cells[2].Value.ToString();
                if ("Admin" == DGVAdminSec.Rows[e.RowIndex].Cells[3].Value.ToString())
                {
                    cmbAdminSecURoll.SelectedIndex = 2;
                }
                else
                {
                    cmbAdminSecURoll.SelectedIndex = 1;
                }
                if ("True" == DGVAdminSec.Rows[e.RowIndex].Cells[6].Value.ToString())
                {
                    cmbAdminSecUStatus.SelectedIndex = 1;
                }
                else
                {
                    cmbAdminSecUStatus.SelectedIndex = 2;
                }
                //cmbAdminSecUStatus.SelectedItem = DGVAdminSec.Rows[e.RowIndex].Cells[5].Value.ToString(); 
                txtAdminUSalary.Text = DGVAdminSec.Rows[e.RowIndex].Cells[5].Value.ToString();
                DateTime date = DateTime.Parse(DGVAdminSec.Rows[e.RowIndex].Cells[4].Value.ToString());

                dateTimePicker1.Value = date;
                //MessageBox.Show(DGVAdminSec.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
        }

        private void cmbMainType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMainType.SelectedItem != null)
            {
                getSubtype(cmbMainType.Text);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(""+DGVProTypeDetail.SelectedCells[0].Value);
            //return;
            dt.Rows.Clear();
            string sql = "update  tblSubProTypes  set MaintoSub_pro_type_id=" + subtype + ",Sub_pro_type_name='" + txtProTyName.Text + "',IsActive='" + cmbPproTyStat.Text + "'  where Sub_pro_type_id=" + subid;
            //
            //cmd.Parameters.AddWithValue(@name", );
            //cmd.Parameters.AddWithValue("@acti",cmbPproTyStat.Text);
            //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);
            loadMyData("tblSubProTypes");
            MessageBox.Show("DATA Updated!!!");



        }

        private void DGVProTypeDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            subid = DGVProTypeDetail.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
            txtProTyName.Text = DGVProTypeDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            if ("True" == DGVProTypeDetail.Rows[e.RowIndex].Cells[2].Value.ToString())
            {
                cmbPproTyStat.SelectedIndex = 1;
            }
            else
            {
                cmbPproTyStat.SelectedIndex = 2;
            }
        }

        private void DGVTAble_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(DGVTAble.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void txtAdminSecUpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

