using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS
{
    public class RestaurantBill
    {
        public decimal[] prices { get; set; }
        public decimal CalculateTotal(decimal[] prices)
        {
            decimal total = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                total += prices[i];
            }

        }
    }
}
