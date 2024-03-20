using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LAB1._1
{
    
    public partial class Bai4 : Form
    {
        
        public Bai4()
        {
            InitializeComponent();
            LoadPhimData();
        }

        private void LoadPhimData()
        {
            cbbTenphim.Items.AddRange(new string[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });

        }

        private readonly Dictionary<string, int> giaVePhim = new Dictionary<string, int>
        {
            { "Đào, phở và piano", 45000 },
            { "Mai", 100000 },
            { "Gặp lại chị bầu", 70000 },
            { "Tarot", 90000 }
        };

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text.Trim();
        }
    }

   
}
