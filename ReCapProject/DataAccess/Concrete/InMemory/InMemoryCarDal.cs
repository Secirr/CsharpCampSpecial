using System;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1,BrandId = 1,ColorId = 1,ModelYear = new DateTime(2020),DailyPrice = 200000,Description = "Brand And Model Informations"},
                new Car{Id = 2,BrandId = 2,ColorId = 2,ModelYear = new DateTime(2023),DailyPrice = 250000,Description = "Brand And Model Informations"},
                new Car{Id = 3,BrandId = 1,ColorId = 1,ModelYear = new DateTime(2015),DailyPrice = 100000,Description = "Brand And Model Informations"}               
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id); //Referansı tutmak

            CarToUpdate.BrandId = car.BrandId;  //Bilgileri referansa göre tek tek güncellemek
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;


            

      

        }

        public void Delete(int id)
        {
            
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == id);
            _cars.Remove(CarToDelete);
        }
    }
}

