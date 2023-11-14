using ClassMetotDemo;
using deneme;

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.FirstName = "Atilla";
customer1.LastName = "Akın";

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.FirstName = "Kadir";
customer2.LastName = "Özdemir";

Customer customer3 = new Customer();
customer3.Id = 3;
customer3.FirstName = "Fatih";
customer3.LastName = "Sevencan";



List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

CustomerManager customerManager = new CustomerManager();
foreach (var item in customers)
{
    customerManager.Add(item);
}

foreach (var item in customers)
{
    customerManager.List(item);
}

foreach (var item in customers)
{
    customerManager.Delete(item);
}





Console.ReadKey();

