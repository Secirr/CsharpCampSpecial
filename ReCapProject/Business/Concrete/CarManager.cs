using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _cardal; //injection

        public CarManager(ICarDal carDal)
        {
            _cardal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Name.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            else if (car.DailyPrice <= 0)
            {
                return new ErrorResult(Messages.DailyPriceError);
            }

            _cardal.Add(car);

            return new SuccessResult(Messages.CarAdded);
           
        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);
            return new SuccessResult();
        }

        public IResult Update(Car car)
        {
            _cardal.Update(car);
            return new SuccessResult();
        }
       
        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_cardal.GetCarDetails(), Messages.CarList); //Bu metotta 3 tablonun joinleri ile istenilen veriler çekilmiştir(Cars,Brands,Colors) 
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            var result = _cardal.GetAll(c => c.BrandId == id);
            return new SuccesDataResult<List<Car>>(result);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccesDataResult<List<Car>>(_cardal.GetAll(c=> c.ColorId == id));
        }

        public IDataResult<Car> Get(int id)
        {
            return new SuccesDataResult<Car>(_cardal.Get(c=> c.Id == id));
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccesDataResult<List<Car>>(_cardal.GetAll(), Messages.CarList);
        }

    }
}

