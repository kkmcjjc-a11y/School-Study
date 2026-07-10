using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    internal interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            MessageBox.Show("차가 움직입니다.");
        }
    }

    public class Bycle : IMovable
    {
        public void Move()
        {
            MessageBox.Show("자전거가 움직입니다.");
        }
    }

    public class Ship : IMovable
    {
        public void Move()
        {
            MessageBox.Show("배가 움직입니다.");
        }
    }
    public class Plane : IMovable
    {
        public void Move()
        {
            MessageBox.Show("비행기가 움직입니다.");
        }
    }
}
