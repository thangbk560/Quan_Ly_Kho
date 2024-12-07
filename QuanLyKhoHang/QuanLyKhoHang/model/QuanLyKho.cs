using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.model
{
    public class QuanLyKho
    {
        private HangHoa HangHoaKho;
        private String MaKe;
        private String TenKe;
        private String Tang;
        private String Ngan;

        public QuanLyKho()
        {

        }

        public QuanLyKho(HangHoa HangHoaKho, String MaKe, String TenKe, String Tang, String Ngan)
        {
            this.HangHoaKho = HangHoaKho;
            this.MaKe = MaKe;
            this.TenKe = TenKe;
            this.Tang = Tang;
            this.Ngan = Ngan;
        }

        public HangHoa getHangHoaKho()
        {
            return HangHoaKho;
        }

        public String getMaKe()
        {
            return MaKe;
        }

        public String getTenKe()
        {
            return TenKe;
        }

        public String getTang()
        {
            return Tang;
        }

        public String getNgan()
        {
            return Ngan;
        }

        public void setHangHoaKho(HangHoa HangHoaKho)
        {
            this.HangHoaKho = HangHoaKho;
        }

        public void setMaKe(String MaKe)
        {
            this.MaKe = MaKe;
        }

        public void setTenKe(String TenKe)
        {
            this.TenKe = TenKe;
        }

        public void setTang(String Tang)
        {
            this.Tang = Tang;
        }

        public void setNgan(String Ngan)
        {
            this.Ngan = Ngan;
        }
    }
}
