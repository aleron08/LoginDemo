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
            //��������ʼ��BLL���LoginService��
            BLL.LoginService loginService = new BLL.LoginService();

            //ͨ��BLL���жϵ�¼�ɹ���񣬲���UI��ʾ���
            if (loginService.login(account, pwd))
            {
                MessageBox.Show("��¼�ɹ�!");
            }
            else
            {
                MessageBox.Show("�����µ�¼!");
            }
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
