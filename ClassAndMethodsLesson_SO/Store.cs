using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsLesson_SO
{
    public class Store
    {
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public List<Customer> RegisteredCustomers { get; set; } = new List<Customer>();
        public List<Product> AvailableProducts { get; set; } = new List<Product>();

        public bool CheckCustomer(Customer someCustomer)
        {
            if (RegisteredCustomers.Contains(someCustomer))
                return true;
            else
                return false;
        }

        public void RegisterCustomer(Customer someCustomer)
        {
            RegisteredCustomers.Add(someCustomer);
        }

        public void GiveDiscount()
        {

        }
    }
}
