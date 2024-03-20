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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbNhap.Text = "";
            tbKQ.Text = "";
            tbXL.Text = "";
            tbSomondau.Text = "";
            tbSomonrot.Text = "";
            tbMonthapnhat.Text = "";
            tbMoncaonhat.Text = "";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] diemArray = tbNhap.Text.Split(',');

            if (diemArray.Length < 2)
            {
                MessageBox.Show("Nhập họ tên và ít nhất một điểm.");
                return;
            }

            string hoTen = diemArray[0].Trim();
            string[] diemStringArray = diemArray.Skip(1).ToArray();
            double[] diemArrayDouble;

            try
            {
                diemArrayDouble = diemStringArray.Select(double.Parse).ToArray();
            }
            catch (FormatException)
            {
                MessageBox.Show("Không hợp lệ.");
                return;
            }

            string message = $"Họ và tên: {hoTen}\nDanh sách điểm theo môn: ";
            for (int i = 0; i < diemArrayDouble.Length; i++)
            {
                message += $"Môn {i + 1}: {diemArrayDouble[i]} ";
            }

            MessageBox.Show(message);


            // Tinh dtb
            double diemTrungBinh = diemArrayDouble.Length > 0 ? diemArrayDouble.Average() : 0;
            tbKQ.Text = diemTrungBinh.ToString("0.00");

            // Tim mon diem cao nhat, thap nhat
            double diemCaoNhat = diemArrayDouble.Length > 0 ? diemArrayDouble.Max() : 0;
            double diemThapNhat = diemArrayDouble.Length > 0 ? diemArrayDouble.Min() : 0;
            tbMoncaonhat.Text = diemCaoNhat.ToString("0.00");
            tbMonthapnhat.Text = diemThapNhat.ToString("0.00");

            // So mon dau, mon rot
            int soMonDau = diemArrayDouble.Count(diem => diem >= 5);
            int soMonRot = diemArrayDouble.Count(diem => diem < 5);
            tbSomondau.Text = soMonDau.ToString();
            tbSomonrot.Text = soMonRot.ToString();

            // Xep loai
            if (diemTrungBinh >= 8 && diemArrayDouble.All(diem => diem >= 6.5))
            {
                tbXL.Text = "Giỏi";
            }
            else if (diemTrungBinh >= 6.5 && diemArrayDouble.All(diem => diem >= 5))
            {
                tbXL.Text = "Khá";
            }
            else if (diemTrungBinh >= 5 && diemArrayDouble.All(diem => diem >= 3.5))
            {
                tbXL.Text = "Trung bình";
            }
            else if (diemTrungBinh >= 3.5 && diemArrayDouble.All(diem => diem >= 2))
            {
                tbXL.Text = "Yếu";
            }
            else
            {
                tbXL.Text = "Kém";
            }
        }
    }
}
