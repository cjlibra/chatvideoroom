namespace VideoChatRoom
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_UkeyID = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Image = ((System.Drawing.Image)(resources.GetObject("button_login.Image")));
            this.button_login.Location = new System.Drawing.Point(123, 146);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(74, 28);
            this.button_login.TabIndex = 12;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(98, 98);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(111, 21);
            this.textBox_pwd.TabIndex = 9;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(98, 56);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(111, 21);
            this.textBox_id.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "密  码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = " 聊天室ID：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 21);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "R1000";
            this.textBox1.Visible = false;
            // 
            // tb_UkeyID
            // 
            this.tb_UkeyID.Location = new System.Drawing.Point(82, 12);
            this.tb_UkeyID.Name = "tb_UkeyID";
            this.tb_UkeyID.Size = new System.Drawing.Size(182, 21);
            this.tb_UkeyID.TabIndex = 15;
            this.tb_UkeyID.Visible = false;
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(213, 146);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(62, 28);
            this.button_exit.TabIndex = 16;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Location = new System.Drawing.Point(221, 102);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(53, 12);
            this.lbUpdate.TabIndex = 18;
            this.lbUpdate.Text = "修改密码";
            this.lbUpdate.Visible = false;
            this.lbUpdate.Click += new System.EventHandler(this.lbUpdate_Click);
            // 
            // btlogin
            // 
            this.btlogin.FlatAppearance.BorderSize = 0;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Image = ((System.Drawing.Image)(resources.GetObject("btlogin.Image")));
            this.btlogin.Location = new System.Drawing.Point(38, 163);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 26);
            this.btlogin.TabIndex = 19;
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Visible = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 201);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.tb_UkeyID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(333, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(333, 240);
            this.Name = "LoginForm";
            this.Text = "微视视频会议系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_UkeyID;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Button btlogin;
    }
}