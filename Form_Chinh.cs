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
    public partial class Form_Chinh : Form
    {
        public Form_Chinh()
        {
            InitializeComponent();
        }

        private void Form_Chinh_Load(object sender, EventArgs e)
        {

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Bai1 f = new Bai1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai2 f = new Bai2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai3 f = new Bai3();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai6 f = new Bai6();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai4 f = new Bai4();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai3_1 f = new Bai3_1();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai5 f = new Bai5();   
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai7 f = new Bai7();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai8 f = new Bai8();
            f.Show();
        }
    }
}
