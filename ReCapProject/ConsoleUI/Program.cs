
using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carMenager = new CarManager(new InMemoryCarDal());

foreach (var car in carMenager.GetAll())
{
    Console.WriteLine(car.Description);
}

Console.ReadKey();