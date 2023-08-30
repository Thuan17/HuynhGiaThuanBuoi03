using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HuynhGiaThuan
{
    public class Bai3
    {
        public int MSSV;
        public string HoTen;
        public double DiemLT, DiemTH;


        public int GetMssv()
        {
            return MSSV;
        }
        public string GetHoTen()
        {
            return HoTen;
        }
        public double GetDiemLT()
        {
            return DiemLT;
        }
        public double GetDiemTH()
        {
            return DiemTH;
        }

        public void setMssv(int mssv)
        {
            this.MSSV = mssv;
        }
        public void setHoten(string hoten)
        {
            this.HoTen = hoten;
        }
        public void setDiemLT(double diemLT)
        {
            this.DiemLT = diemLT;
        }
        public void setDiemTH(double diemTH)
        {
            this.DiemTH = diemTH;
        }
        public Bai3(int mssv, string Hoten, double diemLT, double diemTH)
        {
            MSSV = mssv;
            HoTen = Hoten;
            DiemLT = diemLT;
            DiemTH = diemTH;
        }
        public bool checkDiem()
        {
            if (DiemLT < 0 && DiemLT > 10)
            {
                return DiemLT == 0;
            }
            else if (DiemTH < 0 && DiemTH > 10)
            {
                return DiemTH == 0;
            }
            return true;
        }


        public double DiemTB()
        {
            return ((DiemLT+DiemTH)/2);
        }
        public void Contruc()
        {
            MSSV = 2000;
            HoTen = "Thusn";
            DiemLT = 7.5;
            DiemTH = 10;
        }

        public void thongtin()
        {
            MSSV =GetMssv();
        }

    }
}
