using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Product
    {
        private int pid;
        private string pname;
        private double price,disPrice;
        public Product(int id,string name,double p)
        {
            pid = id;
            pname = name;
            price = p;
        }
        public void DiscountedPrice(double dis)
        {
            if (price > 1000)
            {
                disPrice = price * 0.10;
                price -= disPrice;
            }
        }
        public string Print()
        {
            return $"Id={pid}, Name={pname}, Discount Price={disPrice}, Total Price={price}";
        }
    }
}
