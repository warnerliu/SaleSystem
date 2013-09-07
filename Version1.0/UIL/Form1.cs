using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Version1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseOP allOperate = new DatabaseOP();
       

        //当类别发生改变时，自动加载对应的型号
        private void SortClass_SelectedValueChanged(object sender, EventArgs e)
        {        
            String cmdProType = "select * from db_Product where Pro_Sort = " + "'" + SortCombobox.SelectedValue.ToString() + "'";

            DataSet ds = new DataSet();
            ds = allOperate.getDS(cmdProType);
            
            TypeCombobox.DataSource = ds.Tables[0];

            TypeCombobox.DisplayMember = "Pro_Type";
            TypeCombobox.Text = "请选择";
            
        }


        //更新库存
        private void In_Store_Click(object sender, EventArgs e)
        {
           
            allOperate.inStore(SortCombobox.Text.Trim(), TypeCombobox.Text.Trim(),int.Parse(InQuantity.Text.ToString()),int.Parse(InPrice.Text.ToString()),DateTime.Now);
            this.getStore_Click(sender, e);
            SortCombobox.Text = "请选择";
            TypeCombobox.Text = "请选择";
            InPrice.Clear();
            InQuantity.Clear();
            
        }

       
        //选择销售管理标签时，自动加载相应的combobox选项，包括员工姓名和产品类别
        private void Manage_Sys_SelectedIndexChanged(object sender, EventArgs e)
        {
            //库存管理标签
            if (this.Manage_Sys.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                String cmdProSort = "select distinct Pro_Sort from db_Product";
                ds = allOperate.getDS(cmdProSort);


                //使用SelectedValueChanged方法要将数据源的绑定放在DisplayMember和ValueMember前面；
                //使用SelectedIndexChanged方法要将数据源的绑定放在DisplayMember和ValueMember后面；

                SortCombobox.DataSource = ds.Tables[0];
                SortCombobox.DisplayMember = "Pro_Sort";
                SortCombobox.ValueMember = "Pro_Sort";
                SortCombobox.Text = "请选择";
            }



            //销售记录标签
            if (this.Manage_Sys.SelectedIndex == 2)
            {
                
                DataSet ds = new DataSet();
                String cmdEmployeeName = "select * from db_Employee";
                ds = allOperate.getDS(cmdEmployeeName);
                
                employeeName.DataSource = ds.Tables[0];
                employeeName.DisplayMember = "EmployeeName";
                employeeName.ValueMember = "EmployeeName";
                employeeName.Text = "请选择";
                employeeID.Text = "请选择";
                DatabaseOP operateDB = new DatabaseOP();
                String sortStr = "select distinct Pro_Sort from db_Product";
                DataSet sortDS = new DataSet();
                sortDS = operateDB.getDS(sortStr);
                saleProductSort.DataSource = sortDS.Tables[0];
                saleProductSort.DisplayMember = "Pro_sort";
                saleProductSort.ValueMember = "Pro_sort";
                saleProductSort.Text = "请选择";
                saleProductType.Text = "请选择";
            }
            //销售明细标签
            if (this.Manage_Sys.SelectedIndex == 5)
            {
                DataSet ds = new DataSet();
                String cmdEmployeeName = "select * from db_Employee";

                ds = allOperate.getDS(cmdEmployeeName);

                viewEmployeeName.DataSource = ds.Tables[0];
                viewEmployeeName.DisplayMember = "EmployeeName";
                viewEmployeeName.ValueMember = "EmployeeName";
                //viewEmployeeID.DataSource = ds.Tables[0];
                //viewEmployeeID.DisplayMember = "EmployeeID";
                viewEmployeeName.Text = "请选择";
                viewEmployeeID.Text = "请选择";
            }
                
        }


        //将销售记录写入数据库
        private void saleRecord_Click(object sender, EventArgs e)
        {
            DatabaseOP saleDB = new DatabaseOP();
            String getEmployeeID = employeeID.Text.Trim();
            String getPro_Type = saleProductType.Text.Trim();
            int getSale_Price = int.Parse(salePrice.Text.ToString());
            DateTime getSale_Date = DateTime.Now;
            String getCustomerName = customerName.Text.Trim();
            String getCustomerPhone = customerPhone.Text.Trim();
            String getCustomerAddress = customerAddress.Text.Trim();
            String getAddInfo = addInfo.Text.Trim();
            saleDB.addSaleRecorde(getEmployeeID,getPro_Type,getSale_Price,getCustomerName,getCustomerPhone,getCustomerAddress,getAddInfo,getSale_Date.Day,getSale_Date.Month,getSale_Date.Year);
            this.viewAllSaleBtn_Click(sender, e);

            //清空控件内容
            employeeName.Text = "请选择";
            employeeID.Text = "请选择";
            saleProductSort.Text = "请选择";
            saleProductType.Text = "请选择";
            salePrice.Clear();
            customerName.Clear();
            customerPhone.Clear();
            customerAddress.Clear();
            addInfo.Clear();
            

        }


        //当员工姓名发生变化时，自动查找相应的工号
        private void employeeName_SelectedValueChanged(object sender, EventArgs e)
        {
            DatabaseOP opDatabase = new DatabaseOP();
            
            DataSet ds = new DataSet();
            String cmdEmployeeID = "select * from db_Employee where EmployeeName = " + "'" + employeeName.SelectedValue.ToString() + "'";

            ds = opDatabase.getDS(cmdEmployeeID);
           
            employeeID.DataSource = ds.Tables[0];
            employeeID.DisplayMember = "EmployeeID";
            //employeeID.Text = "请选择";
        }


        //产品类别发生变化时，自动加载相应的型号列表
        private void saleProductSort_SelectedValueChanged(object sender, EventArgs e)
        {
            DatabaseOP operateDB = new DatabaseOP();
            String sqlTypeStr = "select Pro_Type from db_Product where Pro_Sort = '"+saleProductSort.Text.Trim()+"';";
            DataSet ds = new DataSet();
            ds = operateDB.getDS(sqlTypeStr);
            saleProductType.DataSource = ds.Tables[0];
            saleProductType.DisplayMember = "Pro_Type";
            saleProductType.Text = "请选择";
        }


        //增加新员工
        private void btn_addNewEmployee_Click(object sender, EventArgs e)
        {
            DatabaseOP insertDB = new DatabaseOP();
            String newEmployeeName = newNameBox.Text.Trim();
            String newEmployeeID = newIDBox.Text.Trim();
            insertDB.insertData(newEmployeeName,newEmployeeID);
            String employeeSelect = "select * from db_Employee";
            DataSet ds = new DataSet();
            ds = insertDB.getDS(employeeSelect);
            employeeDataGridView.DataSource = ds.Tables[0].DefaultView;
            newNameBox.Clear();
            newIDBox.Clear();
        }


        //查看库存
        private void getStore_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            String selectStr = "select * from db_Store;";
            ds = allOperate.getDS(selectStr);
            dataGridView1.DataSource = ds.Tables[0];
            
        }


        //打印，问题尚未解决
        private void printBtn_Click(object sender, EventArgs e)
        {
            
           
            
        }


        //添加新产品
        private void addNewProduct_Click(object sender, EventArgs e)
        {
            DatabaseOP addPro = new DatabaseOP();
            String newSort = sortTextBox.Text.Trim();
            String newType = typeTextBox.Text.Trim();
            addPro.addNewProduct(newSort,newType);
            DataSet ds = new DataSet();
            ds = addPro.getDS("select * from db_Product;");
            productDataGridView.DataSource = ds.Tables[0].DefaultView;
            sortTextBox.Clear();
            typeTextBox.Clear();
        }

        

        //刷新销售记录
        private void viewAllSaleBtn_Click(object sender, EventArgs e)
        {
            DatabaseOP viewAllSale = new DatabaseOP();
            DataSet getAllSale = new DataSet();
            getAllSale = viewAllSale.viewSaleRecorde();
            allSaleDataGridView.DataSource = getAllSale.Tables[0].DefaultView;
        }

        private void viewEmployeeName_SelectedValueChanged(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            String cmdEmployeeID = "select * from db_Employee where EmployeeName = '" + viewEmployeeName.SelectedValue.ToString() + "'";
            ds = allOperate.getDS(cmdEmployeeID);
           
            viewEmployeeID.DataSource = ds.Tables[0];
            viewEmployeeID.DisplayMember = "EmployeeID";
        }


        //公司总体销售情况
        private void viewSale_Click(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;

            DataSet ds = new DataSet();
            ds = allOperate.viewMonthProfit(int.Parse(dt.Month.ToString()),int.Parse(dt.Year.ToString()));
            dataGridViewProfit.DataSource = ds.Tables[0].DefaultView;
            Object obj = new Object();
            obj = allOperate.profitMonthShow(int.Parse(dt.Month.ToString()),int.Parse(dt.Year.ToString()));
            profitLabel.Text = obj.ToString();
        }


        //个人日销售明细
        private void daySaleBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
         
            DataSet ds = new DataSet();
            DatabaseOP db = new DatabaseOP();
            ds = db.viewProfit(viewEmployeeID.Text.Trim(),int.Parse(dt.Day.ToString()),int.Parse(dt.Year.ToString()));
            dataGridViewProfit.DataSource = ds.Tables[0].DefaultView;
            profitLabel.Text = allOperate.showDayProfit(viewEmployeeID.Text.Trim(), int.Parse(dt.Day.ToString()), int.Parse(dt.Year.ToString())).ToString();

        }


        //个人月销售明细
        private void monthSaleBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
       
            DataSet ds = new DataSet();
            DatabaseOP db = new DatabaseOP();
            ds = db.viewMonthProfit(viewEmployeeID.Text.Trim(), int.Parse(dt.Month.ToString()),int.Parse(dt.Year.ToString()));
            dataGridViewProfit.DataSource = ds.Tables[0].DefaultView;
            profitLabel.Text = allOperate.showMonthProfit(viewEmployeeID.Text.Trim(), int.Parse(dt.Month.ToString()), int.Parse(dt.Year.ToString())).ToString();
        }


        //公司日销售明细
        private void allDaySaleBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DataSet ds = new DataSet();
            ds = allOperate.viewProfit(int.Parse(dt.Day.ToString()),int.Parse(dt.Year.ToString()));
            dataGridViewProfit.DataSource = ds.Tables[0].DefaultView;
            Object obj = allOperate.profitShow(int.Parse(dt.Day.ToString()), int.Parse(dt.Year.ToString()));
            profitLabel.Text = obj.ToString();
        }

        

       

       

        

        

       
       

   

      

        

        
    }
}
