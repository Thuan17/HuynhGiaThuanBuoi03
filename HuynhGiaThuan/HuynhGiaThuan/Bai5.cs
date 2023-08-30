using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HuynhGiaThuan
{
    class Bai5
    {
        public int MaHang;
        public string TenHang;
        public double DonGia;
        public DateTime NgaySanXuat, NgayHetHan;
        public string GhiChu;
   
        public void setMaHang(int mahang) {

            if (!mahang.Equals(""))
            {
                this.MaHang = mahang;
            }
            

            this.MaHang = mahang; }
        public void setTenHang(string tenhang)
        {

            if (!tenhang.Trim().Equals(""))
            {
                this.TenHang = tenhang;
            }
            else
            {
                this.TenHang = ("xxx");
            }
        }
        public void setDonGia(double dongia) {

            if (dongia > 0)
            {
                this.DonGia = dongia;
            }
           
            else {
                this .DonGia = 0;
            }
        }
        public void setNSX(DateTime nsx) {
            DateTime ngay = DateTime.UtcNow;   
            string formatdate = ngay .ToString("dddd, dd MMMM yyyy HH:mm:ss ");   
            if (!nsx.Equals(""))
            {
                this.NgaySanXuat = nsx;
            }
            else 
            {
               this.NgaySanXuat =Convert.ToDateTime(formatdate);
            }
        }

        public bool checkDay() 
        {
            if (NgaySanXuat > NgayHetHan)
            {
                return true;
            }
            else if (NgayHetHan == null)
            {
                return (NgayHetHan==NgaySanXuat);
            }
            else
            {
                return false;
            }
           
        }
        public void setNHH(DateTime nhh)
        {
            DateTime test = nhh;
            int month = test.Year;
         
             if (nhh < NgaySanXuat)
            {
                this.NgayHetHan = NgaySanXuat;
            }
            else
            {
                this.NgayHetHan = nhh;
            }


        }
        public void setGhiChu(string ghichu) 
        { 
            DateTime now = DateTime.Now;
        
            if (getNHH() < now)
            {
                this.GhiChu = "Hang het han";
            }
            else 
            {
                this.GhiChu = ghichu;
            }

        }

        public int getMahang() { return MaHang; }
        public string getTenHang() 
        {
            return TenHang; 
              
        }
        public double getDonGia() { return DonGia; }
        public DateTime getNSX() { return NgaySanXuat; }
        public DateTime getNHH() { return NgayHetHan; }

        public string getGhiChu() { return GhiChu; }
    }
}
