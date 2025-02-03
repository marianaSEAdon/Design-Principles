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
        public decimal CalculateTotal(decimal[] prices, decimal? propina)
        {
            decimal total = prices.Sum();

            if (propina.HasValue)
            {
                total = total * (propina.Value / 100);
            }
            else
            {
                total = total * 0.10m;
            }

            return total;
        }



    }
 
    


}
