using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WindowsApplication1; //锁引用

namespace VideoChatRoom
{
    public partial class LoginForm : Form
    {
        ConnDB db = new ConnDB();  //数据库

        public LoginForm( )
        {
            InitializeComponent();          
        }

        private string currentUserID;
        public string CurrentUserID
        {
            get { return currentUserID; }            
        }

        public string RoomID
        {
            get
            {
                return this.textBox1.Text;
            }
        }

        //以下为锁添加
        SoftKey2K ytsoftkey;
        public static string KeyPath;
        public System.Windows.Forms.Button Command2;//


        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                //锁函数//////////
                //初始化加密锁的类
                ytsoftkey = new SoftKey2K();
                //用于判断系统中是否存在加密锁，不需要是指定的加密锁
                if (ytsoftkey.FindPort(0, ref KeyPath) != 0)
                {
                    MessageBox.Show("未找到加密锁，请插入加密锁后，再进行操作。");
                    Application.Exit();
                }
                //用于返回加密锁的ID号,ID号由两个长整型组成
                int id_1 = 0, id_2 = 0;
                if (ytsoftkey.GetID(ref id_1, ref id_2, KeyPath) != 0)
                {
                    MessageBox.Show("请插入合法的加密锁，再进行操作。");
                    return;
                }
                tb_UkeyID.Text = id_1.ToString("X") + id_2.ToString("X");

                //验证登录
                bool user1 = (textBox_id.Text.Trim() == "康乐xq") && (tb_UkeyID.Text.Trim() == "2EBCEE2FF397B078");
                bool user2 = (textBox_id.Text.Trim() == "康宁强") && (tb_UkeyID.Text.Trim() == "6956EF3E4E21C187");
                bool user3 = (textBox_id.Text.Trim() == "桂康") && (tb_UkeyID.Text.Trim() == "D71CCD8175C2036E");
                bool user4 = (textBox_id.Text.Trim() == "桂二") && (tb_UkeyID.Text.Trim() == "902936313EC07C0E");
                bool user5 = (textBox_id.Text.Trim() == "长虹坊") && (tb_UkeyID.Text.Trim() == "551FA57EE4B6EC4C");
                bool user6 = (textBox_id.Text.Trim() == "长青坊") && (tb_UkeyID.Text.Trim() == "EB8F9C66C05B6EBF");
                bool user7 = (textBox_id.Text.Trim() == "长顺海") && (tb_UkeyID.Text.Trim() == "FAB291818969D75F");
                bool user8 = (textBox_id.Text.Trim() == "长丰坊") && (tb_UkeyID.Text.Trim() == "CD66CCDC6B1D03AA");
                bool user9 = (textBox_id.Text.Trim() == "长兴坊") && (tb_UkeyID.Text.Trim() == "C0CA76EE6F61BCCC");
                bool user10 = (textBox_id.Text.Trim() == "寿祥坊") && (tb_UkeyID.Text.Trim() == "B442AFA253F8E58F");
                bool user11 = (textBox_id.Text.Trim() == "寿益坊") && (tb_UkeyID.Text.Trim() == "58D8830BE77EC9D9");
                bool user12 = (textBox_id.Text.Trim() == "寿昌山") && (tb_UkeyID.Text.Trim() == "64247EB6F3CAB484");
                bool user13 = (textBox_id.Text.Trim() == "紫鹃园") && (tb_UkeyID.Text.Trim() == "AD14D8BF4CBB1E8D");
                bool user14 = (textBox_id.Text.Trim() == "月季bt") && (tb_UkeyID.Text.Trim() == "3DC8324ECB6E781C");
                bool user15 = (textBox_id.Text.Trim() == "紫薇园") && (tb_UkeyID.Text.Trim() == "2F2DD90FF4F8AC58");
                bool user16 = (textBox_id.Text.Trim() == "茶花gh") && (tb_UkeyID.Text.Trim() == "3DC5E753CB7C2E30");
                bool user17 = (textBox_id.Text.Trim() == "丁香yc") && (tb_UkeyID.Text.Trim() == "3CF93B2112C40D7A");
                bool user18 = (textBox_id.Text.Trim() == "玉兰园") && (tb_UkeyID.Text.Trim() == "657A6E10F410A4FE");
                bool user19 = (textBox_id.Text.Trim() == "樱花园") && (tb_UkeyID.Text.Trim() == "3B828837C928CF04");
                bool user20 = (textBox_id.Text.Trim() == "上师大") && (tb_UkeyID.Text.Trim() == "7BC3D09E1A6A176C");
                bool user21 = (textBox_id.Text.Trim() == "紫荆园") && (tb_UkeyID.Text.Trim() == "DA969180783CD75E");
                bool user22 = (textBox_id.Text.Trim() == "金桂苑") && (tb_UkeyID.Text.Trim() == "C239603061E0A70E");
                bool user23 = (textBox_id.Text.Trim() == "欣园") && (tb_UkeyID.Text.Trim() == "CF7F4BA9A44B1DE2");
                bool user24 = (textBox_id.Text.Trim() == "联莘") && (tb_UkeyID.Text.Trim() == "C07C6BA96E13A186");
                bool user25 = (textBox_id.Text.Trim() == "党校") && (tb_UkeyID.Text.Trim() == "11164DA8AFBC8376");
                bool user26 = (textBox_id.Text.Trim() == "会议室1") && (tb_UkeyID.Text.Trim() == "EE7973E58C2FB9B3");
                bool user27 = (textBox_id.Text.Trim() == "会议室2") && (tb_UkeyID.Text.Trim() == "8612657825C8AC55");
                bool user28 = (textBox_id.Text.Trim() == "网格zx") && (tb_UkeyID.Text.Trim() == "5A9F1DA23F6BEFFB");
                bool user29 = (textBox_id.Text.Trim() == "wzf") && (tb_UkeyID.Text.Trim() == "CBECA3236A82E9F0");


