using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Version1._0
{
    class DatabaseOP
    {
        private static String connectionStr = "server = localhost; uid = sa; pwd = zyx; database = CS;";
     
        SqlConnection sqlConn = new SqlConnection(connectionStr);


        //返回数据集
        public DataSet getDS(String sqlCommandStr)
        {
            
            DataSet ds = new DataSet();
            try
            {
                sqlConn.Open();
                
                SqlDataAdapter da = new SqlDataAdapter(sqlCommandStr, sqlConn);
                da.Fill(ds);
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
            return ds;
 
        }


        //加入新员工
        public void insertData(String newName,String newID)
        {
            String checkStr = "select EmployeeID from db_Employee where EmployeeID = @existID";
            String insertStr = "insert into db_Employee(EmployeeName,EmployeeID) values(@employeeName,@employeeID);";
            SqlCommand insertCommand = new SqlCommand(insertStr,sqlConn);
            SqlCommand checkCommand = new SqlCommand(checkStr,sqlConn);
            
            insertCommand.Prepare();
            insertCommand.Parameters.Add("@employeeName", SqlDbType.VarChar, 50);
            insertCommand.Parameters.Add("@employeeID", SqlDbType.VarChar, 50);
            checkCommand.Prepare();
            checkCommand.Parameters.Add("@existID",SqlDbType.VarChar,50);

            try
            {
                if (newName != String.Empty && newID != String.Empty)
                {
                    sqlConn.Open();
                    checkCommand.Parameters["@existID"].Value = newID;
                    Object obj = checkCommand.ExecuteScalar();
                    if (obj == null)
                    {
                        insertCommand.Parameters["@employeeName"].Value = newName;
                        insertCommand.Parameters["@employeeID"].Value = newID;
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("工号已经存在，请确认新员工的工号！");
                    }
                }
                else
                    MessageBox.Show("姓名和工号不能为空！");


            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        //添加销售记录
        public void addSaleRecorde(String EmployeeID,String Pro_Type,int Sale_Price,String CustomerName,String CustomerPhone,String CustomerAddress,String AddInfo,int SaleDay,int SaleMonth,int SaleYear)
        {
            String addSaleStr = @"insert into 
            db_Sale(EmployeeID,Pro_Type,Sale_Price,CustomerName,CustomerPhone,CustomerAddress,AddInfo,SaleDay,SaleMonth,SaleYear)
            values(@EmployeeID,@Pro_Type,@Sale_Price,@CustomerName,@CustomerPhone,@CustomerAddress,@AddInfo,@SaleDay,@SaleMonth,@SaleYear);";
            SqlCommand addSaleCommand = new SqlCommand(addSaleStr,sqlConn);
            addSaleCommand.Prepare();
            addSaleCommand.Parameters.Add("@EmployeeID",SqlDbType.VarChar,50);
            addSaleCommand.Parameters.Add("@Pro_Type", SqlDbType.VarChar, 50);
            addSaleCommand.Parameters.Add("@Sale_Price",SqlDbType.Int);
       
            addSaleCommand.Parameters.Add("@CustomerName", SqlDbType.VarChar, 50);
            addSaleCommand.Parameters.Add("@CustomerPhone", SqlDbType.VarChar, 50);
            addSaleCommand.Parameters.Add("@CustomerAddress", SqlDbType.VarChar, 100);
            addSaleCommand.Parameters.Add("@AddInfo", SqlDbType.VarChar, 50);
            addSaleCommand.Parameters.Add("@SaleDay",SqlDbType.Int);
            addSaleCommand.Parameters.Add("@SaleMonth",SqlDbType.Int);
            addSaleCommand.Parameters.Add("@SaleYear",SqlDbType.Int);

            //相应型号的库存数量应该减少
            String remainProStr = @"select Quantity from db_Store where Pro_Type = @salePro_Type";
            SqlCommand remainCommand = new SqlCommand(remainProStr,sqlConn);
            remainCommand.Prepare();
            remainCommand.Parameters.Add("@salePro_Type",SqlDbType.VarChar,50);
            String updateStoreStr = @"update db_Store set Quantity = @remainQuantity where Pro_Type = @salePro_Type";
            SqlCommand updateCommand = new SqlCommand(updateStoreStr,sqlConn);
            updateCommand.Prepare();
            updateCommand.Parameters.Add("@remainQuantity",SqlDbType.Int);
            updateCommand.Parameters.Add("@salePro_Type",SqlDbType.VarChar,50);


            try
            {
                sqlConn.Open();
                SqlTransaction test = sqlConn.BeginTransaction();
                addSaleCommand.Transaction = test;
                updateCommand.Transaction = test;

                addSaleCommand.Parameters["@EmployeeID"].Value = EmployeeID;
                addSaleCommand.Parameters["@Pro_Type"].Value = Pro_Type;
                addSaleCommand.Parameters["@Sale_Price"].Value = Sale_Price;

                addSaleCommand.Parameters["@CustomerName"].Value = CustomerName;
                addSaleCommand.Parameters["@CustomerPhone"].Value = CustomerPhone;
                addSaleCommand.Parameters["@CustomerAddress"].Value = CustomerAddress;
                addSaleCommand.Parameters["@AddInfo"].Value = AddInfo;
                addSaleCommand.Parameters["@SaleDay"].Value = SaleDay;
                addSaleCommand.Parameters["@SaleMonth"].Value = SaleMonth;
                addSaleCommand.Parameters["@SaleYear"].Value = SaleYear;

                remainCommand.Parameters["@salePro_Type"].Value = Pro_Type;
                updateCommand.Parameters["@salePro_Type"].Value = Pro_Type;
                
                Object getRemain = remainCommand.ExecuteScalar();
                int storeQuantity = Convert.ToInt32(getRemain);

                if (storeQuantity > 0)
                {
                    addSaleCommand.ExecuteNonQuery();
                    MessageBox.Show("销售记录添加成功！");

                    updateCommand.Parameters["@remainQuantity"].Value = storeQuantity - 1;
                    updateCommand.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("仓库中没有该型号的产品！");
                }
                test.Commit();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
          
        }


        //添加新产品
        public void addNewProduct(String newProductSort, String newProductType)
        {
            String checkStr = "select Pro_Type from db_Product where Pro_Type = @existPro_Type";
            String insertStr = "insert into db_Product(Pro_Sort,Pro_Type) values(@sortName,@sortType);";
            SqlCommand insertCommand = new SqlCommand(insertStr, sqlConn);
            SqlCommand checkCommand = new SqlCommand(checkStr, sqlConn);

            insertCommand.Prepare();
            insertCommand.Parameters.Add("@sortName", SqlDbType.VarChar, 50);
            insertCommand.Parameters.Add("@sortType", SqlDbType.VarChar, 50);
            checkCommand.Prepare();
            checkCommand.Parameters.Add("@existPro_Type", SqlDbType.VarChar, 50);
            if (newProductSort != String.Empty && newProductType != String.Empty)
            {
                try
                {

                    sqlConn.Open();
                    checkCommand.Parameters["@existPro_Type"].Value = newProductType;
                    Object obj = checkCommand.ExecuteScalar();
                    if (obj == null)
                    {
                        insertCommand.Parameters["@sortName"].Value = newProductSort;
                        insertCommand.Parameters["@sortType"].Value = newProductType;
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("产品型号已经存在！");
                    }


                }
                catch (Exception err)
                {
                    throw err;
                }
                finally
                {
                    sqlConn.Close();
                }
            }
            else
                MessageBox.Show("产品类型和型号不能为空！");
        }


        //更新库存
        public void inStore(String proSort,String proType,int quantity,int inPrice,DateTime dt)
        {
            try
            {
                sqlConn.Open();

                //获取库存量
                String selectStr = "select Quantity from db_Store where Pro_Type =@proType;";
                SqlCommand selectCommand = new SqlCommand(selectStr, sqlConn);
                selectCommand.Prepare();
                selectCommand.Parameters.Add("@proType",SqlDbType.VarChar,50);
                selectCommand.Parameters["@proType"].Value = proType;

                Object obj = selectCommand.ExecuteScalar();
                //增加库存
                
                int newQuantity = quantity;
                if (obj != null)
                {
                    //MessageBox.Show("产品存在！");
                    //Int32 exist_Quantity = (Int32)(selectCommand.ExecuteScalar());
                    int exist_Quantity = int.Parse(selectCommand.ExecuteScalar().ToString());
                   
                    newQuantity += exist_Quantity;
                    String updateStr = "update db_Store set Quantity = @newQuantity where Pro_Type = @proType";
                    SqlCommand cmd = new SqlCommand(updateStr, sqlConn);
                    cmd.Prepare();
                    cmd.Parameters.Add("@newQuantity",SqlDbType.Int);
                    cmd.Parameters.Add("@proType",SqlDbType.VarChar,50);
                    cmd.Parameters["@newQuantity"].Value = newQuantity;
                    cmd.Parameters["@proType"].Value = proType;

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    //MessageBox.Show("加入新产品");
                    newQuantity = quantity;
                    String insertStr = "insert into db_Store(Pro_Sort,Pro_Type,Quantity,In_Price,In_Date) values(@proSort,@proType,@quantity,@inPrice,@dt);";
                    SqlCommand cmd = new SqlCommand(insertStr, sqlConn);
                    cmd.Prepare();
                    cmd.Parameters.Add("@proSort",SqlDbType.VarChar,50);
                    cmd.Parameters.Add("@proType",SqlDbType.VarChar,50);
                    cmd.Parameters.Add("@quantity",SqlDbType.Int);
                    cmd.Parameters.Add("@inPrice",SqlDbType.Int);
                    cmd.Parameters.Add("@dt",SqlDbType.DateTime);

                    cmd.Parameters["@proSort"].Value = proSort;
                    cmd.Parameters["@proType"].Value = proType;
                    cmd.Parameters["@quantity"].Value = newQuantity;
                    cmd.Parameters["@inPrice"].Value = inPrice;
                    cmd.Parameters["@dt"].Value = dt;

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("库存更新成功");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                sqlConn.Close();

            }
 
        }

        
        //查看个人全部销售，功能尚未使用，暂时保留
        public DataSet viewProfit(String viewID)
        {
            String getProfitStr = @"select db_Sale.EmployeeID as 工号,
            db_Store.Pro_Sort as 产品种类,
            db_Sale.Pro_Type as 产品型号,
            db_Sale.Sale_Price as 销售价格,
            db_Store.In_Price as 进价,
            db_Sale.Sale_Price-db_Store.In_Price as 利润 
            from db_Sale 
            left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.EmployeeID = @getEmployeeID";
            SqlCommand viewProfitCommand = new SqlCommand(getProfitStr,sqlConn);
            viewProfitCommand.Prepare();
            viewProfitCommand.Parameters.Add("@getEmployeeID",SqlDbType.VarChar,50);
            viewProfitCommand.Parameters["@getEmployeeID"].Value = viewID;
            
            try
            {
                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(viewProfitCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
                //viewProfitCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        

        //个人日销售明细查询
        public DataSet viewProfit(String viewID,int saleDay,int saleYear)
        {
            String getProfitStr = @"select db_Sale.EmployeeID as 工号,
            db_Store.Pro_Sort as 产品种类,
            db_Sale.Pro_Type as 产品型号,
            db_Sale.Sale_Price as 销售价格,
            db_Store.In_Price as 进价,
            db_Sale.Sale_Price-db_Store.In_Price as 利润 
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.EmployeeID = @getEmployeeID and db_Sale.SaleDay = @saleDay and db_Sale.SaleYear = @saleYear";

            String profitStr = @"select 
            sum(db_Sale.Sale_Price-db_Store.In_Price) as 利润  
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.EmployeeID = @getEmployeeID and db_Sale.SaleDay = @saleDay and db_Sale.SaleYear = @saleYear";


            SqlCommand viewProfitCommand = new SqlCommand(getProfitStr, sqlConn);
            SqlCommand viewDayProfit = new SqlCommand(profitStr,sqlConn);

            viewProfitCommand.Prepare();
            viewProfitCommand.Parameters.Add("@getEmployeeID", SqlDbType.VarChar, 50);
            viewProfitCommand.Parameters.Add("@saleDay",SqlDbType.Int);
            viewProfitCommand.Parameters.Add("@saleYear",SqlDbType.Int);

            viewDayProfit.Parameters.Add("@getEmployeeID", SqlDbType.VarChar, 50);
            viewDayProfit.Parameters.Add("@saleDay", SqlDbType.Int);
            viewDayProfit.Parameters.Add("@saleYear", SqlDbType.Int);


            viewProfitCommand.Parameters["@getEmployeeID"].Value = viewID;
            viewProfitCommand.Parameters["@saleDay"].Value = saleDay;
            viewProfitCommand.Parameters["@saleYear"].Value = saleYear;

            viewDayProfit.Parameters["@getEmployeeID"].Value = viewID;
            viewDayProfit.Parameters["@saleDay"].Value = saleDay;
            viewDayProfit.Parameters["@saleYear"].Value = saleYear;

            try
            {
                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(viewProfitCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
               
                //viewProfitCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        //公司日销售情况
        public DataSet viewProfit(int saleDay, int saleYear)
        {
            String getProfitStr = @"select db_Sale.EmployeeID as 工号,
            db_Store.Pro_Sort as 产品种类,
            db_Sale.Pro_Type as 产品型号,
            db_Sale.Sale_Price as 销售价格,
            db_Store.In_Price as 进价,
            db_Sale.Sale_Price-db_Store.In_Price as 利润 
            
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.SaleDay = @saleDay and db_Sale.SaleYear = @saleYear";

            

            SqlCommand viewProfitCommand = new SqlCommand(getProfitStr, sqlConn);
            

            viewProfitCommand.Prepare();
            viewProfitCommand.Parameters.Add("@saleDay", SqlDbType.Int);
            viewProfitCommand.Parameters.Add("@saleYear", SqlDbType.Int);

            

            viewProfitCommand.Parameters["@saleDay"].Value = saleDay;
            viewProfitCommand.Parameters["@saleYear"].Value = saleYear;

            

            try
            {
                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(viewProfitCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
               
                //viewProfitCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        //公司月销售情况
        public DataSet viewMonthProfit(int saleMonth, int saleYear)
        {
            String getProfitStr = @"select db_Sale.EmployeeID as 工号,
            db_Store.Pro_Sort as 产品种类,
            db_Sale.Pro_Type as 产品型号,
            db_Sale.Sale_Price as 销售价格,
            db_Store.In_Price as 进价,
            db_Sale.Sale_Price-db_Store.In_Price as 利润 
            
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.SaleMonth = @saleMonth and db_Sale.SaleYear = @saleYear";



            SqlCommand viewProfitCommand = new SqlCommand(getProfitStr, sqlConn);


            viewProfitCommand.Prepare();
            viewProfitCommand.Parameters.Add("@saleMonth", SqlDbType.Int);
            viewProfitCommand.Parameters.Add("@saleYear", SqlDbType.Int);



            viewProfitCommand.Parameters["@saleMonth"].Value = saleMonth;
            viewProfitCommand.Parameters["@saleYear"].Value = saleYear;



            try
            {
                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(viewProfitCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

                //viewProfitCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        //公司每天销售利润
        public Object profitShow(int saleDay, int saleYear)
        {
            String profitAllStr = @"select
            sum(db_Sale.Sale_Price-db_Store.In_Price) as 利润 
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.SaleDay = @saleDay and db_Sale.SaleYear = @saleYear";
            SqlCommand viewAllProfitCommand = new SqlCommand(profitAllStr, sqlConn);
            viewAllProfitCommand.Prepare();
            viewAllProfitCommand.Parameters.Add("@saleDay", SqlDbType.Int);
            viewAllProfitCommand.Parameters.Add("@saleYear", SqlDbType.Int);
            viewAllProfitCommand.Parameters["@saleDay"].Value = saleDay;
            viewAllProfitCommand.Parameters["@saleYear"].Value = saleYear;

            try
            {
                sqlConn.Open();
                Object obj = viewAllProfitCommand.ExecuteScalar();
                return obj;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
            
 
        }


        //公司每月销售利润
        public Object profitMonthShow(int saleMonth, int saleYear)
        {
            String profitAllStr = @"select
            sum(db_Sale.Sale_Price-db_Store.In_Price) as 利润 
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.SaleMonth = @saleMonth and db_Sale.SaleYear = @saleYear";
            SqlCommand viewAllProfitCommand = new SqlCommand(profitAllStr, sqlConn);
            viewAllProfitCommand.Prepare();
            viewAllProfitCommand.Parameters.Add("@saleMonth", SqlDbType.Int);
            viewAllProfitCommand.Parameters.Add("@saleYear", SqlDbType.Int);
            viewAllProfitCommand.Parameters["@saleMonth"].Value = saleMonth;
            viewAllProfitCommand.Parameters["@saleYear"].Value = saleYear;

            try
            {
                sqlConn.Open();
                Object obj = viewAllProfitCommand.ExecuteScalar();
                return obj;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }


        }


        //个人每天销售利润
        public Object showDayProfit(String viewID, int saleDay, int saleYear)
        {
            

            String profitStr = @"select 
            sum(db_Sale.Sale_Price-db_Store.In_Price) as 利润  
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.EmployeeID = @getEmployeeID and db_Sale.SaleDay = @saleDay and db_Sale.SaleYear = @saleYear";

            SqlCommand viewDayProfit = new SqlCommand(profitStr, sqlConn);

            viewDayProfit.Prepare();

            viewDayProfit.Parameters.Add("@getEmployeeID", SqlDbType.VarChar, 50);
            viewDayProfit.Parameters.Add("@saleDay", SqlDbType.Int);
            viewDayProfit.Parameters.Add("@saleYear", SqlDbType.Int);

            viewDayProfit.Parameters["@getEmployeeID"].Value = viewID;
            viewDayProfit.Parameters["@saleDay"].Value = saleDay;
            viewDayProfit.Parameters["@saleYear"].Value = saleYear;

            try
            {
                sqlConn.Open();
                Object obj = viewDayProfit.ExecuteScalar();
                return obj;

                //viewProfitCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        //个人每月销售利润
        public Object showMonthProfit(String viewID, int saleMonth, int saleYear)
        {
            String monthProfitStr = @"select 
            sum(db_Sale.Sale_Price-db_Store.In_Price) as 利润 
            from 
            db_Sale left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.EmployeeID = @getEmployeeID and db_Sale.SaleMonth = @saleMonth and db_Sale.SaleYear = @saleYear";

            SqlCommand monthProfitCommand = new SqlCommand(monthProfitStr, sqlConn);
            monthProfitCommand.Prepare();
            monthProfitCommand.Parameters.Add("@getEmployeeID", SqlDbType.VarChar, 50);
            monthProfitCommand.Parameters.Add("@saleMonth", SqlDbType.Int);
            monthProfitCommand.Parameters.Add("@saleYear", SqlDbType.Int);

            monthProfitCommand.Parameters["@getEmployeeID"].Value = viewID;
            monthProfitCommand.Parameters["@saleMonth"].Value = saleMonth;
            monthProfitCommand.Parameters["@saleYear"].Value = saleYear;

            try
            {
                sqlConn.Open();
                Object obj = monthProfitCommand.ExecuteScalar();
                return obj;
                //viewProfitCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        //个人月销售明细
        public DataSet viewMonthProfit(String viewID, int saleMonth,int saleYear)
        {
            String getProfitStr = @"select db_Sale.EmployeeID as 工号,
            db_Store.Pro_Sort as 产品种类,
            db_Sale.Pro_Type as 产品型号,
            db_Sale.Sale_Price as 销售价格,
            db_Store.In_Price as 进价,
            db_Sale.Sale_Price-db_Store.In_Price as 利润 
            from db_Sale 
            left join db_Store on db_Sale.Pro_Type = db_Store.Pro_Type 
            where db_Sale.EmployeeID = @getEmployeeID and db_Sale.SaleMonth = @saleMonth and db_Sale.SaleYear = @saleYear";
            SqlCommand viewProfitCommand = new SqlCommand(getProfitStr, sqlConn);
            viewProfitCommand.Prepare();
            viewProfitCommand.Parameters.Add("@getEmployeeID", SqlDbType.VarChar, 50);
            viewProfitCommand.Parameters.Add("@saleMonth", SqlDbType.Int);
            viewProfitCommand.Parameters.Add("@saleYear",SqlDbType.Int);

            viewProfitCommand.Parameters["@getEmployeeID"].Value = viewID;
            viewProfitCommand.Parameters["@saleMonth"].Value = saleMonth;
            viewProfitCommand.Parameters["@saleYear"].Value = saleYear;

            try
            {
                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(viewProfitCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
                //viewProfitCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        //查看销售记录
        public DataSet viewSaleRecorde()
        {
            DataSet ds = new DataSet();
            String saleDetailsStr = @"select EmployeeID as 工号,
            Pro_Type as 产品型号,
            Sale_Price as 售价,
            SaleYear as 年,
            SaleMonth as 月,
            SaleDay as 日
            from db_Sale
            order by SaleYear desc,SaleMonth desc,SaleDay desc;";
            SqlCommand saleCommand = new SqlCommand(saleDetailsStr,sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(saleCommand);
            da.Fill(ds);
            return ds;
        }

    }
}
