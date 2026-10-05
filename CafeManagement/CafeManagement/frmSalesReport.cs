using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;
namespace CafeManagement
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }
        public DataTable GetFreshData()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter( "SELECT salesId,customerName,proName,proPrice,proQuntity,totPrice,ByDate FROM tblSalesReport", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void frmSalesReport_Load(object sender, EventArgs e)
        {

            SalesReport rpt = new SalesReport();
          // "D:\harsh\13-10-25\CafeManagement\CafeManagement\SalesReport.rpt"
            rpt.Load(Application.StartupPath + ("@D:\\harsh\\13-10-25\\CafeManagement\\CafeManagement\\SalesReport.rpt"));
            rpt.SetDataSource(GetFreshData());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }
    }
}
