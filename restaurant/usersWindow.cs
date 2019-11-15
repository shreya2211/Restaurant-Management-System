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
    public partial class usersWindow : Sample2 
    {
        public usersWindow()
        {
            InitializeComponent();
        }

        private void usersWindow_Load(object sender, EventArgs e)
        {
            RetrivalData.loadItems("st_getRoles", rolesDD, "Role", "RoleID");
            rolesDD.SelectedIndex = -1;
            roleErrorLabel.Visible = false;

        }

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (userTxt.Text == "") { usersErrorLabel.Visible = true; } else { usersErrorLabel.Visible = false; }

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
            { phoneErrorLabel.Visible = true; }
            else 
            { phoneErrorLabel.Visible = false; }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rolesDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolesDD.SelectedIndex== -1) { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }


        int userID;
        public override void savebtn_Click(object sender, EventArgs e)
        {
            if(MainClass.checkControls(leftpanel).Count==0)
            {
                if(edit==0)//save
                {
                    insertion.insertUsers(userTxt.Text, usernameTxt.Text, passwordTxt.Text, addressTxt.Text, phoneTxt.Text, Convert.ToInt16(rolesDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, RoleIDGV, RoleGV);
                }
                else if(edit==1)//update
                {
                   Updates.updateUsers(userID,userTxt.Text, usernameTxt.Text, passwordTxt.Text, addressTxt.Text, phoneTxt.Text, Convert.ToInt16(rolesDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, RoleIDGV, RoleGV);
                }
            }
            else
            {
                MessageBox.Show("Please enter all required fiels");
            }
        }

        public override void deletebtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Want to delete this record?", "Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteUsers", "@userID", userID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, RoleIDGV, RoleGV);
                }
            }
        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            RetrivalData.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, RoleIDGV, RoleGV);

        }

        private void label10_Click(object sender, EventArgs e)
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
                userID = Convert.ToInt16(row.Cells["userIDGV"].Value.ToString());
                userTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["usernameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["passGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                rolesDD.SelectedValue = row.Cells["roleIDGV"].Value;
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
