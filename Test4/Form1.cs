using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            switch (cboColor.Text)
            {
                case "빨강":
                    Red red = new Red(true, false)

            }
        }
    }
}
