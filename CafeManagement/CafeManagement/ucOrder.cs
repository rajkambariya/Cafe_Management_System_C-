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
    public partial class ucOrder : UserControl
    {
        connection conn;
        public ucOrder()
        {
            conn = new connection();
            conn.cnn = new SqlConnection(conn.cnstr);
            InitializeComponent();
          
        }
       // SqlDataAdapter da;
        //SqlCommand cmd;
        //SqlConnection cnn;
        int pos, maxStock, OrdId, val, totval, newval, ty, Mainpro_type;
        int noOrd = 0,qun;
        int []proStock=new int[200];
        string sql1,name;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DateTime date = DateTime.Today;
        private int GetLastOrderId()
        {
            int lastOrderId = 0;

            string sql = "SELECT ISNULL(MAX(orderId), 0) FROM tblOrderDetail"; // or tblOrderAtoC, whichever is the final order table

            using (SqlCommand cmd = new SqlCommand(sql, conn.cnn))
            {
                try
                {
                    conn.cnn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        lastOrderId = Convert.ToInt32(result);
                    }
                }
                finally
                {
                    conn.cnn.Close();
                }
            }

            return lastOrderId;
        }

        void updateStock()
        {

            int newVal = 0;

            for (int i = 0; i <= (noOrd - 1); i++)
            {

                proStock[i] = int.Parse(DGVOrderDetail.Rows[i].Cells[2].Value.ToString());
                string sql = "select n.productName,p.pro_stock from tblOrderAtoC n join tblProducts p on n.productName = p.pro_name";
                using (conn.cmd = new SqlCommand(sql, conn.cnn))
                {
                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt3 = new DataTable();
                    conn.da.Fill(dt3);
                }
                newVal = int.Parse(dt3.Rows[i][1].ToString()) - proStock[i];
                sql1 = " update tblProducts set pro_stock=" + newVal + "where pro_name='" + dt3.Rows[i][0].ToString() + "'";
                using (conn.cmd = new SqlCommand(sql1, conn.cnn))
                {

                    conn.da = new SqlDataAdapter(conn.cmd);
                    dt = new DataTable();
                    conn.da.Fill(dt);
                }
                newVal = 0;
            }
            //MessageBox.Show(" Stock updated");
        }

        void loadMyData(string proType)
        {
            dt.Rows.Clear();
            //======================================================================================================================
            string sql = "SELECT p.pro_name as Name,p.pro_price as Price,p.pro_stock as Stock FROM tblProducts p";
            sql += " INNER JOIN tblSubProTypes s ON p.SubtoPro_pro_type_id = s.Sub_pro_type_id WHERE s.Sub_pro_type_name ='" + proType + "'";

            //conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);
            // MessageBox.Show(dt.Rows.Count.ToString());

            DGVOrder.DataSource = dt;
        }


        void loadMyData(int ordId)
        {
            dt2.Rows.Clear();
            string sql = "SELECT orderid,productName,quntity,totPrice FROM tblOrderAtoC WHERE IsActive=1 AND orderid=" + OrdId;
           // cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");

            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt2 = new DataTable();
            conn.da.Fill(dt2);

            DGVOrderDetail.DataSource = dt2;

        }
        void mainType()
        {
            dt4.Rows.Clear();
            //======================================================================================================================
            string sql = "select Main_pro_type_name from tblMainProTypes where IsActive=1";
            //======================================================================================================================

            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
           // dt1 = new DataTable();
            conn.da.Fill(dt4);

            cmbMainType.DisplayMember = "Main_pro_type_name";
            cmbMainType.ValueMember = "Main_pro_type_id";
            cmbMainType.DataSource = dt4;
            //subtype = int.Parse(dt2.Rows[0][0].ToString());
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

            Mainpro_type = int.Parse(dt3.Rows[0][0].ToString());
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

            cmbOrdType.ValueMember = "Sub_pro_type_id";
            cmbOrdType.DisplayMember = "Sub_pro_type_name";
            cmbOrdType.DataSource = dt1;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


           
        

        private void btnProClear_Click(object sender, EventArgs e)
        {
            cmbOrdQuntity.Value = 0;
            lblOrdPrice.Text = "Price : ";
            lblProductName.Text = "Product Name: ";
           // dt.Rows.Clear();
        }


        

        private void DGVOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbOrdQuntity.Value = 1;
            lblProductName.Text = "Product Name: " + DGVOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
              lblOrdPrice.Text = "Price: " + DGVOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            pos = e.RowIndex;
            maxStock = int.Parse(DGVOrder.Rows[e.RowIndex].Cells[2].Value.ToString());
            val = int.Parse(DGVOrder.Rows[pos].Cells[1].Value.ToString());
            newval = int.Parse(DGVOrder.Rows[pos].Cells[1].Value.ToString());
        }
        private void DGVOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            qun = int.Parse(DGVOrderDetail.Rows[e.RowIndex].Cells[2].Value.ToString());
            name = DGVOrderDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnRemove.Enabled = true;
        }



        private void ucOrder_Load(object sender, EventArgs e)
        {
            mainType();
            DGVOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdId = GetLastOrderId() + 1;

            
        }
        private void cmbOrdQuntity_ValueChanged(object sender, EventArgs e)
        {
          
            if (maxStock >= cmbOrdQuntity.Value)
            {
               
                 
                newval = val * int.Parse(cmbOrdQuntity.Value.ToString()); ;
                lblOrdPrice.Text = "Price:  " + newval.ToString();

            }
            else
            {
                MessageBox.Show(" There is No enough stock!!!");
                cmbOrdQuntity.Value = maxStock;
            }
        }

        private void btnOrdAtoC_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DGVOrder.Rows[pos].Cells[0].Value.ToString());
            string sql = "insert into tblOrderAtoC Values(@OrdId,@proName,@quntity,@totPrice,@acti,@date)";

            using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {
                conn.cmd.Parameters.AddWithValue("@OrdId", OrdId);

                //***** ADD CUTOMER ID dynimicly*****//


                conn.cmd.Parameters.AddWithValue("@proName", DGVOrder.Rows[pos].Cells[0].Value.ToString());
                conn.cmd.Parameters.AddWithValue("@quntity", cmbOrdQuntity.Value);
                conn.cmd.Parameters.AddWithValue("@totPrice", newval);
                conn.cmd.Parameters.AddWithValue("@acti", "true");
                conn.cmd.Parameters.AddWithValue("@date", date);


                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                //MessageBox.Show("inserted");
                loadMyData(OrdId);
            }
                //FOR FINAL AMOUNT
                //          
                totval = 0;
                for (int i = 0; i < dt2.Rows.Count; i++)
                {


                    totval = totval + int.Parse(DGVOrderDetail.Rows[i].Cells[3].Value.ToString()); ;
                    lblOrdTotalPrice.Text = "Total Price : " + totval;


                }
                //  AMOUNT TO PAY
                lblOrdAmtToPay.Text = "Amount To Pay :  " + totval;
                noOrd += 1;
              
            }

        private void btnOrdPlaceOrder_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == "")
            {
                MessageBox.Show("Fill the Fileds!!");
                return;
            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
           
            //==========================================================================================
            //==============================        INSERTING STOCK TO Order    ================================
            //==========================================================================================

            //string sql = "insert into tblOrderDetail select  orderId,customer_id,productName,quntity,totPrice,IsActive,OrdDate from tblOrderAtoC where IsActive=1 And orderId=" + OrdId;

            //using (cmd = new SqlCommand(sql, cnn))
            //{


            //    da = new SqlDataAdapter(cmd);
            //    dt = new DataTable();
            //    da.Fill(dt);

            //}
            string sql = @"INSERT INTO tblOrderDetail
               (orderId, customer_id, productName, quntity, totPrice, IsActive, OrdDate)
               SELECT orderId, @customer_id, productName, quntity, totPrice, IsActive, OrdDate
               FROM tblOrderAtoC
               WHERE IsActive = 1 AND orderId = @OrdId";

            using (SqlCommand cmd = new SqlCommand(sql, conn.cnn))
            {
                cmd.Parameters.AddWithValue("@customer_id", txtCustName.Text); // from textbox
                cmd.Parameters.AddWithValue("@OrdId", OrdId);          // from textbox

                conn.cnn.Open();
                cmd.ExecuteNonQuery();
                conn.cnn.Close();
            }

            //==========================================================================================
            //============================   inserting into tblSalesReport  ============================
            //==========================================================================================

            sql = "INSERT INTO tblSalesReport (CustomerName, proName, proPrice, proQuntity, totPrice , ByDate,IsActive) SELECT customer_id,productName,totPrice / quntity,quntity,totPrice,OrdDate,IsActive FROM tblOrderDetail where Orderid=" + OrdId;
            using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {


                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);

            }
        
            //==========================================================================================
            //==============================        UPDATEING STOCK     ================================
            //==========================================================================================

                    updateStock();
           

                    MessageBox.Show("order Palced!!");
                    lblOrdTotalPrice.Text = "Total Price :  PAID!!";
                    lblOrdAmtToPay.Text = "Amount To Pay :  PAID!!";

                    totval = 0;
                    noOrd = 0;
                    loadSubType(Mainpro_type);
            //==========================================================================================
            //==============================   DELETING STOCK FRO A TO C    ============================
            //==========================================================================================
                    frmReport rp = new frmReport();
                    rp.Show();

             sql = "Delete from tblOrderAtoC where orderid=" + OrdId;
          //conn.  cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
          using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {

                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);

                        OrdId += 1;
            
        }
        }
        
        private void cmbOrdType_SelectedIndexChanged(object sender, EventArgs e)
        {
           loadMyData(cmbOrdType.Text);
        }

        private void btnOrdReceipt_Click(object sender, EventArgs e)
        {
          

            
               
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sql1 = "Delete tblOrderAtoC where productName='" + name + "'";
           // conn.cnn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True");
            using (conn.cmd = new SqlCommand(sql1, conn.cnn))
            {

                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();

                conn.da.Fill(dt);
                //MessageBox.Show(name + " -- " + qun+"\n deleted");
                loadMyData(OrdId);
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

        private void txtProSearch_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
                 //string sql = "SELECT p.pro_name as Name,p.pro_price as Price,p.pro_stock as Stock FROM tblProducts p";
            //sql += " INNER JOIN tblSubProTypes s 
            string sql = "SELECT p.pro_name as Name,pro_price as Price,p.pro_stock as Stocks FROM tblProducts p";
            sql += " JOIN tblSubProTypes pt ON p.SubtoPro_pro_type_id = pt.Sub_pro_type_id";
            sql += " JOIN tblMainProTypes mpt ON pt.MaintoSub_pro_type_id = mpt.Main_pro_type_id WHERE pro_name LIKE '" + txtProSearch.Text.ToString() + "%' AND  p.IsActive=1";

            using (conn.cmd = new SqlCommand(sql, conn.cnn))
            {

                conn.da = new SqlDataAdapter(conn.cmd);
                dt = new DataTable();
                conn.da.Fill(dt);
                DGVOrder.DataSource = dt;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     }
}
