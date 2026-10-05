namespace CafeManagement
{
    partial class ucOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVOrder = new System.Windows.Forms.DataGridView();
            this.cmbOrdType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdClear = new System.Windows.Forms.Button();
            this.btnOrdPlaceOrder = new System.Windows.Forms.Button();
            this.btnOrdAtoC = new System.Windows.Forms.Button();
            this.cmbOrdQuntity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblOrdPrice = new System.Windows.Forms.Label();
            this.DGVOrderDetail = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOrderAtoCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db1DataSet6 = new CafeManagement.db1DataSet6();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOrdAmtToPay = new System.Windows.Forms.Label();
            this.lblOrdTotalPrice = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tblOrderAtoCTableAdapter = new CafeManagement.db1DataSet6TableAdapters.tblOrderAtoCTableAdapter();
            this.cmbMainType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdQuntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderAtoCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "Order ";
            // 
            // DGVOrder
            // 
            this.DGVOrder.AllowUserToAddRows = false;
            this.DGVOrder.AllowUserToDeleteRows = false;
            this.DGVOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVOrder.DefaultCellStyle = dataGridViewCellStyle20;
            this.DGVOrder.Location = new System.Drawing.Point(137, 181);
            this.DGVOrder.Name = "DGVOrder";
            this.DGVOrder.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DGVOrder.RowHeadersVisible = false;
            this.DGVOrder.Size = new System.Drawing.Size(402, 152);
            this.DGVOrder.TabIndex = 53;
            this.DGVOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrder_CellContentClick);
            // 
            // cmbOrdType
            // 
            this.cmbOrdType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOrdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdType.FormattingEnabled = true;
            this.cmbOrdType.Location = new System.Drawing.Point(331, 102);
            this.cmbOrdType.Name = "cmbOrdType";
            this.cmbOrdType.Size = new System.Drawing.Size(186, 30);
            this.cmbOrdType.TabIndex = 51;
            this.cmbOrdType.SelectedIndexChanged += new System.EventHandler(this.cmbOrdType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Product Type:";
            // 
            // btnOrdClear
            // 
            this.btnOrdClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrdClear.BackColor = System.Drawing.Color.Gray;
            this.btnOrdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdClear.ForeColor = System.Drawing.Color.Black;
            this.btnOrdClear.Location = new System.Drawing.Point(310, 497);
            this.btnOrdClear.Name = "btnOrdClear";
            this.btnOrdClear.Size = new System.Drawing.Size(176, 55);
            this.btnOrdClear.TabIndex = 40;
            this.btnOrdClear.Text = "CLEAR";
            this.btnOrdClear.UseVisualStyleBackColor = false;
            this.btnOrdClear.Click += new System.EventHandler(this.btnProClear_Click);
            // 
            // btnOrdPlaceOrder
            // 
            this.btnOrdPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrdPlaceOrder.BackColor = System.Drawing.Color.Gray;
            this.btnOrdPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdPlaceOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrdPlaceOrder.Location = new System.Drawing.Point(179, 536);
            this.btnOrdPlaceOrder.Name = "btnOrdPlaceOrder";
            this.btnOrdPlaceOrder.Size = new System.Drawing.Size(193, 55);
            this.btnOrdPlaceOrder.TabIndex = 39;
            this.btnOrdPlaceOrder.Text = "PLACE ORDER";
            this.btnOrdPlaceOrder.UseVisualStyleBackColor = false;
            this.btnOrdPlaceOrder.Click += new System.EventHandler(this.btnOrdPlaceOrder_Click);
            // 
            // btnOrdAtoC
            // 
            this.btnOrdAtoC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrdAtoC.BackColor = System.Drawing.Color.Gray;
            this.btnOrdAtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdAtoC.ForeColor = System.Drawing.Color.Black;
            this.btnOrdAtoC.Location = new System.Drawing.Point(116, 497);
            this.btnOrdAtoC.Name = "btnOrdAtoC";
            this.btnOrdAtoC.Size = new System.Drawing.Size(166, 55);
            this.btnOrdAtoC.TabIndex = 37;
            this.btnOrdAtoC.Text = "ADD TO CART";
            this.btnOrdAtoC.UseVisualStyleBackColor = false;
            this.btnOrdAtoC.Click += new System.EventHandler(this.btnOrdAtoC_Click);
            // 
            // cmbOrdQuntity
            // 
            this.cmbOrdQuntity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOrdQuntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdQuntity.Location = new System.Drawing.Point(301, 395);
            this.cmbOrdQuntity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrdQuntity.Name = "cmbOrdQuntity";
            this.cmbOrdQuntity.Size = new System.Drawing.Size(90, 28);
            this.cmbOrdQuntity.TabIndex = 57;
            this.cmbOrdQuntity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbOrdQuntity.ValueChanged += new System.EventHandler(this.cmbOrdQuntity_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Quntity :";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(114, 360);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(149, 24);
            this.lblProductName.TabIndex = 59;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblOrdPrice
            // 
            this.lblOrdPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrdPrice.AutoSize = true;
            this.lblOrdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdPrice.Location = new System.Drawing.Point(193, 446);
            this.lblOrdPrice.Name = "lblOrdPrice";
            this.lblOrdPrice.Size = new System.Drawing.Size(70, 24);
            this.lblOrdPrice.TabIndex = 60;
            this.lblOrdPrice.Text = "Price :";
            // 
            // DGVOrderDetail
            // 
            this.DGVOrderDetail.AllowUserToAddRows = false;
            this.DGVOrderDetail.AllowUserToDeleteRows = false;
            this.DGVOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVOrderDetail.AutoGenerateColumns = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DGVOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quntityDataGridViewTextBoxColumn,
            this.totPriceDataGridViewTextBoxColumn});
            this.DGVOrderDetail.DataSource = this.tblOrderAtoCBindingSource;
            this.DGVOrderDetail.Location = new System.Drawing.Point(81, 76);
            this.DGVOrderDetail.Name = "DGVOrderDetail";
            this.DGVOrderDetail.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.DGVOrderDetail.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DGVOrderDetail.Size = new System.Drawing.Size(402, 242);
            this.DGVOrderDetail.TabIndex = 61;
            this.DGVOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrderDetail_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "orderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quntityDataGridViewTextBoxColumn
            // 
            this.quntityDataGridViewTextBoxColumn.DataPropertyName = "quntity";
            this.quntityDataGridViewTextBoxColumn.HeaderText = "quntity";
            this.quntityDataGridViewTextBoxColumn.Name = "quntityDataGridViewTextBoxColumn";
            this.quntityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totPriceDataGridViewTextBoxColumn
            // 
            this.totPriceDataGridViewTextBoxColumn.DataPropertyName = "totPrice";
            this.totPriceDataGridViewTextBoxColumn.HeaderText = "totPrice";
            this.totPriceDataGridViewTextBoxColumn.Name = "totPriceDataGridViewTextBoxColumn";
            this.totPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblOrderAtoCBindingSource
            // 
            this.tblOrderAtoCBindingSource.DataMember = "tblOrderAtoC";
            this.tblOrderAtoCBindingSource.DataSource = this.db1DataSet6;
            // 
            // db1DataSet6
            // 
            this.db1DataSet6.DataSetName = "db1DataSet6";
            this.db1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblOrdAmtToPay);
            this.panel1.Controls.Add(this.lblOrdTotalPrice);
            this.panel1.Controls.Add(this.txtCustName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DGVOrderDetail);
            this.panel1.Controls.Add(this.btnOrdPlaceOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(631, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 701);
            this.panel1.TabIndex = 62;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.Gray;
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(210, 622);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 42);
            this.btnRemove.TabIndex = 67;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 29);
            this.label9.TabIndex = 63;
            this.label9.Text = "BILL";
            // 
            // lblOrdAmtToPay
            // 
            this.lblOrdAmtToPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrdAmtToPay.AutoSize = true;
            this.lblOrdAmtToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdAmtToPay.Location = new System.Drawing.Point(167, 468);
            this.lblOrdAmtToPay.Name = "lblOrdAmtToPay";
            this.lblOrdAmtToPay.Size = new System.Drawing.Size(165, 24);
            this.lblOrdAmtToPay.TabIndex = 66;
            this.lblOrdAmtToPay.Text = "Amount To Pay :";
            // 
            // lblOrdTotalPrice
            // 
            this.lblOrdTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrdTotalPrice.AutoSize = true;
            this.lblOrdTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdTotalPrice.Location = new System.Drawing.Point(157, 348);
            this.lblOrdTotalPrice.Name = "lblOrdTotalPrice";
            this.lblOrdTotalPrice.Size = new System.Drawing.Size(122, 24);
            this.lblOrdTotalPrice.TabIndex = 65;
            this.lblOrdTotalPrice.Text = "Total Price :";
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(248, 408);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(125, 26);
            this.txtCustName.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "cust Name:";
            // 
            // tblOrderAtoCTableAdapter
            // 
            this.tblOrderAtoCTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMainType
            // 
            this.cmbMainType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainType.FormattingEnabled = true;
            this.cmbMainType.Items.AddRange(new object[] {
            "--SELECT--"});
            this.cmbMainType.Location = new System.Drawing.Point(331, 64);
            this.cmbMainType.Name = "cmbMainType";
            this.cmbMainType.Size = new System.Drawing.Size(184, 25);
            this.cmbMainType.TabIndex = 69;
            this.cmbMainType.SelectedIndexChanged += new System.EventHandler(this.cmbMainType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Main Type:";
            // 
            // txtProSearch
            // 
            this.txtProSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProSearch.Location = new System.Drawing.Point(333, 141);
            this.txtProSearch.Name = "txtProSearch";
            this.txtProSearch.Size = new System.Drawing.Size(184, 24);
            this.txtProSearch.TabIndex = 71;
            this.txtProSearch.TextChanged += new System.EventHandler(this.txtProSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "Product Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtProSearch);
            this.panel2.Controls.Add(this.lblOrdPrice);
            this.panel2.Controls.Add(this.btnOrdClear);
            this.panel2.Controls.Add(this.cmbMainType);
            this.panel2.Controls.Add(this.btnOrdAtoC);
            this.panel2.Controls.Add(this.cmbOrdQuntity);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbOrdType);
            this.panel2.Controls.Add(this.DGVOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 701);
            this.panel2.TabIndex = 72;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Order Detail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(1188, 701);
            this.Load += new System.EventHandler(this.ucOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdQuntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderAtoCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVOrder;
        private System.Windows.Forms.ComboBox cmbOrdType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdClear;
        private System.Windows.Forms.Button btnOrdPlaceOrder;
        private System.Windows.Forms.Button btnOrdAtoC;
        private System.Windows.Forms.NumericUpDown cmbOrdQuntity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblOrdPrice;
        private System.Windows.Forms.DataGridView DGVOrderDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOrdAmtToPay;
        private System.Windows.Forms.Label lblOrdTotalPrice;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblOrderAtoCBindingSource;
        private db1DataSet6 db1DataSet6;
        private db1DataSet6TableAdapters.tblOrderAtoCTableAdapter tblOrderAtoCTableAdapter;
        private System.Windows.Forms.ComboBox cmbMainType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}
