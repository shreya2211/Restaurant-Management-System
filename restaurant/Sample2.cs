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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void button6_Click(object sender, EventArgs e)
        {
            adminHomeScreenWindow hs = new adminHomeScreenWindow();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }
        public static int edit = 0, delStatus = 0;
        public virtual void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.resetEnable(leftpanel);
            delStatus = 0;
        }

        public virtual void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.EnableControls(leftpanel);
        }

        public virtual void savebtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deletebtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void viewbtn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public virtual void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
