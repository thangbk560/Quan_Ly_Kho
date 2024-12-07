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
    public partial class F_PX_Sua : Form
    {
        private string connectionString = "Server=localhost,1433;Database=BTL_QuanLyKhoHang;Trusted_Connection=True;";
        private int ID_TaiKhoan;
        private PhieuXuat phieuXuat;
        private PhieuXuat originalPhieuXuat;
        public F_PX_Sua(int ID_TaiKhoan, PhieuXuat phieuXuat)
        {
            InitializeComponent();
            this.ID_TaiKhoan = ID_TaiKhoan;
            this.phieuXuat = phieuXuat;

            originalPhieuXuat = new PhieuXuat(phieuXuat.getMaPhieuXuat(), phieuXuat.getNgayXuat(), phieuXuat.getMaNhanVien(), phieuXuat.getKhachHang(), phieuXuat.getMaHangHoa(), phieuXuat.getSoLuongXuat(), phieuXuat.getThanhTien());

            txtMaPhieu.Text = phieuXuat.getMaPhieuXuat();
            dtpNgayXuat.Value = phieuXuat.getNgayXuat();
            txtMaNhanVien.Text = phieuXuat.getMaNhanVien();
            txtKhachHang.Text = phieuXuat.getKhachHang();
            txtMaHangHoa.Text = phieuXuat.getMaHangHoa();
            nudSoLuongXuat.Value = (int)phieuXuat.getSoLuongXuat();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            phieuXuat = new PhieuXuat(originalPhieuXuat.getMaPhieuXuat(), originalPhieuXuat.getNgayXuat(), originalPhieuXuat.getMaNhanVien(), originalPhieuXuat.getKhachHang(), originalPhieuXuat.getMaHangHoa(), originalPhieuXuat.getSoLuongXuat(), originalPhieuXuat.getThanhTien());

            txtMaPhieu.Text = phieuXuat.getMaPhieuXuat();
            dtpNgayXuat.Value = phieuXuat.getNgayXuat();
            txtMaNhanVien.Text = phieuXuat.getMaNhanVien();
            txtKhachHang.Text = phieuXuat.getKhachHang();
            txtMaHangHoa.Text = phieuXuat.getMaHangHoa();
            nudSoLuongXuat.Value = (int)phieuXuat.getSoLuongXuat();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            phieuXuat.setNgayXuat(dtpNgayXuat.Value);
            phieuXuat.setMaNhanVien(txtMaNhanVien.Text);
            phieuXuat.setKhachHang(txtKhachHang.Text);
            phieuXuat.setMaHangHoa(txtMaHangHoa.Text);
            phieuXuat.setSoLuongXuat((int)nudSoLuongXuat.Value);

            string query = "UPDATE PhieuXuat SET NgayXuat = @NgayXuat, MaNhanVen = @MaNhanVien, KhachHang = @KhachHang, MaHang = @MaHangHoa, SoLuongXuat = @soLuongXuat WHERE MaPhieuXuat = @MaPhieuXuat AND ID_TaiKhoan = @ID_TaiKhoan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NgayXuat", phieuXuat.getNgayXuat().ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@MaNhanVien", phieuXuat.getMaNhanVien());
                command.Parameters.AddWithValue("@KhachHang", phieuXuat.getKhachHang());
                command.Parameters.AddWithValue("@MaHang", phieuXuat.getMaHangHoa());
                command.Parameters.AddWithValue("@SoLuongXuat", phieuXuat.getSoLuongXuat());
                command.Parameters.AddWithValue("@MaPhieuXuat", phieuXuat.getMaPhieuXuat());
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
