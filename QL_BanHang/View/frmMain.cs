using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.View;

namespace QL_BanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void hàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.ShowDialog();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }
    }
}
