using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsLesson_SO
{
    public class Customer
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string TelNumber { get; set; }
        public List<Product> PurchasedProducts { get; set; } = new List<Product>();
        public Store CurrentStore { get; set; }

        public void GoToTheStore(Store store)
        {
            CurrentStore = store;
        }

        public void BuySomething(Product product)
        {
            Product existingProduct = CurrentStore.
                AvailableProducts.Find(r => r.ProductName == product.ProductName);

            if (existingProduct.Type == ProductType.Alco && Age < 21)
            {
                Console.WriteLine("Go home!");
                return;
            }

            if (existingProduct != null)
            {
                if (existingProduct.ExpiryDate > DateTime.Now)
                {
                    Console.WriteLine("Product out of date");
                    return;
                }
                PurchasedProducts.Add(product);
            }
        }

        public void Exit()
        {
            Console.WriteLine(PurchasedProducts.Count);
        }
    }
}
