using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class SalesHistory
    {
        private Dictionary<Аптека, List<Запись_о_продаже>> SalesDictionary = new Dictionary<Аптека, List<Запись_о_продаже>>();
        public Dictionary<Аптека, List<Запись_о_продаже>> GetSalesDictionary()
        {
            return SalesDictionary;
        }

        public void AddSale(Аптека group, Запись_о_продаже запись_О_Продаже)
        {
            if (!SalesDictionary.ContainsKey(group))
            {
                SalesDictionary.Add(group, new List<Запись_о_продаже>());
                SalesDictionary[group].Add(запись_О_Продаже);
            }

        }

        public int GetTotalQuantityByGroup(Аптека group)
        {
            int total = 0;
            if (SalesDictionary.ContainsKey(group))
            {
                foreach (var запись_О_Продаже in SalesDictionary[group])
                {
                    total += запись_О_Продаже.Количество;
                }
                return total;
            }
            else
            {
                return 0;
            }

        }
        public void PrintSalesSummary()
        {
            foreach (var groupSales in SalesDictionary)
            {
                Аптека group = groupSales.Key;
                List<Запись_о_продаже> salesList = groupSales.Value;

                Console.WriteLine($"Группа товаров: {group}");

                foreach (var sale in salesList)
                {
                    Console.WriteLine($"В {sale.День_продажи} день было продано товара {sale.Товар.Name} в кол-ве {sale.Количество}");
                }
            }

        }


    }


}
