using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CubeDemo;

namespace classobjectdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Employee
        {
            int salary;
            int bonus;
            public void tsal(int sal1, int bonus1)
            {
                salary = sal1;
                bonus = bonus1;
                MessageBox.Show("The total salary is " + (salary + bonus));
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {
                Employee emp = new Employee();
                emp.tsal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            }

            private void button2_Click(object sender, EventArgs e)
            {
                CubeFind cubeFind = new CubeFind();
                MessageBox.Show("the cube of the number is " + cubeFind.Cube(5));
            }
        }
    }

