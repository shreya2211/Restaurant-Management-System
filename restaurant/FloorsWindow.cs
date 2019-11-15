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
    public partial class FloorsWindow : Sample2
    {
        public FloorsWindow()
        {
            InitializeComponent();
        }

        private void FloorsWindow_Load(object sender, EventArgs e)
        {

        }
        Int16 floorID;
        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save
                {
                    insertion.insertFloors(floorTxt.Text,Convert.ToInt16(floorNumberDD.SelectedItem.ToString()));
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
                }
                else if (edit == 1)//update
                {
                    Updates.updateFloors(floorID,floorTxt.Text, Convert.ToInt16(floorNumberDD.SelectedItem.ToString()));
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
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
                    Deletion.deleteData("st_deleteFloor", "@floorID", floorID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
                }
            }
        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            RetrivalData.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);

        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floorTxt_TextChanged(object sender, EventArgs e)
        {
            if (floorTxt.Text == "")
                floorErrorLabel.Visible = true;
            else
                floorErrorLabel.Visible = false;
        }

        private void floorNumberDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (floorNumberDD.SelectedIndex == -1)
                fnameErrorLabel.Visible = true;
            else
                fnameErrorLabel.Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                floorID = Convert.ToInt16(row.Cells["floorIDGV"].Value.ToString());
                floorNumberDD.SelectedItem = row.Cells["floorNumberGV"].Value.ToString();
                floorTxt.Text = row.Cells["floorNameGV"].Value.ToString();
            }
        }
    }
}
