using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;

namespace restaurant
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (serverTxt.Text == "")
            
                serverErrorLabel.Visible = true;
         
            else
                serverErrorLabel.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (databaseTxt.Text == "")
            {
                DbErrorLabel.Visible = true;
            }
            else
                DbErrorLabel.Visible = false;

        }

        private void itcb_CheckedChanged(object sender, EventArgs e)
        {
            if(iscb.Checked)
            {
                UserErrorLabel.Visible = false;
                PassErrorLabel.Visible = false;
                userTxt.Enabled = false;
                passTxt.Enabled = false;
                userTxt.Text = "";
                passTxt.Text = "";


            }
            else
            {
                userTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(!iscb.Checked)
            {
                if (userTxt.Text == "")
                {
                    UserErrorLabel.Visible = true;
                }
                else
                    UserErrorLabel.Visible = false;
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!iscb.Checked)
            {
                if (passTxt.Text == "")
                {
                    PassErrorLabel.Visible = true;
                }
                else
                    PassErrorLabel.Visible = false;
            }
        }

        public void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            File.WriteAllText(path, connection);
        }

        string connection;
        private void savebtn_Click(object sender, EventArgs e)
        {
            if(iscb.Checked)
            {
                if (serverTxt.Text == "")

                    serverErrorLabel.Visible = true;
                else
                    serverErrorLabel.Visible = false;

                if (databaseTxt.Text == "")
                {
                    DbErrorLabel.Visible = true;
                }
                else
                    DbErrorLabel.Visible = false;


                if(serverErrorLabel.Visible || DbErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are mandatory.", "error");
                }
                else
                {
                    connection = "Data Source=" + serverTxt.Text +
                        ";Initial Catalog=" + databaseTxt.Text +
                        ";Integrated Security=true;MultipleActiveResultSets=true";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Settings saved succesfully.");
                    if(dr==DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (serverTxt.Text == "")

                    serverErrorLabel.Visible = true;

                else
                    serverErrorLabel.Visible = false;

            

            
                if (databaseTxt.Text == "")
                {
                    DbErrorLabel.Visible = true;
                }
                else
                    DbErrorLabel.Visible = false;



                if (userTxt.Text == "")
                {
                    UserErrorLabel.Visible = true;
                }
                else
                    UserErrorLabel.Visible = false;


                if (passTxt.Text == "")
                {
                    PassErrorLabel.Visible = true;
                }
                else
                    PassErrorLabel.Visible = false;



                if (serverErrorLabel.Visible || DbErrorLabel.Visible || UserErrorLabel.Visible|| PassErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are mandatory.", "error");
                }
                else
                {
                    connection = "Data Source=" + serverTxt.Text +
                        ";Initial Catalog=" + databaseTxt.Text +
                        ";User Id="+userTxt.Text+";Password="+passTxt.Text+
                        ";MultipleActiveResultSets=true";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Settings saved succesfully.");
                    if (dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }

                }
            }
        }

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
