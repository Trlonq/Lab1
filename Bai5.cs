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
    public partial class Bai5 : Form
    {
        private string luaChonPhepToan;
        public Bai5()
        {
            InitializeComponent();
            LoadNoiDungComboBox();
        }

        private void LoadNoiDungComboBox()
        {
            cbbChon.Items.AddRange(new string[] { "(A - B)!", "Tổng S = A^1 + A^2 + A^3 + ... + A^B" });
        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
            tbKQ.Text = "";

        }

        private long GiaiThua(int n)
        {
            if (n < 0)
            {
                return 0; 
            }

            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }

            return ketQua;
        }

        private double Tong(int A, int B)
        {
            double ketQua = 0;
            for (int i = 1; i <= B; i++)
            {
                ketQua += Math.Pow(A, i);
            }

            return ketQua;
        }

        private void KQ(string ketQua)
        {
            tbKQ.Text = $" {ketQua}";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbA.Text, out int A) && int.TryParse(tbB.Text, out int B))
            {
                luaChonPhepToan = cbbChon.SelectedItem.ToString();

                switch (luaChonPhepToan)
                {
                    case "(A - B)!":
                        long ketQuaGiaiThua = GiaiThua(A - B);
                        KQ(ketQuaGiaiThua.ToString());
                        break;

                    case "Tổng S = A^1 + A^2 + A^3 + ... + A^B":
                        double ketQuaTong = Tong(A, B);
                        KQ(ketQuaTong.ToString());
                        break;

                    default:
                        MessageBox.Show("Vui lòng chọn phép toán.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B.");
            }
        }
    }
}
