﻿using QuanLyKhoHang.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.view
{
    public partial class F_PX_Them : Form
    {
        private string connectionString = "Server=localhost,1433;Database=BTL_QuanLyKhoHang;Trusted_Connection=True;";
        private int ID_TaiKhoan;
        private PhieuXuat phieuXuat;
        public F_PX_Them(int ID_TaiKhoan)
        {
            InitializeComponent();
            this.ID_TaiKhoan = ID_TaiKhoan;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = string.Empty;
            dtpNgayXuat.Value = DateTime.Now;
            txtMaNhanVien.Text = string.Empty;
            txtKhachHang.Text = string.Empty;
            txtMaHangHoa.Text = string.Empty;
            nudSoLuongXuat.Value = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text) || string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtKhachHang.Text) || string.IsNullOrEmpty(txtMaHangHoa.Text) || nudSoLuongXuat.Value <= 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO PhieuXuat (MaPhieuXuat, NgayXuat, MaNhanVien, KhachHang, MaHang, SoLuongXuat, ID_TaiKhoan) " +
                           "VALUES (@MaPhieuXuat, @NgayXuat, @MaNhanVien, @KhachHang, @MaHang, @SoLuongXuat, @ID_TaiKhoan)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaPhieuXuat", txtMaPhieu.Text);
                command.Parameters.AddWithValue("@NgayXuat", dtpNgayXuat.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                command.Parameters.AddWithValue("@KhachHang", txtKhachHang.Text);
                command.Parameters.AddWithValue("@MaHang", txtMaHangHoa.Text);
                command.Parameters.AddWithValue("@SoLuongXuat", (int)nudSoLuongXuat.Value);
                command.Parameters.AddWithValue("@ID_TaiKhoan", ID_TaiKhoan);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoi_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát mà không lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
