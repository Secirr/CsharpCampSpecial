using System;
using Entities.InterfaceAbstractDemo;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {

        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }


        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
                Console.WriteLine(customer.FirstName + " kişisinin kimlik doğrulaması yapıldı");
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }
    }
}

