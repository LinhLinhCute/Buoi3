using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_NgoThiThuyLinh_Buoi3_OOP
{
    class HangThucPham
    {
        private string mahang;
        private string tenhang;
        private double dongia;
        private DateTime ngaysanxuat;
        private DateTime ngayhethan;

        public void SetMaHang(string mahang) 
        {
            if (!mahang.Trim().Equals(""))
                this.mahang = mahang;
            else
                throw new Exception("Ma Hang Khong Duoc Rong !!");
        }
        public void GetMaHang(string mahang){
            this.mahang=mahang;
        }
        public void SetTenHang(string tenhang)
        {
            if (!tenhang.Trim().Equals(""))
                this.tenhang = tenhang;
            else
                this.mahang = "xxx";
        }
        public void GetTenHang(string tenhang)
        {
            this.tenhang = tenhang;
        }
        public void SetDonGia(double dongia)
        {
            if (dongia >= 0)
                this.dongia = dongia;
            else
                throw new Exception("Don Gia Phai Lon Hon Hoac Bang 0");
        }
        public void GetDonGia(double dongia)
        {
            this.dongia = dongia;
        }
    }
}
