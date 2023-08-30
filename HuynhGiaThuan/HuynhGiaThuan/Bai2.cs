using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhGiaThuan
{
     class Bai2
    {
        public int x, y;
        public string nameX; 
        public void setX(int x)
        { this.x = x; }
        public void setY(int y) 
        {  this.y = y; }
        public void setNameX(string namex) { this.nameX = namex; }
      

        public int getX() { return this.x; }
        public int getY() { return this.y; }
        public string getNameX() { return this.nameX; }
       


    }
}
