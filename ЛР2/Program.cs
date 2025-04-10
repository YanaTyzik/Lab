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

            SalesHistory history = new SalesHistory();

            Запись_о_продаже sale1 = new Запись_о_продаже { День_продажи = 1, Количество = 10, Товар = Парацетомол };
            Запись_о_продаже sale2 = new Запись_о_продаже { День_продажи = 1, Количество = 20, Товар = Шприцы };
            Запись_о_продаже sale3 = new Запись_о_продаже { День_продажи = 2, Количество = 5, Товар = Парацетомол };
            Запись_о_продаже sale4 = new Запись_о_продаже { День_продажи = 2, Количество = 15, Товар = Антибиотики };

            history.AddSale(Аптека.Парацетомол, sale1);
            history.AddSale(Аптека.Шприцы, sale2);
            history.AddSale(Аптека.Парацетомол, sale3);
            history.AddSale(Аптека.Антибиотики, sale4);

            int totalParacetomol = history.GetTotalQuantityByGroup(Аптека.Парацетомол);
            int totalSyringes = history.GetTotalQuantityByGroup(Аптека.Шприцы);
            int totalAntibiotics = history.GetTotalQuantityByGroup(Аптека.Антибиотики);

            Console.WriteLine($"Всего продано парацетомола: {totalParacetomol}");
            Console.WriteLine($"Всего продано шприцов: {totalSyringes}");
            Console.WriteLine($"Всего продано антибиотиков: {totalAntibiotics}");
        }
    }
}
