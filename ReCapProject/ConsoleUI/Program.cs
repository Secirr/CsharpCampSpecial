using System.Collections.Generic;
using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


//  --- Manager news ---
ICarService carManager = new CarManager(new EfCarDal());
IUserService userManager = new UserManager(new EfUserDal());
ICustomerService customerManager = new CustomerManager(new EfCustomerDal());
IRentalService rentalManager = new RentalManager(new EfRentalDal(), carManager);

var car = carManager.Get(5); //Burada verilen id ye göre araç tablosundan bir araç getirilir.
var item = rentalManager.Add(car.Data, 4); //bir item nesnesi oluşturulur ve rentalMAnager ile arabanın kiralanabilirlik durumu incelenerek
                                           //Kiralanabilir olup olmadığının datası gelir. 
Console.WriteLine(item.Message);           

//New Data for Car Table
//Car audi = new Car { Id = 11, BrandId = 4, ColorId = 2, Name = "Q7", DailyPrice = 3000 };
//Car mercedes = new Car { Id = 12, BrandId = 3, ColorId = 9, Name = "C200", DailyPrice = 2000 };
//Car peugeot = new Car { Id = 13, BrandId = 6, ColorId = 3, Name = "206", DailyPrice = 500 };

//New Data for User Table
//User kadir = new User { Id = 1, FirstName = "Kadir", LastName = "Özdemir", Email = "kadirozdemirr00@gmail.com", Password = "kadir123" };
//User sevim = new User { Id = 2, FirstName = "Sevim", LastName = "Erünsal", Email = "sevim123@gmail.com", Password = "sevim123" };
//User seval = new User { Id = 3, FirstName = "seval", LastName = "Özakoğlu", Email = "seval123@gmail.com", Password = "seval123" };
//User minasu = new User { Id = 4, FirstName = "Minasu", LastName = "Akın", Email = "minasu123@gmail.com", Password = "minasu123" };
//User atilla = new User { Id = 5, FirstName = "Metin Atilla", LastName = "Akın", Email = "metinatilla123@gmail.com", Password = "atilla123" };
//User atakan = new User { Id = 6, FirstName = "Mustafa Atakan", LastName = "Akın", Email = "mustafaatakan123@gmail.com", Password = "atakan123" };

//New Data for Customer Table
//Customer lm = new Customer { CustomerId = 6 , UserId = 6, CompanyName = "Leyla ile mecnun dizi seti"};

//UserManager Event Test to Add
//userManager.Add(kadir);
//userManager.Add(sevim);
//userManager.Add(seval);
//userManager.Add(minasu);
//userManager.Add(atilla);
//userManager.Add(atakan);

//UserManager Event Test to GetAll
//foreach (var user in userManager.GetAll().Data)
//{
//    Console.WriteLine(user.FirstName + user.LastName);
//}


//customerManager Event Test to Add
//customerManager.Add(lm);

//customerManager Event Test to GetAll
//foreach (var customer in customerManager.GetAll().Data)
//{
//    Console.WriteLine(customer.CustomerId);
//}


//CarManager Event Test to Add
//carManager.Add(audi);
//carManager.Add(mercedes);
//carManager.Add(peugeot);

//CarManager Event Test to Delete
//carManager.Delete(audi);
//carManager.Delete(mercedes);
//carManager.Delete(peugeot);

//CarManager Event Test to GetAll
//foreach (var car in carManager.GetAll().Data)
//{
//    Console.WriteLine(car.Name);
//}



//CarManager Event Test to update
//int carIdToUpdate = 13;

//Car carToUpdate = new Car
//{
//    Id = carIdToUpdate,
//    BrandId = 2,
//    ColorId = 5,
//    Name = "M8",
//    DailyPrice = 4500
//};

//using (ReCapDemoContext context = new ReCapDemoContext())
//{
//    int carIdToUpdate = 4; //Audi ----> Bmw
//    var carToUpdate = context.Cars.Find(carIdToUpdate);

//    if (carToUpdate != null)
//    {
//        carToUpdate.Id = 2;
//        carToUpdate.Name = "M7";
//        carToUpdate.BrandId = 2;
//        carToUpdate.ColorId = 7;
//        carToUpdate.DailyPrice = 3000;
//        carToUpdate.Description = "BMW is Faster car";
//        carManager.Update(carToUpdate);
//    }
//    else
//    {
//        Console.WriteLine("The match failed!");
//    }
//}


//carManager.Update(carToUpdate);



//Listing the GetCarDetailDtos methot in console
//foreach (var car in carManager.GetCarDetailDtos().Data)
//{
//    Console.WriteLine(car.BrandName + " " +
//    car.CarName + " " +
//    car.ColorName + " " +
//    "DailyPrice: " + car.DailyPrice);
//}



Console.ReadKey();