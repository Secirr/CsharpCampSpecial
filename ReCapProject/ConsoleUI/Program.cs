
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

var result = carManager.GetCarsByBrandId(2);
Console.WriteLine(result.Name);

//foreach (var car in carManager.GetCarsByBrandId())
//{
//    Console.WriteLine(car.Name);
//}

Console.ReadKey();