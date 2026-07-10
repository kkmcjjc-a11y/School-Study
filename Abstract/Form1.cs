using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.Drawing();
            circle.Move(1,2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            triangle.Drawing();
            triangle.Move(1, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Drawing();
            rectangle.Move(1, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "차":
                    IMovable car = new Car();
                    car.Move();
                    break;
                case "자전거":
                    IMovable bycle = new Bycle();
                    bycle.Move();
                    break;
                case "배":
                    IMovable ship = new Ship();
                    ship.Move();
                    break;
                case "비행기":
                    IMovable plane = new Plane();
                    plane.Move();
                    break;
            }
        }
    }
}
