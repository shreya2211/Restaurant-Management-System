namespace restaurant
{
    partial class TablesWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chairsDD = new System.Windows.Forms.ComboBox();
            this.floorNumberDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tablenumberDD = new System.Windows.Forms.ComboBox();
            this.tableNumberErrorLabel = new System.Windows.Forms.Label();
            this.chairsErrorLabel = new System.Windows.Forms.Label();
            this.floorNumberErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChairsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(153, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.floorNumberErrorLabel);
            this.leftpanel.Controls.Add(this.chairsErrorLabel);
            this.leftpanel.Controls.Add(this.tableNumberErrorLabel);
            this.leftpanel.Controls.Add(this.tablenumberDD);
            this.leftpanel.Controls.Add(this.floorNumberDD);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.chairsDD);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.chairsDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.floorNumberDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.tablenumberDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.tableNumberErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.chairsErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.floorNumberErrorLabel, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox2);
            this.rightpanel.Size = new System.Drawing.Size(980, 554);
            this.rightpanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Chairs";
            // 
            // chairsDD
            // 
            this.chairsDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chairsDD.Enabled = false;
            this.chairsDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chairsDD.FormattingEnabled = true;
            this.chairsDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.chairsDD.Location = new System.Drawing.Point(6, 180);
            this.chairsDD.Name = "chairsDD";
            this.chairsDD.Size = new System.Drawing.Size(241, 24);
            this.chairsDD.TabIndex = 7;
            // 
            // floorNumberDD
            // 
            this.floorNumberDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorNumberDD.Enabled = false;
            this.floorNumberDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.floorNumberDD.FormattingEnabled = true;
            this.floorNumberDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.floorNumberDD.Location = new System.Drawing.Point(6, 236);
            this.floorNumberDD.Name = "floorNumberDD";
            this.floorNumberDD.Size = new System.Drawing.Size(241, 24);
            this.floorNumberDD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Floor Number";
            // 
            // tablenumberDD
            // 
            this.tablenumberDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tablenumberDD.Enabled = false;
            this.tablenumberDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tablenumberDD.FormattingEnabled = true;
            this.tablenumberDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.tablenumberDD.Location = new System.Drawing.Point(6, 132);
            this.tablenumberDD.Name = "tablenumberDD";
            this.tablenumberDD.Size = new System.Drawing.Size(241, 24);
            this.tablenumberDD.TabIndex = 10;
            // 
            // tableNumberErrorLabel
            // 
            this.tableNumberErrorLabel.AutoSize = true;
            this.tableNumberErrorLabel.Location = new System.Drawing.Point(232, 113);
            this.tableNumberErrorLabel.Name = "tableNumberErrorLabel";
            this.tableNumberErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.tableNumberErrorLabel.TabIndex = 11;
            this.tableNumberErrorLabel.Text = "*";
            // 
            // chairsErrorLabel
            // 
            this.chairsErrorLabel.AutoSize = true;
            this.chairsErrorLabel.Location = new System.Drawing.Point(232, 165);
            this.chairsErrorLabel.Name = "chairsErrorLabel";
            this.chairsErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.chairsErrorLabel.TabIndex = 12;
            this.chairsErrorLabel.Text = "*";
            // 
            // floorNumberErrorLabel
            // 
            this.floorNumberErrorLabel.AutoSize = true;
            this.floorNumberErrorLabel.Location = new System.Drawing.Point(232, 217);
            this.floorNumberErrorLabel.Name = "floorNumberErrorLabel";
            this.floorNumberErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.floorNumberErrorLabel.TabIndex = 13;
            this.floorNumberErrorLabel.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 460);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.floorIDGV,
            this.floorNameGV,
            this.TableNumberGV,
            this.tableIDGV,
            this.ChairsGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(974, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.snoGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.snoGV.HeaderText = "";
            this.snoGV.Name = "snoGV";
            this.snoGV.Width = 19;
            // 
            // floorIDGV
            // 
            this.floorIDGV.HeaderText = "floorID";
            this.floorIDGV.Name = "floorIDGV";
            this.floorIDGV.ReadOnly = true;
            this.floorIDGV.Visible = false;
            // 
            // floorNameGV
            // 
            this.floorNameGV.HeaderText = "Floor";
            this.floorNameGV.Name = "floorNameGV";
            this.floorNameGV.ReadOnly = true;
            // 
            // TableNumberGV
            // 
            this.TableNumberGV.HeaderText = "Table Number";
            this.TableNumberGV.Name = "TableNumberGV";
            this.TableNumberGV.ReadOnly = true;
            // 
            // tableIDGV
            // 
            this.tableIDGV.HeaderText = "Table ID";
            this.tableIDGV.Name = "tableIDGV";
            this.tableIDGV.ReadOnly = true;
            this.tableIDGV.Visible = false;
            // 
            // ChairsGV
            // 
            this.ChairsGV.HeaderText = "Chairs";
            this.ChairsGV.Name = "ChairsGV";
            this.ChairsGV.ReadOnly = true;
            // 
            // TablesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 554);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TablesWindow";
            this.Text = "TablesWindow";
            this.Load += new System.EventHandler(this.TablesWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tablenumberDD;
        private System.Windows.Forms.ComboBox floorNumberDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chairsDD;
        private System.Windows.Forms.Label floorNumberErrorLabel;
        private System.Windows.Forms.Label chairsErrorLabel;
        private System.Windows.Forms.Label tableNumberErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumberGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChairsGV;
    }
}