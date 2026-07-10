using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOverriding_Click(object sender, EventArgs e)
        {
            switch (cboClass.Text)
            {
                case "부모":
                    Parents parents = new Parents();
                    MessageBox.Show(parents.Speak());
                    break;

                case "자식":
                    Kids kids = new Kids();
                    MessageBox.Show(kids.Speak());
                    break;
            }
        }

        private void btnOverloading_Click(object sender, EventArgs e)
        {
            switch (cboClass.Text)
            {
                case "부모":
                    Parents parents = new Parents();
                    MessageBox.Show(parents.Call(tbName.Text, int.Parse(tbNum.Text)));
                    break;
            }
        }
    }

    class Parents
    {
        //Overriding을 할때는 부모에서는 virtual 키워드를 넣는다.
        public virtual string Speak()
        {
            return "부모님이 말씀하신다.";
        }

        //Overloading 반환형이나 매개변수가 달라지면 된다
        public string Call(string kid1)
        {
            return $"부모님이 {kid1}를 부르고 있습니다";
        }

        public string Call(string kid1, int num)
        {
            return $"부모님이 {kid1}를 {num}번 부르고 있습니다";
        }
    }

    class Kids : Parents
    {
        //Overriding을 할때는 자식에서는 override 키워드를 넣는다.
        public override string Speak()
        {
            return "자식도 말한다.";
        }
    }
}
