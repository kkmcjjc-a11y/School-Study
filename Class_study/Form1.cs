using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_study
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //클래스 인스턴스 생성
            //클래스로 생성된 객체 또는 인스턴스는 서로 다른 존재
            Person a = new Person(tbName.Text, tbPhone.Text, int.Parse(tbAge.Text));
            a.Introduce();

            Person b = new Person("사람", "010-1234-5678", 123);
            b.Introduce();
        }
    }

    //쿠키틀, 탬플릿
    class Person
    {
        //공간 1
        //새로운 것들을 지정하고 정의하는 공간
        public string Name;
        public string Phone;
        public int Age;

        //생성자
        //클래스가 처음 객체를 생성할 때 값을 세팅하는 곳
        public Person(string name, string phone, int age)
        {
            Name = name; //클래스의 전역변수와 파라미터 값을 연결
            Phone = phone;
            Age = age;
        }

        public void Introduce()
        {
            //공간 2
            //만들어진 변수, 메서드, 생성자를 호출 or 사용하는 공간
            MessageBox.Show($"안녕하세요. 저는 {Name}이고, 전화번호는 {Phone}이고, 나이는 {Age}살입니다.");
        }
    }

}
