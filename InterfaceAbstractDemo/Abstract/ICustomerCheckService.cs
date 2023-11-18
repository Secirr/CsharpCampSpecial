using System;
using Entities.InterfaceAbstractDemo;

namespace InterfaceAbstractDemo.Abstract
{
	public interface ICustomerCheckService
	{
        bool CheckIfRealPerson(Customer customer);
    }
}

