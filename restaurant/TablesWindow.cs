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
    public partial class TablesWindow : Sample2
    {
        int tableID;
        public TablesWindow()
        {
            InitializeComponent();
        }

        private void TablesWindow_Load(object sender, EventArgs e)
        {
            RetrivalData.loadItems("st_getFloors", floorNumberDD, "Floor", "ID");
            floorNumberDD.SelectedIndex = -1;
        }
        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save
                {
                    insertion.insertTables(Convert.ToInt32(tablenumberDD.SelectedItem.ToString()), Convert.ToInt16(chairsDD.SelectedItem.ToString()), Convert.ToInt16(floorNumberDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV,tableIDGV,ChairsGV);
                }
                else if (edit == 1)//update
                {
                    Updates.updateTables(tableID,Convert.ToInt32(tablenumberDD.SelectedItem.ToString()), Convert.ToInt16(chairsDD.SelectedItem.ToString()), Convert.ToInt16(floorNumberDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableIDGV, ChairsGV);
                }
            }
            else
            {
                MessageBox.Show("Please enter all required fields");
            }
        }

        public override void deletebtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Want to delete this record?", "Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteTables", "@tableID", tableID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableIDGV, ChairsGV);
                }
            }
        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            RetrivalData.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableIDGV, ChairsGV);

        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tableID = Convert.ToInt32(row.Cells["tableIDGV"].Value.ToString());
                tablenumberDD.SelectedItem = row.Cells["TableNumberGV"].Value.ToString();
                chairsDD.SelectedItem = row.Cells["ChairsGV"].Value.ToString();
                floorNumberDD.SelectedValue = row.Cells["floorIDGV"].Value;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
