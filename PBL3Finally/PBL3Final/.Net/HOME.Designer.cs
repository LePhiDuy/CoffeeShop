namespace PBL3
{
    partial class HOME
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.orderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbChangeTable = new System.Windows.Forms.ComboBox();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.cbbFoodType = new System.Windows.Forms.ComboBox();
            this.lblListFood = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.btnAnalytic = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.picDownArrow = new System.Windows.Forms.PictureBox();
            this.picPeople = new System.Windows.Forms.PictureBox();
            this.gridFood = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInfoAccount = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblChangeTable = new System.Windows.Forms.Label();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Giam = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).BeginInit();
            this.pnlTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDownArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpTable.AutoScroll = true;
            this.flpTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flpTable.Location = new System.Drawing.Point(9, 144);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(424, 525);
            this.flpTable.TabIndex = 10;
            // 
            // gridOrder
            // 
            this.gridOrder.AutoGenerateColumns = false;
            this.gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Tang,
            this.Giam});
            this.gridOrder.DataSource = this.orderDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "#,####.####";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridOrder.Location = new System.Drawing.Point(439, 103);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.RowHeadersVisible = false;
            this.gridOrder.RowHeadersWidth = 51;
            this.gridOrder.Size = new System.Drawing.Size(373, 395);
            this.gridOrder.TabIndex = 11;
            this.gridOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrder_CellContentClick);
            // 
            // orderDTOBindingSource
            // 
            this.orderDTOBindingSource.DataSource = typeof(DTO.OrderDTO);
            // 
            // cbbChangeTable
            // 
            this.cbbChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChangeTable.FormattingEnabled = true;
            this.cbbChangeTable.Location = new System.Drawing.Point(212, 106);
            this.cbbChangeTable.Name = "cbbChangeTable";
            this.cbbChangeTable.Size = new System.Drawing.Size(129, 32);
            this.cbbChangeTable.TabIndex = 13;
            this.cbbChangeTable.SelectedIndexChanged += new System.EventHandler(this.cbbChangeTable_SelectedIndexChanged);
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(11)))), ((int)(((byte)(33)))));
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameUser.Location = new System.Drawing.Point(1067, 21);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(146, 24);
            this.lblNameUser.TabIndex = 15;
            this.lblNameUser.Text = "Nguyen Van A";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(198)))), ((int)(((byte)(121)))));
            this.btnPay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(550, 623);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(167, 46);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(471, 576);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 24);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Tổng :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDiscount.Location = new System.Drawing.Point(471, 536);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(146, 24);
            this.lblDiscount.TabIndex = 22;
            this.lblDiscount.Text = "Giảm giá (%) : ";
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFoodType.Location = new System.Drawing.Point(824, 100);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(123, 24);
            this.lblFoodType.TabIndex = 24;
            this.lblFoodType.Text = "Danh  mục :";
            // 
            // cbbFoodType
            // 
            this.cbbFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFoodType.FormattingEnabled = true;
            this.cbbFoodType.Location = new System.Drawing.Point(962, 98);
            this.cbbFoodType.Name = "cbbFoodType";
            this.cbbFoodType.Size = new System.Drawing.Size(228, 32);
            this.cbbFoodType.TabIndex = 25;
            this.cbbFoodType.SelectedIndexChanged += new System.EventHandler(this.cbbFoodType_SelectedIndexChanged);
            // 
            // lblListFood
            // 
            this.lblListFood.AutoSize = true;
            this.lblListFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListFood.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListFood.Location = new System.Drawing.Point(824, 168);
            this.lblListFood.Name = "lblListFood";
            this.lblListFood.Size = new System.Drawing.Size(168, 24);
            this.lblListFood.TabIndex = 26;
            this.lblListFood.Text = "Danh sách món :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(988, 137);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 29);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_Change);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(631, 573);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(181, 29);
            this.txtTotal.TabIndex = 30;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(631, 533);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(181, 29);
            this.txtDiscount.TabIndex = 31;
            this.txtDiscount.Text = "0";
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.pnlTittle.Controls.Add(this.btnAnalytic);
            this.pnlTittle.Controls.Add(this.btnManage);
            this.pnlTittle.Controls.Add(this.btnOrder);
            this.pnlTittle.Controls.Add(this.picDownArrow);
            this.pnlTittle.Controls.Add(this.lblNameUser);
            this.pnlTittle.Controls.Add(this.picPeople);
            this.pnlTittle.Location = new System.Drawing.Point(0, 0);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(1265, 75);
            this.pnlTittle.TabIndex = 32;
            // 
            // btnAnalytic
            // 
            this.btnAnalytic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.btnAnalytic.FlatAppearance.BorderSize = 0;
            this.btnAnalytic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytic.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnalytic.Image = global::PBL3.Properties.Resources.analytics_48;
            this.btnAnalytic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnalytic.Location = new System.Drawing.Point(309, -7);
            this.btnAnalytic.Name = "btnAnalytic";
            this.btnAnalytic.Size = new System.Drawing.Size(127, 90);
            this.btnAnalytic.TabIndex = 37;
            this.btnAnalytic.Text = "THỐNG KÊ";
            this.btnAnalytic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnalytic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnalytic.UseVisualStyleBackColor = false;
            this.btnAnalytic.Click += new System.EventHandler(this.btnAnalytic_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManage.Image = global::PBL3.Properties.Resources.settings_5_48;
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManage.Location = new System.Drawing.Point(148, -7);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(127, 90);
            this.btnManage.TabIndex = 36;
            this.btnManage.Text = "QUẢN LÝ";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Image = global::PBL3.Properties.Resources.purchase_order_48;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrder.Location = new System.Drawing.Point(23, -7);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(97, 90);
            this.btnOrder.TabIndex = 35;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // picDownArrow
            // 
            this.picDownArrow.Image = global::PBL3.Properties.Resources.arrow_216_32;
            this.picDownArrow.Location = new System.Drawing.Point(1219, 12);
            this.picDownArrow.Name = "picDownArrow";
            this.picDownArrow.Size = new System.Drawing.Size(20, 47);
            this.picDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDownArrow.TabIndex = 16;
            this.picDownArrow.TabStop = false;
            this.picDownArrow.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // picPeople
            // 
            this.picPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(11)))), ((int)(((byte)(33)))));
            this.picPeople.Image = global::PBL3.Properties.Resources.nd2m6os0tmc9env4gc8jh3er0j;
            this.picPeople.Location = new System.Drawing.Point(991, 12);
            this.picPeople.Name = "picPeople";
            this.picPeople.Size = new System.Drawing.Size(83, 33);
            this.picPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPeople.TabIndex = 14;
            this.picPeople.TabStop = false;
            // 
            // gridFood
            // 
            this.gridFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridFood.Location = new System.Drawing.Point(828, 204);
            this.gridFood.Margin = new System.Windows.Forms.Padding(2);
            this.gridFood.Name = "gridFood";
            this.gridFood.ReadOnly = true;
            this.gridFood.RowHeadersWidth = 51;
            this.gridFood.RowTemplate.Height = 24;
            this.gridFood.Size = new System.Drawing.Size(409, 293);
            this.gridFood.TabIndex = 33;
            this.gridFood.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFood_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnInfoAccount);
            this.panel2.Location = new System.Drawing.Point(1039, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 104);
            this.panel2.TabIndex = 34;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::PBL3.Properties.Resources.logout_32;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(0, 50);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(196, 50);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.ButLogout_Click);
            // 
            // btnInfoAccount
            // 
            this.btnInfoAccount.BackColor = System.Drawing.Color.White;
            this.btnInfoAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoAccount.FlatAppearance.BorderSize = 0;
            this.btnInfoAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoAccount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoAccount.Location = new System.Drawing.Point(0, 0);
            this.btnInfoAccount.Name = "btnInfoAccount";
            this.btnInfoAccount.Size = new System.Drawing.Size(196, 50);
            this.btnInfoAccount.TabIndex = 0;
            this.btnInfoAccount.Text = "Thông tin tài khoản";
            this.btnInfoAccount.UseVisualStyleBackColor = false;
            this.btnInfoAccount.Click += new System.EventHandler(this.ButInfo_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(824, 137);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(148, 24);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Tìm kiếm món:";
            // 
            // lblChangeTable
            // 
            this.lblChangeTable.AutoSize = true;
            this.lblChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTable.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeTable.Location = new System.Drawing.Point(52, 110);
            this.lblChangeTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeTable.Name = "lblChangeTable";
            this.lblChangeTable.Size = new System.Drawing.Size(135, 26);
            this.lblChangeTable.TabIndex = 35;
            this.lblChangeTable.Text = "Chuyển bàn:";
            // 
            // foodDataGridViewTextBoxColumn
            // 
            this.foodDataGridViewTextBoxColumn.DataPropertyName = "Food";
            this.foodDataGridViewTextBoxColumn.HeaderText = "Tên món";
            this.foodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodDataGridViewTextBoxColumn.Name = "foodDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.FillWeight = 40F;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle1.Format = "#,#0";
            dataGridViewCellStyle1.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalDataGridViewTextBoxColumn.FillWeight = 40F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tang
            // 
            this.Tang.FillWeight = 20F;
            this.Tang.HeaderText = "";
            this.Tang.MinimumWidth = 6;
            this.Tang.Name = "Tang";
            this.Tang.Text = "+";
            this.Tang.UseColumnTextForButtonValue = true;
            // 
            // Giam
            // 
            this.Giam.FillWeight = 20F;
            this.Giam.HeaderText = "";
            this.Giam.MinimumWidth = 6;
            this.Giam.Name = "Giam";
            this.Giam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Giam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Giam.Text = "-";
            this.Giam.UseColumnTextForButtonValue = true;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblChangeTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridFood);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblListFood);
            this.Controls.Add(this.cbbFoodType);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblFoodType);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbbChangeTable);
            this.Controls.Add(this.gridOrder);
            this.Controls.Add(this.flpTable);
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HOME_FormClosed);
            this.Load += new System.EventHandler(this.HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).EndInit();
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDownArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.ComboBox cbbChangeTable;
        private System.Windows.Forms.PictureBox picPeople;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.ComboBox cbbFoodType;
        private System.Windows.Forms.Label lblListFood;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.DataGridView gridFood;
        private System.Windows.Forms.PictureBox picDownArrow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInfoAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnAnalytic;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblChangeTable;
        private System.Windows.Forms.BindingSource orderDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Tang;
        private System.Windows.Forms.DataGridViewButtonColumn Giam;
    }
}

