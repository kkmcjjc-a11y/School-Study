using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            //Q. top, middle, bot
            //top.text >, < middle.text 크면 빨간색 작으면 노란색
            //middle bot 비교하고 같으면 둘 다 초록색 다르면 bot에만 파란색

            //    string topText = (btnTop.Text);
            //    string middleText = (btnMiddle.Text);
            //    int convertTopText = Convert.ToInt32(topText);
            //    int convertMiddleText = Convert.ToInt32(middleText);

            //    if (convertTopText < convertMiddleText)
            //    {
            //        btnTop.BackColor = Color.Yellow;
            //        btnMiddle.BackColor = Color.Red;
            //    }

            //    else if (convertTopText > convertMiddleText)
            //    {
            //        btnTop.BackColor = Color.Red;
            //        btnMiddle.BackColor = Color.Yellow;
            //    }

            //    if (btnMiddle.Text == btnBot.Text)
            //    {
            //        btnMiddle.BackColor = Color.Green;
            //        btnBot.BackColor = Color.Green;
            //    }
            //    else
            //    {
            //        btnBot.BackColor = Color.Blue;
            //        btnMiddle.BackColor = Color.White;
            //    }

            //1. 텍스트와 텍스트 비교
            //숫자로 형 변환

            int a = Convert.ToInt32(btnTop.Text);
            int b = Convert.ToInt32(btnMiddle.Text);
            int c = Convert.ToInt32(btnBot.Text);

            //2. 숫자 비교해서 색깔 넣기

            if (a > b)
            {
                btnTop.BackColor = Color.Red;
                btnMiddle.BackColor = Color.Yellow;
            }

            else if (a < b)
            {
                btnTop.BackColor = Color.Yellow;
                btnMiddle.BackColor = Color.Red;
            }

            //3. 다음 문제

            if (b == c)
            {
                btnMiddle.BackColor = Color.Green;
                btnBot.BackColor = Color.Green;
            }

            else if (b != c)
            {
                btnBot.BackColor = Color.Blue;
            }
        }

        private void btnSignal2_Click(object sender, EventArgs e)
        {
            //Q
            //1.신호를 클릭해서 메세지박스 20번 띄우기
            //2. btnMiddle.text에 3.14 값을 곱하기 할당해서 표시하기

            for (int i = 0; i < 20; i++)
            {
                //신호를 클릭하자마자 2번 문항 실행
                //if (i == 0)
                //{
                //    double a = 3.14;
                //    double MiddleValue = Convert.ToDouble(btnMiddle.Text);
                //    double MiddleText = MiddleValue * a;
                //    btnMiddle.Text = Convert.ToString(MiddleText);
                //}
                MessageBox.Show("메세지박스");
            }

            //메세지박스 20번 띄운 후 2번 문항 실행
            double a = 3.14;
            double MiddleValue = Convert.ToDouble(btnMiddle.Text);
            double MiddleText = MiddleValue * a;
            btnMiddle.Text = Convert.ToString(MiddleText);
        }
    }
}
