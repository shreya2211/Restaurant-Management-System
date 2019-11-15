using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace restaurant
{
    class Updates
    {
        public static int updateOrder(Int64 orderID, float amountPaid, float amtReturned, Int16 status)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateOrder", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amtPaid", amountPaid);
                cmd.Parameters.AddWithValue("@amtReturned", amtReturned);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                MainClass.con.Open();
                res = cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save the Order.", "error");
            }
            return res;
        }
        public static void updateOrderStatus(Int64 orderID, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateOrderStatus", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Order status updated.", "success");
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update ordder status.", "error");
            }
        }
        public static void updateMenuItem(int menuID,string name, float price, int catID, int status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateMenuItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@menuID", menuID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Menu Item '" + name + "' updated successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update the Menu Item.\nContact technical support", "error");
            }
        }
        public static void updateCategory(string name, int catID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", catID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " updated successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void updateRole(string role,Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateRole", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                cmd.Parameters.AddWithValue("@rid", roleID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if(res>0)
                {
                    MainClass.showMessage(role + " updated successfully into the system", "success");
                }
            }
            catch(Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void updateUsers(int userID,string name, string uname, string pass, string address, string phone, Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleID", roleID);
                cmd.Parameters.AddWithValue("@userID", userID);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " updated successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMessage("Unable to update the user.\nContact technical support", "error");
            }
        }
        public static void updateCustomer(Int64 cid,string name, string phone, string address)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@cID", cid);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + " updated successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update customer.\nContact technical support", "error");
            }
        }
        public static void updateFloors(Int16 floorID, string name, Int16 number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorNumber", number);
                cmd.Parameters.AddWithValue("@floorID", floorID);
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
                MainClass.showMessage("Unable to updated floor.\nContact technical support", "error");
            }
        }
        public static void updateTables(int tableID,int tableNumber, Int16 chairs, Int16 floorID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                cmd.Parameters.AddWithValue("@tableID", tableID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tableNumber + " updated successfully into the system.", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save table.\nContact technical support", "error");
            }
        }
    }
}
