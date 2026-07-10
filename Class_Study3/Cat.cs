using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Study3
{
    internal class Cat : Animal
    {
        public string Bell { get; set; }

        public Cat(string name, int legs, string bell) : base(name, legs)
        //부모에서 생성되는 생성자를 따라가며 앞쪽에는 자식의 생성자 : 부모의 생성자 / base()
        {
            Bell = bell;
        }

        public string Meow()
        {
            return $"{Name} 야옹 {Bell}이 달랑달랑";
        }
    }
}
