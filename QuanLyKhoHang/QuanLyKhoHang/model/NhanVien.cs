using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.model
{
    public class NhanVien
    {
        private String MaNhanVien;
        private String HoTen;
        private String SoDienThoai;
        private String DiaChi;
        private DateTime NgayVaoLam;

        public NhanVien()
        {

        }
        public NhanVien(String MaNV, String HoTen, String SoDienThoai, String DiaChi, DateTime NgayVaoLam)
        {
            this.MaNhanVien = MaNV;
            this.HoTen = HoTen;
            this.SoDienThoai = SoDienThoai;
            this.DiaChi = DiaChi;
            this.NgayVaoLam = NgayVaoLam;
        }

        public String getMaNhanVien()
        {
            return this.MaNhanVien;
        }
        public void setMaNhanVien(String MaNhanVien)
        {
            this.MaNhanVien = MaNhanVien;
        }
        public String getHoTen()
        {
            return this.HoTen;
        }
        public void setHoTen(String HoTen)
        {
            this.HoTen = HoTen;
        }
        public String getSoDienThoai()
        {
            return this.SoDienThoai;
        }
        public void setSoDienThoai(String SoDienThoai)
        {
            this.SoDienThoai = SoDienThoai;
        }
        public String getDiaChi()
        {
            return this.DiaChi;
        }
        public void setDiaChi(String DiaChi)
        {
            this.DiaChi = DiaChi;
        }
        public DateTime getNgayVaoLam()
        {
            return this.NgayVaoLam;
        }
        public void setNgayVaoLam(DateTime NgayVaoLam)
        {
            this.NgayVaoLam = NgayVaoLam;
        }
    }
}
