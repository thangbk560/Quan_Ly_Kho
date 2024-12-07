using QuanLyKhoHang.model;
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
    public partial class F_PN_Sua : Form
    {
        private string connectionString = "Server=localhost,1433;Database=BTL_QuanLyKhoHang;Trusted_Connection=True;";
        private int ID_TaiKhoan;
        private PhieuNhap phieuNhap;
        private PhieuNhap originalPhieuNhap;
        public F_PN_Sua(int ID_TaiKhoan, PhieuNhap phieuNhap)
        {
            InitializeComponent();
            this.ID_TaiKhoan = ID_TaiKhoan;
            this.phieuNhap = phieuNhap;

            originalPhieuNhap = new PhieuNhap(phieuNhap.getMaPhieuNhap(), phieuNhap.getNgayNhap(), phieuNhap.getMaNhanVien(), phieuNhap.getNhaCungCap (), phieuNhap.getMaHangHoa(), phieuNhap.getSoLuongNhap());

            txtMaPhieu.Text = phieuNhap.getMaPhieuNhap();
            dtpNgayNhap.Value = phieuNhap.getNgayNhap();
            txtMaNhanVien.Text = phieuNhap.getMaNhanVien();
            txtNhaCungCap.Text = phieuNhap.getNhaCungCap();
            txtMaHangHoa.Text = phieuNhap.getMaHangHoa();
            nudSoLuongNhap.Value = (int)phieuNhap.getSoLuongNhap();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            phieuNhap = new PhieuNhap(originalPhieuNhap.getMaPhieuNhap(), originalPhieuNhap.getNgayNhap(), originalPhieuNhap.getMaNhanVien(), originalPhieuNhap.getNhaCungCap(), originalPhieuNhap.getMaHangHoa(), originalPhieuNhap.getSoLuongNhap());

            txtMaPhieu.Text = phieuNhap.getMaPhieuNhap();
            dtpNgayNhap.Value = phieuNhap.getNgayNhap();
            txtMaNhanVien.Text = phieuNhap.getMaNhanVien();
            txtNhaCungCap.Text = phieuNhap.getNhaCungCap();
            txtMaHangHoa.Text = phieuNhap.getMaHangHoa();
            nudSoLuongNhap.Value = (int)phieuNhap.getSoLuongNhap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            phieuNhap.setNgayNhap(dtpNgayNhap.Value);
            phieuNhap.setMaNhanVien(txtMaNhanVien.Text);
            phieuNhap.setNhaCungCap(txtNhaCungCap.Text);
            phieuNhap.setMaHangHoa(txtMaHangHoa.Text);
            phieuNhap.setSoLuongNhap((int)nudSoLuongNhap.Value);

            string query = "UPDATE PhieuNhap SET NgayNhap = @NgayNhap, MaNhanVen = @MaNhanVien, NhaCungCap = @NhaCungCap, MaHang = @MaHangHoa, SoLuongNhap = @soLuongNhap WHERE MaPhieuNhap = @MaPhieuNhap AND ID_TaiKhoan = @ID_TaiKhoan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NgayNhap", phieuNhap.getNgayNhap().ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@MaNhanVien", phieuNhap.getMaNhanVien());
                command.Parameters.AddWithValue("@NhaCungCap", phieuNhap.getNhaCungCap());
                command.Parameters.AddWithValue("@MaHang", phieuNhap.getMaHangHoa());
                command.Parameters.AddWithValue("@SoLuongNhap", phieuNhap.getSoLuongNhap());
                command.Parameters.AddWithValue("@MaPhieuNhap", phieuNhap.getMaPhieuNhap());
                command.Parameters.AddWithValue("@ID_TaiKhoan", ID_TaiKhoan);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
