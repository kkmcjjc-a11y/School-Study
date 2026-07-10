using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    //추상 클래스
    //구현은 하지 않고 자식에서 상속받아서 정의하는 내용

    //접근 제한자 - 부모와 자식이 동일하게 맞춘다
    public abstract class Shape
    {
        public abstract void Drawing();

        public void Move(int x, int y)
        {
            MessageBox.Show($"{x},{y}로 이동합니다.");
        }
    }

    public class Circle : Shape
    {
        //추상 클래스 부모에서 가져온 메서드를 자식에서 override해서 사용

        public override void Drawing()
        {
            MessageBox.Show("원을 그립니다.");
        }
    }

    public class Triangle : Shape
    {
        //추상 클래스 부모에서 가져온 메서드를 자식에서 override해서 사용

        public override void Drawing()
        {
            MessageBox.Show("삼각형을 그립니다.");
        }
    }

    public class Rectangle : Shape
    {
        //추상 클래스 부모에서 가져온 메서드를 자식에서 override해서 사용

        public override void Drawing()
        {
            MessageBox.Show("사각형을 그립니다.");
        }
    }
}
