using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Book
    {
        private int bid;
        private string bname,author;
        private double price;
        public Book(int id, string name, string auth, double p)
        {
            bid = id;
            bname = name;
            author = auth;
            price = p;
        }
        public string Print()
        {
            return $"Id:{bid}, Name:{bname}, Author:{author}, Price:{price}";
        }
    }
}
