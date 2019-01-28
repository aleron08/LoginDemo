using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string account = textAccount.Text.ToString();
            string pwd = textPwd.Text.ToString();
            //声明并初始化BLL层的LoginService类
            BLL.LoginService loginService = new BLL.LoginService();

            //通过BLL层判断登录成功与否，并在UI显示结果
            if (loginService.login(account, pwd))
            {
                MessageBox.Show("登录成功!");
            }
            else
            {
                MessageBox.Show("请重新登录!");
            }
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
