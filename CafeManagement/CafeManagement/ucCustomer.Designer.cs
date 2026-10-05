namespace CafeManagement
{
    partial class ucCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAdminSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.CmbCusStatus = new System.Windows.Forms.ComboBox();
            this.txtCustNumb = new System.Windows.Forms.TextBox();
            this.txtCustname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCustClear = new System.Windows.Forms.Button();
            this.btnCustDelete = new System.Windows.Forms.Button();
            this.btnCustUpdate = new System.Windows.Forms.Button();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdminSearch
            // 
            this.txtAdminSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminSearch.Location = new System.Drawing.Point(844, 348);
            this.txtAdminSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdminSearch.Name = "txtAdminSearch";
            this.txtAdminSearch.Size = new System.Drawing.Size(244, 30);
            this.txtAdminSearch.TabIndex = 92;
            this.txtAdminSearch.TextChanged += new System.EventHandler(this.txtAdminSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 29);
            this.label8.TabIndex = 91;
            this.label8.Text = "Customer Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(1299, 96);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AllowUserToAddRows = false;
            this.DGVCustomer.AllowUserToDeleteRows = false;
            this.DGVCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomer.Location = new System.Drawing.Point(0, 0);
            this.DGVCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.ReadOnly = true;
            this.DGVCustomer.RowHeadersVisible = false;
            this.DGVCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustomer.Size = new System.Drawing.Size(1965, 772);
            this.DGVCustomer.TabIndex = 89;
            this.DGVCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            this.DGVCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellEnter);
            // 
            // CmbCusStatus
            // 
            this.CmbCusStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbCusStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCusStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCusStatus.FormattingEnabled = true;
            this.CmbCusStatus.Items.AddRange(new object[] {
            "--SELECET--",
            "True",
            "False"});
            this.CmbCusStatus.Location = new System.Drawing.Point(1299, 150);
            this.CmbCusStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbCusStatus.Name = "CmbCusStatus";
            this.CmbCusStatus.Size = new System.Drawing.Size(244, 33);
            this.CmbCusStatus.TabIndex = 88;
            // 
            // txtCustNumb
            // 
            this.txtCustNumb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustNumb.Location = new System.Drawing.Point(716, 155);
            this.txtCustNumb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustNumb.Name = "txtCustNumb";
            this.txtCustNumb.Size = new System.Drawing.Size(244, 30);
            this.txtCustNumb.TabIndex = 85;
            // 
            // txtCustname
            // 
            this.txtCustname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustname.Location = new System.Drawing.Point(716, 100);
            this.txtCustname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(244, 30);
            this.txtCustname.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1061, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 29);
            this.label6.TabIndex = 83;
            this.label6.Text = "Customer Status: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(969, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 29);
            this.label4.TabIndex = 81;
            this.label4.Text = "Customer RegisterDate : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 29);
            this.label3.TabIndex = 80;
            this.label3.Text = "Customer Contect: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 79;
            this.label2.Text = "Customer Name : ";
            // 
            // btnCustClear
            // 
            this.btnCustClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustClear.BackColor = System.Drawing.Color.Gray;
            this.btnCustClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustClear.ForeColor = System.Drawing.Color.Black;
            this.btnCustClear.Location = new System.Drawing.Point(1012, 239);
            this.btnCustClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustClear.Name = "btnCustClear";
            this.btnCustClear.Size = new System.Drawing.Size(252, 66);
            this.btnCustClear.TabIndex = 96;
            this.btnCustClear.Text = "Clear";
            this.btnCustClear.UseVisualStyleBackColor = false;
            this.btnCustClear.Click += new System.EventHandler(this.btnCustClear_Click);
            // 
            // btnCustDelete
            // 
            this.btnCustDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustDelete.BackColor = System.Drawing.Color.Gray;
            this.btnCustDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustDelete.ForeColor = System.Drawing.Color.Black;
            this.btnCustDelete.Location = new System.Drawing.Point(1296, 239);
            this.btnCustDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustDelete.Name = "btnCustDelete";
            this.btnCustDelete.Size = new System.Drawing.Size(252, 66);
            this.btnCustDelete.TabIndex = 95;
            this.btnCustDelete.Text = "Delete";
            this.btnCustDelete.UseVisualStyleBackColor = false;
            this.btnCustDelete.Click += new System.EventHandler(this.btnCustDelete_Click);
            // 
            // btnCustUpdate
            // 
            this.btnCustUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnCustUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnCustUpdate.Location = new System.Drawing.Point(728, 239);
            this.btnCustUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustUpdate.Name = "btnCustUpdate";
            this.btnCustUpdate.Size = new System.Drawing.Size(252, 66);
            this.btnCustUpdate.TabIndex = 94;
            this.btnCustUpdate.Text = "Edit";
            this.btnCustUpdate.UseVisualStyleBackColor = false;
            this.btnCustUpdate.Click += new System.EventHandler(this.btnCustUpdate_Click);
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustAdd.BackColor = System.Drawing.Color.Gray;
            this.btnCustAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCustAdd.Location = new System.Drawing.Point(444, 239);
            this.btnCustAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(252, 66);
            this.btnCustAdd.TabIndex = 93;
            this.btnCustAdd.Text = "Add";
            this.btnCustAdd.UseVisualStyleBackColor = false;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAdminSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCustClear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCustDelete);
            this.panel1.Controls.Add(this.txtCustname);
            this.panel1.Controls.Add(this.btnCustUpdate);
            this.panel1.Controls.Add(this.txtCustNumb);
            this.panel1.Controls.Add(this.btnCustAdd);
            this.panel1.Controls.Add(this.CmbCusStatus);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1965, 418);
            this.panel1.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 98;
            this.label1.Text = "Customer Detail";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1965, 772);
            this.panel2.TabIndex = 97;
            // 
            // ucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(1965, 1190);
            this.Load += new System.EventHandler(this.ucCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.ComboBox CmbCusStatus;
        private System.Windows.Forms.TextBox txtCustNumb;
        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCustClear;
        private System.Windows.Forms.Button btnCustDelete;
        private System.Windows.Forms.Button btnCustUpdate;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
