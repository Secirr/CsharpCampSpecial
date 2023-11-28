using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


//  --- CarManager Event Tests ---
CarManager carManager = new CarManager(new EfCarDal());

//Car audi = new Car { Id = 11, BrandId = 4, ColorId = 2, Name = "Q7", DailyPrice = 3000 };
//Car mercedes= new Car { Id = 12, BrandId = 3, ColorId = 9, Name = "C200" , DailyPrice = 2000};
//Car peugeot = new Car { Id = 13, BrandId = 6, ColorId = 3, Name = "206" , DailyPrice = 500};

//carManager.Add(audi);
//carManager.Add(mercedes);
//carManager.Add(peugeot);

//carManager.Delete(audi);
//carManager.Delete(mercedes);
//carManager.Delete(peugeot);

//int carIdToUpdate = 13;

//Car carToUpdate = new Car
//{
//    Id = carIdToUpdate,
//    BrandId = 2,
//    ColorId = 5,
//    Name = "M8",
//    DailyPrice = 4500
//};

//carManager.Update(carToUpdate);


//List<Car> allCars = carManager.GetAll();

//foreach (var item in allCars)
//{
//    Console.WriteLine(item.Name);
//}




using (ReCapDemoContext context = new ReCapDemoContext())
{
    int carIdToUpdate = 4; //Audi ----> Bmw
    var carToUpdate = context.Cars.Find(carIdToUpdate);

    if (carToUpdate != null)
    {
        carToUpdate.Id = 2;
        carToUpdate.Name = "M7";
        carToUpdate.BrandId = 2;
        carToUpdate.ColorId = 7;
        carToUpdate.DailyPrice = 3000;
        carToUpdate.Description = "BMW is Faster car";
        carManager.Update(carToUpdate);
    }
    else
    {
        Console.WriteLine("The match failed!");
    }
}


foreach (var car in carManager.GetCarDetailDtos())
{
    Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + " DailyPrice: " + car.DailyPrice);
}



Console.ReadKey();