using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal struct Запись_о_продаже
    {
        public int Количество;
        public int День_продажи { get; set; }
        public Описание_товаров Товар;
    }
        
}
