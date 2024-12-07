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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienThiMatKhau.Checked ? '\0' : '●';
            txtXacNhanMatKhau.PasswordChar = chkHienThiMatKhau.Checked ? '\0' : '●';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            new DangNhap().Show();
            this.Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string cpassword = txtXacNhanMatKhau.Text.Trim();

            string connectionString = "Server=localhost,1433;Database=BTL_QuanLyKhoHang;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE Ten_TaiKhoan = @Ten_TaiKhoan";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Ten_TaiKhoan", username);
            int count = (int)command.ExecuteScalar();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cpassword))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập, mật khẩu và xác nhận mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, nhập tên đăng nhập khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (password != cpassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else
            {
                string query1 = "INSERT INTO TaiKhoan(Ten_TaiKhoan, MatKhau_TaiKhoan) VALUES(@username, @passwword)";
                using (SqlCommand command1 = new SqlCommand(query1, conn))
                {
                    command1.Parameters.AddWithValue("@username", username);
                    command1.Parameters.AddWithValue("@password", password);
                    try
                    {
                        command1.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new DangNhap().Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }
            }
            conn.Close();
        }
    }
}
