using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace restaurant
{
    class insertion
    {
        public static void insertOrder(DateTime date,Int64 custID, Int16 orderType, Int16 floorID,Int16 tableID,float tamount,float amountPaid,float amtReturned,Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertOrder", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.Parameters.AddWithValue("@orderType", orderType);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                cmd.Parameters.AddWithValue("@tableID", tableID);
                cmd.Parameters.AddWithValue("@tAmount", tamount);
                cmd.Parameters.AddWithValue("@amtPaid", amountPaid);
                cmd.Parameters.AddWithValue("@amtReturned", amtReturned);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Order placed successfully.", "success");
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
        }
        public static int insertOrderDetails(Int64 orderID,int proID,Int16 quantity)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertOrderDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                MainClass.con.Open();
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save the Menu Item.\nThe table may already exist.\nContact technical support", "error");
            }
            return res;
        }
        public static void insertMenuItem(string name,float price,int catID,int status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertMenuItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Menu Item '" + name + "' added successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save the Menu Item.\nThe table may already exist.\nContact technical support", "error");
            }
        }
        public static void insertCategory(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Category "+name + " added successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save the Category.\nThe table may already exist.\nContact technical support", "error");
            }
        }
        public static void insertTables(int tableNumber, Int16 chairs, Int16 floorID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tableNumber + " added successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save table.\nThe table may already exist.\nContact technical support", "error");
            }
        }
        public static void insertFloors(string name, Int16 number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorNumber", number);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " added successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save floor.\nThe floor may already exist.\nContact technical support", "error");
            }
        }
        public static void insertCustomer(string name,string phone,string address)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " added successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save customer.\nThe customer may already exist.\nContact technical support", "error");
            }
        }
        public static void insertRole(string role)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(role + " added successfully into the system.", "success");
                }
            }
            catch(Exception)
            {
                
                MainClass.con.Close();
                MainClass.showMessage("Unable to save role.\nThe role may already exist.\nContact technical support", "error");


            }
            

        }
        public static void insertUsers(string name,string uname, string pass, string address, string phone,Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleID", roleID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " added successfully into the system.", "success");
                }
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMessage("Unable to save user.\nThe user may already exist.\nContact technical support", "error");


            }


        }
    }
}
