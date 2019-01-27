using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DBUtil

    {
        //资源名称
        public static string sourceName = "";
        //用户名称
        public static string userName = "aleron08";
        //用户密码
        public static string pwd = "cold08";
        //连接的数据库名称
        public static string database = "login_demo";
        //连接数据库
        static SqlConnection conn;
        //数据表
        static DataTable dataTable = new DataTable();

        public static DataTable SQLConnect(string sql)
        {
            //拼接数据库连接串
            string connstr = "data source=" + sourceName + ";user=" + userName + ";pwd=" + pwd + ";database=" + database;
            //新建数据库连接
            conn = new SqlConnection(connstr);

            try
            {
                //打开数据库连接
                conn.Open();
                //执行sql命令
                SqlCommand cmd = new SqlCommand(sql, conn);
                //适配命令通道
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //执行查询，结果返回到数据表
                adapter.Fill(dataTable);
                //清除参数
                cmd.Parameters.Clear();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                //关闭数据库连接
                conn.Close();
            }
            //返回数据表
            return dataTable;
        }
    }

}
