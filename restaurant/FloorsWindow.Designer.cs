namespace restaurant
{
    partial class FloorsWindow
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
            this.floorTxt = new System.Windows.Forms.TextBox();
            this.floorErrorLabel = new System.Windows.Forms.Label();
            this.floorNumberDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fnameErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(142, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.fnameErrorLabel);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.floorNumberDD);
            this.leftpanel.Controls.Add(this.floorErrorLabel);
            this.leftpanel.Controls.Add(this.floorTxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.floorTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.floorErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.floorNumberDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.fnameErrorLabel, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox2);
            this.rightpanel.Size = new System.Drawing.Size(915, 554);
            this.rightpanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Floor";
            // 
            // floorTxt
            // 
            this.floorTxt.Enabled = false;
            this.floorTxt.Location = new System.Drawing.Point(3, 156);
            this.floorTxt.MaxLength = 20;
            this.floorTxt.Name = "floorTxt";
            this.floorTxt.Size = new System.Drawing.Size(241, 21);
            this.floorTxt.TabIndex = 4;
            this.floorTxt.TextChanged += new System.EventHandler(this.floorTxt_TextChanged);
            // 
            // floorErrorLabel
            // 
            this.floorErrorLabel.AutoSize = true;
            this.floorErrorLabel.Location = new System.Drawing.Point(229, 133);
            this.floorErrorLabel.Name = "floorErrorLabel";
            this.floorErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.floorErrorLabel.TabIndex = 5;
            this.floorErrorLabel.Text = "*";
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
            this.floorNumberDD.Location = new System.Drawing.Point(3, 220);
            this.floorNumberDD.Name = "floorNumberDD";
            this.floorNumberDD.Size = new System.Drawing.Size(241, 24);
            this.floorNumberDD.TabIndex = 6;
            this.floorNumberDD.SelectedIndexChanged += new System.EventHandler(this.floorNumberDD_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Floor Number";
            // 
            // fnameErrorLabel
            // 
            this.fnameErrorLabel.AutoSize = true;
            this.fnameErrorLabel.Location = new System.Drawing.Point(229, 197);
            this.fnameErrorLabel.Name = "fnameErrorLabel";
            this.fnameErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.fnameErrorLabel.TabIndex = 8;
            this.fnameErrorLabel.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 460);
            this.groupBox2.TabIndex = 5;
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
            this.floorNumberGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(909, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // floorNumberGV
            // 
            this.floorNumberGV.HeaderText = "Floor Number";
            this.floorNumberGV.Name = "floorNumberGV";
            this.floorNumberGV.ReadOnly = true;
            // 
            // FloorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 554);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FloorsWindow";
            this.Text = "FloorsWindow";
            this.Load += new System.EventHandler(this.FloorsWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox floorNumberDD;
        private System.Windows.Forms.Label floorErrorLabel;
        private System.Windows.Forms.TextBox floorTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fnameErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberGV;
    }
}