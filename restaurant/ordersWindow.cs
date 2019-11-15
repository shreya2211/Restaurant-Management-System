using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace restaurant
{
    public partial class ordersWindow : Sample2
    {
        public ordersWindow()
        {
            InitializeComponent();
        }
        private void ordersWindow_Load(object sender, EventArgs e)
        {
            RetrivalData.loadItems("st_getMenu",itemListBox, "Menu Name", "Menu ID");
            RetrivalData.loadItems("st_getMenu", itemDD, "Menu Name", "Menu ID");
            itemDD.SelectedIndex = -1;
            RetrivalData.loadItems("st_getFloors", floorDD, "Floor", "ID");
            floorDD.SelectedIndex = -1;
        }
        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void itemDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(itemDD.SelectedIndex!=-1)
            {
                try
                {
                    itemEL.Visible = false;
                    SqlCommand cmd = new SqlCommand("st_getPriceWRTitem",MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(itemDD.SelectedValue.ToString()));
                    MainClass.con.Open();
                    priceTxt.Text =Math.Round(Convert.ToDouble(cmd.ExecuteScalar().ToString()),0).ToString();
                    MainClass.con.Close();
                    DataRowView drv = itemDD.SelectedItem as DataRowView;
                    RetrivalData.loadCategoryWRTItem(drv["Menu Name"].ToString());
                }
                catch(Exception ex)
                {
                    MainClass.showMessage(ex.Message, "error");
                }
            }
            else
            {
                itemEL.Visible = true;
                priceTxt.Text = "";
            }
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            if(priceTxt.Text=="")
            {
                priceEL.Visible = true;
            }
            else
            {
                priceEL.Visible = false;
            }
        }
        private void quantityDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void floorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(floorDD.SelectedIndex!=-1)
            {
                RetrivalData.loadItems("st_getTablesWRTfloor", tableDD, "Table Number", "Table ID", "@floorID",Convert.ToInt32(floorDD.SelectedValue.ToString()));
                tableDD.SelectedIndex = -1;
            }
        }
        private void orderDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderDD.SelectedIndex==0)
            {
                floorDD.Enabled = true;
                tableDD.Enabled = true;
                phonetxt.Visible = false;
                phoneLabel.Visible = false;
                floorEL.Visible = true;
                tableEL.Visible = true;
                PhoneEL.Visible = false;
            }
            else
            {
                floorDD.Enabled = false;
                tableDD.Enabled = false;
                phonetxt.Visible = true;
                phoneLabel.Visible = true;
                floorEL.Visible = false;
                tableEL.Visible = false;
                PhoneEL.Visible = true;
            }
        }

        float totalAmount = 0;
        int catID; string catName;
        private void cartButton_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count != 0)
            {
                MainClass.showMessage("Please enter all the required field", "error"); 
            }
            else
            {
                bool check = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    if(row.Cells["itemIDGV"].Value.ToString()==itemDD.SelectedValue.ToString())
                    {
                        check = true;
                        break;
                    }
                }
                DataRowView drvFloor = floorDD.SelectedItem as DataRowView;
                DataRowView drvTable = tableDD.SelectedItem as DataRowView;
                DataRowView drvItems = itemDD.SelectedItem as DataRowView;
                try
                {

                    if (check)
                    {
                        MainClass.showMessage("Item added already!", "error");
                    }
                    else
                    {
                        catID = RetrivalData.CATEGORYID;
                        catName = RetrivalData.CATEGORYNAME;
                        if (orderDD.SelectedIndex == 0)
                        {

                            totalAmount += Convert.ToSingle(priceTxt.Text) * Convert.ToSingle(numericUpDown1.Value);
                            totalLabel.Text = totalAmount.ToString();
                            dataGridView1.Rows.Add(null, Convert.ToInt32(tableDD.SelectedValue.ToString()),
                                Convert.ToInt32(floorDD.SelectedValue.ToString()),
                                catID, catName,
                                Convert.ToInt32(itemDD.SelectedValue.ToString()),
                                drvItems["Menu Name"],
                                Convert.ToSingle(priceTxt.Text),
                                Convert.ToInt32(numericUpDown1.Text),
                                orderDD.SelectedItem.ToString(),
                                drvFloor["Floor"],
                                drvTable["Table Number"],
                               null);
                        }
                        else if (orderDD.SelectedIndex == 1 || orderDD.SelectedIndex == 2)
                        {
                            totalAmount += Convert.ToSingle(priceTxt.Text) * Convert.ToSingle(numericUpDown1.Value);
                            totalLabel.Text = totalAmount.ToString();
                            dataGridView1.Rows.Add(null, null, null, catID, catName, Convert.ToInt32(itemDD.SelectedValue.ToString()), drvItems["Menu Name"],
                                Convert.ToSingle(priceTxt.Text),
                                Convert.ToInt32(numericUpDown1.Text),
                                orderDD.SelectedItem.ToString(), null,
                                null, phonetxt.Text);
                        }
                    }
                }
                catch(Exception)
                {
                    MainClass.showMessage("Please enter all the fields.", "error");
                }
            }
            MainClass.sno(dataGridView1, "snoGV");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
                quantityEL.Visible = true;
            else
                quantityEL.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1&& e.ColumnIndex!=1)
            {
                if(e.ColumnIndex==13)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    float prc = Convert.ToSingle(row.Cells["priceGV"].Value.ToString())* Convert.ToSingle(numericUpDown1.Value);
                    totalAmount -= prc;
                    totalLabel.Text = totalAmount.ToString();
                    dataGridView1.Rows.Remove(row);
                    MainClass.sno(dataGridView1, "snoGV");
                }
            }
        }

        private void quantityEL_Click(object sender, EventArgs e)
        {

        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            using (TransactionScope sc=new TransactionScope())
            {
                try
                {
                    if(orderDD.SelectedIndex==0)
                    {
                        insertion.insertOrder(DateTime.Today, 1, Convert.ToInt16(orderDD.SelectedIndex), Convert.ToInt16(floorDD.SelectedValue.ToString()), Convert.ToInt16(tableDD.SelectedValue.ToString()),Convert.ToSingle(totalLabel.Text), 0, 0,0);
                        insertOrderDetails();
                    }
                    else
                    {
                        insertion.insertOrder(DateTime.Today,custID, Convert.ToInt16(orderDD.SelectedIndex),0,
                           0, Convert.ToSingle(totalLabel.Text), 0, 0, 0);
                        insertOrderDetails();
                    }
                }
                catch(Exception)
                {
                }
                sc.Complete();
            }
        }
        private void insertOrderDetails()
        {
            Int64 orderID = RetrivalData.lastOrderID();
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count += insertion.insertOrderDetails(orderID, Convert.ToInt32(row.Cells["itemIDGV"].Value.ToString()),Convert.ToInt16(row.Cells["QuantityGV"].Value.ToString()));

            }
            if (count > 0)
            {
                
            }
            else
            {
                MainClass.showMessage("An Error Occured", "error");
            }
        }
        public override void deletebtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {

        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        Int64 custID;
        private void phonetxt_TextChanged(object sender, EventArgs e)
        {
            if (phonetxt.Text == "")
            {
                PhoneEL.Visible = true;
            }
            else
            {
                PhoneEL.Visible = false;
            }
        }

        private void phonetxt_Leave(object sender, EventArgs e)
        {
            if (phonetxt.Text != "")
            {
                PhoneEL.Visible = false;
                custID = RetrivalData.getCustIDwrtPhone(phonetxt.Text);
                if(custID==0)
                {
                    customersWindow cw = new customersWindow();
                    MainClass.showWindow(cw, this, MDI.ActiveForm);
                }
                else
                {
                    MainClass.showMessage(RetrivalData.CUSTOMER + "\n" + RetrivalData.ADDRESS + "\n","success");
                }
            }
        }

        private void tableDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableDD.SelectedIndex != -1)
            {
                if (RetrivalData.CheckTableStatus(Convert.ToInt32(tableDD.SelectedValue.ToString()), Convert.ToInt16(floorDD.SelectedValue.ToString())))
                {
                    tableDD.SelectedIndex = -1;
                }
            }
            
        }
    }
}