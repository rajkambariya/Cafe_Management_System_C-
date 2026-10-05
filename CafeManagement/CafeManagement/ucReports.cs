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
    public partial class ucReports : UserControl
    {
        connection conn;
        public ucReports()
        {
            conn = new connection();
            conn.cnn = new SqlConnection(conn.cnstr);
            InitializeComponent();
        }

      //  SqlDataAdapter da;
        //SqlCommand cmd;
       // SqlConnection cnn;
     //   int pos, maxStock, OrdId, val, totval;
        DataTable dt = new DataTable();
        DateTime date = DateTime.Today;
        void SalseData()
        {
            dt.Rows.Clear();
            string sql = "SELECT salesId,customerName,proName,proPrice,proQuntity,totPrice,ByDate ,IsActive FROM tblSalesReport";

            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);

            DGVallReports.DataSource = dt;

        }
        void SalseData(String date)
        {
            dt.Rows.Clear();
            string sql = "SELECT salesId,customerName,proName,proPrice,proQuntity,totPrice,ByDate,IsActive FROM tblSalesReport WHERE ByDate='" + date + "'";
 
            conn.cmd = new SqlCommand(sql, conn.cnn);
            conn.da = new SqlDataAdapter(conn.cmd);
            dt = new DataTable();
            conn.da.Fill(dt);

            DGVallReports.DataSource = dt;

        }
       
     

        private void btnProAdd_Click(object sender, EventArgs e)
        {
            DGVallReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalseData();
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SalseData(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            frmSalesReport frm = new frmSalesReport();
            frm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DGVallReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
