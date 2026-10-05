namespace CafeManagement
{
    partial class ucDashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashBordPicBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAvilable = new System.Windows.Forms.Label();
            this.btnDBCHECK = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTO = new System.Windows.Forms.Label();
            this.cmbCout = new System.Windows.Forms.ComboBox();
            this.cmbCin = new System.Windows.Forms.ComboBox();
            this.txtRVSCoutTime = new System.Windows.Forms.TextBox();
            this.txtRVSCinTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DashBordPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashBordPicBox
            // 
            this.DashBordPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBordPicBox.Image = global::CafeManagement.Properties.Resources.dash_img3;
            this.DashBordPicBox.Location = new System.Drawing.Point(0, 0);
            this.DashBordPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.DashBordPicBox.Name = "DashBordPicBox";
            this.DashBordPicBox.Size = new System.Drawing.Size(1189, 813);
            this.DashBordPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DashBordPicBox.TabIndex = 0;
            this.DashBordPicBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(83, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Allottig Time :";
            // 
            // lblAvilable
            // 
            this.lblAvilable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvilable.AutoSize = true;
            this.lblAvilable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAvilable.Location = new System.Drawing.Point(706, 27);
            this.lblAvilable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvilable.Name = "lblAvilable";
            this.lblAvilable.Size = new System.Drawing.Size(113, 29);
            this.lblAvilable.TabIndex = 73;
            this.lblAvilable.Text = "Avilable:";
            // 
            // btnDBCHECK
            // 
            this.btnDBCHECK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDBCHECK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDBCHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBCHECK.Location = new System.Drawing.Point(1068, 0);
            this.btnDBCHECK.Name = "btnDBCHECK";
            this.btnDBCHECK.Size = new System.Drawing.Size(121, 79);
            this.btnDBCHECK.TabIndex = 74;
            this.btnDBCHECK.Text = "CHECK";
            this.btnDBCHECK.UseVisualStyleBackColor = false;
            this.btnDBCHECK.Click += new System.EventHandler(this.btnDBCHECK_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 28);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // lblTO
            // 
            this.lblTO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTO.AutoSize = true;
            this.lblTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTO.Location = new System.Drawing.Point(584, 27);
            this.lblTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTO.Name = "lblTO";
            this.lblTO.Size = new System.Drawing.Size(42, 29);
            this.lblTO.TabIndex = 107;
            this.lblTO.Text = " to";
            // 
            // cmbCout
            // 
            this.cmbCout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCout.FormattingEnabled = true;
            this.cmbCout.Items.AddRange(new object[] {
            "pm",
            "am"});
            this.cmbCout.Location = new System.Drawing.Point(633, 40);
            this.cmbCout.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCout.Name = "cmbCout";
            this.cmbCout.Size = new System.Drawing.Size(68, 37);
            this.cmbCout.TabIndex = 106;
            // 
            // cmbCin
            // 
            this.cmbCin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCin.FormattingEnabled = true;
            this.cmbCin.Items.AddRange(new object[] {
            "pm",
            "am"});
            this.cmbCin.Location = new System.Drawing.Point(506, 40);
            this.cmbCin.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCin.Name = "cmbCin";
            this.cmbCin.Size = new System.Drawing.Size(65, 37);
            this.cmbCin.TabIndex = 105;
            // 
            // txtRVSCoutTime
            // 
            this.txtRVSCoutTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRVSCoutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRVSCoutTime.Location = new System.Drawing.Point(633, 4);
            this.txtRVSCoutTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRVSCoutTime.Name = "txtRVSCoutTime";
            this.txtRVSCoutTime.Size = new System.Drawing.Size(62, 30);
            this.txtRVSCoutTime.TabIndex = 104;
            // 
            // txtRVSCinTime
            // 
            this.txtRVSCinTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRVSCinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRVSCinTime.Location = new System.Drawing.Point(506, 4);
            this.txtRVSCinTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRVSCinTime.Name = "txtRVSCinTime";
            this.txtRVSCinTime.Size = new System.Drawing.Size(62, 30);
            this.txtRVSCinTime.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txtRVSCinTime);
            this.panel1.Controls.Add(this.lblTO);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbCout);
            this.panel1.Controls.Add(this.lblAvilable);
            this.panel1.Controls.Add(this.cmbCin);
            this.panel1.Controls.Add(this.btnDBCHECK);
            this.panel1.Controls.Add(this.txtRVSCoutTime);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 79);
            this.panel1.TabIndex = 108;
            // 
            // ucDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DashBordPicBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDashBoard";
            this.Size = new System.Drawing.Size(1189, 813);
            this.Load += new System.EventHandler(this.ucDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DashBordPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DashBordPicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAvilable;
        private System.Windows.Forms.Button btnDBCHECK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTO;
        private System.Windows.Forms.ComboBox cmbCout;
        private System.Windows.Forms.ComboBox cmbCin;
        private System.Windows.Forms.TextBox txtRVSCoutTime;
        private System.Windows.Forms.TextBox txtRVSCinTime;
        private System.Windows.Forms.Panel panel1;
    }
}
