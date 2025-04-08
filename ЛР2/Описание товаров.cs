using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Описание_товаров
    {
        private string Name { get; set; }
        private double price { get; set; }


        public Описание_товаров(string Название, double Цена)
        {
           Название = Name;
           Цена = price;
        }
        public string SayName()
        {
            return Name;
        }
        public double SayPrice()
        {
            return price;
        }
    }
}
