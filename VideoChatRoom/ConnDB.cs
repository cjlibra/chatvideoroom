using System;
using System.Collections.Generic;
using System.Text;

using System.Data; //以下为mysql添加的命名空间
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;//要是出现“找不到mysql命名空间”的错误时，添加引用“mysql.data”或者把“mysql.data.dll”放在文件夹中，在引用以下即可


namespace VideoChatRoom
{
    class ConnDB
    {
        const string szConn = "server=localhost;uid=root;pwd=3393;DataBase=ovcs";
        MySqlConnection con = new MySqlConnection(szConn);

        public ConnDB()
        {
            //
            //TODO:在此处添加构造函数逻辑
            //
        }

        //登录////////
        #region
        public DataSet login(string login, string pwd)
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = @"SELECT * FROM user_tb 
WHERE user_state=1 AND user_name = '"+ login +"' AND user_tb.user_pwd ='"+pwd+"'";

                MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                con.Open();
                DA.Fill(ds);
                con.Close();
                return ds;
            }
            catch
            {
                return ds;
 
            }
        }

        public DataSet schkey(int userid)
        {
            try
            {
                DataSet ds = new DataSet();
  
                string sql = @"SELECT ukey_tb.* 
FROM  ukey_tb INNER JOIN
     userkey_tb ON userkey_tb.ukey_id = ukey_tb.ukey_id  INNER JOIN
      user_tb ON user_tb.user_id = userkey_tb.user_id
WHERE userkey_tb.user_id = '"+ userid +"' AND userkey_tb.userkey_state=1 AND ukey_tb.ukey_state=1";

                MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                con.Open();
                DA.Fill(ds);
                con.Close();
                return ds;         
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        //修改密码
        public int pwdUpdate(string username, string newpwd)
        {
            try
            {
                string sql_v = @"select * from user_tb where user_name = '" + username + "' and user_state=1 ";
                MySqlDataAdapter DA = new MySqlDataAdapter(sql_v, con);
                DataSet ds = new DataSet();
                con.Open();
                DA.Fill(ds);
                con.Close();
                DataTable dt = ds.Tables[0];
                int result;
                if (dt.Rows.Count > 0)
                {
                    string sql = @"update user_tb set user_pwd = '" + newpwd + "' where user_name = '" + username + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    result = cmd.ExecuteNonQuery();
                    con.Close();

                    if (result == 1)
                    {
                        return 1;  //修改成功                
                    }
                    else
                    {
                        return 2;  //修改失败
                    }
                }
                else
                {
                    return 0; //数据库中无此用户名
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }


        #endregion



    }
}
