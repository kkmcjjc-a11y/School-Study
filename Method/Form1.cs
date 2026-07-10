using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        //전역변수 class에 직접 선언된 변수, 이 클래스 안이라면 어디서든 접근 가능
        int click = 1;

        //열거형
        enum Days //enum 이름(그룹 이름)
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Status
        {
            Run,
            Idle,
            Error,
            Stop
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //메서드(함수)
            //객체는 사물과 동작으로 표현할 수 있음
            //메서드는 동작을 코드로 나타냄

            //전달해주는 요소, 인자 -(parameter), 반환형 - 메서드 이름 앞에 붙는 키워드

            //1. 매개변수(파라미터, Parameter) 없고 반환(리턴, Return) 없음
            Sum(); //메서드 호출

            //2. 매개변수(파라미터, Parameter) 있고 반환(리턴, Return) 없음
            Sub(1, 2);

            //3. 매개변수(파라미터, Parameter) 없고 반환(리턴, Return) 있음
            int a = Mul(); //반환형은 자료형 그 자체다
            MessageBox.Show(a.ToString());

            //4. 매개변수(파라미터, Parameter) 있고 반환(리턴, Return) 있음
            int b = 3;
            double c = Div(a, b);
            MessageBox.Show(c.ToString());
        }

        private double Div(int a, int b)
        {
            return a / b;
        }

        private int Mul() //int, double로 반환
        {
            int a = 1;
            int b = 2;

            return a * b;
        }

        private void Sub(int v1, int v2) //(정수형 a, 정수형 b) 인자를 받는다
        {
            MessageBox.Show((v1 - v2).ToString());
        }

        private void Sum() //void - 반환할 게 없다, () 받을 인자도 없다, 파라미터가 없다
        {
            MessageBox.Show((1 + 2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Q
            //메서드
            //4가지
            //1. 매개변수(파라미터, Parameter) 없고 반환(리턴, Return) 없음 | 메서드에서 messagebox로 "클릭"
            First();

            //2. 매개변수(파라미터, Parameter) 있고 반환(리턴, Return) 없음 | parameter에 "클릭"이라는 글자를 전달 messagebox로 출력
            Second("클릭");

            //3. 매개변수(파라미터, Parameter) 없고 반환(리턴, Return) 있음 | 메서드에서 생성된 "클릭"이라는 글자를 받아와서 messagebox로 출력
            MessageBox.Show(Third());

            //4. 매개변수(파라미터, Parameter) 있고 반환(리턴, Return) 있음 | parameter에 "클"이라는 글자를 전달하고 메서드에서 "릭"이라는 글자를 합쳐서 반환한 뒤 messagebox로 출력
            MessageBox.Show(Forth("클"));
        }

        private string Forth(string c)
        {
            return c + "릭";
        }

        private string Third()
        {
            return "클릭";
        }

        private void Second(string v)
        {
            MessageBox.Show(v);
        }

        private void First()
        {
            MessageBox.Show("클릭");
        }

        //1. 메서드를 먼저 구현
        //2. 호출

        //1. 매개변수(파라미터, Parameter) 없고 반환(리턴, Return) 없음
        //2. 매개변수(파라미터, Parameter) 있고 반환(리턴, Return) 없음
        //3. 매개변수(파라미터, Parameter) 없고 반환(리턴, Return) 있음
        //4. 매개변수(파라미터, Parameter) 있고 반환(리턴, Return) 있음

        //반도체 장비를 가동한다는 가정
        //Run, Move, Grab, Make
        private void Run()
        {
            MessageBox.Show("운전을 시작합니다.");
        }

        private void Move(int x) //x라는 숫자를 받음, 호출할 때 보냄, 돌려주는 값음 없음
        {
            MessageBox.Show($"x축으로 {x}만큼 이동합니다.");
        }

        private string Grab() //호출시 값 필요 없음, 웨이퍼 라는 글자 반환
        {
            return "웨이퍼";
        }

        //변수 또는 메서드 이름 지을때
        //1. 직관적
        //2. 쉬울 것

        private string Make(string mat = "재료") //호출할 때 문자열 삽입, 반환할 때 문자열 반환
        {
            string semicon = $"{mat}를 결합하여 반도체로 만들었습니다.";
            return semicon;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Move(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string grab = $"장비에서 {Grab()}을 잡았습니다.";
            MessageBox.Show(grab);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //1. 가장 안쪽 메서드가 실행
            //2. Grab() = "웨이퍼"
            //3. Grab()이 Make()의 매개변수가 됨
            //4. Make() = "반도체로 만들었습니다."
            //5. product에 = "반도체로 만들었습니다."

            string product = Make(Grab()); //Make("웨이퍼"), "웨이퍼" = Grab()
            MessageBox.Show(product);

            //1. 변수 활용을 하면 누구나 이해하기 쉽게 코드를 작성할 수 있다.
            string a = Grab();
            string b = Make(a);
            MessageBox.Show(b);

            //2. 레거시나 기존 프로젝트, 혹은 AI가 작성한 코드에서 이해하기 어려운 부분들이 있을 수 있음.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Make());
            MessageBox.Show(Make("웨이퍼"));
        }

        private void Sum(ref int a, ref int b)
        {
            //referance, 참조형 > 원본 데이터를 그대로 사용하고 그대로 돌려줌

            a++;
            b++;
        }

        private void Sum2(int a, int b)
        {
            //값을 받아서 사용하고 이 함수에서 끝

            a++; //a = a + 1
            b++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 3;

            Sum2(a, b); //원데이터 복사본만 전송
            MessageBox.Show(a.ToString()); //0
            MessageBox.Show(b.ToString()); //3

            Sum(ref a, ref b); //원데이터 자체를 전송
            MessageBox.Show(a.ToString()); //1
            MessageBox.Show(b.ToString()); //4
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //out 키워드
            //Method에서 반환값은 1개인데 여러개를 반환하고 싶을 때
            //bool a = int.TryParse("123", out int b);

            //MessageBox.Show(a.ToString());
            //MessageBox.Show(b.ToString());

            //프로세스 구현을 하고 결과값에 따라 화면에 변화가 있음
            //1. Run, Move, Grab, Make 1회 사이클 완성 = Process true, "성공"
            //2. Run, Move 해당 파트에서 오류가 발생하면서 실패 = Process false, "실패"

            string result = "";
            bool final = Process(out result);

            if (!final)
            {
                MessageBox.Show(result);
                return;
            }

        }

        private bool Process(out string result)
        {
            if (Grab() != "웨이퍼")
            {
                result = "실패";
                return false;
            }

            result = "성공";
            return true;
        }

        //Q
        //1. 디폴트 있는 메서드 만들고 호출하기 디폴트 값 나오게, 파라미터 전달 값 나오게 2가지로
        //2. ref 사용해서 함수 내에서 곱해진 값을 원데이터로 확인하기
        //3. out 키워드 사용해서 값을 최대 5개까지 받기

        //1번 항목
        private string DefaultTest(string a = "디폴트")
        {
            string b = $"{a}값이 출력되었습니다.";
            return b;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DefaultTest());
            MessageBox.Show(DefaultTest("전달"));
        }

        //2번 항목
        private void RefTest(ref int a)
        {
            a *= 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = 3;
            RefTest(ref a);
            MessageBox.Show(a.ToString());

        }

        //3번 항목
        private bool OutTest(out int a, out int b, out int c, out int d, out int f)
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            f = 5;
            return true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OutTest(out int a, out int b, out int c, out int d, out int f);
            MessageBox.Show($"{a}, {b}, {c}, {d}, {f}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //지역변수 이 메서드 안에서만 동작하는 변수
            //메서드가 호출되면 새로 생성됨
            //int click = 1;
            //MessageBox.Show($"{click}번 클릭했습니다");
            //click++;

            MessageBox.Show($"오늘은 {Days.Tuesday}입니다");

            //열거형 사용방법
            Status a = Status.Error;

            switch (a)
            {
                case Status.Run:
                    MessageBox.Show("정상 가동");
                    break;

                case Status.Idle:
                    MessageBox.Show("예열 완료");
                    break;

                case Status.Error:
                    MessageBox.Show("에러 고장");
                    break;

                case Status.Stop:
                    MessageBox.Show("멈춤 상태");
                    break;

                default:
                    MessageBox.Show("작업자가 판단하여 동작시킬 것");
                    break;
            }
        }

        enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Navy,
            Purple
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Rainbow color = Rainbow.Red;

            switch (color)
            {
                case Rainbow.Red:
                    MessageBox.Show("빨강");
                    break;
                case Rainbow.Orange:
                    MessageBox.Show("주황");
                    break;
                case Rainbow.Yellow:
                    MessageBox.Show("노랑");
                    break;
                case Rainbow.Green:
                    MessageBox.Show("초록");
                    break;
                case Rainbow.Blue:
                    MessageBox.Show("파랑");
                    break;
                case Rainbow.Navy:
                    MessageBox.Show("남색");
                    break;
                case Rainbow.Purple:
                    MessageBox.Show("보라");
                    break;
            }
                
        }
    }
}
