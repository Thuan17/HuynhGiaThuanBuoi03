using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhGiaThuan

{
    public class Bai1
    {
        public  string carColor;
         public double carPrice;


        public void setColor(string carColor)
        {
            this.carColor = carColor;
        }
        public string getcarColor()
        {
            return carColor;
        }

        public void setGia(double carPrice)
        {
            this.carPrice = carPrice;
        }
        public double getGia()
        {
            return carPrice;
        }



    }
}
