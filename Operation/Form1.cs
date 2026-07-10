using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            //산술 연산자
            //+, -, *, /, %

            int a = 10;
            int b = 5;

            MessageBox.Show((a + b).ToString()); //더하기
            MessageBox.Show((a - b).ToString()); //빼기
            MessageBox.Show((a * b).ToString()); //곱하기
            MessageBox.Show((a / b).ToString()); //나누기
            MessageBox.Show((a % b).ToString()); //나머지
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //할당 연산자
            //+=, -=, *=, /=, %=

            int a = 10;

            a += 5; // a = a + 5; a에 5를 더한 값을 a에 저장
            MessageBox.Show(a.ToString());
            a -= 5; // a = a - 5; a에서 5를 뺀 값을 a에 저장
            MessageBox.Show(a.ToString());
            a *= 5; // a = a * 5; a를 5로 곱한 값을 a에 저장
            MessageBox.Show(a.ToString());
            a /= 5; // a = a / 5; a를 5로 나눈 몫을 a에 저장
            MessageBox.Show(a.ToString());
            a %= 5; // a = a % 5; a를 5로 나눈 나머지를 a에 저장
            MessageBox.Show(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //비교 연산자
            //==, !=, >, <, >=, <=

            //기계 에러 발생
            //기계의 신호를 계속 받으면서 비교하는 변수가 있음
            //변수의 값이 "err" 이면 button2의 색깔을 빨간색으로 바꿈
            //"err"가 아니면 button2의 색깔을 초록색으로 바꾸기

            string state = "normal";

            if (state == "err")
            {
                button2.BackColor = Color.Red;
            }

            else if (state != "err")
            {
                button2.BackColor = Color.Green;
            }

            //Q
            //장비에 프로그렘이 연결되어 있다고 생각하고 진행
            //0 1 신호를 줌, 0 신호가 꺼져있음, 1 신호가 켜져있음

            int on = 1;
            int off = 0;

            //장비에서 error 신호가 들어오고 있는지 확인해서 신호가 있으면 프로그램 정지
            if(on == 1) //신호가 들어왔는지 확인
            {
                MessageBox.Show("에러 긴급 정지");
            }

            if(on != 0)//신호가 안들어왔을때
            {
                MessageBox.Show("정상 동작");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //논리 연산자
            //&&, ||, !

            //실린더 전진 후진

            //양솔
            //실린더 전진 하려면 전진 on 후진 off
            //실린더 후진 하려면 전진 off 후진 on

            bool front = true;
            bool back = false;

            //양솔을 후진하려면
            if (front && !back)
            {
                MessageBox.Show("실린더 전진");
            }

            if (front && back)
            {
                MessageBox.Show("실린더 후진");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3항 연산자
            //() ? 앞 : 뒤
            //"00" 정지, "10" 운전

            string machine = "00";

            string state = (machine == "10") ? "정지" : "운전"; //machine 값이 "00"이면 state에 "정지"를 저장, 아니면 state에 "운전"을 저장

            MessageBox.Show(state.ToString());
        }
    }
}
