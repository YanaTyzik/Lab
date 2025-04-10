using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product(string Name, double Price)
        {
           this.Name = Name;
           this.Price = Price;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }
    }
}
