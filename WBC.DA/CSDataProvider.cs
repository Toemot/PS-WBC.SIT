using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBC.DA.Model;

namespace WBC.DA
{
    public class CSDataProvider
    {
        public IEnumerable<CoffeeS> LoadCoffeeShop()
        {
            yield return new CoffeeS { Location = "CapeTown", BeansInStockInKg = 107 };
            yield return new CoffeeS { Location = "Joburg", BeansInStockInKg = 23 };
            yield return new CoffeeS { Location = "Pretoria", BeansInStockInKg = 56 };
        }
    }
}
