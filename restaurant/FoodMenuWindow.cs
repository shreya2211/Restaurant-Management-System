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
    public partial class FoodMenuWindow : Sample2
    {
        public FoodMenuWindow()
        {
            InitializeComponent();
        }

        private void FoodMenuWindow_Load(object sender, EventArgs e)
        {
            RetrivalData.loadItems("st_getCategories", categoryDD, "Category", "ID");
            categoryDD.SelectedIndex = -1;
        }

        private void itemTxt_TextChanged(object sender, EventArgs e)
        {
            if (itemTxt.Text == "")
                itemErrorLabel.Visible = true;
            else
                itemErrorLabel.Visible = false;
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryDD.SelectedIndex == -1)
                CategoryErrorLabel.Visible = true;
            else
                CategoryErrorLabel.Visible = false;
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            if (priceTxt.Text == "")
                PriceErrorLabel.Visible = true;
            else
                PriceErrorLabel.Visible = false;
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1)
                statusErrorLabel.Visible = true;
            else
                statusErrorLabel.Visible = false;
        }
        int menuID;
        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                short status = statusDD.SelectedItem == "Available" ? Convert.ToInt16(1) : Convert.ToInt16(0);

                if (edit == 0)//save
                {
                    insertion.insertMenuItem(itemTxt.Text,Convert.ToSingle(priceTxt.Text),Convert.ToInt32(categoryDD.SelectedValue.ToString()),status);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getMenu(dataGridView1, catIDGV, catGV,MenuItemGV,menuIDGV,priceGV,StatusGV);
                }
                else if (edit == 1)//update
                {
                    Updates.updateMenuItem(menuID,itemTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryDD.SelectedValue.ToString()), status);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getMenu(dataGridView1, catIDGV, catGV, MenuItemGV, menuIDGV, priceGV, StatusGV);
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
                    Deletion.deleteData("st_deleteMenuItem", "@menuID", menuID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getMenu(dataGridView1, catIDGV, catGV, MenuItemGV, menuIDGV, priceGV, StatusGV);
                }
            }
        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            RetrivalData.getMenu(dataGridView1, catIDGV, catGV, MenuItemGV, menuIDGV, priceGV, StatusGV);

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
                menuID = Convert.ToInt32(row.Cells["menuIDGV"].Value.ToString());
                categoryDD.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                itemTxt.Text = row.Cells["MenuItemGV"].Value.ToString();
                priceTxt.Text = row.Cells["priceGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}
