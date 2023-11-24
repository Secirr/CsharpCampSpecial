using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _cardal; //injection

        public CarManager(ICarDal carDal)
        {
            _cardal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Name.Length > 2 && car.DailyPrice > 0)
            {
                _cardal.Add(car);
            }
            else
            {
                throw new DuplicateWaitObjectException("the product could not be added because it did not meet the requirements");
            }
           
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public Car GetCarsByBrandId(int id)
        {
            return _cardal.Get(c=> c.BrandId == id);
        }

        public Car GetCarsByColorId(int id)
        {
            return _cardal.Get(c => c.ColorId == id);
        }
    }
}

