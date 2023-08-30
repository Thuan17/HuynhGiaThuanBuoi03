using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HuynhGiaThuan
{
    static class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Chon");
            Console.WriteLine("1.Bai 1");
            Console.WriteLine("2.Bai 1");
            Console.WriteLine("3.Bai 3");
            Console.WriteLine("4.Bai 4");
            Console.WriteLine("5.Bai 5");
            Console.Write("Nhap vao thang can kiem tra: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
               
                case 1:
                    Console.WriteLine("Thang {0} la mua xuan", x);
                    Bai1 bai1 = new Bai1();
                    bai1.setColor("Thuan");
                    bai1.setGia(2000);
                    break;
               
                case 2:
                    Bai2 bai2 = new Bai2();
                    bai2.setX(12);
                    bai2.setY(15);
                    bai2.setNameX("thusna");
                   
                    Console.WriteLine(bai2.getNameX()+"("+Convert.ToString(bai2.getX())+";" + Convert.ToString(bai2.getY()) + ")"  );


                    break;
               
                case 3:
                    
                    Bai3 bai3 = new Bai3(2000, "Thuan", 9, 8);
                    Bai3 baix = new Bai3(2000, "Thuan", 9, 8);
                    Console.WriteLine("Bai", x);
                    Console.WriteLine("Nhap Sv 03");
                    Console.WriteLine("Nhap MSSV 03");
                    int mssv = Convert.ToInt32(Console.ReadLine());
                    bai3.setMssv(mssv);
                    Console.WriteLine("Nhap HoTen 03");
                    string HoTen = Console.ReadLine();
                    bai3.setHoten(HoTen);
                    Console.WriteLine("Nhap DiemLT 03");
                    double diemLT = Convert.ToDouble(Console.ReadLine());
                    bai3.setDiemLT(diemLT);
                    Console.WriteLine("Nhap DiemTH 03");
                    double diemTH = Convert.ToDouble(Console.ReadLine());
                    bai3.setDiemTH(diemTH);
                    Console.WriteLine("Thong Tin");
                    Console.WriteLine(Convert.ToString(baix.MSSV) + "\t" + baix.HoTen + "\t" + baix.DiemTH + "\t" + baix.DiemLT + "\t"+ baix.DiemTB());
                    Console.WriteLine(bai3.GetMssv()+"\t"+bai3.GetHoTen() + "\t" + bai3.GetDiemLT() + "\t" + bai3.GetDiemTH() + "\t" + bai3.DiemTB());
                    break;
                case 4:
                    Bai4 bai4 = new Bai4();
                    Console.WriteLine("Tinh Xe");
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine("Ten Xe"+i);
                        string name = Console.ReadLine();
                        bai4.SetName(name);
                       
                        Console.WriteLine("Loai Xe"+i);
                        string type = Console.ReadLine();
                        bai4.SetType(type);

                        Console.WriteLine("Dung Tich Xe:" + i);
                        int dungtich = Convert.ToInt32(Console.ReadLine());
                        bai4.SetDungTich(dungtich);
                       
                        Console.WriteLine("Gia  Xe:" + i);
                        double gia = Convert.ToDouble(Console.ReadLine());
                        bai4.SetPrice(gia);
                        Console.WriteLine("Thue xe "    + bai4.Vat());
                        Console.WriteLine(bai4.GetName() + "\t" + bai4.GetType() + "\t" + bai4.GetDungTich() + "\t" + bai4.GetPrice() + "\t" + bai4.Vat());
                    }
                    break; 
                case 5:
                    Bai5 bai5 = new Bai5();
                    Console.WriteLine("Kho Hang");


                    Console.WriteLine("Ma Hang");
                    int mahnag=Convert.ToInt32(Console.ReadLine());
                    bai5.setMaHang(mahnag);
                    Console.WriteLine("Ma Hang" + bai5.getMahang());



                    Console.WriteLine("Ten Hang");
                    string ten = Console.ReadLine();
                    bai5.setTenHang(ten);
                 
                    Console.WriteLine(bai5.getTenHang());


                  
                
                    Console.WriteLine("Gia Hang");
                    double giahang = Convert.ToDouble(Console.ReadLine());
                    bai5.setDonGia(giahang);
                    Console.WriteLine(bai5.getDonGia());



                    Console.Write("Ngay san xuat :");
                    DateTime nsx=Convert.ToDateTime(Console.ReadLine());
                    bai5.setNSX(nsx);
                    Console.WriteLine("NgaySanXuat" + bai5.getNSX());

                


                    Console.WriteLine("NHH");
                 
                    DateTime nghh = Convert.ToDateTime(Console.ReadLine());
                    bai5.setNHH(nghh);
                    Console.WriteLine(bai5.getNHH());
                    bai5.setGhiChu("");
                    Console.WriteLine("Ghi Chu:"+ bai5.getGhiChu());
                    break;

                case 6:


                    break;
             
            }
            Console.ReadLine();
            //bai 3
            //Bai3 bai3 = new Bai3(201000,"Thuan",11,8);
            // //Bai3 bai3 = new Bai3();
            // //bai3.setHoten("Thuan");
            // Console.WriteLine(Convert.ToString(bai3.MSSV)+bai3.HoTen+bai3.DiemTH+bai3.DiemLT) ;
            // Console.WriteLine("Diem TB : " + bai3.DiemTB());
            // Console.WriteLine("Nhap Thong Tin Sinh Vien 03 :");
            // Console.WriteLine()
            // Console.ReadLine();
        }
    }
}
