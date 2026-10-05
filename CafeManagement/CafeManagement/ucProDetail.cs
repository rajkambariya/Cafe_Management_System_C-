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
    public partial class ucProDetail : UserControl
    {
        connection conn;
        public ucProDetail()
        {
                conn = new connection();
                conn.cnn = new SqlConnection(conn.cnstr);
            InitializeComponent();
        }
        

        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DateTime date =DateTime.Today;
        int ty = 0, pro_id, pro_type, Mainpro_type, pro_type_id;
        string delProName;
        void loadMyData()
        {
            dt.Rows.Clear();
            //======================================================================================================================
            string sql = "SELECT p.pro_id as ID,p.pro_name as Name,pt.Sub_pro_type_name as Subtype,mpt.Main_pro_type_name as Maintype,p.pro_stock as Stock,p.pro_price as Price,p.IsActive as Status FROM tblProducts p";
            sql += " JOIN tblSubProTypes pt ON p.SubtoPro_pro_type_id = pt.Sub_pro_type_id";
            sql += " JOIN tblMainProTypes mpt ON pt.MaintoSub_pro_type_id = mpt.Main_pro_type_id";// WHERE p.IsActive=1";
            //======================================================================================================================
           //
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
           conn. da.Fill(dt);

            DGVProDetail.DataSource = dt;
            
   
        }
        void mainType()
        {
            dt4.Rows.Clear();
            //======================================================================================================================
            string sql = "select Main_pro_type_name from tblMainProTypes where IsActive=1";
            //======================================================================================================================

            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
           
            conn.da.Fill(dt4);
            
            cmbMainType.DisplayMember = "Main_pro_type_name";
           cmbMainType.ValueMember = "Main_pro_type_id";
            cmbMainType.DataSource = dt4;
            //subtype = int.Parse(dt2.Rows[0][0].ToString());
        }
     
        void getSubProtypeid(string type)
        {
            dt3.Rows.Clear();
            //======================================================================================================================
            string sql = "select Sub_pro_type_id from tblSubProTypes where Sub_pro_type_name ='" + type + "' AND IsActive=1";
            //======================================================================================================================
           // conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt3 = new DataTable();
            conn.da.Fill(dt3);
            
            pro_type_id = int.Parse(dt3.Rows[0][0].ToString());
         //   MessageBox.Show("" + Mainpro_type + "/" + pro_type_id);
           // getProtype(cmbProductType.)
        }



           void getMainProtypeid(string type)
        {
            dt3.Rows.Clear();
            //======================================================================================================================
            string sql = "select Main_pro_type_id from tblMainProTypes where Main_pro_type_name ='" + type + "' AND IsActive=1";
            //======================================================================================================================
            conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt3 = new DataTable();
            conn.da.Fill(dt3);

            Mainpro_type= int.Parse(dt3.Rows[0][0].ToString());
            loadSubType(Mainpro_type);
            // getProtype(cmbProductType.)
        }
        void loadSubType(int b)
        {
            dt1.Rows.Clear();
            //======================================================================================================================
            string sql = "select Sub_pro_type_name from tblSubProTypes where  MaintoSub_pro_type_id=" + b + " AND IsActive=1";
            //======================================================================================================================
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt1 = new DataTable();
            conn.da.Fill(dt1);

            cmbProductType.ValueMember = "Sub_pro_type_id";
            cmbProductType.DisplayMember = "Sub_pro_type_name";
            cmbProductType.DataSource = dt1;
        }
        void clearMydata()
        {
            // txtProductId.Clear();
            cmbProductType.SelectedIndex = 0;
            cmbProductStatus.SelectedIndex = 0;
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductStock.Clear();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void ucProDetail_Load(object sender, EventArgs e)
        {
            loadMyData();
            mainType();
            DGVProDetail.ReadOnly= true;
            cmbProductType.SelectedIndex = 0;
            cmbProductStatus.SelectedIndex = 0;
            DGVProDetail.AutoGenerateColumns = false;
            DGVProDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            getSubProtypeid(cmbProductType.Text);
        }
      

        private void btnProAdd_Click_1(object sender, EventArgs e)
        {

            if (txtProductName.Text == "" || txtProductPrice.Text == "" || txtProductStock.Text == "" || cmbProductStatus.SelectedIndex == -1 || cmbProductType.SelectedIndex == -1)
            {
                MessageBox.Show("FILL THE FILEDS!!");
            }
            else
            {

                //***** GETTNG SUB PRODUCT ID TO  ADD DATA******//
                getSubProtypeid(cmbProductType.Text.ToString());
                string sql = "select  pro_name from tblProducts where pro_name=@una";
                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                    conn.cmd.Parameters.AddWithValue("@una", txtProductName.Text.ToString());


                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                 conn.da.Fill(dt);
                }
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Allready existed!!");

                }
                else
                {

                    sql = "insert into tblProducts(SubtoPro_pro_type_id,pro_name,pro_stock,pro_price,ByDate,IsActive,MaintoSub_pro_type_id) values(@type,@pna,@stock,@price,@date,@acti,@Maintype)";

                    using (conn.cmd = new SqlCommand(sql, conn.cnn))
                    {
                        //cmd.Parameters.AddWithValue("@pid", txtProductId.Text.ToString());

                        conn.cmd.Parameters.AddWithValue("@type", pro_type_id);
                        conn.cmd.Parameters.AddWithValue("@pna", txtProductName.Text.ToString());
                        conn.cmd.Parameters.AddWithValue("@stock", txtProductStock.Text.ToString());
                        conn.cmd.Parameters.AddWithValue("@price", txtProductPrice.Text.ToString());
                        conn.cmd.Parameters.AddWithValue("@date", date);
                        conn.cmd.Parameters.AddWithValue("@acti", cmbProductStatus.SelectedItem.ToString());
                        conn.cmd.Parameters.AddWithValue("@Maintype", Mainpro_type);
                        //cmd = new SqlCommand(sql, cnn);
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

        private void btnProUpdate_Click_1(object sender, EventArgs e)
            {
                if (btnProUpdate.Text == "Edit")
                {
                    btnProAdd.Enabled = false;
                    btnProDelete.Enabled = false;
                    DGVProDetail.ReadOnly = false;
                    btnProUpdate.Text = "Update";
                    btnProClear.Text = "Cancel";
                }
                else
                {
                    if (txtProductName.Text == "" || txtProductPrice.Text == "" || txtProductStock.Text == "")
                    {
                        MessageBox.Show("FILL THE FILEDS!!");
                    }
                    else
                    {

                        if (DialogResult.Yes == MessageBox.Show("are you sure? you want to update?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            dt5.Rows.Clear();
                            string sql = "Update tblProducts SET SubtoPro_pro_type_id=@type,pro_name=@pna,pro_stock=@stock,pro_price=@price,ByDate=@date,IsActive=@acti,MainToSub_pro_type_id="+Mainpro_type;
                            sql += " WHERE pro_id=" + pro_id;


                            using (conn.cmd = new SqlCommand(sql, conn.cnn))
                            {
                                //cmd.Parameters.AddWithValue("@pid", txtProductId.Text.ToString());
                                conn.cmd.Parameters.AddWithValue("@type", pro_type_id);
                                conn.cmd.Parameters.AddWithValue("@pna", txtProductName.Text.ToString());
                                conn.cmd.Parameters.AddWithValue("@stock", txtProductStock.Text.ToString());
                                conn.cmd.Parameters.AddWithValue("@price", txtProductPrice.Text.ToString());
                                conn.cmd.Parameters.AddWithValue("@date", date);
                                conn.cmd.Parameters.AddWithValue("@acti", cmbProductStatus.SelectedItem.ToString());
                                //  MessageBox.Show("" + Mainpro_type + "/" + pro_type_id);
                                //conn.cmd.Parameters.AddWithValue("@Mtype", 2);//Mainpro_type);

                                conn.da = new SqlDataAdapter(conn.cmd);
                                dt5 = new DataTable();
                                conn.da.Fill(dt5);
                                MessageBox.Show("UPDATED!!");
                                clearMydata();
                                loadMyData();
                            }

                        }
                        btnProUpdate.Text = "Edit";
                        btnProClear.Text = "Clear";
                    }
                }
        }

        private void btnProClear_Click_1(object sender, EventArgs e)
        {
           
            clearMydata();
            if (btnProClear.Text == "Cancel")
            {
                btnProUpdate.Text = "Edit";
                btnProClear.Text = "Clear";
                DGVProDetail.ReadOnly = true;   
                btnProAdd.Enabled = true;
                btnProDelete.Enabled = true;
            }
        }

        private void btnProDelete_Click_1(object sender, EventArgs e)
        {
            
                if (DialogResult.Yes == MessageBox.Show("are you sure? ,you want to Delete ?\n''"+delProName+"''", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string sql = "Update tblProducts SET IsActive='false' WHERE pro_id=" + pro_id;


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
            //}
            //else
            //{
            //    MessageBox.Show("Select Product!!");
            //}
        }

        private void DGVProDetail_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnProDelete.Enabled = true;

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {


           
               if (cmbProductType.SelectedItem != null)
               {
                //    if (btnProUpdate.Text != "Update")
                //    {
                //    // loadMyData(cmbProductType.Text, Mainpro_type);

                //}
            getSubProtypeid(cmbProductType.Text);         
            
            }
            
        }
        private void cmbMainType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainType.SelectedItem != null)
            {
                getMainProtypeid(cmbMainType.Text);
                //mainType();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnProDetailShow.Text == "Show")
            {
                loadMyData();
                btnProDetailShow.Text = "Hide";
            }
            else
            {
                dt.Rows.Clear();
                btnProDetailShow.Text = "Show";
            }
            
        }

      
        private void txtProSearch_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            string sql = "SELECT p.pro_id as ID,p.pro_name as Name,pt.Sub_pro_type_name as Subtype,mpt.Main_pro_type_name as Maintype,p.pro_stock as Stock,p.pro_price as Price,p.IsActive as Status FROM tblProducts p";
            sql += " JOIN tblSubProTypes pt ON p.SubtoPro_pro_type_id = pt.Sub_pro_type_id";
            sql += " JOIN tblMainProTypes mpt ON pt.MaintoSub_pro_type_id = mpt.Main_pro_type_id WHERE pro_name LIKE '" + txtProSearch.Text.ToString() + "%' AND  p.IsActive=1";
            
            using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {

                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                DGVProDetail.DataSource = dt;
            }
        }

        private void DGVProDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
         
           

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVProDetail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pro_id = int.Parse(DGVProDetail.Rows[e.RowIndex].Cells[0].Value.ToString());
            delProName = DGVProDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            getSubProtypeid(cmbProductType.Text);
            if (DGVProDetail.ReadOnly == false)
            {
               
                txtProductName.Text = DGVProDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbProductType.Text = DGVProDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbProductStatus.SelectedItem = DGVProDetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtProductPrice.Text = DGVProDetail.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtProductStock.Text = DGVProDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                //MessageBox.Show(DGVAdminSec.Rows[e.RowIndex].Cells[4].Value.ToString());
                cmbMainType.Text = DGVProDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
           
        }
    }
}
