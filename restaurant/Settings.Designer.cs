namespace restaurant
{
    partial class Settings
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
            this.textserver = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.textdatabase = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.iscb = new System.Windows.Forms.CheckBox();
            this.textpass = new System.Windows.Forms.Label();
            this.DbErrorLabel = new System.Windows.Forms.Label();
            this.UserErrorLabel = new System.Windows.Forms.Label();
            this.PassErrorLabel = new System.Windows.Forms.Label();
            this.serverErrorLabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.PassErrorLabel);
            this.leftpanel.Controls.Add(this.UserErrorLabel);
            this.leftpanel.Controls.Add(this.iscb);
            this.leftpanel.Controls.Add(this.savebtn);
            this.leftpanel.Controls.Add(this.passTxt);
            this.leftpanel.Controls.Add(this.textpass);
            this.leftpanel.Controls.Add(this.userTxt);
            this.leftpanel.Controls.Add(this.textuser);
            this.leftpanel.Controls.Add(this.databaseTxt);
            this.leftpanel.Controls.Add(this.textdatabase);
            this.leftpanel.Controls.Add(this.serverTxt);
            this.leftpanel.Controls.Add(this.textserver);
            this.leftpanel.Controls.Add(this.serverErrorLabel);
            this.leftpanel.Controls.Add(this.DbErrorLabel);
            this.leftpanel.Size = new System.Drawing.Size(250, 450);
            this.leftpanel.Controls.SetChildIndex(this.DbErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.serverErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.textserver, 0);
            this.leftpanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.textdatabase, 0);
            this.leftpanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.textuser, 0);
            this.leftpanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.textpass, 0);
            this.leftpanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.savebtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.iscb, 0);
            this.leftpanel.Controls.SetChildIndex(this.UserErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.PassErrorLabel, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(550, 450);
            this.rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightpanel_Paint);
            // 
            // textserver
            // 
            this.textserver.AutoSize = true;
            this.textserver.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textserver.Location = new System.Drawing.Point(3, 135);
            this.textserver.Name = "textserver";
            this.textserver.Size = new System.Drawing.Size(45, 18);
            this.textserver.TabIndex = 1;
            this.textserver.Text = "Server";
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(3, 154);
            this.serverTxt.MaxLength = 50;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(241, 21);
            this.serverTxt.TabIndex = 2;
            this.serverTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(3, 197);
            this.databaseTxt.MaxLength = 50;
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(241, 21);
            this.databaseTxt.TabIndex = 4;
            this.databaseTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textdatabase
            // 
            this.textdatabase.AutoSize = true;
            this.textdatabase.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdatabase.Location = new System.Drawing.Point(3, 178);
            this.textdatabase.Name = "textdatabase";
            this.textdatabase.Size = new System.Drawing.Size(66, 18);
            this.textdatabase.TabIndex = 3;
            this.textdatabase.Text = "Database";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(3, 241);
            this.userTxt.MaxLength = 50;
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(241, 21);
            this.userTxt.TabIndex = 6;
            this.userTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textuser
            // 
            this.textuser.AutoSize = true;
            this.textuser.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.Location = new System.Drawing.Point(3, 222);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(51, 18);
            this.textuser.TabIndex = 5;
            this.textuser.Text = "User ID";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(3, 284);
            this.passTxt.MaxLength = 50;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(241, 21);
            this.passTxt.TabIndex = 8;
            this.passTxt.UseSystemPasswordChar = true;
            this.passTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.FlatAppearance.BorderSize = 2;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(77, 356);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(99, 35);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // iscb
            // 
            this.iscb.AutoSize = true;
            this.iscb.Location = new System.Drawing.Point(6, 321);
            this.iscb.Name = "iscb";
            this.iscb.Size = new System.Drawing.Size(122, 20);
            this.iscb.TabIndex = 10;
            this.iscb.Text = "Integrated Security";
            this.iscb.UseVisualStyleBackColor = true;
            this.iscb.CheckedChanged += new System.EventHandler(this.itcb_CheckedChanged);
            // 
            // textpass
            // 
            this.textpass.AutoSize = true;
            this.textpass.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.Location = new System.Drawing.Point(3, 265);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(65, 18);
            this.textpass.TabIndex = 7;
            this.textpass.Text = "Password";
            // 
            // DbErrorLabel
            // 
            this.DbErrorLabel.AutoSize = true;
            this.DbErrorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbErrorLabel.Location = new System.Drawing.Point(228, 178);
            this.DbErrorLabel.Name = "DbErrorLabel";
            this.DbErrorLabel.Size = new System.Drawing.Size(16, 18);
            this.DbErrorLabel.TabIndex = 12;
            this.DbErrorLabel.Text = "*";
            // 
            // UserErrorLabel
            // 
            this.UserErrorLabel.AutoSize = true;
            this.UserErrorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserErrorLabel.Location = new System.Drawing.Point(228, 220);
            this.UserErrorLabel.Name = "UserErrorLabel";
            this.UserErrorLabel.Size = new System.Drawing.Size(16, 18);
            this.UserErrorLabel.TabIndex = 13;
            this.UserErrorLabel.Text = "*";
            // 
            // PassErrorLabel
            // 
            this.PassErrorLabel.AutoSize = true;
            this.PassErrorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassErrorLabel.Location = new System.Drawing.Point(228, 265);
            this.PassErrorLabel.Name = "PassErrorLabel";
            this.PassErrorLabel.Size = new System.Drawing.Size(16, 18);
            this.PassErrorLabel.TabIndex = 14;
            this.PassErrorLabel.Text = "*";
            // 
            // serverErrorLabel
            // 
            this.serverErrorLabel.AutoSize = true;
            this.serverErrorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverErrorLabel.Location = new System.Drawing.Point(228, 135);
            this.serverErrorLabel.Name = "serverErrorLabel";
            this.serverErrorLabel.Size = new System.Drawing.Size(16, 18);
            this.serverErrorLabel.TabIndex = 15;
            this.serverErrorLabel.Text = "*";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textserver;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label textuser;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label textdatabase;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.CheckBox iscb;
        private System.Windows.Forms.Label PassErrorLabel;
        private System.Windows.Forms.Label UserErrorLabel;
        private System.Windows.Forms.Label textpass;
        private System.Windows.Forms.Label serverErrorLabel;
        private System.Windows.Forms.Label DbErrorLabel;
    }
}