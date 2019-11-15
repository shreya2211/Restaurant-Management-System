namespace restaurant
{
    partial class Sample2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sample2));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.button6);
            this.leftpanel.Controls.Add(this.panel4);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftpanel.Controls.SetChildIndex(this.button6, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.panel3);
            this.rightpanel.Size = new System.Drawing.Size(636, 554);
            this.rightpanel.Controls.SetChildIndex(this.panel3, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 45);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7364F));
            this.tableLayoutPanel1.Controls.Add(this.viewbtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.deletebtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.savebtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.editbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // viewbtn
            // 
            this.viewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.viewbtn.FlatAppearance.BorderSize = 2;
            this.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.viewbtn.Location = new System.Drawing.Point(427, 3);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(97, 39);
            this.viewbtn.TabIndex = 5;
            this.viewbtn.Text = "&VIEW";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.deletebtn.FlatAppearance.BorderSize = 2;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deletebtn.Location = new System.Drawing.Point(321, 3);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 39);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "&DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savebtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.savebtn.FlatAppearance.BorderSize = 2;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.savebtn.Location = new System.Drawing.Point(215, 3);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(100, 39);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "&SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.editbtn.FlatAppearance.BorderSize = 2;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.editbtn.Location = new System.Drawing.Point(109, 3);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(100, 39);
            this.editbtn.TabIndex = 1;
            this.editbtn.Text = "&EDIT";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.addbtn.FlatAppearance.BorderSize = 2;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addbtn.Location = new System.Drawing.Point(3, 3);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 39);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "&ADD";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchtxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(530, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 39);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchtxt
            // 
            this.searchtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchtxt.Location = new System.Drawing.Point(3, 17);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(97, 21);
            this.searchtxt.TabIndex = 0;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 45);
            this.panel4.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 23);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 23);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 554);
            this.Controls.Add(this.button5);
            this.Name = "Sample2";
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.leftpanel, 0);
            this.Controls.SetChildIndex(this.rightpanel, 0);
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button deletebtn;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.Button editbtn;
        public System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button viewbtn;
    }
}