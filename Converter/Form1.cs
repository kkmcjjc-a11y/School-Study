using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //암시적 형 변환
            //언급 없이 형태 변환
            //실수 > 정수
            int a = 1;
            double b;
            b = a;

            MessageBox.Show(b.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //명시적 형 변환
            //(자료명)변수
            //실수 > 정수
            double a = 3.14;
            int b;
            b = (int)a;

            MessageBox.Show(b.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Convert 변환
            string a = "123";
            int b = Convert.ToInt32(a); //Convert.To자료형(변수) 괄호 안 변수를 자료형에 맞게 변환
            //문자열 > 정수

            int c = 123;
            string d = Convert.ToString(c);
            //정수 > 문자열


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
