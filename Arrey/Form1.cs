using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Arrey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //배열 선언 및 초기화
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            //화면에 숫자들 출력
            //for, foreach

            //배열에 접근하는 방법
            //index : 순서
            //MessageBox.Show(numbers[0].ToString());
            //numbers라는 배율 중에 첫번째 요소에 접근해서 or 값을 읽어와서 메세지박스로 출력한다.

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = 0;
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    MessageBox.Show(numbers[i].ToString());
            //}

            //foreach (int num in numbers)
            //{
            //    MessageBox.Show(num.ToString());
            //}

            //1,2,3   1번째 줄
            //4,5,6   2번째 줄

            //2라는 숫자를 출력하려면 [0][1]   [몇번째 줄][해당 줄의 몇번째 칸]
            //6을 출력하려면 [1][2]

            //Q
            //1. 문자열 배열을 만들고 무지개 색깔을 넣어보자
            //2. 초록색을 검정색으로 바꿔보자
            //3. foreach문으로 모든 색깔을 출력해보자

            string[] rainbow = { "빨강", "주황", "노랑", "초록", "파랑", "남색", "보라" };
            rainbow[3] = "검정";
            foreach (string color in rainbow)
            {
                MessageBox.Show(color);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string country = "한국";
            string collage = "아산";

            //string text = string.Format("{0}폴리텍 {1}캠퍼스", country, collage);
            //MessageBox.Show(text);

            //보간 문자열 ($)을 사용하면 쉽게 포멧팅을 할 수 있다
            //여러줄을 사용하려면 @를 붙여준다
            string text = $@"{country}폴리텍
여러줄 사용 가능   
{collage}캠퍼스";
            MessageBox.Show(text);


        }
    }
}
