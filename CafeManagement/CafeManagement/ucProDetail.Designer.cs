namespace CafeManagement
{
    partial class ucProDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.DGVProDetail = new System.Windows.Forms.DataGridView();
            this.btnProDetailShow = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbMainType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProUpdate = new System.Windows.Forms.Button();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProductStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProAdd
            // 
            this.btnProAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProAdd.BackColor = System.Drawing.Color.Gray;
            this.btnProAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProAdd.ForeColor = System.Drawing.Color.Black;
            this.btnProAdd.Location = new System.Drawing.Point(168, 246);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(192, 47);
            this.btnProAdd.TabIndex = 37;
            this.btnProAdd.Text = "Add";
            this.btnProAdd.UseVisualStyleBackColor = false;
            this.btnProAdd.Click += new System.EventHandler(this.btnProAdd_Click_1);
            // 
            // DGVProDetail
            // 
            this.DGVProDetail.AllowUserToAddRows = false;
            this.DGVProDetail.AllowUserToDeleteRows = false;
            this.DGVProDetail.BackgroundColor = System.Drawing.Color.White;
            this.DGVProDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVProDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProDetail.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVProDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProDetail.Location = new System.Drawing.Point(0, 0);
            this.DGVProDetail.Name = "DGVProDetail";
            this.DGVProDetail.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVProDetail.RowHeadersVisible = false;
            this.DGVProDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProDetail.Size = new System.Drawing.Size(1180, 375);
            this.DGVProDetail.TabIndex = 53;
            this.DGVProDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProDetail_CellContentClick_1);
            this.DGVProDetail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProDetail_CellEnter);
            this.DGVProDetail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVProDetail_CellMouseClick);
            // 
            // btnProDetailShow
            // 
            this.btnProDetailShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProDetailShow.BackColor = System.Drawing.Color.Gray;
            this.btnProDetailShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProDetailShow.ForeColor = System.Drawing.Color.Black;
            this.btnProDetailShow.Location = new System.Drawing.Point(927, 169);
            this.btnProDetailShow.Name = "btnProDetailShow";
            this.btnProDetailShow.Size = new System.Drawing.Size(112, 68);
            this.btnProDetailShow.TabIndex = 59;
            this.btnProDetailShow.Text = "Show";
            this.btnProDetailShow.UseVisualStyleBackColor = false;
            this.btnProDetailShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 60;
            this.label8.Text = "Product Name:";
            // 
            // txtProSearch
            // 
            this.txtProSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProSearch.Location = new System.Drawing.Point(414, 317);
            this.txtProSearch.Name = "txtProSearch";
            this.txtProSearch.Size = new System.Drawing.Size(399, 24);
            this.txtProSearch.TabIndex = 61;
            this.txtProSearch.TextChanged += new System.EventHandler(this.txtProSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 751);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGVProDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1180, 375);
            this.panel3.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtProSearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnProDetailShow);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.cmbMainType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnProClear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnProDelete);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnProUpdate);
            this.panel2.Controls.Add(this.btnProAdd);
            this.panel2.Controls.Add(this.txtProductStock);
            this.panel2.Controls.Add(this.txtProductPrice);
            this.panel2.Controls.Add(this.cmbProductType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbProductStatus);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 374);
            this.panel2.TabIndex = 64;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Product Data";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "Product Type:";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(376, 99);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 24);
            this.txtProductName.TabIndex = 48;
            // 
            // cmbMainType
            // 
            this.cmbMainType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainType.FormattingEnabled = true;
            this.cmbMainType.Items.AddRange(new object[] {
            "--SELECT--"});
            this.cmbMainType.Location = new System.Drawing.Point(376, 169);
            this.cmbMainType.Name = "cmbMainType";
            this.cmbMainType.Size = new System.Drawing.Size(184, 25);
            this.cmbMainType.TabIndex = 62;
            this.cmbMainType.SelectedIndexChanged += new System.EventHandler(this.cmbMainType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Product Name:";
            // 
            // btnProClear
            // 
            this.btnProClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProClear.BackColor = System.Drawing.Color.Gray;
            this.btnProClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProClear.ForeColor = System.Drawing.Color.Black;
            this.btnProClear.Location = new System.Drawing.Point(608, 246);
            this.btnProClear.Name = "btnProClear";
            this.btnProClear.Size = new System.Drawing.Size(192, 47);
            this.btnProClear.TabIndex = 40;
            this.btnProClear.Text = "Clear";
            this.btnProClear.UseVisualStyleBackColor = false;
            this.btnProClear.Click += new System.EventHandler(this.btnProClear_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Main Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProDelete
            // 
            this.btnProDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProDelete.BackColor = System.Drawing.Color.Gray;
            this.btnProDelete.Enabled = false;
            this.btnProDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProDelete.ForeColor = System.Drawing.Color.Black;
            this.btnProDelete.Location = new System.Drawing.Point(828, 246);
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.Size = new System.Drawing.Size(192, 47);
            this.btnProDelete.TabIndex = 39;
            this.btnProDelete.Text = "Delete";
            this.btnProDelete.UseVisualStyleBackColor = false;
            this.btnProDelete.Click += new System.EventHandler(this.btnProDelete_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(634, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = " Stock:";
            // 
            // btnProUpdate
            // 
            this.btnProUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnProUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnProUpdate.Location = new System.Drawing.Point(388, 246);
            this.btnProUpdate.Name = "btnProUpdate";
            this.btnProUpdate.Size = new System.Drawing.Size(192, 47);
            this.btnProUpdate.TabIndex = 38;
            this.btnProUpdate.Text = "Edit";
            this.btnProUpdate.UseVisualStyleBackColor = false;
            this.btnProUpdate.Click += new System.EventHandler(this.btnProUpdate_Click_1);
            // 
            // txtProductStock
            // 
            this.txtProductStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductStock.Location = new System.Drawing.Point(723, 101);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(184, 24);
            this.txtProductStock.TabIndex = 49;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(376, 129);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(183, 24);
            this.txtProductPrice.TabIndex = 50;
            // 
            // cmbProductType
            // 
            this.cmbProductType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "--SELECT--"});
            this.cmbProductType.Location = new System.Drawing.Point(723, 170);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(184, 25);
            this.cmbProductType.TabIndex = 51;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(630, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = " Status:";
            // 
            // cmbProductStatus
            // 
            this.cmbProductStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductStatus.FormattingEnabled = true;
            this.cmbProductStatus.Items.AddRange(new object[] {
            "--SELECT--",
            "True",
            "False"});
            this.cmbProductStatus.Location = new System.Drawing.Point(723, 134);
            this.cmbProductStatus.Name = "cmbProductStatus";
            this.cmbProductStatus.Size = new System.Drawing.Size(184, 25);
            this.cmbProductStatus.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(295, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Price:";
            // 
            // ucProDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucProDetail";
            this.Size = new System.Drawing.Size(1182, 751);
            this.Load += new System.EventHandler(this.ucProDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private db1DataSet1 db1DataSet1;
        //private db1DataSet1TableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn protypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.DataGridView DGVProDetail;
        private System.Windows.Forms.Button btnProDetailShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbMainType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProUpdate;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductStatus;
        private System.Windows.Forms.Label label5;



    }
}
