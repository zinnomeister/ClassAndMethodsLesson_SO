namespace ClassAndMethodsLesson_SO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Dmytro";
            customer.TelNumber = "123344535345";
            customer.Sex = "Male";
            customer.Age = 16;

            Store silpo = new Store();
            silpo.StoreName = "Silpo inc.";
            silpo.StoreAddress = "Kiev, kitaevskaya 11 st.";
            silpo.AvailableProducts = new List<Product>();

            silpo.AvailableProducts.Add(new Product()
            {
                ProductName = "Sugar",
                Type = ProductType.Food,
                ProductionDate = new DateTime(2022, 5, 1),
                ExpiryDate = new DateTime(2022, 10, 1)
            });

            silpo.AvailableProducts.Add(new Product()
            {
                ProductName = "Milk",
                Type = ProductType.Food,
                ProductionDate = new DateTime(2022, 9, 1),
                ExpiryDate = new DateTime(2022, 9, 10)
            });

            silpo.AvailableProducts.Add(new Product()
            {
                ProductName = "Vodka",
                Type = ProductType.Alco,
                ProductionDate = new DateTime(2022, 9, 1),
                ExpiryDate = new DateTime(2022, 9, 5)
            });


            bool isRegisteredCustomer = silpo.CheckCustomer(customer);
            if (isRegisteredCustomer == false)
                silpo.RegisterCustomer(customer);

            customer.GoToTheStore(silpo);

            Product product = new Product();
            product.ProductName = "Sugar";
            customer.BuySomething(product);

            customer.Exit();

            Console.ReadKey();
        }
    }
}