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
    public partial class Bai8 : Form
    {
        private List<string> danhSachMonAn = new List<string> {  };
        public Bai8()
        {
            InitializeComponent();
            HienThiDanhSachMonAn();
        }

        private void HienThiDanhSachMonAn()
        {
            txtDanhsach.Text = string.Join(", ", danhSachMonAn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDanhsach.Text = "";
            txtKQ.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string monMoi = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(monMoi))
            {
                danhSachMonAn.Add(monMoi);
                HienThiDanhSachMonAn();
                textBox1.Text = "";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (danhSachMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống. Vui lòng thêm món ăn trước khi tìm.");
                return;
            }

            Random random = new Random();
            int index = random.Next(0, danhSachMonAn.Count);
            string monAnHomNay = danhSachMonAn[index];

            txtKQ.Text = $"{monAnHomNay}";
        }
    }
}
