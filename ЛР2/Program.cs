using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Парацетомол = new Product("Парацетомол 500мг", 50.0);
            Product Шприцы = new Product("Шприцы 2мл", 10.0);
            Product Антибиотики = new Product("Антибиотики 300мг", 25.0);
            Product Противовирусные = new Product("Противовирусные 300мг", 55.0);
            Product Спазмолитики = new Product("Спазмолитики 400мг", 34.0);

            SalesHistory history = new SalesHistory();

            Запись_о_продаже sale1 = new Запись_о_продаже { День_продажи = 1, Количество = 10, Товар = Парацетомол };
            Запись_о_продаже sale2 = new Запись_о_продаже { День_продажи = 1, Количество = 20, Товар = Шприцы };
            Запись_о_продаже sale3 = new Запись_о_продаже { День_продажи = 2, Количество = 5, Товар = Противовирусные };
            Запись_о_продаже sale4 = new Запись_о_продаже { День_продажи = 2, Количество = 15, Товар = Антибиотики };
            Запись_о_продаже sale5 = new Запись_о_продаже { День_продажи = 3, Количество = 25, Товар = Спазмолитики };

            history.AddSale(Аптека.Парацетомол, sale1);
            history.AddSale(Аптека.Шприцы, sale2);
            history.AddSale(Аптека.Противовирусные, sale3);
            history.AddSale(Аптека.Антибиотики, sale4);
            history.AddSale(Аптека.Спазмолитики, sale5);

            double RP = history.GetTotalQuantityByGroup(Аптека.Парацетомол);
            double Rs = history.GetTotalQuantityByGroup(Аптека.Шприцы);
            double Rd = history.GetTotalQuantityByGroup(Аптека.Противовирусные);
            double Rr = history.GetTotalQuantityByGroup(Аптека.Антибиотики);
            double Rp = history.GetTotalQuantityByGroup(Аптека.Спазмолитики);

            history.PrintSalesSummary();

            Console.WriteLine($"Общая выручка от парацетомола: {RP}");
            Console.WriteLine($"Общая выручка от шприцов: {Rs}");
            Console.WriteLine($"Общая выручка от противовирусных: {Rd}");
            Console.WriteLine($"Общая выручка от антибиотиков: {Rr}");
            Console.WriteLine($"Общая выручка от спазмолитиков: {Rp}");
        }
    }
}
