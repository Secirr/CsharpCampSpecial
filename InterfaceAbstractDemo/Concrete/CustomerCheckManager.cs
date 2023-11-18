using System;
using Entities.InterfaceAbstractDemo;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Concrete
{
	public class CustomerCheckManager : ICustomerCheckService
	{
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

