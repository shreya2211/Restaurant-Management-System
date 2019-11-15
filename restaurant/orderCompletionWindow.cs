using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace restaurant
{
    public partial class orderCompletionWindow : Sample
    {
        public orderCompletionWindow()
        {
            InitializeComponent();
        }

    
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void orderCompletionWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            RetrivalData.loadItems("st_getFloors", floorDD, "Floor", "ID");
            floorDD.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            BillLabel.Text = "";
            orderidTxt.Text = "";
        }

        private void floorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(floorDD.SelectedIndex!=-1)
            {
                RetrivalData.loadItems("st_getTablesWRTfloor", tableDD, "Table Number", "Table ID", "@floorID", Convert.ToInt32(floorDD.SelectedValue.ToString()));
                tableDD.SelectedIndex = -1;
                dataGridView1.DataSource = null;
                BillLabel.Text = "";
                orderidTxt.Text = "";
                paidTxt.Text = "";
                retrunedTXt.Text = "";
            }
        }

        private void tableDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tableDD.SelectedIndex!=-1)
            {
                RetrivalData.getOrderBill(Convert.ToInt32(tableDD.SelectedValue.ToString()),dataGridView1,ItemGV,QuantGV,amountGV,orderIDGV,totalAmountGV);
                BillLabel.Text =Math.Round(Convert.ToDouble(dataGridView1.Rows[0].Cells["totalAmountGV"].Value.ToString()),0).ToString();
                orderidTxt.Text = dataGridView1.Rows[0].Cells["orderIDGV"].Value.ToString();
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            adminHomeScreenWindow obj = new adminHomeScreenWindow();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void paidTxt_TextChanged(object sender, EventArgs e)
        {
            if (paidTxt.Text == "")
            {
                paidTxt.BackColor = Color.Firebrick;
            }
            else
            {
                paidTxt.BackColor = Color.White;
                if(Convert.ToDouble(paidTxt.Text)>=Convert.ToDouble(BillLabel.Text))
                {
                    double amtpaid = Convert.ToDouble(paidTxt.Text);
                    double amtReturned = amtpaid-Convert.ToDouble(BillLabel.Text);
                    retrunedTXt.Text = amtReturned.ToString();
                }
            }
        }

        private void retrunedTXt_TextChanged(object sender, EventArgs e)
        {

        }
        ReportDocument rd;
        private void billButton_Click(object sender, EventArgs e)
        {
            if(retrunedTXt.Text!=""&& floorDD.SelectedIndex!=-1 &&tableDD.SelectedIndex!=-1)
            {
                int ch = Updates.updateOrder(Convert.ToInt64(orderidTxt.Text), Convert.ToSingle(paidTxt.Text), Convert.ToSingle(retrunedTXt.Text),2);
                if(ch>0)
                {
                    DialogResult dr = MessageBox.Show("Order completed successfully", "Success..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dr==DialogResult.OK)
                    {
                        rd = new ReportDocument();
                        if(orderTypeDD.SelectedIndex==0)
                        {
                            RetrivalData.loadReport(rd, crystalReportViewer1, Convert.ToInt32(tableDD.SelectedValue.ToString()), 2);
                        }
                        else
                        {
                            RetrivalData.loadReport(rd, crystalReportViewer1, Convert.ToInt32(tableDD.SelectedValue.ToString()), 2,phoneTxt.Text);

                        }
                    }
                }
            }
        }

        private void orderTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderTypeDD.SelectedIndex!=-1)
            {
                if(orderTypeDD.SelectedIndex==0)
                {
                    floorDD.Enabled = true;
                    tableDD.Enabled = true;
                    phonelabel.Visible = false;
                    phoneTxt.Visible = false;
                    floorDD.Visible = true;
                    tableDD.Visible = true;
                    floorLable.Visible = true;
                    tableLabel.Visible = true;
                }
                else
                {
                    floorDD.Enabled = false;
                    tableDD.Enabled = false;
                    phonelabel.Visible = true;
                    phoneTxt.Visible = true;
                    floorDD.Visible = false;
                    tableDD.Visible = false;
                    floorLable.Visible = false;
                    tableLabel.Visible = false;
                }
            }
        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            if (phoneTxt.Text != "")
            {
                RetrivalData.getOrderBill(phoneTxt.Text, dataGridView1, ItemGV, QuantGV, amountGV, orderIDGV, totalAmountGV);
                BillLabel.Text = Math.Round(Convert.ToDouble(dataGridView1.Rows[0].Cells["totalAmountGV"].Value.ToString()), 0).ToString();
                orderidTxt.Text = dataGridView1.Rows[0].Cells["orderIDGV"].Value.ToString();
            }
        }
    }
}

