using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace restaurant
{
    class MainClass
    {

        private static string path;
        private static string connectString()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else return "";
        }

        public static SqlConnection con = new SqlConnection(connectString());
        public static void showWindow(Form openwin,Form closeWin,Form MDI)
        {
            closeWin.Close();
            openwin.WindowState = FormWindowState.Maximized;
            openwin.MdiParent = MDI;
            openwin.Show();
        }

        public static void sno(DataGridView gv,string snoGV)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[snoGV].Value = count;
            }
        }
        public static void showWindow(Form openwin, Form MDI)
        {
            openwin.WindowState = FormWindowState.Maximized;
            openwin.MdiParent = MDI;
            openwin.Show();
        }
         public static void showMessage(string msg,string type)
        {
            if(type=="success")
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(type=="error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void resetEnable(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;

                }
                if(c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = true;
                }
                if(c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = true;
                }
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = true;

                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Value = 0;
                    cb.Enabled = true;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
            }
        }
        public static void resetDisable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;

                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Value = 0;
                    cb.Enabled = false;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
            }
        }
        public static void EnableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                   cb.Enabled = true;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
            }
        }
        public static void DisableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
            }
        }
        static ArrayList arr = new ArrayList();
        public static ArrayList checkControls(Panel p)
        {
            
            foreach(Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if(tb.AllowDrop==true)
                    {

                    }
                    else
                    {
                        if (tb.Text == "")
                        {
                            arr.Add(tb);
                        }
                        else
                        {
                            if (arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }
                        }
                    }
                }
                if (c is ComboBox) 
                {
                    ComboBox cb = (ComboBox)c;
                    if(cb.AllowDrop==true)
                    {

                    }
                    else
                    {
                        if (cb.SelectedIndex == -1)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                    }
                   
                }
                if(c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if(rb.AllowDrop==true)
                    {

                    }
                    else
                    {
                        if (!rb.Checked)
                        {
                            arr.Add(rb);
                        }
                        else
                        {
                            if (arr.Contains(rb))
                            {
                                arr.Remove(rb);
                            }
                        }
                    }
                }
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if(cb.AllowDrop==true)
                    {

                    }
                    else
                    {
                        if (!cb.Checked)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                    }
                    
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if(cb.AllowDrop==true)
                    {

                    }
                    else
                    {
                        if (cb.Value == 0)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                    }
                    
                }
            }
            return arr;
        }

    }
}
