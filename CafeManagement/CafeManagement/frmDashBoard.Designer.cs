namespace CafeManagement
{
    partial class frmDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.log_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnAdminSec = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOrdDetail = new System.Windows.Forms.Button();
            this.btnProDetail = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucCustomer1 = new CafeManagement.ucCustomer();
            this.ucAdminSec1 = new CafeManagement.ucAdminSec();
            this.ucReservation1 = new CafeManagement.ucReservation();
            this.ucReports1 = new CafeManagement.ucReports();
            this.ucProDetail1 = new CafeManagement.ucProDetail();
            this.ucOrder1 = new CafeManagement.ucOrder();
            this.ucDashBoard1 = new CafeManagement.ucDashBoard();
            this.adminDashBoardUc1 = new CafeManagement.AdminDashBoardUc();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.adminDashBoardUc1);
            this.panel1.Controls.Add(this.log_exit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1558, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // log_exit
            // 
            this.log_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.log_exit.AutoSize = true;
            this.log_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_exit.Location = new System.Drawing.Point(1515, 3);
            this.log_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.log_exit.Name = "log_exit";
            this.log_exit.Size = new System.Drawing.Size(33, 31);
            this.log_exit.TabIndex = 20;
            this.log_exit.Text = "X";
            this.log_exit.Click += new System.EventHandler(this.log_exit_Click);
            this.log_exit.MouseLeave += new System.EventHandler(this.log_exit_MouseLeave);
            this.log_exit.MouseHover += new System.EventHandler(this.log_exit_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cafe For High\'s";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnReservation);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnAdminSec);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnOrdDetail);
            this.panel2.Controls.Add(this.btnProDetail);
            this.panel2.Controls.Add(this.btnDashBoard);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 956);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.Gray;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.Black;
            this.btnReservation.Location = new System.Drawing.Point(12, 704);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(260, 65);
            this.btnReservation.TabIndex = 20;
            this.btnReservation.Text = "RESERVATION";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogOut.BackColor = System.Drawing.Color.Gray;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(13, 905);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(260, 48);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Gray;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Location = new System.Drawing.Point(12, 627);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(260, 65);
            this.btnCustomer.TabIndex = 18;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnAdminSec
            // 
            this.btnAdminSec.BackColor = System.Drawing.Color.Gray;
            this.btnAdminSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSec.ForeColor = System.Drawing.Color.Black;
            this.btnAdminSec.Location = new System.Drawing.Point(13, 473);
            this.btnAdminSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminSec.Name = "btnAdminSec";
            this.btnAdminSec.Size = new System.Drawing.Size(260, 65);
            this.btnAdminSec.TabIndex = 16;
            this.btnAdminSec.Text = "ADMIN SECTION";
            this.btnAdminSec.UseVisualStyleBackColor = false;
            this.btnAdminSec.Click += new System.EventHandler(this.btnStaffDetail_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gray;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(12, 550);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(260, 65);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "SALES REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOrdDetail
            // 
            this.btnOrdDetail.BackColor = System.Drawing.Color.Gray;
            this.btnOrdDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdDetail.ForeColor = System.Drawing.Color.Black;
            this.btnOrdDetail.Location = new System.Drawing.Point(13, 396);
            this.btnOrdDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdDetail.Name = "btnOrdDetail";
            this.btnOrdDetail.Size = new System.Drawing.Size(260, 65);
            this.btnOrdDetail.TabIndex = 15;
            this.btnOrdDetail.Text = "ORDER";
            this.btnOrdDetail.UseVisualStyleBackColor = false;
            this.btnOrdDetail.Click += new System.EventHandler(this.btnOrdDetail_Click);
            // 
            // btnProDetail
            // 
            this.btnProDetail.BackColor = System.Drawing.Color.Gray;
            this.btnProDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProDetail.ForeColor = System.Drawing.Color.Black;
            this.btnProDetail.Location = new System.Drawing.Point(13, 319);
            this.btnProDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnProDetail.Name = "btnProDetail";
            this.btnProDetail.Size = new System.Drawing.Size(260, 65);
            this.btnProDetail.TabIndex = 14;
            this.btnProDetail.Text = "PRODUCT Mng.";
            this.btnProDetail.UseVisualStyleBackColor = false;
            this.btnProDetail.Click += new System.EventHandler(this.btnProDetail_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.Gray;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoard.Location = new System.Drawing.Point(13, 242);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(260, 65);
            this.btnDashBoard.TabIndex = 13;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cafe For High\'s";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagement.Properties.Resources.cafe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 135);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ucCustomer1
            // 
            this.ucCustomer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomer1.Location = new System.Drawing.Point(291, 40);
            this.ucCustomer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucCustomer1.Name = "ucCustomer1";
            this.ucCustomer1.Size = new System.Drawing.Size(1267, 956);
            this.ucCustomer1.TabIndex = 10;
            this.ucCustomer1.Visible = false;
            // 
            // ucAdminSec1
            // 
            this.ucAdminSec1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminSec1.Location = new System.Drawing.Point(291, 40);
            this.ucAdminSec1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucAdminSec1.Name = "ucAdminSec1";
            this.ucAdminSec1.Size = new System.Drawing.Size(1267, 956);
            this.ucAdminSec1.TabIndex = 9;
            this.ucAdminSec1.Visible = false;
            // 
            // ucReservation1
            // 
            this.ucReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReservation1.Location = new System.Drawing.Point(291, 40);
            this.ucReservation1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucReservation1.Name = "ucReservation1";
            this.ucReservation1.Size = new System.Drawing.Size(1267, 956);
            this.ucReservation1.TabIndex = 7;
            this.ucReservation1.Visible = false;
            // 
            // ucReports1
            // 
            this.ucReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReports1.Location = new System.Drawing.Point(291, 40);
            this.ucReports1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(1267, 956);
            this.ucReports1.TabIndex = 5;
            this.ucReports1.Visible = false;
            // 
            // ucProDetail1
            // 
            this.ucProDetail1.BackColor = System.Drawing.Color.White;
            this.ucProDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProDetail1.Location = new System.Drawing.Point(291, 40);
            this.ucProDetail1.Margin = new System.Windows.Forms.Padding(5);
            this.ucProDetail1.Name = "ucProDetail1";
            this.ucProDetail1.Size = new System.Drawing.Size(1267, 956);
            this.ucProDetail1.TabIndex = 4;
            // 
            // ucOrder1
            // 
            this.ucOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrder1.Location = new System.Drawing.Point(291, 40);
            this.ucOrder1.Margin = new System.Windows.Forms.Padding(5);
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1267, 956);
            this.ucOrder1.TabIndex = 3;
            this.ucOrder1.Visible = false;
            // 
            // ucDashBoard1
            // 
            this.ucDashBoard1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucDashBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDashBoard1.Location = new System.Drawing.Point(291, 40);
            this.ucDashBoard1.Margin = new System.Windows.Forms.Padding(5);
            this.ucDashBoard1.Name = "ucDashBoard1";
            this.ucDashBoard1.Size = new System.Drawing.Size(1267, 956);
            this.ucDashBoard1.TabIndex = 2;
            this.ucDashBoard1.Visible = false;
            // 
            // adminDashBoardUc1
            // 
            this.adminDashBoardUc1.Location = new System.Drawing.Point(431, 23);
            this.adminDashBoardUc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminDashBoardUc1.Name = "adminDashBoardUc1";
            this.adminDashBoardUc1.Size = new System.Drawing.Size(641, 391);
            this.adminDashBoardUc1.TabIndex = 21;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1558, 996);
            this.Controls.Add(this.ucCustomer1);
            this.Controls.Add(this.ucAdminSec1);
            this.Controls.Add(this.ucReservation1);
            this.Controls.Add(this.ucReports1);
            this.Controls.Add(this.ucProDetail1);
            this.Controls.Add(this.ucOrder1);
            this.Controls.Add(this.ucDashBoard1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnOrdDetail;
        private System.Windows.Forms.Button btnProDetail;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnAdminSec;
        private System.Windows.Forms.Label log_exit;
        private ucDashBoard ucDashBoard1;
        private ucOrder ucOrder1;
        private ucProDetail ucProDetail1;
        private ucReports ucReports1;
        private System.Windows.Forms.Button btnReservation;
        private AdminDashBoardUc adminDashBoardUc1;
        private ucReservation ucReservation1;
        private ucAdminSec ucAdminSec1;
        private ucCustomer ucCustomer1;
    }
}