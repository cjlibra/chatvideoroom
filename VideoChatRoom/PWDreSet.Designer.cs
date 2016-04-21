namespace VideoChatRoom
{
    partial class PWDreSet
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
            this.tb_pwdReSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOldpwd = new System.Windows.Forms.TextBox();
            this.tbJYnewpwd = new System.Windows.Forms.TextBox();
            this.tbNewpwd = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_pwdReSet
            // 
            this.tb_pwdReSet.Location = new System.Drawing.Point(120, 184);
            this.tb_pwdReSet.Name = "tb_pwdReSet";
            this.tb_pwdReSet.Size = new System.Drawing.Size(75, 23);
            this.tb_pwdReSet.TabIndex = 0;
            this.tb_pwdReSet.Text = "修改密码";
            this.tb_pwdReSet.UseVisualStyleBackColor = true;
            this.tb_pwdReSet.Click += new System.EventHandler(this.tb_pwdReSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "校验新密码：";
            // 
            // tbOldpwd
            // 
            this.tbOldpwd.Location = new System.Drawing.Point(109, 67);
            this.tbOldpwd.Name = "tbOldpwd";
            this.tbOldpwd.Size = new System.Drawing.Size(112, 21);
            this.tbOldpwd.TabIndex = 4;
            // 
            // tbJYnewpwd
            // 
            this.tbJYnewpwd.Location = new System.Drawing.Point(109, 147);
            this.tbJYnewpwd.Name = "tbJYnewpwd";
            this.tbJYnewpwd.Size = new System.Drawing.Size(114, 21);
            this.tbJYnewpwd.TabIndex = 5;
            // 
            // tbNewpwd
            // 
            this.tbNewpwd.Location = new System.Drawing.Point(109, 105);
            this.tbNewpwd.Name = "tbNewpwd";
            this.tbNewpwd.Size = new System.Drawing.Size(114, 21);
            this.tbNewpwd.TabIndex = 6;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(109, 26);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(112, 21);
            this.tbusername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "用户名：";
            // 
            // PWDreSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 219);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbNewpwd);
            this.Controls.Add(this.tbJYnewpwd);
            this.Controls.Add(this.tbOldpwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pwdReSet);
            this.Name = "PWDreSet";
            this.Text = "PWDreSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tb_pwdReSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOldpwd;
        private System.Windows.Forms.TextBox tbJYnewpwd;
        private System.Windows.Forms.TextBox tbNewpwd;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label4;
    }
}