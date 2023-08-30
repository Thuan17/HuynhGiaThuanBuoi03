using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhGiaThuan
{
    class Bai4
    {
        public string NameVehicle, TypeVehicle;
        public int DungTich;
        public double PriceVehicle;
        public void SetName(string nameve)
        { this.NameVehicle = nameve; }
        public void SetType(string type) { this.TypeVehicle = type; }
        public void SetDungTich(int dungTich) { this.DungTich = dungTich; }
        public void SetPrice(double Price) { this.PriceVehicle = Price; }


        public string GetName() { return NameVehicle;}
        public string GetType() { return TypeVehicle; }
        public int GetDungTich() {  return DungTich;}
        public double GetPrice() { return PriceVehicle; }


        public void check()
        {
            if (PriceVehicle <= 0)
            {
                this.PriceVehicle = 0;
            }
            else if (DungTich <= 0)
            {
                this.DungTich = 0;
            }
        }
        public double Vat() 
        {
            double VAT;
            check();
            if (DungTich <= 100)
            {
                VAT= PriceVehicle * 0.01;
            }
            else if (DungTich > 100 && DungTich < 200)
            {
                VAT = PriceVehicle * 0.03;
            }
            else
            {
                VAT = PriceVehicle * 0.05;
            }
            return VAT;

        }

    }
}
