namespace restaurant
{
    partial class usersWindow
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
            this.usersErrorLabel = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roleErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rolesDD = new System.Windows.Forms.ComboBox();
            this.usernameTxtErrorLabel = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordTxtErrorLabel = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.passwordTxtErrorLabel);
            this.leftpanel.Controls.Add(this.passwordTxt);
            this.leftpanel.Controls.Add(this.label10);
            this.leftpanel.Controls.Add(this.usernameTxtErrorLabel);
            this.leftpanel.Controls.Add(this.usernameTxt);
            this.leftpanel.Controls.Add(this.label8);
            this.leftpanel.Controls.Add(this.rolesDD);
            this.leftpanel.Controls.Add(this.roleErrorLabel);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.addressErrorLabel);
            this.leftpanel.Controls.Add(this.addressTxt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.phoneErrorLabel);
            this.leftpanel.Controls.Add(this.phoneTxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.usersErrorLabel);
            this.leftpanel.Controls.Add(this.userTxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.usersErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.phoneErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.addressErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.roleErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.rolesDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.label8, 0);
            this.leftpanel.Controls.SetChildIndex(this.usernameTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.usernameTxtErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label10, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordTxtErrorLabel, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox2);
            this.rightpanel.Size = new System.Drawing.Size(839, 554);
            this.rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightpanel_Paint);
            this.rightpanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // usersErrorLabel
            // 
            this.usersErrorLabel.AutoSize = true;
            this.usersErrorLabel.Location = new System.Drawing.Point(229, 116);
            this.usersErrorLabel.Name = "usersErrorLabel";
            this.usersErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.usersErrorLabel.TabIndex = 8;
            this.usersErrorLabel.Text = "*";
            // 
            // userTxt
            // 
            this.userTxt.Enabled = false;
            this.userTxt.Location = new System.Drawing.Point(3, 135);
            this.userTxt.MaxLength = 40;
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(241, 21);
            this.userTxt.TabIndex = 7;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Location = new System.Drawing.Point(229, 173);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.phoneErrorLabel.TabIndex = 11;
            this.phoneErrorLabel.Text = "*";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Enabled = false;
            this.phoneTxt.Location = new System.Drawing.Point(3, 192);
            this.phoneTxt.MaxLength = 15;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(241, 21);
            this.phoneTxt.TabIndex = 10;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone  Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Location = new System.Drawing.Point(232, 230);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.addressErrorLabel.TabIndex = 14;
            this.addressErrorLabel.Text = "*";
            // 
            // addressTxt
            // 
            this.addressTxt.Enabled = false;
            this.addressTxt.Location = new System.Drawing.Point(3, 249);
            this.addressTxt.MaxLength = 100;
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(241, 71);
            this.addressTxt.TabIndex = 13;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // roleErrorLabel
            // 
            this.roleErrorLabel.AutoSize = true;
            this.roleErrorLabel.Location = new System.Drawing.Point(229, 453);
            this.roleErrorLabel.Name = "roleErrorLabel";
            this.roleErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.roleErrorLabel.TabIndex = 17;
            this.roleErrorLabel.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Roles";
            // 
            // rolesDD
            // 
            this.rolesDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesDD.Enabled = false;
            this.rolesDD.FormattingEnabled = true;
            this.rolesDD.Location = new System.Drawing.Point(3, 473);
            this.rolesDD.Name = "rolesDD";
            this.rolesDD.Size = new System.Drawing.Size(241, 24);
            this.rolesDD.TabIndex = 18;
            this.rolesDD.SelectedIndexChanged += new System.EventHandler(this.rolesDD_SelectedIndexChanged);
            // 
            // usernameTxtErrorLabel
            // 
            this.usernameTxtErrorLabel.AutoSize = true;
            this.usernameTxtErrorLabel.Location = new System.Drawing.Point(229, 338);
            this.usernameTxtErrorLabel.Name = "usernameTxtErrorLabel";
            this.usernameTxtErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.usernameTxtErrorLabel.TabIndex = 21;
            this.usernameTxtErrorLabel.Text = "*";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Enabled = false;
            this.usernameTxt.Location = new System.Drawing.Point(3, 357);
            this.usernameTxt.MaxLength = 30;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(241, 21);
            this.usernameTxt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Username";
            // 
            // passwordTxtErrorLabel
            // 
            this.passwordTxtErrorLabel.AutoSize = true;
            this.passwordTxtErrorLabel.Location = new System.Drawing.Point(229, 396);
            this.passwordTxtErrorLabel.Name = "passwordTxtErrorLabel";
            this.passwordTxtErrorLabel.Size = new System.Drawing.Size(15, 16);
            this.passwordTxtErrorLabel.TabIndex = 24;
            this.passwordTxtErrorLabel.Text = "*";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Enabled = false;
            this.passwordTxt.Location = new System.Drawing.Point(3, 415);
            this.passwordTxt.MaxLength = 30;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(241, 21);
            this.passwordTxt.TabIndex = 23;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Password";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 460);
            this.groupBox2.TabIndex = 3;
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
            this.userIDGV,
            this.NameGV,
            this.usernameGV,
            this.RoleGV,
            this.passGV,
            this.phoneGV,
            this.addressGV,
            this.RoleIDGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(833, 438);
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
            // userIDGV
            // 
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "User";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // usernameGV
            // 
            this.usernameGV.HeaderText = "Username";
            this.usernameGV.Name = "usernameGV";
            this.usernameGV.ReadOnly = true;
            // 
            // RoleGV
            // 
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.Name = "RoleGV";
            // 
            // passGV
            // 
            this.passGV.HeaderText = "Password";
            this.passGV.Name = "passGV";
            this.passGV.ReadOnly = true;
            this.passGV.Visible = false;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // RoleIDGV
            // 
            this.RoleIDGV.HeaderText = "RoleID";
            this.RoleIDGV.MinimumWidth = 2;
            this.RoleIDGV.Name = "RoleIDGV";
            this.RoleIDGV.Visible = false;
            // 
            // usersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 554);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "usersWindow";
            this.Text = "usersWindow";
            this.Load += new System.EventHandler(this.usersWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usersErrorLabel;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rolesDD;
        private System.Windows.Forms.Label roleErrorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label passwordTxtErrorLabel;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label usernameTxtErrorLabel;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn passGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleIDGV;
    }
}