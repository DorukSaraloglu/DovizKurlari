using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKurlari
{
    class Currency
    {
        public int Unit { get; set; }
        public string CurrencyName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }

        public override string ToString()
        {
            return CurrencyName + " " + Unit;
        }
    }
}
