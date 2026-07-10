using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Study3
{
    //상속 받는 형태
    internal class Dog : Animal //class 자식클래스이름 : 부모클래스이름
    {
        public string Tail { get; set; }

        public Dog(string name, int legs, string tail) : base(name, legs)
        //부모에서 생성되는 생성자를 따라가며 앞쪽에는 자식의 생성자 : 부모의 생성자 / base()
        {
            Name = "멍멍이"; //protected 접근 제한자가 붙어 있는 필드(전역변수)는 자식 클래스에서 제어(접근)가 가능하다.
            Tail = tail;
        }

        public string Bark()
        {
            return $"{Name} 멍멍 {Tail}를 흔듭니다.";
        }
    }
}
