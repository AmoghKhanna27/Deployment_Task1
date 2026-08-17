using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingLogic
{
    public class PricingClassifier
    {
        public string Categorize(decimal price)
        {
            if (price < 0)
            {
                return "Invalid Price";
            }
            else if (price <= 50)
            {
                return "Cheap";
            }
            else
            {
                return "Expensive";
            }
        }
    }
}
