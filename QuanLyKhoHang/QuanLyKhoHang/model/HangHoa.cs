using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.model
{
    public class HangHoa
    {
        private String MaHang;
        private String TenHang;
        private int SoLuongTon;
        private String DonViTinh;
        private Decimal DonGia;
        private String MoTa;
        private String NhaSanXuat;

        public HangHoa()
        {
        }

        public HangHoa(String MaHang, String TenHang, int SoLuongTon, String DonViTinh, Decimal DonGia, String MoTa, String NhaSanXuat)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.SoLuongTon = SoLuongTon;
            this.DonViTinh = DonViTinh;
            this.DonGia = DonGia;
            this.MoTa = MoTa;
            this.NhaSanXuat = NhaSanXuat;
        }

        public String getMaHang()
        {
            return MaHang;
        }

        public String getTenHang()
        {
            return TenHang;
        }

        public int getSoLuongTon()
        {
            return SoLuongTon;
        }

        public String getDonViTinh()
        {
            return DonViTinh;
        }

        public Decimal getDonGia()
        {
            return DonGia;
        }

        public String getMoTa()
        {
            return MoTa;
        }

        public String getNhaSanXuat()
        {
            return NhaSanXuat;
        }

        public void setMaHang(String MaHang)
        {
            this.MaHang = MaHang;
        }

        public void setTenHang(String TenHang)
        {
            this.TenHang = TenHang;
        }

        public void setSoLuongTon(int SoLuongTon)
        {
            this.SoLuongTon = SoLuongTon;
        }

        public void setDonViTinh(String DonViTinh)
        {
            this.DonViTinh = DonViTinh;
        }

        public void setDonGia(Decimal DonGia)
        {
            this.DonGia = DonGia;
        }

        public void setMoTa(String MoTa)
        {
            this.MoTa = MoTa;
        }

        public void setNhaSanXuat(String NhaSanXuat)
        {
            this.NhaSanXuat = NhaSanXuat;
        }
    }
}
