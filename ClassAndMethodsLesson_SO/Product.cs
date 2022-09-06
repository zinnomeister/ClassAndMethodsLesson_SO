using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsLesson_SO
{
    public enum ProductType{ Food, Alco}
    public class Product
    {
        public string ProductName { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public ProductType Type { get; set; }
             
    }
}