                if (((user1==true) || (user2==true) || (user3==true) || (user4==true) || (user5==true) || (user6==true) || (user7==true) || (user8==true) || (user9==true) ||(user10==true) ||
                     (user11==true) || (user12==true) || (user13==true) || (user14==true) || (user15==true) || (user16==true) || (user17==true) || (user18==true) || (user19==true) ||(user20==true) ||
                     (user21 == true) || (user22 == true) || (user23 == true) || (user24 == true) || (user25 == true) || (user26 == true) || (user27 == true) || (user28 == true) || (user29 == true)) && (textBox_pwd.Text.Trim() == "1234"))
                {
                    string userID = this.textBox_id.Text.Trim();
                    if (userID.Length > 21)
                    {
                        MessageBox.Show("ID长度必须小于21.");
                        return;
                    }

                    this.currentUserID = userID;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }        
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close(); //只是关闭当前窗口，若不是主窗体的话，是无法退出程序的。另外若有托管线程（非主线程），也无法退出干净
        }

        //链接数据库的登录
        private void btlogin_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Trim() == "sa" && textBox_pwd.Text.Trim() == "trimps")  //超级用户管理员
            {
                string userID = this.textBox_id.Text.Trim();

                this.currentUserID = userID;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //锁函数//////////
                //初始化加密锁的类
                ytsoftkey = new SoftKey2K();
                //用于判断系统中是否存在加密锁，不需要是指定的加密锁
                if (ytsoftkey.FindPort(0, ref KeyPath) != 0)
                {
                    MessageBox.Show("未找到加密锁，请插入加密锁后，再进行操作。");
                    Application.Exit();
                }
                //用于返回加密锁的ID号,ID号由两个长整型组成
                int id_1 = 0, id_2 = 0;
                if (ytsoftkey.GetID(ref id_1, ref id_2, KeyPath) != 0)
                {
                    MessageBox.Show("请插入合法的加密锁，再进行操作。");
                    return;
                }
                tb_UkeyID.Text = id_1.ToString("X") + id_2.ToString("X");
                //string szKey = tb_UkeyID.Text.Trim();

                string userID = textBox_id.Text.Trim();
                string userPwd = textBox_pwd.Text.Trim();
                DataSet ds = db.login(userID, userPwd);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    int userid = Convert.ToInt32(dt.Rows[0]["user_id"].ToString());

                    DataSet ds_key = db.schkey(userid);
                    DataTable dt_key = ds_key.Tables[0];
                    string keyno = dt_key.Rows[0][1].ToString();

                    //string szKey = tb_UkeyID.Text.Trim();

                    if (Equals(tb_UkeyID.Text, keyno))
                    {
                        this.currentUserID = userID;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("请插入正确的ukey");
                    }

                }
                else
                {
                    MessageBox.Show("用户名不存在或用户名密码错误！");
                }

            }

        }

        //修改密码
        private void lbUpdate_Click(object sender, EventArgs e)
        {
            PWDreSet pwdReSet = new PWDreSet();
            pwdReSet.ShowDialog();  //弹出密码修改框
            //string userID = this.textBox_id.Text.Trim();
            //string userPWD = this.textBox_pwd.Text.Trim();
            //int userid = -1;

            //DataSet ds = db.userUpdate(userID, userPWD);


        }

        //key丢了时，补发key

        //注册：新用户名、密码、key

       
        






       
    }
}
