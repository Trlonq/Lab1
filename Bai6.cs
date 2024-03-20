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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(textBox1.Text);
            int month = Convert.ToInt32(textBox2.Text);
            switch (month)
            {
                case 1:
                    if (day < 20)
                        textBox4.Text = "Ma Kết";
                    else
                        textBox4.Text = "Bảo Bình";
                    break;
                case 2:
                    if (day < 20)
                        textBox4.Text = "Bảo Bình";
                    else
                        textBox4.Text = "Song Ngư";
                    break;
                case 3:
                    if (day < 21)
                        textBox4.Text = "Song Ngư";
                    else
                        textBox4.Text = "Bạch Dương";
                    break;
                case 4:
                    if (day < 20)
                        textBox4.Text = "Bạch Dươn";
                    else
                        textBox4.Text = "Kim Ngưu";
                    break;
                case 5:
                    if (day < 21)
                        textBox4.Text = "Kim Ngưu";
                    else
                        textBox4.Text = "Song Tử";
                    break;
                case 6:
                    if (day < 21)
                        textBox4.Text = "Song Tử";
                    else
                        textBox4.Text = "Cự Giải";
                    break;
                case 7:
                    if (day < 23)
                        textBox4.Text = "Cự Giải";
                    else
                        textBox4.Text = "Sư Tử";
                    break;
                case 8:
                    if (day < 23)
                        textBox4.Text = "Sư Tử";
                    else
                        textBox4.Text = "Xử Nữ";
                    break;
                case 9:
                    if (day < 23)
                        textBox4.Text = "Xử Nữ";
                    else
                        textBox4.Text = "Thiên Bình";
                    break;
                case 10:
                    if (day < 23)
                        textBox4.Text = "Thiên Bình";
                    else
                        textBox4.Text = "Bọ Cạp";
                    break;
                case 11:
                    if (day < 22)
                        textBox4.Text = "Bọ Cạp";
                    else
                        textBox4.Text = "Nhân Mã";
                    break;
                case 12:
                    if (day < 22)
                        textBox4.Text = "Nhân Mã";
                    else
                        textBox4.Text = "Ma Kết";
                    break;
                default:
                    textBox4.Text = "Không xác định";
                    break;
            }    
        }
    }
}
