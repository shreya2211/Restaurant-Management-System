using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace restaurant
{
    class RetrivalData
    {
        public static void loadReport(ReportDocument rd ,CrystalReportViewer crv,int tableID,Int16 status,string phone = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderReport", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if(phone==null)
                {
                    cmd.Parameters.AddWithValue("@tableID", tableID);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@phone", null);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@tableID", null);

                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\billReport.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch(Exception ex)
            {
                if(rd!=null)
                {
                    rd.Close();
                }
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getOrderBill(string phone, DataGridView gv, DataGridViewColumn itemGV, DataGridViewColumn quantGV, DataGridViewColumn amountGV, DataGridViewColumn orderID, DataGridViewColumn totalAmountGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderSDetailsWRTPhone", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amountGV.DataPropertyName = dt.Columns["Price"].ToString();
                orderID.DataPropertyName = dt.Columns["ID"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Toatl Amount"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getOrderBill(int tableID,DataGridView gv,DataGridViewColumn itemGV,DataGridViewColumn quantGV,DataGridViewColumn amountGV,DataGridViewColumn orderID,DataGridViewColumn totalAmountGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderSDetailsWRTtables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableId", tableID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amountGV.DataPropertyName = dt.Columns["Price"].ToString();
                orderID.DataPropertyName = dt.Columns["ID"].ToString();
                totalAmountGV.DataPropertyName= dt.Columns["Toatl Amount"].ToString();
                gv.DataSource=dt;
            } 
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getPendingOrderdetails(Int64 orderid,DataGridView gv,DataGridViewColumn prodGV,DataGridViewColumn quantityGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prodGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static void getPendingOrders(DataGridView gv, DataGridViewColumn orderIDGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrders", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderIDGV.DataPropertyName = dt.Columns["OrderID"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, "error");
            }
        }
        private static string customer, address;
        public static string CUSTOMER
        {
           
            get
            {
                return customer;
            }
            private set
            {
                customer = value;
            }
        }
        public static string ADDRESS
        {

            get
            {
                return address;
            }
            private set
            {
                address = value;
            }
        }

        public static Int64 getCustIDwrtPhone(string phone)
        {
            Int64 custID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustIdWRTPhone", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        custID = Convert.ToInt64(dr["CustomerID"].ToString());
                        CUSTOMER = dr["Name"].ToString();
                        ADDRESS = dr["Address"].ToString();
                    }
                }
                else
                {
                    custID = 0;
                    CUSTOMER = "";
                    ADDRESS = "";
                }
                MainClass.con.Close();
            }
            catch(Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
            return custID;
        }
        public static void getMenu(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catGV,DataGridViewColumn menuItemGV,DataGridViewColumn menuItemIDGV, 
            DataGridViewColumn priceGV,DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMenu", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); ;
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                menuItemGV.DataPropertyName = dt.Columns["Menu Name"].ToString();
                menuItemIDGV.DataPropertyName = dt.Columns["Menu ID"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, " error");
            }
        }
        public static void getCategory(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategories", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); ;
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, " error");
            }
        }
        public static void getTables(DataGridView gv, DataGridViewColumn floorIDGV, DataGridViewColumn floornameGV,DataGridViewColumn tableNameGV ,DataGridViewColumn tableIDGV,DataGridViewColumn chairsGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); ;
                da.Fill(dt);
                floorIDGV.DataPropertyName = dt.Columns["Floor ID"].ToString();
                floornameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                tableIDGV.DataPropertyName = dt.Columns["Table ID"].ToString();
                chairsGV.DataPropertyName = dt.Columns["Chairs"].ToString();
                tableNameGV.DataPropertyName = dt.Columns["Table Number"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");

            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, " error");
            }
        }
        public static void getFloors(DataGridView gv, DataGridViewColumn floorIDGV, DataGridViewColumn nameGV, DataGridViewColumn floorNumberGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); ;
                da.Fill(dt);
                floorIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                floorNumberGV.DataPropertyName = dt.Columns["Floor Number"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");

            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, " error");
            }
        }
        public static void getCustomer(DataGridView gv, DataGridViewColumn custIDgv, DataGridViewColumn nameGV, DataGridViewColumn phoneGV, DataGridViewColumn addressGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustomers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); ;
                da.Fill(dt);
                custIDgv.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Customer"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");

            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, " error");
            }
        }
        public static void getRoles(DataGridView gv,DataGridViewColumn roleIDGV,DataGridViewColumn roleNameGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); ;
                da.Fill(dt);
                roleIDGV.DataPropertyName = dt.Columns["RoleID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV");
            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, " error");
            }
        }
        public static void loadItems(string proc,ComboBox cb,string dMember,string vMember,string param=null,int val=0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if(param==null && val==0)
                {

                }
                else
                {
                    cmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static void loadItems(string proc, ListBox cb, string dMember, string vMember, string param = null, int val = 0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param == null && val == 0)
                {

                }
                else
                {
                    cmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static int categoryID; private static string categoryName;
        public static int CATEGORYID
        {
            get
            {
                return categoryID;
            }
            private set
            {
                categoryID = value; 
            }
        }
        public static string CATEGORYNAME
        {
            get
            {
                return categoryName;
            }
            private set
            {
                categoryName = value;
            }
        }
        public static void loadCategoryWRTItem(string item)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoryWRTItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", item);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        CATEGORYID = Convert.ToInt32(dr[0].ToString());
                        CATEGORYNAME = dr[1].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Int64 lastOrderID()
        {
            Int64 orderID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastOrderId", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                orderID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                
            }
            return orderID;
        }

        public static bool CheckTableStatus(int tableID,Int16 floorID)
        {
            bool stat = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkTableStatus", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableID", tableID);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    stat = true;
                }
                else
                {
                    stat = false; 
                }
               
                MainClass.con.Close();
            }
            catch (Exception)
            {

            }
            return stat;
        }


        private static string name;
        private static string role;

        public static string USER
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public static string ROLE
        {
            get
            {
                return role;
            }
            private set
            {
                role = value;
            }
        }
        public static bool ValidUser(string user,string pass)
        {
            bool status = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserAuth", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        if(user==dr["Username"].ToString()&& pass == dr["Password"].ToString())
                        {
                            USER = dr["User"].ToString();
                            ROLE = dr["Role"].ToString();
                            status = true;
                        }
                        else
                        {
                            MainClass.showMessage("Invalid username or password.", "error");
                            status = false;
                        }
                    }
                }
                else
                {
                    MainClass.showMessage("Invalid username or password.", "error");
                    status = false;
                }
                MainClass.con.Close();
            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message,"error");
            }
            return status;
        }
        public static void getUsers(DataGridView gv, DataGridViewColumn userIDgv, DataGridViewColumn nameGV,DataGridViewColumn usernameGV, DataGridViewColumn passGV,DataGridViewColumn phoneGV, DataGridViewColumn addressGV, DataGridViewColumn roleIDGV, DataGridViewColumn roleGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); ;
                da.Fill(dt);
                userIDgv.DataPropertyName = dt.Columns["User ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["User"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                roleIDGV.DataPropertyName = dt.Columns["Role ID"].ToString();
                roleGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;
                MainClass.sno(gv, "snoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, " error");
            }
        }

    }
}
