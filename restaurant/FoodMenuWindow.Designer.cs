namespace restaurant
{
    partial class FoodMenuWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.itemErrorLabel = new System.Windows.Forms.Label();
            this.CategoryErrorLabel = new System.Windows.Forms.Label();
            this.PriceErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.statusErrorLabel);
            this.leftpanel.Controls.Add(this.PriceErrorLabel);
            this.leftpanel.Controls.Add(this.CategoryErrorLabel);
            this.leftpanel.Controls.Add(this.itemErrorLabel);
            this.leftpanel.Controls.Add(this.statusDD);
            this.leftpanel.Controls.Add(this.categoryDD);
            this.leftpanel.Controls.Add(this.priceTxt);
            this.leftpanel.Controls.Add(this.itemTxt);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.itemTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.categoryDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.itemErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.CategoryErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.PriceErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox2);
            this.rightpanel.Size = new System.Drawing.Size(916, 554);
            this.rightpanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status";
            // 
            // itemTxt
            // 
            this.itemTxt.Enabled = false;
            this.itemTxt.Location = new System.Drawing.Point(6, 138);
            this.itemTxt.MaxLength = 50;
            this.itemTxt.Name = "itemTxt";
            this.itemTxt.Size = new System.Drawing.Size(238, 21);
            this.itemTxt.TabIndex = 7;
            this.itemTxt.TextChanged += new System.EventHandler(this.itemTxt_TextChanged);
            // 
            // priceTxt
            // 
            this.priceTxt.Enabled = false;
            this.priceTxt.Location = new System.Drawing.Point(6, 250);
            this.priceTxt.MaxLength = 5;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(238, 21);
            this.priceTxt.TabIndex = 8;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
            // 
            // categoryDD
            // 
            this.categoryDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDD.Enabled = false;
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(6, 191);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(238, 24);
            this.categoryDD.TabIndex = 9;
            this.categoryDD.SelectedIndexChanged += new System.EventHandler(this.categoryDD_SelectedIndexChanged);
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.Enabled = false;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Available",
            "Not available"});
            this.statusDD.Location = new System.Drawing.Point(6, 311);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(238, 24);
            this.statusDD.TabIndex = 10;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // itemErrorLabel
            // 
            this.itemErrorLabel.AutoSize = true;
            this.itemErrorLabel.Location = new System.Drawing.Point(229, 122);
            this.itemErrorLabel.Name = "itemErrorLabel";
            this.itemErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.itemErrorLabel.TabIndex = 11;
            this.itemErrorLabel.Text = "*";
            // 
            // CategoryErrorLabel
            // 
            this.CategoryErrorLabel.AutoSize = true;
            this.CategoryErrorLabel.Location = new System.Drawing.Point(230, 172);
            this.CategoryErrorLabel.Name = "CategoryErrorLabel";
            this.CategoryErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.CategoryErrorLabel.TabIndex = 12;
            this.CategoryErrorLabel.Text = "*";
            // 
            // PriceErrorLabel
            // 
            this.PriceErrorLabel.AutoSize = true;
            this.PriceErrorLabel.Location = new System.Drawing.Point(229, 234);
            this.PriceErrorLabel.Name = "PriceErrorLabel";
            this.PriceErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.PriceErrorLabel.TabIndex = 13;
            this.PriceErrorLabel.Text = "*";
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Location = new System.Drawing.Point(230, 295);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.statusErrorLabel.TabIndex = 14;
            this.statusErrorLabel.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 460);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.menuIDGV,
            this.MenuItemGV,
            this.priceGV,
            this.catGV,
            this.StatusGV,
            this.catIDGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(910, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.snoGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.snoGV.HeaderText = "";
            this.snoGV.Name = "snoGV";
            this.snoGV.Width = 19;
            // 
            // menuIDGV
            // 
            this.menuIDGV.HeaderText = "menuID";
            this.menuIDGV.Name = "menuIDGV";
            this.menuIDGV.ReadOnly = true;
            this.menuIDGV.Visible = false;
            // 
            // MenuItemGV
            // 
            this.MenuItemGV.HeaderText = "Menu Item";
            this.MenuItemGV.Name = "MenuItemGV";
            this.MenuItemGV.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "CategoryID";
            this.catIDGV.MinimumWidth = 2;
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.Visible = false;
            // 
            // FoodMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 554);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FoodMenuWindow";
            this.Text = "FoodMenuWindow";
            this.Load += new System.EventHandler(this.FoodMenuWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox itemTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.Label PriceErrorLabel;
        private System.Windows.Forms.Label CategoryErrorLabel;
        private System.Windows.Forms.Label itemErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
    }
}