using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class rolesWindow : Sample2
    {
        public rolesWindow()
        {
            InitializeComponent();
        }
       
        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (rolesTxt.Text == "") { rolesErrorLabel.Visible = true; } else { rolesErrorLabel.Visible = false; }
            if(rolesErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are mandatory", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    insertion.insertRole(rolesTxt.Text);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getRoles(dataGridView1, RoleIDGV, RoleGV);
                }
                else if(edit==1)
                {
                    Updates.updateRole(rolesTxt.Text, roleID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getRoles(dataGridView1, RoleIDGV, RoleGV);
                }
            }
        }


        public override void deletebtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {
                DialogResult dr = MessageBox.Show("Want to delete this record?", "Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr== DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteRole", "@rid", roleID);
                    MainClass.resetDisable(leftpanel);
                    RetrivalData.getRoles(dataGridView1, RoleIDGV, RoleGV);
                }
            }
               
        }

        public override void viewbtn_Click(object sender, EventArgs e)
        {
            RetrivalData.getRoles(dataGridView1, RoleIDGV, RoleGV);
        }
        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void rolesTxt_TextChanged(object sender, EventArgs e)
        {
            if (rolesTxt.Text == "")
                rolesErrorLabel.Visible = true;
            else
                rolesErrorLabel.Visible = false;

        }
        Int16 roleID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1&&e.ColumnIndex!=-1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt16(row.Cells["RoleIDGV"].Value.ToString());
                rolesTxt.Text = row.Cells["RoleGV"].Value.ToString();
            }
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
