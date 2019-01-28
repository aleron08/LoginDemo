using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class UserDao
    {
        //查找用户的方法，返回User类型
        public Model.User findUser(string account)
        {
            Model.User user = new Model.User();
            string sql = "SELECT *  FROM [login_demo].[dbo].[user] WHERE [account]= '" + account +"'";
            //通过DBUtil类查询并返回结果到DataTable中
            DataTable dataTable = DBUtil.SQLConnect(sql);
            if (dataTable.Rows.Count > 0)
            {
                //从DataTable中获取账号密码
                user.account = dataTable.Rows[0]["account"].ToString().Trim();
                user.pwd = dataTable.Rows[0]["pwd"].ToString().Trim();
            }
            return user;
        }

    }
}
