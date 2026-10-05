using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

            ucReservation1.Hide();
            ucOrder1.Hide();
            ucProDetail1.Hide();
            ucAdminSec1.Hide();
            ucDashBoard1.Show();
            ucReports1.Hide();
           
            ucCustomer1.Hide();
         //   ucAddProType1.Hide();
            if (Class1.roll == true)
            { 
            
                btnAdminSec.Enabled = true;
            }
            else
            {
                btnAdminSec.Enabled = false;
            }

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

            ucReservation1.Hide();

          //  ucAddProType1.Hide(); 
            ucDashBoard1.Show();
            ucAdminSec1.Hide();
            ucCustomer1.Hide();
            ucOrder1.Hide();
            ucProDetail1.Hide();
            ucReports1.Hide();
        }

        private void btnProDetail_Click(object sender, EventArgs e)
        {
            ucReservation1.Hide(); 
            ucProDetail1.Show();
            ucAdminSec1.Hide();
           // ucAddProType1.Hide();
            ucCustomer1.Hide();
            ucDashBoard1.Hide();
            ucReports1.Hide();
            ucOrder1.Hide();
           

        }

        private void btnOrdDetail_Click(object sender, EventArgs e)
        {
      
            ucDashBoard1.Hide();
            ucAdminSec1.Hide();
            ucCustomer1.Hide();
          //  ucAddProType1.Hide();
            ucReservation1.Hide(); 
            ucOrder1.Show();
            ucProDetail1.Hide();
            ucReports1.Hide();
           
        }

        private void btnStaffDetail_Click(object sender, EventArgs e)
        {
            if (Class1.roll == true)
            {
                ucAdminSec1.Show();
                ucOrder1.Hide();
                ucReports1.Hide();
                ucReservation1.Hide(); 
                ucProDetail1.Hide();
       
                ucCustomer1.Hide();            
                ucDashBoard1.Hide();

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            ucDashBoard1.Hide();
            ucAdminSec1.Hide();
            ucOrder1.Hide();
            ucProDetail1.Hide();
            ucReports1.Show();
            ucCustomer1.Hide();
            ucReservation1.Hide();
            //ucAddProType1.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ucDashBoard1.Hide();
            ucAdminSec1.Hide();
            ucOrder1.Hide();
            ucProDetail1.Hide();
          //  ucAddProType1.Hide();
            ucReports1.Hide();
            ucReservation1.Hide();
            ucCustomer1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void log_exit_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are you sure you want to exit!", "information message", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
                      
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            DialogResult check = MessageBox.Show("Are you sure you want to LOG OUT!", "information message", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {

                frmLogin f1 = new frmLogin();
                f1.Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ucProDetail1_Load(object sender, EventArgs e)
        {

        }

        private void ucReports1_Load(object sender, EventArgs e)
        {

        }

        private void ucProDetail1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucDashBoard1.Hide();
            ucCustomer1.Hide();
            ucReservation1.Show();
            ucAdminSec1.Hide();
            ucOrder1.Hide();
            ucProDetail1.Hide();
            ucReports1.Hide();
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void log_exit_MouseHover(object sender, EventArgs e)
        {
            log_exit.BackColor = Color.Red;
        }

        private void log_exit_MouseLeave(object sender, EventArgs e)
        {
            log_exit.BackColor = Color.White;
        }
    }
}
