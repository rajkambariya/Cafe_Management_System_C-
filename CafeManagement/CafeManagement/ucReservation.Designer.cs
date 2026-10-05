namespace CafeManagement
{
    partial class ucReservation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRVSCname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVRVS = new System.Windows.Forms.DataGridView();
            this.tblreservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRvsgustes = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRVSCinTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAVltable = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRvsClear = new System.Windows.Forms.Button();
            this.btnRvsCancel = new System.Windows.Forms.Button();
            this.btnRvsUpdate = new System.Windows.Forms.Button();
            this.btnRvsAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRvsId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRvsIDshow = new System.Windows.Forms.Button();
            this.lblTblAlloted = new System.Windows.Forms.Label();
            this.btnAvlTable = new System.Windows.Forms.Button();
            this.chkRvs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRVSCoutTime = new System.Windows.Forms.TextBox();
            this.cmbCin = new System.Windows.Forms.ComboBox();
            this.cmbCout = new System.Windows.Forms.ComboBox();
            this.lblTO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRvsgustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRVSCname
            // 
            this.txtRVSCname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRVSCname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRVSCname.Location = new System.Drawing.Point(420, 350);
            this.txtRVSCname.Margin = new System.Windows.Forms.Padding(4);
            this.txtRVSCname.Name = "txtRVSCname";
            this.txtRVSCname.Size = new System.Drawing.Size(120, 30);
            this.txtRVSCname.TabIndex = 70;
            this.txtRVSCname.TextChanged += new System.EventHandler(this.txtRVSCname_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(432, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 69;
            this.label5.Text = "Name :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DGVRVS
            // 
            this.DGVRVS.AllowUserToAddRows = false;
            this.DGVRVS.AllowUserToDeleteRows = false;
            this.DGVRVS.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRVS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRVS.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRVS.Location = new System.Drawing.Point(268, 10);
            this.DGVRVS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVRVS.Name = "DGVRVS";
            this.DGVRVS.ReadOnly = true;
            this.DGVRVS.RowHeadersVisible = false;
            this.DGVRVS.RowTemplate.Height = 24;
            this.DGVRVS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRVS.Size = new System.Drawing.Size(1003, 251);
            this.DGVRVS.TabIndex = 71;
            this.DGVRVS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRVS_CellContentClick);
            this.DGVRVS.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRVS_CellEnter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(295, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 72;
            this.label1.Text = "Guests :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbRvsgustes
            // 
            this.cmbRvsgustes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRvsgustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRvsgustes.Location = new System.Drawing.Point(420, 400);
            this.cmbRvsgustes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRvsgustes.Name = "cmbRvsgustes";
            this.cmbRvsgustes.Size = new System.Drawing.Size(120, 34);
            this.cmbRvsgustes.TabIndex = 73;
            this.cmbRvsgustes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbRvsgustes.ValueChanged += new System.EventHandler(this.cmbRvsgustes_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(882, 403);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 76;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(730, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = " Rvs Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtRVSCinTime
            // 
            this.txtRVSCinTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRVSCinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRVSCinTime.Location = new System.Drawing.Point(872, 453);
            this.txtRVSCinTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRVSCinTime.MaxLength = 2;
            this.txtRVSCinTime.Name = "txtRVSCinTime";
            this.txtRVSCinTime.Size = new System.Drawing.Size(56, 30);
            this.txtRVSCinTime.TabIndex = 78;
            this.txtRVSCinTime.TextChanged += new System.EventHandler(this.txtRVSCinTime_TextChanged);
            this.txtRVSCinTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRVSCinTime_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(776, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 77;
            this.label2.Text = "Time :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbAVltable
            // 
            this.cmbAVltable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAVltable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAVltable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAVltable.FormattingEnabled = true;
            this.cmbAVltable.Location = new System.Drawing.Point(417, 498);
            this.cmbAVltable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAVltable.Name = "cmbAVltable";
            this.cmbAVltable.Size = new System.Drawing.Size(121, 37);
            this.cmbAVltable.TabIndex = 82;
            this.cmbAVltable.SelectedIndexChanged += new System.EventHandler(this.cmbAVltable_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(196, 502);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 29);
            this.label6.TabIndex = 83;
            this.label6.Text = "Available Table:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnRvsClear
            // 
            this.btnRvsClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRvsClear.BackColor = System.Drawing.Color.Gray;
            this.btnRvsClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRvsClear.ForeColor = System.Drawing.Color.Black;
            this.btnRvsClear.Location = new System.Drawing.Point(713, 612);
            this.btnRvsClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnRvsClear.Name = "btnRvsClear";
            this.btnRvsClear.Size = new System.Drawing.Size(235, 68);
            this.btnRvsClear.TabIndex = 87;
            this.btnRvsClear.Text = "Clear";
            this.btnRvsClear.UseVisualStyleBackColor = false;
            this.btnRvsClear.Click += new System.EventHandler(this.btnRvsClear_Click);
            // 
            // btnRvsCancel
            // 
            this.btnRvsCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRvsCancel.BackColor = System.Drawing.Color.Gray;
            this.btnRvsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRvsCancel.ForeColor = System.Drawing.Color.Black;
            this.btnRvsCancel.Location = new System.Drawing.Point(973, 612);
            this.btnRvsCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnRvsCancel.Name = "btnRvsCancel";
            this.btnRvsCancel.Size = new System.Drawing.Size(257, 68);
            this.btnRvsCancel.TabIndex = 86;
            this.btnRvsCancel.Text = "Check Out";
            this.btnRvsCancel.UseVisualStyleBackColor = false;
            this.btnRvsCancel.Click += new System.EventHandler(this.btnRvsCancel_Click);
            // 
            // btnRvsUpdate
            // 
            this.btnRvsUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRvsUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnRvsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRvsUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnRvsUpdate.Location = new System.Drawing.Point(437, 612);
            this.btnRvsUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnRvsUpdate.Name = "btnRvsUpdate";
            this.btnRvsUpdate.Size = new System.Drawing.Size(252, 68);
            this.btnRvsUpdate.TabIndex = 85;
            this.btnRvsUpdate.Text = "Update";
            this.btnRvsUpdate.UseVisualStyleBackColor = false;
            this.btnRvsUpdate.Click += new System.EventHandler(this.btnRvsUpdate_Click);
            // 
            // btnRvsAdd
            // 
            this.btnRvsAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRvsAdd.BackColor = System.Drawing.Color.Gray;
            this.btnRvsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRvsAdd.ForeColor = System.Drawing.Color.Black;
            this.btnRvsAdd.Location = new System.Drawing.Point(153, 612);
            this.btnRvsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRvsAdd.Name = "btnRvsAdd";
            this.btnRvsAdd.Size = new System.Drawing.Size(252, 68);
            this.btnRvsAdd.TabIndex = 84;
            this.btnRvsAdd.Text = "Add";
            this.btnRvsAdd.UseVisualStyleBackColor = false;
            this.btnRvsAdd.Click += new System.EventHandler(this.btnRvsAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(745, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(263, 114);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtRvsId
            // 
            this.txtRvsId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRvsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRvsId.Location = new System.Drawing.Point(535, 288);
            this.txtRvsId.Margin = new System.Windows.Forms.Padding(4);
            this.txtRvsId.Name = "txtRvsId";
            this.txtRvsId.Size = new System.Drawing.Size(89, 30);
            this.txtRvsId.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(349, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 89;
            this.label7.Text = "id :";
            // 
            // btnRvsIDshow
            // 
            this.btnRvsIDshow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRvsIDshow.BackColor = System.Drawing.Color.Gray;
            this.btnRvsIDshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRvsIDshow.ForeColor = System.Drawing.Color.Black;
            this.btnRvsIDshow.Location = new System.Drawing.Point(632, 284);
            this.btnRvsIDshow.Margin = new System.Windows.Forms.Padding(4);
            this.btnRvsIDshow.Name = "btnRvsIDshow";
            this.btnRvsIDshow.Size = new System.Drawing.Size(96, 36);
            this.btnRvsIDshow.TabIndex = 91;
            this.btnRvsIDshow.Text = "Show";
            this.btnRvsIDshow.UseVisualStyleBackColor = false;
            this.btnRvsIDshow.Click += new System.EventHandler(this.btnRvsIDshow_Click);
            // 
            // lblTblAlloted
            // 
            this.lblTblAlloted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTblAlloted.AutoSize = true;
            this.lblTblAlloted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTblAlloted.Location = new System.Drawing.Point(223, 452);
            this.lblTblAlloted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTblAlloted.Name = "lblTblAlloted";
            this.lblTblAlloted.Size = new System.Drawing.Size(177, 29);
            this.lblTblAlloted.TabIndex = 93;
            this.lblTblAlloted.Text = "Table Alloted:";
            this.lblTblAlloted.Click += new System.EventHandler(this.lblTblAlloted_Click);
            // 
            // btnAvlTable
            // 
            this.btnAvlTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvlTable.BackColor = System.Drawing.Color.Gray;
            this.btnAvlTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvlTable.ForeColor = System.Drawing.Color.Black;
            this.btnAvlTable.Location = new System.Drawing.Point(1156, 279);
            this.btnAvlTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvlTable.Name = "btnAvlTable";
            this.btnAvlTable.Size = new System.Drawing.Size(115, 36);
            this.btnAvlTable.TabIndex = 94;
            this.btnAvlTable.Text = "Show";
            this.btnAvlTable.UseVisualStyleBackColor = false;
            this.btnAvlTable.Click += new System.EventHandler(this.btnAvlTable_Click);
            // 
            // chkRvs
            // 
            this.chkRvs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkRvs.BackColor = System.Drawing.Color.Gray;
            this.chkRvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRvs.ForeColor = System.Drawing.Color.Black;
            this.chkRvs.Location = new System.Drawing.Point(548, 502);
            this.chkRvs.Margin = new System.Windows.Forms.Padding(4);
            this.chkRvs.Name = "chkRvs";
            this.chkRvs.Size = new System.Drawing.Size(163, 36);
            this.chkRvs.TabIndex = 95;
            this.chkRvs.Text = "check AVl tbl";
            this.chkRvs.UseVisualStyleBackColor = false;
            this.chkRvs.Click += new System.EventHandler(this.chkRvs_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 43);
            this.label3.TabIndex = 96;
            this.label3.Text = "enter customer id to check customer registered or no!!";
            // 
            // txtRVSCoutTime
            // 
            this.txtRVSCoutTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRVSCoutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRVSCoutTime.Location = new System.Drawing.Point(984, 453);
            this.txtRVSCoutTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRVSCoutTime.MaxLength = 2;
            this.txtRVSCoutTime.Name = "txtRVSCoutTime";
            this.txtRVSCoutTime.Size = new System.Drawing.Size(56, 30);
            this.txtRVSCoutTime.TabIndex = 97;
            this.txtRVSCoutTime.TextChanged += new System.EventHandler(this.txtRVSCoutTime_TextChanged);
            this.txtRVSCoutTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRVSCoutTime_KeyPress);
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
            this.cmbCin.Location = new System.Drawing.Point(872, 491);
            this.cmbCin.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCin.Name = "cmbCin";
            this.cmbCin.Size = new System.Drawing.Size(56, 37);
            this.cmbCin.TabIndex = 100;
            this.cmbCin.SelectedIndexChanged += new System.EventHandler(this.cmbCin_SelectedIndexChanged);
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
            this.cmbCout.Location = new System.Drawing.Point(984, 492);
            this.cmbCout.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCout.Name = "cmbCout";
            this.cmbCout.Size = new System.Drawing.Size(56, 37);
            this.cmbCout.TabIndex = 101;
            this.cmbCout.SelectedIndexChanged += new System.EventHandler(this.cmbCout_SelectedIndexChanged);
            // 
            // lblTO
            // 
            this.lblTO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTO.AutoSize = true;
            this.lblTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTO.Location = new System.Drawing.Point(935, 455);
            this.lblTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTO.Name = "lblTO";
            this.lblTO.Size = new System.Drawing.Size(42, 29);
            this.lblTO.TabIndex = 102;
            this.lblTO.Text = " to";
            this.lblTO.Click += new System.EventHandler(this.lblTO_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1245, 612);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 64);
            this.button1.TabIndex = 103;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVRVS);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRvsClear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRvsCancel);
            this.panel1.Controls.Add(this.btnRvsIDshow);
            this.panel1.Controls.Add(this.btnRvsUpdate);
            this.panel1.Controls.Add(this.btnRvsAdd);
            this.panel1.Controls.Add(this.lblTblAlloted);
            this.panel1.Controls.Add(this.txtRvsId);
            this.panel1.Controls.Add(this.btnAvlTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblTO);
            this.panel1.Controls.Add(this.txtRVSCname);
            this.panel1.Controls.Add(this.cmbCout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCin);
            this.panel1.Controls.Add(this.cmbRvsgustes);
            this.panel1.Controls.Add(this.txtRVSCoutTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.chkRvs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRVSCinTime);
            this.panel1.Controls.Add(this.cmbAVltable);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 681);
            this.panel1.TabIndex = 105;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ucReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucReservation";
            this.Size = new System.Drawing.Size(1508, 681);
            this.Load += new System.EventHandler(this.ucReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRvsgustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRVSCname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVRVS;
        private System.Windows.Forms.BindingSource tblreservationBindingSource;
//        
  //      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cmbRvsgustes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtRVSCinTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAVltable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRvsClear;
        private System.Windows.Forms.Button btnRvsCancel;
        private System.Windows.Forms.Button btnRvsUpdate;
        private System.Windows.Forms.Button btnRvsAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRvsId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRvsIDshow;
        private System.Windows.Forms.Label lblTblAlloted;
        private System.Windows.Forms.Button btnAvlTable;
        private System.Windows.Forms.Button chkRvs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRVSCoutTime;
        private System.Windows.Forms.ComboBox cmbCin;
        private System.Windows.Forms.ComboBox cmbCout;
        private System.Windows.Forms.Label lblTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}
