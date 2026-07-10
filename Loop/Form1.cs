using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //반복문 for                        //반복 횟수 = 조건문
            //for (int i = 0; i < 5; i++) //초기값, 반복 횟수, 증감
            //{
            //    MessageBox.Show(i.ToString()); //i를 증가시키면서 출력시키는 실행문
            //}

            // 1부터 4까지 출력
            //for (int i = 1; i <= 4; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            for (int i = 5; i >= 1; i--)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //while문

            int i = 0;

            //while (i < 5) //(조건) 조건이 참이면 반복문 실행
            //{
            //    //조건을 제어할 수 있는 장치를 추가함
            //    MessageBox.Show("고장");
            //    i++;
            //}

            do
            {
                MessageBox.Show("실행");
                i++;
            }
            while (i < 5); //조건이 거짓이여도 무조건 1회는 실행됨
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            //string[] fruits = { "딸기", "사과", "포도" }; //자료형 변수 in 변수(배열 or 리스트)

            //foreach (string fruit in fruits) //배열의 요소를 하나씩 꺼내서 반복문 실행
            //{
            //    MessageBox.Show(fruit);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 }; //자료형[] 변수 = { 자료형용 값 }
            //foreach (int i in numbers)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            //for (int i = 0; i < numbers.Length; i++) //배열의 길이만큼 반복문 실행
            //{
            //    MessageBox.Show(numbers[i].ToString()); //index 순서, 순번

                //numbers[0] = 1;
                //numbers[1] = 2;
                //numbers[6] = 7;
            //}

            double[] doubles = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            foreach (double d in doubles)
            {
                MessageBox.Show(d.ToString());
            }
        }
    }
}
