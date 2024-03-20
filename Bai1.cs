using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1._1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool IsInteger(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != '-')
                {
                    return false;
                }
            }
            return true;
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (IsInteger(textBox1.Text.Trim()) && IsInteger(textBox2.Text.Trim()))
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!!!");
            }
           

        }

        

    }
}
