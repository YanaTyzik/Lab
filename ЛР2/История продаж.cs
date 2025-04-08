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

        public void ДобавитьПродажу(Аптека тип, Запись_о_продаже запись)
        {
            if (!продажи.ContainsKey(тип))
                продажи[тип] = new List<Запись_о_продаже>();

            продажи[тип].Add(запись);
        }

        public List<Запись_о_продаже> ПолучитьПродажи(Аптека тип) =>
            продажи.ContainsKey(тип) ? продажи[тип] : new List<Запись_о_продаже>();

        public decimal ПолучитьСуммуПоКатегории(Аптека тип) =>
            ПолучитьПродажи(тип).Sum(продажа => продажа.ПолучитьСумму());
    }
}
}
