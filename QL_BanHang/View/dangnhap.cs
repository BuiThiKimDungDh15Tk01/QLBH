using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_BanHang.View
{
    public partial class dangnhap : Form
    {
        private string user;
        private string pass;

        public dangnhap()
        {
            InitializeComponent();
        }

        public dangnhap(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            txtMatKhau.Focus();
        }

        private void dangnhap1()
        {
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
                MessageBox.Show("Mời bạn nhập Tài khoản và Mật khẩu");
            else
                if (this.txtTaiKhoan.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập tài khoản");
            else
                if (this.txtMatKhau.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            else

                if (this.txtTaiKhoan.Text == "123456" && txtMatKhau.Text == "123456");
            else
                MessageBox.Show("Bạn nhập thông tin không đúng");

        }


        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            if (this.txtTaiKhoan.Text == "123456" && this.txtMatKhau.Text == "123456")
            {
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            dangnhap1();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
