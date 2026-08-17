using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceFormatter
{
    public class CurrencyFormatter
    {
            public string FormatPrice(decimal price)
            {
                return "$" + price.ToString("0.00");
            }
        
    }
}
