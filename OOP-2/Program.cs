using OOP_2;

Individual customer1 = new Individual();
customer1.Id = 1;
customer1.IdentityNo = "135325624";
customer1.CustomerNo = "153326";
customer1.Name = "Kadir";
customer1.Surname = "Özdemir";

Corporate customer2 = new Corporate();
customer2.Id = 2;
customer2.CustomerNo = "32424";
customer2.TaxNo = "23523";
customer2.CompanyName = "Felice LTD";

//Customer Classı Individual ve Corporate classlarının referansını tutabilir.
//Çünkü Individual ve Corporate classları Customer classını inheritance alıyor.
Customer customer3 = new Individual();
Customer customer4 = new Corporate();



CustomerManager customerManager = new CustomerManager();
//Customer parametresinde Individual ya da Corporate referanslarını da kullanabilirim.
//Çünkü Individual ve Corporate classları Customer classını inheritance alıyor.
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);

Console.ReadKey();