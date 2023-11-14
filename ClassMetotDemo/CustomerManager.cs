using System;
namespace ClassMetotDemo
{
	public class CustomerManager : ICustomerService
	{
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + customer.LastName + " Eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + customer.LastName + " Listelendi.");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.FirstName + customer.LastName + " Silindi.");
        }
    }
}

