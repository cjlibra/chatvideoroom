using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoChatRoom
{
    public partial class PWDreSet : Form
    {
        ConnDB db = new ConnDB();  //数据库

        public PWDreSet()
        {
            InitializeComponent();
        }

        private void tb_pwdReSet_Click(object sender, EventArgs e)
        {
            string userName = tbusername.Text.Trim();
            string oldpwd = tbOldpwd.Text.Trim();
            string newpwd = tbNewpwd.Text.Trim();
            string jynewpwd = tbJYnewpwd.Text.Trim();

            if (newpwd.Length == 0)
            {
                MessageBox.Show("新密码不能为空,请输入至少4位密码!");
            }
            else
            {
                if (newpwd.Length < 4)
                {
                    MessageBox.Show("请至少输入4为密码!");
                }
                else
                {
                    if (Equals(newpwd, jynewpwd) == false)
                    {
                        MessageBox.Show("两次输入的新密码不一致，请重新输入！");
                    }
                    else
                    {
                        int UdtResult = db.pwdUpdate(userName, newpwd);
                        if (UdtResult == 0)
                        {
                            MessageBox.Show("该用户名不存在，不能更新！");
                        }
                        
                        if (UdtResult == 1)
                        {
                            MessageBox.Show("修改密码成功！");
                        }
                        if (UdtResult == 2)
                        {
                            MessageBox.Show("修改密码失败！");
                        }
                    }
                }
            }
        }

    }
}
