using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class ChefOrderWindow : Sample2
    {
        public ChefOrderWindow()
        {
            InitializeComponent();
        }
        public override void button6_Click(object sender, EventArgs e)
        {
            HomeScreen2 hs = new HomeScreen2();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
            
        }

        private void ChefOrderWindow_Load(object sender, EventArgs e)
        {
            RetrivalData.getPendingOrders(dataGridView1,orderIDGV,statusGV);
            MainClass.sno(dataGridView1, "snoGV");
            addbtn.Visible = false;
            deletebtn.Visible = false; searchtxt.Visible = false;

        }
        Int64 orderID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1&& e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                orderID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                RetrivalData.getPendingOrderdetails(orderID, dataGridView2,productGV,quantityGV);
                MainClass.sno(dataGridView1, "snoGV");
                if(e.ColumnIndex==3)
                {
                    DialogResult dr = MessageBox.Show("Are you sure?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr==DialogResult.Yes)
                    {
                        Updates.updateOrderStatus(orderID, 1);
                        RetrivalData.getPendingOrders(dataGridView1, orderIDGV, statusGV);
                        MainClass.sno(dataGridView1, "snoGV");
                    }
                }
            }
        }
        private void ChefOrderWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            RetrivalData.getPendingOrders(dataGridView1, orderIDGV, statusGV);
            MainClass.sno(dataGridView1, "snoGV");
        }
    }
}
