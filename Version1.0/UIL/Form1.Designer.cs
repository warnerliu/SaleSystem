namespace Version1._0
{
    partial class Form1
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
            this.Manage_Sys = new System.Windows.Forms.TabControl();
            this.welcome = new System.Windows.Forms.TabPage();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.Store = new System.Windows.Forms.TabPage();
            this.getStore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.In_Store = new System.Windows.Forms.Button();
            this.TypeCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SortCombobox = new System.Windows.Forms.ComboBox();
            this.Sale = new System.Windows.Forms.TabPage();
            this.allSaleDataGridView = new System.Windows.Forms.DataGridView();
            this.saleManage = new System.Windows.Forms.GroupBox();
            this.viewAllSaleBtn = new System.Windows.Forms.Button();
            this.saleRecord = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.addInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saleProductType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saleProductSort = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.ComboBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.TabPage();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.newEmployee = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_addNewEmployee = new System.Windows.Forms.Button();
            this.newIDBox = new System.Windows.Forms.TextBox();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Pro_New = new System.Windows.Forms.TabPage();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sortTextBox = new System.Windows.Forms.TextBox();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.saleDetails = new System.Windows.Forms.TabPage();
            this.profitLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.daySaleBtn = new System.Windows.Forms.Button();
            this.monthSaleBtn = new System.Windows.Forms.Button();
            this.viewEmployeeID = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.viewEmployeeName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.allDaySaleBtn = new System.Windows.Forms.Button();
            this.viewMonthSale = new System.Windows.Forms.Button();
            this.dataGridViewProfit = new System.Windows.Forms.DataGridView();
            this.Manage_Sys.SuspendLayout();
            this.welcome.SuspendLayout();
            this.Store.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allSaleDataGridView)).BeginInit();
            this.saleManage.SuspendLayout();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.newEmployee.SuspendLayout();
            this.Pro_New.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.saleDetails.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // Manage_Sys
            // 
            this.Manage_Sys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Manage_Sys.Controls.Add(this.welcome);
            this.Manage_Sys.Controls.Add(this.Store);
            this.Manage_Sys.Controls.Add(this.Sale);
            this.Manage_Sys.Controls.Add(this.Employee);
            this.Manage_Sys.Controls.Add(this.Pro_New);
            this.Manage_Sys.Controls.Add(this.saleDetails);
            this.Manage_Sys.Location = new System.Drawing.Point(30, 25);
            this.Manage_Sys.Name = "Manage_Sys";
            this.Manage_Sys.SelectedIndex = 0;
            this.Manage_Sys.Size = new System.Drawing.Size(853, 486);
            this.Manage_Sys.TabIndex = 0;
            this.Manage_Sys.SelectedIndexChanged += new System.EventHandler(this.Manage_Sys_SelectedIndexChanged);
            // 
            // welcome
            // 
            this.welcome.Controls.Add(this.welcomeLabel);
            this.welcome.Location = new System.Drawing.Point(4, 22);
            this.welcome.Name = "welcome";
            this.welcome.Padding = new System.Windows.Forms.Padding(3);
            this.welcome.Size = new System.Drawing.Size(845, 460);
            this.welcome.TabIndex = 5;
            this.welcome.Text = "主界面";
            this.welcome.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("KaiTi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcomeLabel.Location = new System.Drawing.Point(211, 225);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(385, 35);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "欢迎使用销售管理系统";
            // 
            // Store
            // 
            this.Store.Controls.Add(this.getStore);
            this.Store.Controls.Add(this.dataGridView1);
            this.Store.Controls.Add(this.groupBox1);
            this.Store.Location = new System.Drawing.Point(4, 22);
            this.Store.Name = "Store";
            this.Store.Padding = new System.Windows.Forms.Padding(3);
            this.Store.Size = new System.Drawing.Size(845, 460);
            this.Store.TabIndex = 0;
            this.Store.Text = "仓库管理";
            this.Store.UseVisualStyleBackColor = true;
            // 
            // getStore
            // 
            this.getStore.Location = new System.Drawing.Point(43, 123);
            this.getStore.Name = "getStore";
            this.getStore.Size = new System.Drawing.Size(75, 23);
            this.getStore.TabIndex = 2;
            this.getStore.Text = "查看库存";
            this.getStore.UseVisualStyleBackColor = true;
            this.getStore.Click += new System.EventHandler(this.getStore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(777, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.InPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.In_Store);
            this.groupBox1.Controls.Add(this.TypeCombobox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SortCombobox);
            this.groupBox1.Location = new System.Drawing.Point(35, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入库管理";
            // 
            // InQuantity
            // 
            this.InQuantity.Location = new System.Drawing.Point(544, 31);
            this.InQuantity.Name = "InQuantity";
            this.InQuantity.Size = new System.Drawing.Size(100, 21);
            this.InQuantity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数量";
            // 
            // InPrice
            // 
            this.InPrice.Location = new System.Drawing.Point(394, 31);
            this.InPrice.Name = "InPrice";
            this.InPrice.Size = new System.Drawing.Size(100, 21);
            this.InPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "进价";
            // 
            // In_Store
            // 
            this.In_Store.Location = new System.Drawing.Point(691, 29);
            this.In_Store.Name = "In_Store";
            this.In_Store.Size = new System.Drawing.Size(55, 23);
            this.In_Store.TabIndex = 4;
            this.In_Store.Text = "入库";
            this.In_Store.UseVisualStyleBackColor = true;
            this.In_Store.Click += new System.EventHandler(this.In_Store_Click);
            // 
            // TypeCombobox
            // 
            this.TypeCombobox.FormattingEnabled = true;
            this.TypeCombobox.Location = new System.Drawing.Point(222, 31);
            this.TypeCombobox.Name = "TypeCombobox";
            this.TypeCombobox.Size = new System.Drawing.Size(121, 20);
            this.TypeCombobox.Sorted = true;
            this.TypeCombobox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品型号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品类别";
            // 
            // SortCombobox
            // 
            this.SortCombobox.FormattingEnabled = true;
            this.SortCombobox.Location = new System.Drawing.Point(66, 31);
            this.SortCombobox.Name = "SortCombobox";
            this.SortCombobox.Size = new System.Drawing.Size(72, 20);
            this.SortCombobox.TabIndex = 0;
            this.SortCombobox.SelectedValueChanged += new System.EventHandler(this.SortClass_SelectedValueChanged);
            // 
            // Sale
            // 
            this.Sale.Controls.Add(this.allSaleDataGridView);
            this.Sale.Controls.Add(this.saleManage);
            this.Sale.Location = new System.Drawing.Point(4, 22);
            this.Sale.Name = "Sale";
            this.Sale.Padding = new System.Windows.Forms.Padding(3);
            this.Sale.Size = new System.Drawing.Size(845, 460);
            this.Sale.TabIndex = 1;
            this.Sale.Text = "销售记录";
            this.Sale.UseVisualStyleBackColor = true;
            // 
            // allSaleDataGridView
            // 
            this.allSaleDataGridView.AllowUserToAddRows = false;
            this.allSaleDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.allSaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allSaleDataGridView.Location = new System.Drawing.Point(20, 157);
            this.allSaleDataGridView.Name = "allSaleDataGridView";
            this.allSaleDataGridView.RowTemplate.Height = 23;
            this.allSaleDataGridView.Size = new System.Drawing.Size(799, 297);
            this.allSaleDataGridView.TabIndex = 1;
            // 
            // saleManage
            // 
            this.saleManage.Controls.Add(this.viewAllSaleBtn);
            this.saleManage.Controls.Add(this.saleRecord);
            this.saleManage.Controls.Add(this.label10);
            this.saleManage.Controls.Add(this.customerAddress);
            this.saleManage.Controls.Add(this.addInfo);
            this.saleManage.Controls.Add(this.label9);
            this.saleManage.Controls.Add(this.customerPhone);
            this.saleManage.Controls.Add(this.label8);
            this.saleManage.Controls.Add(this.customerName);
            this.saleManage.Controls.Add(this.label7);
            this.saleManage.Controls.Add(this.salePrice);
            this.saleManage.Controls.Add(this.label6);
            this.saleManage.Controls.Add(this.saleProductType);
            this.saleManage.Controls.Add(this.label5);
            this.saleManage.Controls.Add(this.saleProductSort);
            this.saleManage.Controls.Add(this.productLabel);
            this.saleManage.Controls.Add(this.employeeID);
            this.saleManage.Controls.Add(this.IDLabel);
            this.saleManage.Controls.Add(this.employeeName);
            this.saleManage.Controls.Add(this.nameLabel);
            this.saleManage.Location = new System.Drawing.Point(20, 15);
            this.saleManage.Name = "saleManage";
            this.saleManage.Size = new System.Drawing.Size(799, 124);
            this.saleManage.TabIndex = 0;
            this.saleManage.TabStop = false;
            this.saleManage.Text = "销售记录";
            // 
            // viewAllSaleBtn
            // 
            this.viewAllSaleBtn.Location = new System.Drawing.Point(718, 95);
            this.viewAllSaleBtn.Name = "viewAllSaleBtn";
            this.viewAllSaleBtn.Size = new System.Drawing.Size(75, 23);
            this.viewAllSaleBtn.TabIndex = 19;
            this.viewAllSaleBtn.Text = "查看销售记录";
            this.viewAllSaleBtn.UseVisualStyleBackColor = true;
            this.viewAllSaleBtn.Click += new System.EventHandler(this.viewAllSaleBtn_Click);
            // 
            // saleRecord
            // 
            this.saleRecord.Location = new System.Drawing.Point(589, 95);
            this.saleRecord.Name = "saleRecord";
            this.saleRecord.Size = new System.Drawing.Size(75, 23);
            this.saleRecord.TabIndex = 18;
            this.saleRecord.Text = "完成";
            this.saleRecord.UseVisualStyleBackColor = true;
            this.saleRecord.Click += new System.EventHandler(this.saleRecord_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "地址";
            // 
            // customerAddress
            // 
            this.customerAddress.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.customerAddress.Location = new System.Drawing.Point(43, 97);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(505, 21);
            this.customerAddress.TabIndex = 16;
            // 
            // addInfo
            // 
            this.addInfo.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.addInfo.Location = new System.Drawing.Point(589, 64);
            this.addInfo.Name = "addInfo";
            this.addInfo.Size = new System.Drawing.Size(121, 21);
            this.addInfo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "备注";
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(427, 64);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(121, 21);
            this.customerPhone.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "客户电话";
            // 
            // customerName
            // 
            this.customerName.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.customerName.Location = new System.Drawing.Point(229, 64);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(121, 21);
            this.customerName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "客户姓名";
            // 
            // salePrice
            // 
            this.salePrice.Location = new System.Drawing.Point(43, 64);
            this.salePrice.Name = "salePrice";
            this.salePrice.Size = new System.Drawing.Size(121, 21);
            this.salePrice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "售价";
            // 
            // saleProductType
            // 
            this.saleProductType.FormattingEnabled = true;
            this.saleProductType.Location = new System.Drawing.Point(589, 30);
            this.saleProductType.Name = "saleProductType";
            this.saleProductType.Size = new System.Drawing.Size(121, 20);
            this.saleProductType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "型号";
            // 
            // saleProductSort
            // 
            this.saleProductSort.FormattingEnabled = true;
            this.saleProductSort.Location = new System.Drawing.Point(427, 30);
            this.saleProductSort.Name = "saleProductSort";
            this.saleProductSort.Size = new System.Drawing.Size(121, 20);
            this.saleProductSort.TabIndex = 5;
            this.saleProductSort.SelectedValueChanged += new System.EventHandler(this.saleProductSort_SelectedValueChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(367, 33);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(53, 12);
            this.productLabel.TabIndex = 4;
            this.productLabel.Text = "销售产品";
            // 
            // employeeID
            // 
            this.employeeID.FormattingEnabled = true;
            this.employeeID.Location = new System.Drawing.Point(229, 30);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(121, 20);
            this.employeeID.TabIndex = 3;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(170, 33);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(53, 12);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "员工工号";
            // 
            // employeeName
            // 
            this.employeeName.FormattingEnabled = true;
            this.employeeName.Location = new System.Drawing.Point(43, 30);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(121, 20);
            this.employeeName.TabIndex = 1;
            this.employeeName.SelectedValueChanged += new System.EventHandler(this.employeeName_SelectedValueChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 12);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "姓名";
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.employeeDataGridView);
            this.Employee.Controls.Add(this.newEmployee);
            this.Employee.Location = new System.Drawing.Point(4, 22);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(845, 460);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "员工管理";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(28, 128);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowTemplate.Height = 23;
            this.employeeDataGridView.Size = new System.Drawing.Size(547, 326);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // newEmployee
            // 
            this.newEmployee.Controls.Add(this.label13);
            this.newEmployee.Controls.Add(this.btn_addNewEmployee);
            this.newEmployee.Controls.Add(this.newIDBox);
            this.newEmployee.Controls.Add(this.newNameBox);
            this.newEmployee.Controls.Add(this.label12);
            this.newEmployee.Controls.Add(this.label11);
            this.newEmployee.Location = new System.Drawing.Point(28, 29);
            this.newEmployee.Name = "newEmployee";
            this.newEmployee.Size = new System.Drawing.Size(547, 70);
            this.newEmployee.TabIndex = 0;
            this.newEmployee.TabStop = false;
            this.newEmployee.Text = "添加新员工";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(308, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "*工号必须唯一";
            // 
            // btn_addNewEmployee
            // 
            this.btn_addNewEmployee.Location = new System.Drawing.Point(412, 27);
            this.btn_addNewEmployee.Name = "btn_addNewEmployee";
            this.btn_addNewEmployee.Size = new System.Drawing.Size(69, 23);
            this.btn_addNewEmployee.TabIndex = 4;
            this.btn_addNewEmployee.Text = "增加";
            this.btn_addNewEmployee.UseVisualStyleBackColor = true;
            this.btn_addNewEmployee.Click += new System.EventHandler(this.btn_addNewEmployee_Click);
            // 
            // newIDBox
            // 
            this.newIDBox.Location = new System.Drawing.Point(202, 29);
            this.newIDBox.Name = "newIDBox";
            this.newIDBox.Size = new System.Drawing.Size(100, 21);
            this.newIDBox.TabIndex = 3;
            // 
            // newNameBox
            // 
            this.newNameBox.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.newNameBox.Location = new System.Drawing.Point(41, 29);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(100, 21);
            this.newNameBox.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "工号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "姓名";
            // 
            // Pro_New
            // 
            this.Pro_New.Controls.Add(this.productDataGridView);
            this.Pro_New.Controls.Add(this.groupBox2);
            this.Pro_New.Location = new System.Drawing.Point(4, 22);
            this.Pro_New.Name = "Pro_New";
            this.Pro_New.Padding = new System.Windows.Forms.Padding(3);
            this.Pro_New.Size = new System.Drawing.Size(845, 460);
            this.Pro_New.TabIndex = 3;
            this.Pro_New.Text = "产品管理";
            this.Pro_New.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.productDataGridView.Location = new System.Drawing.Point(26, 116);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 23;
            this.productDataGridView.Size = new System.Drawing.Size(576, 326);
            this.productDataGridView.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortTextBox);
            this.groupBox2.Controls.Add(this.addNewProduct);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.typeTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(26, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加新产品";
            // 
            // sortTextBox
            // 
            this.sortTextBox.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.sortTextBox.Location = new System.Drawing.Point(75, 26);
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(118, 21);
            this.sortTextBox.TabIndex = 6;
            // 
            // addNewProduct
            // 
            this.addNewProduct.Location = new System.Drawing.Point(495, 24);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(75, 23);
            this.addNewProduct.TabIndex = 5;
            this.addNewProduct.Text = "添加";
            this.addNewProduct.UseVisualStyleBackColor = true;
            this.addNewProduct.Click += new System.EventHandler(this.addNewProduct_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(398, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "*型号唯一";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(275, 26);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(117, 21);
            this.typeTextBox.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "产品型号";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "产品类别";
            // 
            // saleDetails
            // 
            this.saleDetails.Controls.Add(this.profitLabel);
            this.saleDetails.Controls.Add(this.label19);
            this.saleDetails.Controls.Add(this.groupBox4);
            this.saleDetails.Controls.Add(this.groupBox3);
            this.saleDetails.Controls.Add(this.dataGridViewProfit);
            this.saleDetails.Location = new System.Drawing.Point(4, 22);
            this.saleDetails.Name = "saleDetails";
            this.saleDetails.Padding = new System.Windows.Forms.Padding(3);
            this.saleDetails.Size = new System.Drawing.Size(845, 460);
            this.saleDetails.TabIndex = 4;
            this.saleDetails.Text = "销售明细";
            this.saleDetails.UseVisualStyleBackColor = true;
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Location = new System.Drawing.Point(749, 267);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(0, 12);
            this.profitLabel.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(698, 267);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "利润";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.daySaleBtn);
            this.groupBox4.Controls.Add(this.monthSaleBtn);
            this.groupBox4.Controls.Add(this.viewEmployeeID);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.viewEmployeeName);
            this.groupBox4.Location = new System.Drawing.Point(39, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 73);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "个人销售情况";
            // 
            // daySaleBtn
            // 
            this.daySaleBtn.Location = new System.Drawing.Point(413, 30);
            this.daySaleBtn.Name = "daySaleBtn";
            this.daySaleBtn.Size = new System.Drawing.Size(75, 23);
            this.daySaleBtn.TabIndex = 7;
            this.daySaleBtn.Text = "日销售";
            this.daySaleBtn.UseVisualStyleBackColor = true;
            this.daySaleBtn.Click += new System.EventHandler(this.daySaleBtn_Click);
            // 
            // monthSaleBtn
            // 
            this.monthSaleBtn.Location = new System.Drawing.Point(536, 30);
            this.monthSaleBtn.Name = "monthSaleBtn";
            this.monthSaleBtn.Size = new System.Drawing.Size(75, 23);
            this.monthSaleBtn.TabIndex = 6;
            this.monthSaleBtn.Text = "月销售";
            this.monthSaleBtn.UseVisualStyleBackColor = true;
            this.monthSaleBtn.Click += new System.EventHandler(this.monthSaleBtn_Click);
            // 
            // viewEmployeeID
            // 
            this.viewEmployeeID.FormattingEnabled = true;
            this.viewEmployeeID.Location = new System.Drawing.Point(212, 32);
            this.viewEmployeeID.Name = "viewEmployeeID";
            this.viewEmployeeID.Size = new System.Drawing.Size(121, 20);
            this.viewEmployeeID.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "工号";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "姓名";
            // 
            // viewEmployeeName
            // 
            this.viewEmployeeName.FormattingEnabled = true;
            this.viewEmployeeName.Location = new System.Drawing.Point(41, 33);
            this.viewEmployeeName.Name = "viewEmployeeName";
            this.viewEmployeeName.Size = new System.Drawing.Size(121, 20);
            this.viewEmployeeName.TabIndex = 2;
            this.viewEmployeeName.SelectedValueChanged += new System.EventHandler(this.viewEmployeeName_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.allDaySaleBtn);
            this.groupBox3.Controls.Add(this.viewMonthSale);
            this.groupBox3.Location = new System.Drawing.Point(39, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "总体销售情况";
            // 
            // allDaySaleBtn
            // 
            this.allDaySaleBtn.Location = new System.Drawing.Point(162, 20);
            this.allDaySaleBtn.Name = "allDaySaleBtn";
            this.allDaySaleBtn.Size = new System.Drawing.Size(75, 23);
            this.allDaySaleBtn.TabIndex = 2;
            this.allDaySaleBtn.Text = "每日销售";
            this.allDaySaleBtn.UseVisualStyleBackColor = true;
            this.allDaySaleBtn.Click += new System.EventHandler(this.allDaySaleBtn_Click);
            // 
            // viewMonthSale
            // 
            this.viewMonthSale.Location = new System.Drawing.Point(319, 20);
            this.viewMonthSale.Name = "viewMonthSale";
            this.viewMonthSale.Size = new System.Drawing.Size(75, 23);
            this.viewMonthSale.TabIndex = 1;
            this.viewMonthSale.Text = "每月销售";
            this.viewMonthSale.UseVisualStyleBackColor = true;
            this.viewMonthSale.Click += new System.EventHandler(this.viewSale_Click);
            // 
            // dataGridViewProfit
            // 
            this.dataGridViewProfit.AllowUserToAddRows = false;
            this.dataGridViewProfit.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfit.Location = new System.Drawing.Point(39, 165);
            this.dataGridViewProfit.Name = "dataGridViewProfit";
            this.dataGridViewProfit.RowTemplate.Height = 23;
            this.dataGridViewProfit.Size = new System.Drawing.Size(653, 278);
            this.dataGridViewProfit.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 542);
            this.Controls.Add(this.Manage_Sys);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "试用版";
           
           
            this.Manage_Sys.ResumeLayout(false);
            this.welcome.ResumeLayout(false);
            this.welcome.PerformLayout();
            this.Store.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Sale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allSaleDataGridView)).EndInit();
            this.saleManage.ResumeLayout(false);
            this.saleManage.PerformLayout();
            this.Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.newEmployee.ResumeLayout(false);
            this.newEmployee.PerformLayout();
            this.Pro_New.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.saleDetails.ResumeLayout(false);
            this.saleDetails.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Manage_Sys;
        private System.Windows.Forms.TabPage Store;
        private System.Windows.Forms.TabPage Sale;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortCombobox;
        private System.Windows.Forms.Button In_Store;
        private System.Windows.Forms.ComboBox TypeCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox InQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Pro_New;
        private System.Windows.Forms.GroupBox saleManage;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.ComboBox employeeName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox employeeID;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox salePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox saleProductType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox saleProductSort;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button saleRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox addInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox newEmployee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_addNewEmployee;
        private System.Windows.Forms.TextBox newIDBox;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button getStore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addNewProduct;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sortTextBox;
        private System.Windows.Forms.TabPage saleDetails;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox viewEmployeeName;
        private System.Windows.Forms.DataGridView dataGridViewProfit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox viewEmployeeID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView allSaleDataGridView;
        private System.Windows.Forms.Button viewAllSaleBtn;
        private System.Windows.Forms.Button viewMonthSale;
        private System.Windows.Forms.Button daySaleBtn;
        private System.Windows.Forms.Button monthSaleBtn;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button allDaySaleBtn;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage welcome;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

