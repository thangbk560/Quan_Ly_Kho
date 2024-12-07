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
    public partial class pnlViTriHangHoa : UserControl
    {
        private string connectionString = "Server=localhost,1433;Database=BTL_QuanLyKhoHang;Trusted_Connection=True;";
        private int ID_TaiKhoan;
        public pnlViTriHangHoa(int ID_TaiKhoan)
        {
            InitializeComponent();
            this.ID_TaiKhoan = ID_TaiKhoan;
        }

        private void KiemTraMaHangHoa(string maHangHoa)
        {
            string query = "SELECT MaKe, TenKe, Tang, Ngan FROM ViTriHangHoa WHERE MaHang = @MaHang AND ID_TaiKhoan = @ID_TaiKhoan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaHang", maHangHoa);
                command.Parameters.AddWithValue("@ID_TaiKhoan", ID_TaiKhoan);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtMaKe.Text = reader["MaKe"].ToString();
                        txtTenKe.Text = reader["TenKe"].ToString();
                        txtTang.Text = reader["Tang"].ToString();
                        txtNgan.Text = reader["Ngan"].ToString();

                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                    else
                    {
                        ClearTextBoxes();
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        MessageBox.Show("Mã hàng hóa không tồn tại. Bạn có thể thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearTextBoxes()
        {
            txtMaKe.Text = string.Empty;
            txtTenKe.Text = string.Empty;
            txtTang.Text = string.Empty;
            txtNgan.Text = string.Empty;
        }

        private void txtMaHangHoa_TextChanged(object sender, EventArgs e)
        {
            string maHangHoa = txtMaHangHoa.Text.Trim();

            if (!string.IsNullOrEmpty(maHangHoa))
            {
                KiemTraMaHangHoa(maHangHoa);
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHangHoa = txtMaHangHoa.Text.Trim();
            string maKe = txtMaKe.Text.Trim();
            string tenKe = txtTenKe.Text.Trim();
            string tang = txtTang.Text.Trim();
            string ngan = txtNgan.Text.Trim();

            string query = "INSERT INTO QuanLyKho (MaHang, MaKe, TenKe, Tang, Ngan, ID_TaiKhoan) VALUES (@MaHang, @MaKe, @TenKe, @Tang, @Ngan, @ID_TaiKhoan)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaHang", maHangHoa);
                command.Parameters.AddWithValue("@MaKe", maKe);
                command.Parameters.AddWithValue("@TenKe", tenKe);
                command.Parameters.AddWithValue("@Tang", tang);
                command.Parameters.AddWithValue("@Ngan", ngan);
                command.Parameters.AddWithValue("@ID_TaiKhoan", ID_TaiKhoan);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHangHoa = txtMaHangHoa.Text.Trim();
            string maKe = txtMaKe.Text.Trim();
            string tenKe = txtTenKe.Text.Trim();
            string tang = txtTang.Text.Trim();
            string ngan = txtNgan.Text.Trim();

            string query = "UPDATE QuanLyKho SET MaKe = @MaKe, TenKe = @TenKe, Tang = @Tang, Ngan = @Ngan WHERE MaHang = @MaHang AND ID_TaiKhoan = @ID_TaiKhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHang", maHangHoa);
                command.Parameters.AddWithValue("@MaKe", maKe);
                command.Parameters.AddWithValue("@TenKe", tenKe);
                command.Parameters.AddWithValue("@Tang", tang);
                command.Parameters.AddWithValue("@Ngan", ngan);
                command.Parameters.AddWithValue("@ID_TaiKhoan", ID_TaiKhoan);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHangHoa = txtMaHangHoa.Text.Trim();

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM QuanLyKho WHERE MaHang = @MaHang AND ID_TaiKhoan = @ID_TaiKhoan";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@MaHang", maHangHoa);
                    command.Parameters.AddWithValue("@ID_TaiKhoan", ID_TaiKhoan);

                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ID_TaiKhoan = 0;

                TrangChu formTrangChu = this.FindForm() as TrangChu;
                if (formTrangChu != null)
                {
                    formTrangChu.DangXuat();
                }
            }
            else
            {
                return;
            }
        }
    }
}
