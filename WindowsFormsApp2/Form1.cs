using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if ((i == 1 && j == 1) || (i == 2 && j == 2) || (i == 4 || j == 3))
                        break;
                    MessageBox.Show($"{i}{j}");
                }
            }
        }
    }
}
