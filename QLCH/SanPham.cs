using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH
{
    public class SanPham
    {
        private string id;
        private string name;
        private int price;

        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
    }
}
