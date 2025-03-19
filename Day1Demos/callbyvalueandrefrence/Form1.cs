using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callbyvalueandrefrence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class swapdemo
        {
            public void swap( ref int x, ref int y)
            {
                int temp;
                temp = x;
                x = y;
                y= temp;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 10;
            b = 20;
            MessageBox.Show("Before swapping");
            MessageBox.Show("A=" + a + "\nB=" + b);
            swapdemo swapdemo = new swapdemo();
           // swapdemo.swap(a, b);
            MessageBox.Show("After swapping");
            MessageBox.Show("A=" + a + "\nB=" + b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 10;
            b = 20;
            MessageBox.Show("Before swapping");
            MessageBox.Show("A=" + a + "\nB=" + b);
            swapdemo swapdemo = new swapdemo();
            swapdemo.swap(ref a, ref b);
            MessageBox.Show("After swapping");
            MessageBox.Show("A=" + a + "\nB=" + b);
        

    }
    }
}
