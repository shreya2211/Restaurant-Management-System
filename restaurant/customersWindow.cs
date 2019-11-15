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
    public partial class customersWindow : Sample2
    {
        public customersWindow()
        {
            InitializeComponent();
        }

        private void customersWindow_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                custID = Convert.ToInt64(row.Cells["custIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
            }
        }
        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save
                {
                    insertion.insertCustomer(nameTxt.Text, phoneTxt.Text, addressTxt.Text);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getCustomer(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);
                }
                else if (edit == 1)//update
                {
                    Updates.updateCustomer(custID, nameTxt.Text, phoneTxt.Text,addressTxt.Text);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getCustomer(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);
                }
            }
            else
            {
                MessageBox.Show("Please enter all required fiels");
            }
        }
        Int64 custID;
        public override void deletebtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Want to delete this record?", "Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteCustomer", "@cID",0, custID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getCustomer(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);
                }
            }
        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            RetrivalData.getCustomer(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);

        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
                nameErrorLabel.Visible = true;
            else
                nameErrorLabel.Visible = false;
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
                phoneErrorLabel.Visible = true;
            else
                phoneErrorLabel.Visible = false;
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "")
                addressErrorLabel.Visible = true;
            else
                addressErrorLabel.Visible = false;
        }
    }
}
