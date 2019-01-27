using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginService
    {
        public bool login(string account, string pwd)
        {
            //声明并初始化DAL层UserDao类
            DAL.UserDao userDao = new DAL.UserDao();
            //通过账号获取user对象
            Model.User user = userDao.findUser(account);
            //判断得到的user对象密码是否和用户输入密码相等
            if (pwd.Equals(user.pwd)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
