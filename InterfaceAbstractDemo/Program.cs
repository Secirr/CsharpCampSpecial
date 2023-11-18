using Entities.InterfaceAbstractDemo;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;


//Kimlik doğrulamasız program
BaseCustomerManager customerManagerNero = new NeroCustomerManager();

//Kimlik doğrulamalı program
ICustomerCheckService customerCheck = new CustomerCheckManager();
BaseCustomerManager customerManagerStar = new StarbucksCustomerManager(customerCheck);


Customer customer1 = new Customer();
DateTime dateTime1 = new DateTime(2000, 5, 12);
customer1.Id = 1;
customer1.FirstName = "Kadir";
customer1.LastName = "Özdemir";
customer1.DateOfBirth = dateTime1;
customer1.NationalityId = "23455365753";

Customer customer2 = new Customer();
DateTime dateTime2 = new DateTime(1994, 6, 14);
customer2.Id = 2;
customer2.FirstName = "Engin";
customer2.LastName = "Demiroğ";
customer2.DateOfBirth = dateTime2;
customer2.NationalityId = "23453565753";


customerManagerNero.Save(customer1);
customerManagerStar.Save(customer2);

Console.ReadKey();
