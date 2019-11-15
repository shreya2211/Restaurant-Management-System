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
    public partial class FoodCategoryWindow : Sample2
    {
        public FoodCategoryWindow()
        {
            InitializeComponent();
        }

        private void FoodCategoryWindow_Load(object sender, EventArgs e)
        {

        }
        int catID;
        private void categoryTxt_TextChanged(object sender, EventArgs e)
        {
            if (categoryTxt.Text == "")
                categoryErrorLabel.Visible = true;
            else
                categoryErrorLabel.Visible = false;
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save
                {
                    insertion.insertCategory(categoryTxt.Text);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getCategory(dataGridView1, catIDGV, catGV);
                }
                else if (edit == 1)//update
                {
                    Updates.updateCategory(categoryTxt.Text,catID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getCategory(dataGridView1, catIDGV, catGV);
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
                    Deletion.deleteData("st_deleteCategory", "@id", catID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getCategory(dataGridView1, catIDGV, catGV);
                }
            }
        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            RetrivalData.getCategory(dataGridView1, catIDGV, catGV);

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
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                categoryTxt.Text = row.Cells["catGV"].Value.ToString();
            }
        }
    }
}
