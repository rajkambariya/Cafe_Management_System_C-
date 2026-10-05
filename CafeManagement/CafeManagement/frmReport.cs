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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        public DataTable GetFreshData()
        {
            
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db1;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select productName,quntity,totPrice from tblOrderAtoC where IsActive=1", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        private void frmReport_Load(object sender, EventArgs e)
        {

           BR rpt = new BR();
            rpt.Load(Application.StartupPath + ("@D:\\harsh\\Harsh_Parmar\\7-11-25\\CafeManagement\\CafeManagement\\BR.rpt"));
            rpt.SetDataSource(GetFreshData());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
