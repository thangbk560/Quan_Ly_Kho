using QuanLyKhoHang.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.view
{
    public partial class TrangChu : Form
    {
        private int ID_TaiKhoan;
        public TrangChu(int ID_TaiKhoan)
        {
            InitializeComponent();
            this.ID_TaiKhoan = ID_TaiKhoan;
            LoadUserControl(new pnlNhanVien(ID_TaiKhoan));
        }

        private void LoadUserControl(UserControl control)
        {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new pnlNhanVien(ID_TaiKhoan));
        }

        private void tsmiHangHoa_Click(object sender, EventArgs e)
        {
            LoadUserControl(new pnlHangHoa(ID_TaiKhoan));
        }

        private void tsmiPhieuNhap_Click(object sender, EventArgs e)
        {
            LoadUserControl(new pnlPhieuNhap(ID_TaiKhoan));
        }

        private void tsmiPhieuXuat_Click(object sender, EventArgs e)
        {
            LoadUserControl(new pnlPhieuXuat(ID_TaiKhoan));
        }

        private void tsmiViTriHangHoa_Click(object sender, EventArgs e)
        {
            LoadUserControl(new pnlViTriHangHoa(ID_TaiKhoan));
        }

        public void DangXuat()
        {
            new DangNhap().Show();

            this.Close();
        }
    }
}
