using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.model
{
    public class PhieuXuat
    {
        private String MaPhieuXuat;
        private DateTime NgayXuat;
        private String MaNhanVien;
        private String KhachHang;
        private String MaHangHoa;
        private int SoLuongXuat;
        private decimal ThanhTien;

        public PhieuXuat()
        {

        }

        public PhieuXuat(String MaPhieuXuat, DateTime NgayXuat, String MaNhanVien, String KhachHang, String MaHangHoa, int SoLuongXuat, decimal ThanhTien)
        {
            this.MaPhieuXuat = MaPhieuXuat;
            this.NgayXuat = NgayXuat;
            this.MaNhanVien = MaNhanVien;
            this.KhachHang = KhachHang;
            this.MaHangHoa = MaHangHoa;
            this.SoLuongXuat = SoLuongXuat;
            this.ThanhTien = ThanhTien;
        }

        public String getMaPhieuXuat()
        {
            return MaPhieuXuat;
        }

        public DateTime getNgayXuat()
        {
            return NgayXuat;
        }

        public String getMaNhanVien()
        {
            return MaNhanVien;
        }

        public String getKhachHang()
        {
            return KhachHang;
        }

        public String getMaHangHoa()
        {
            return MaHangHoa;
        }

        public int getSoLuongXuat()
        {
            return SoLuongXuat;
        }

        public decimal getThanhTien()
        {
            return ThanhTien;
        }

        public void setMaPhieuXuat(String MaPhieuXuat)
        {
            this.MaPhieuXuat = MaPhieuXuat;
        }

        public void setNgayXuat(DateTime NgayXuat)
        {
            this.NgayXuat = NgayXuat;
        }

        public void setMaNhanVien(String MaNhanVien)
        {
            this.MaNhanVien = MaNhanVien;
        }

        public void setKhachHang(String KhachHang)
        {
            this.KhachHang = KhachHang;
        }

        public void setMaHangHoa(String MaHangHoa)
        {
            this.MaHangHoa = MaHangHoa;
        }

        public void setSoLuongXuat(int SoLuongXuat)
        {
            this.SoLuongXuat = SoLuongXuat;
        }

        public void setThanhTien(decimal ThanhTien)
        {
            this.ThanhTien = ThanhTien;
        }
    }
}
