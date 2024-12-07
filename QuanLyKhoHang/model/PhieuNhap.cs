using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.model
{
    public class PhieuNhap
    {
        private String MaPhieuNhap;
        private DateTime NgayNhap;
        private String MaNhanVien;
        private String NhaCungCap;
        private String MaHangHoa;
        private int SoLuongNhap;

        public PhieuNhap()
        {

        }

        public PhieuNhap(String MaPhieuNhap, DateTime NgayNhap, String MaNhanVien, String NhaCungCap, String MaHangHoa, int SoLuongNhap)
        {
            this.MaPhieuNhap = MaPhieuNhap;
            this.NgayNhap = NgayNhap;
            this.MaNhanVien = MaNhanVien;
            this.NhaCungCap = NhaCungCap;
            this.MaHangHoa = MaHangHoa;
            this.SoLuongNhap = SoLuongNhap;
        }

        public String getMaPhieuNhap()
        {
            return MaPhieuNhap;
        }

        public DateTime getNgayNhap()
        {
            return NgayNhap;
        }

        public String getMaNhanVien()
        {
            return MaNhanVien;
        }

        public String getNhaCungCap()
        {
            return NhaCungCap;
        }

        public String getMaHangHoa()
        {
            return MaHangHoa;
        }

        public int getSoLuongNhap()
        {
            return SoLuongNhap;
        }

        public void setMaPhieuNhap(String MaPhieuNhap)
        {
            this.MaPhieuNhap = MaPhieuNhap;
        }

        public void setNgayNhap(DateTime NgayNhap)
        {
            this.NgayNhap = NgayNhap;
        }

        public void setMaNhanVien(String MaNhanVien)
        {
            this.MaNhanVien = MaNhanVien;
        }

        public void setNhaCungCap(String NhaCungCap)
        {
            this.NhaCungCap = NhaCungCap;
        }

        public void setMaHangHoa(String MaHangHoa)
        {
            this.MaHangHoa = MaHangHoa;
        }

        public void setSoLuongNhap(int SoLuongNhap)
        {
            this.SoLuongNhap = SoLuongNhap;
        }
    }
}
