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
    public partial class pnlNhanVien : UserControl
    {
        private int ID_TaiKhoan;
        private string connectionString = "Server=localhost,1433;Database=BTL_QuanLyKhoHang;Trusted_Connection=True;";

        public pnlNhanVien(int ID_TaiKhoan)
        {
            InitializeComponent();
            this.ID_TaiKhoan = ID_TaiKhoan;
            LoadData();
        }

        private void LoadData(string keyword = "", string orderByColumn = "MaNhanVien", bool isAscending = true)
        {
            string sortOrder = isAscending ? "ASC" : "DESC";
            string query = $"SELECT * FROM NhanVien WHERE ID_TaiKhoan = {ID_TaiKhoan} ORDER BY {orderByColumn} {sortOrder}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", keyword);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvNhanVien.DataSource = table;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            LoadData(keyword);
        }

        private void dgvNhanVien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvNhanVien.Columns[e.ColumnIndex].Name;
            bool isAscending = true;
            LoadData(txtTimKiem.Text.Trim(), columnName, isAscending);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            new F_NV_Them(ID_TaiKhoan).Show();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];


                DateTime.TryParse(selectedRow.Cells["NgayVaoLam"].Value.ToString(), out DateTime NgayVaoLam);
                NhanVien nhanVien = new NhanVien(
                    selectedRow.Cells["MaNhanVien"].Value.ToString(),
                    selectedRow.Cells["HoTen"].Value.ToString(),
                    selectedRow.Cells["SoDienThoai"].Value.ToString(),
                    selectedRow.Cells["DiaChi"].Value.ToString(),
                    NgayVaoLam
                );

                F_NV_Sua formSua = new F_NV_Sua(ID_TaiKhoan, nhanVien);
                formSua.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
                    {
                        string maNhanVien = row.Cells["MaNhanVien"].Value.ToString();
                        string query = $"DELETE FROM NhanVien WHERE MaNhanVien = {maNhanVien} AND ID_TaiKhoan = {ID_TaiKhoan}";

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, conn);

                            try
                            {
                                conn.Open();
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
