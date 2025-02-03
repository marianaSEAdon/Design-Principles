using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGNI
{
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Product {name} added with price {price}.");
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine($"Product{productId} deleted");
        }
    }
}
