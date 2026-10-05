using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace CafeManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new  frmLogin());
        }


    }
    public  class connection
    {
        public string cnstr;
       public SqlConnection cnn;
       public SqlCommand cmd = null;//new SqlCommand();
       public SqlDataAdapter da;
        
        public connection()
        {
            cnstr = "data source=.;initial catalog=db1;integrated security=true";
            cnn = null;
            cmd = null;
            da = null;
        }
        public DataTable get_data(string str)
        {
            cnn = new SqlConnection(cnstr);
            cmd = new SqlCommand(str, cnn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
        public void add_data(string str)
        {
            cnn = new SqlConnection(cnstr);
            cnn.Open();
            cmd = new SqlCommand(str, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public void delete_data(string str)
        {
            cnn = new SqlConnection(cnstr);
            cnn.Open();
            cmd = new SqlCommand(str, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void Update_data(string str)
        {
            cnn = new SqlConnection(cnstr);
            cnn.Open();
            cmd = new SqlCommand(str, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
    }


