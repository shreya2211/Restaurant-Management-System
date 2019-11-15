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
using System.IO;
namespace restaurant
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\rms_connect"))
            {
                Settings obj = new Settings();
                MainClass.showWindow(obj, this);
            }
            else
            {
                LoginScreen ls = new LoginScreen();

                MainClass.showWindow(ls, this);
            }
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings rw = new Settings();
            MainClass.showWindow(rw, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            MainClass.showWindow(ls, this);
        }
    }
}
