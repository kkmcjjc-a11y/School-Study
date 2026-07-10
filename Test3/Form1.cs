using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 admin;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (admin == null)
            {
                admin = new Class1("admin", "1234");
            }

            if (admin.Login(tbID.Text, tbPassword.Text))
            {
                MessageBox.Show("로그인 성공");
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }
    }
}
