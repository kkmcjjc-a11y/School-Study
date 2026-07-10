using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //정수형
            //자연수, 0, 음수
            int a = 1; // 정수형 자료형(int) 변수명 = 값;
            MessageBox.Show(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //실수형
            //정수 + 소수점
            double b = 1.23; // 실수형 자료형(double) 변수명 = 값;
            MessageBox.Show(b.ToString());

            //3가지 실수형
            //float(4byte), double(8byte), decimal(16byte)
            float f = 1.23f; // 접미사 f가 붙음
            decimal d = 1.23m; // 접미사 m이 붙음
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //문자형
            //문자 하나
            char c = 'a'; // 문자형 자료형(char) 변수명 = 값;
            MessageBox.Show(c.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //문자열형
            //문자 여러개
            string str = "문자열"; // 문자열형 자료형(string) 변수명 = 값;
            MessageBox.Show(str.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //boolean형
            //참(true) 또는 거짓(false)
            bool d = true; // boolean형 자료형(bool) 변수명 = true, false;
            MessageBox.Show(d.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            object ob = false; // 모든 자료형을 사용할 수 있다.
        }
    }
}
