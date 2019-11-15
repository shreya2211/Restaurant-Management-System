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
    public partial class LoginScreen : Sample
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MainClass.checkControls(leftpanel).Count==0)
            {
                if(RetrivalData.ValidUser(textBox1.Text,passTxt.Text))
                {
                    if(RetrivalData.ROLE=="admin")
                    {
                        adminHomeScreenWindow hs = new adminHomeScreenWindow();
                        MainClass.showWindow(hs, this, MDI.ActiveForm);
                    }
                    else if (RetrivalData.ROLE == "Chef")
                    {
                        HomeScreen2 hs = new HomeScreen2
                            
                            ();
                        MainClass.showWindow(hs, this, MDI.ActiveForm);
                    }
                   
                }
                else
                {

                }
                
            }
            else
            {
                MessageBox.Show("Please enter all required fields");
            }
            
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                userErrorLabel.Visible = true;
            else
                userErrorLabel.Visible = false;
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "")
                passErrorLabel.Visible = true;
            else
                passErrorLabel.Visible = false;
        }
    }
}
