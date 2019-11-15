namespace restaurant
{
    partial class orderCompletionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderCompletionWindow));
            this.floorLable = new System.Windows.Forms.Label();
            this.floorDD = new System.Windows.Forms.ComboBox();
            this.tableDD = new System.Windows.Forms.ComboBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.orderidTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BillLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderT = new System.Windows.Forms.Label();
            this.orderTypeDD = new System.Windows.Forms.ComboBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.billButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.paidTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.retrunedTXt = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.BillLabel);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.billButton);
            this.leftpanel.Controls.Add(this.label8);
            this.leftpanel.Controls.Add(this.retrunedTXt);
            this.leftpanel.Controls.Add(this.flowLayoutPanel1);
            this.leftpanel.Controls.Add(this.label7);
            this.leftpanel.Controls.Add(this.paidTxt);
            this.leftpanel.Controls.Add(this.panel3);
            this.leftpanel.Size = new System.Drawing.Size(283, 620);
            this.leftpanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftpanel.Controls.SetChildIndex(this.paidTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label7, 0);
            this.leftpanel.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.retrunedTXt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label8, 0);
            this.leftpanel.Controls.SetChildIndex(this.billButton, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.BillLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Size = new System.Drawing.Size(283, 45);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.crystalReportViewer1);
            this.rightpanel.Location = new System.Drawing.Point(283, 0);
            this.rightpanel.Size = new System.Drawing.Size(824, 620);
            this.rightpanel.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            // 
            // floorLable
            // 
            this.floorLable.AutoSize = true;
            this.floorLable.Location = new System.Drawing.Point(3, 46);
            this.floorLable.Name = "floorLable";
            this.floorLable.Size = new System.Drawing.Size(33, 16);
            this.floorLable.TabIndex = 1;
            this.floorLable.Text = "Floor";
            // 
            // floorDD
            // 
            this.floorDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorDD.Enabled = false;
            this.floorDD.FormattingEnabled = true;
            this.floorDD.Location = new System.Drawing.Point(3, 65);
            this.floorDD.Name = "floorDD";
            this.floorDD.Size = new System.Drawing.Size(277, 24);
            this.floorDD.TabIndex = 2;
            this.floorDD.SelectedIndexChanged += new System.EventHandler(this.floorDD_SelectedIndexChanged);
            // 
            // tableDD
            // 
            this.tableDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableDD.Enabled = false;
            this.tableDD.FormattingEnabled = true;
            this.tableDD.Location = new System.Drawing.Point(3, 111);
            this.tableDD.Name = "tableDD";
            this.tableDD.Size = new System.Drawing.Size(277, 24);
            this.tableDD.TabIndex = 4;
            this.tableDD.SelectedIndexChanged += new System.EventHandler(this.tableDD_SelectedIndexChanged);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(3, 92);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(34, 16);
            this.tableLabel.TabIndex = 3;
            this.tableLabel.Text = "Table";
            this.tableLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.totalAmountGV,
            this.ItemGV,
            this.QuantGV,
            this.amountGV,
            this.orderIDGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(274, 120);
            this.dataGridView1.TabIndex = 5;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.snoGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.snoGV.HeaderText = "";
            this.snoGV.Name = "snoGV";
            this.snoGV.Width = 19;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "TotalamountGV";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            this.totalAmountGV.Visible = false;
            // 
            // ItemGV
            // 
            this.ItemGV.HeaderText = "Item";
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.ReadOnly = true;
            // 
            // QuantGV
            // 
            this.QuantGV.HeaderText = "Quantity";
            this.QuantGV.Name = "QuantGV";
            this.QuantGV.ReadOnly = true;
            // 
            // amountGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.amountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.amountGV.HeaderText = "Amount";
            this.amountGV.Name = "amountGV";
            this.amountGV.ReadOnly = true;
            // 
            // orderIDGV
            // 
            this.orderIDGV.HeaderText = "Order ID";
            this.orderIDGV.Name = "orderIDGV";
            this.orderIDGV.ReadOnly = true;
            this.orderIDGV.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Order ID";
            // 
            // orderidTxt
            // 
            this.orderidTxt.Enabled = false;
            this.orderidTxt.Location = new System.Drawing.Point(3, 157);
            this.orderidTxt.Name = "orderidTxt";
            this.orderidTxt.Size = new System.Drawing.Size(274, 21);
            this.orderidTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Bill:";
            // 
            // BillLabel
            // 
            this.BillLabel.AutoSize = true;
            this.BillLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillLabel.Location = new System.Drawing.Point(95, 455);
            this.BillLabel.Name = "BillLabel";
            this.BillLabel.Size = new System.Drawing.Size(53, 25);
            this.BillLabel.TabIndex = 9;
            this.BillLabel.Text = "0.00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.orderT);
            this.flowLayoutPanel1.Controls.Add(this.orderTypeDD);
            this.flowLayoutPanel1.Controls.Add(this.floorLable);
            this.flowLayoutPanel1.Controls.Add(this.floorDD);
            this.flowLayoutPanel1.Controls.Add(this.tableLabel);
            this.flowLayoutPanel1.Controls.Add(this.tableDD);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.orderidTxt);
            this.flowLayoutPanel1.Controls.Add(this.phonelabel);
            this.flowLayoutPanel1.Controls.Add(this.phoneTxt);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 357);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // orderT
            // 
            this.orderT.AutoSize = true;
            this.orderT.Location = new System.Drawing.Point(3, 0);
            this.orderT.Name = "orderT";
            this.orderT.Size = new System.Drawing.Size(61, 16);
            this.orderT.TabIndex = 1;
            this.orderT.Text = "Order Type";
            // 
            // orderTypeDD
            // 
            this.orderTypeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderTypeDD.FormattingEnabled = true;
            this.orderTypeDD.Items.AddRange(new object[] {
            "Dine-in",
            "Take Away",
            "Home Delivery"});
            this.orderTypeDD.Location = new System.Drawing.Point(3, 19);
            this.orderTypeDD.Name = "orderTypeDD";
            this.orderTypeDD.Size = new System.Drawing.Size(278, 24);
            this.orderTypeDD.TabIndex = 2;
            this.orderTypeDD.SelectedIndexChanged += new System.EventHandler(this.orderTypeDD_SelectedIndexChanged);
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(3, 181);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(81, 16);
            this.phonelabel.TabIndex = 1;
            this.phonelabel.Text = "Phone Number";
            this.phonelabel.Visible = false;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(3, 200);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(274, 21);
            this.phoneTxt.TabIndex = 2;
            this.phoneTxt.Visible = false;
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.Color.Brown;
            this.billButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(5, 567);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(274, 50);
            this.billButton.TabIndex = 10;
            this.billButton.Text = "Generate Bill";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.backBTN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 44);
            this.panel3.TabIndex = 13;
            // 
            // backBTN
            // 
            this.backBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBTN.BackgroundImage")));
            this.backBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBTN.FlatAppearance.BorderSize = 0;
            this.backBTN.ForeColor = System.Drawing.Color.Black;
            this.backBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backBTN.Location = new System.Drawing.Point(3, 3);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(30, 23);
            this.backBTN.TabIndex = 3;
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amount Paid";
            // 
            // paidTxt
            // 
            this.paidTxt.Location = new System.Drawing.Point(5, 499);
            this.paidTxt.Name = "paidTxt";
            this.paidTxt.Size = new System.Drawing.Size(275, 21);
            this.paidTxt.TabIndex = 12;
            this.paidTxt.TextChanged += new System.EventHandler(this.paidTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount Returned";
            // 
            // retrunedTXt
            // 
            this.retrunedTXt.Enabled = false;
            this.retrunedTXt.Location = new System.Drawing.Point(5, 540);
            this.retrunedTXt.Name = "retrunedTXt";
            this.retrunedTXt.Size = new System.Drawing.Size(275, 21);
            this.retrunedTXt.TabIndex = 15;
            this.retrunedTXt.TextChanged += new System.EventHandler(this.retrunedTXt_TextChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 45);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(824, 575);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // orderCompletionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 620);
            this.Name = "orderCompletionWindow";
            this.Text = "Order Completion";
            this.Load += new System.EventHandler(this.orderCompletionWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tableDD;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.ComboBox floorDD;
        private System.Windows.Forms.Label floorLable;
        private System.Windows.Forms.Label BillLabel;
        private System.Windows.Forms.TextBox orderidTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox retrunedTXt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paidTxt;
        private System.Windows.Forms.Label orderT;
        private System.Windows.Forms.ComboBox orderTypeDD;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.TextBox phoneTxt;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}