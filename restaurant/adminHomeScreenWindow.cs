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
    public partial class adminHomeScreenWindow : Sample
    {
        public adminHomeScreenWindow()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void adminHomeScreenWindow_Load(object sender, EventArgs e)
        {

        }

        private void rolesbtn_Click(object sender, EventArgs e)
        {
            rolesWindow rw = new rolesWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            ordersWindow rw = new ordersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void usersbtn_Click(object sender, EventArgs e)
        {
            usersWindow rw = new usersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            customersWindow rw = new customersWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void tablesbtn_Click(object sender, EventArgs e)
        {
            TablesWindow rw = new TablesWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        

        private void menubtn_Click(object sender, EventArgs e)
        {
            FoodMenuWindow rw = new FoodMenuWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            FoodCategoryWindow rw = new FoodCategoryWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void floorsbtn_Click(object sender, EventArgs e)
        {
            FloorsWindow rw = new FloorsWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            orderCompletionWindow rw = new orderCompletionWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }
    }
}
