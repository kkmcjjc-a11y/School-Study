using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        //공간 1 (class 안)
        //새롭게 만들어질 필드(전역변수) or 메서드 or 생성자
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //공간 2 (method, 생성자 안)
            //만들어진 필드(전역변수) or 메서드를 사용하는 곳(호출)
            //지역변수 : 해당 지역(method or 생성자)에서만 사용 가능

            //디폴트 값 넣는 함수 만들기
            //디폴트 값으로는 "흰색"을 넣고 함수를 만들어서 빈값으로 호출, 값을 전달하여 호출
            //함수에서 messagebox 띄우기
            void PrintColor(string color = "흰색")
            {
                MessageBox.Show($"색깔은 {color}입니다.");
            }

            PrintColor();
            PrintColor("검정색");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ref 값 넣어서 참조하기
            //숫자 변수 만들고 100 초기화한 다음 ref 키워드가 들어간 함수를 만들고 원래 변수가 300이 되도록 만들기
            int number = 100;

            void ChangeNumber(ref int num)
            {
                num = number * 3;
            }

            MessageBox.Show($"기본값 : {number}");
            ChangeNumber(ref number);
            MessageBox.Show($"ref 키워드로 변경된 값 : {number}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //out으로 값 받기
            //return bool인 함수를 만들고 out으로 숫자 1개 문자열 1개를 받아오는 구조
            //결과에 따라서 true 숫자 출력 false 문자열 출력
            bool GetData(out int num, out string str)
            {
                num = 42;
                str = "Hello, World!";
                return true; // 또는 false로 변경하여 테스트할 수 있습니다.
            }

            if (GetData(out int number, out string message))
            {
                MessageBox.Show($"숫자: {number}");
            }
            else
            {
                MessageBox.Show($"문자열: {message}");
            }
        }
        //기본값 Deafult private
        private void button4_Click(object sender, EventArgs e)
        {
            //클래스 cookie 만들고
            //쿠키 이름 사이즈 가격
            //생성자
            //객체 생성까지

            //객체 생성
            Cookie Cookie1 = new Cookie("초코칩 쿠키", 10.4, 1500);
            Cookie Cookie2 = new Cookie("오트밀 쿠키", 8.2, 1200);

            //결과 출력
            MessageBox.Show($@"쿠키 이름: {Cookie1.Name.ToString()}
                               사이즈: {Cookie1.Size.ToString()}cm
                               가격: {Cookie1.Price.ToString()}원");

            MessageBox.Show($@"쿠키 이름: {Cookie2.Name.ToString()}
                               사이즈: {Cookie2.Size.ToString()}cm
                               가격: {Cookie2.Price.ToString()}원");

        }
    }

    //클래스 cookie 만들고
    class Cookie
    {
        //쿠키 이름 사이즈 가격
        //한정자 public, private
        //public : 어디서든 사용 가능
        //private : 자신이 속한 class에서만 사용 가능
        public string Name;
        public double Size;
        public int Price;

        //생성자
        public Cookie(string name, double size, int price)
        {
            Name = name;
            Size = size;
            Price = price;
        }
    }
}