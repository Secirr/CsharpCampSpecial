using System;
using System.Security.Claims;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
	public class RentalManager : IRentalService
	{
        IRentalDal _rentalDal; //injection

        ICarService _carService; //injection

        public RentalManager(IRentalDal rentalDal, ICarService carService) 
        {
            _rentalDal = rentalDal; 
            _carService = carService; 
        }

        public IResult Add(Car car, int customerId) //kullanıcıdan car tipinde bir parametre ve bir int değerinde Id istiyoruz.
        {
            if (car.IsAvailable == false || car.IsAvailable == null) //IsAvailable false ya da IsAvailable Null ise araba kiralanamaz.
            {
                return new ErrorDataResult<Rental>(Messages.CarNotAvailable); //bu durumda hata mesajını döndürüyoruz. 
            }
            
            var rental = new Rental() //eğer if e girmezse Rental türünde bir rental nesnesi oluşturuyoruz.
            {
                                                //oluşturduğumuz nesnenin
                CarId = car.Id,                 //CarId'si Car nesnesinin Id'sidir.
                CustomerId = customerId,        //CustomerId'si parametreden gelen customerId'dir.
                RentDate = DateTime.Now,        //RentDate'i Şuanki güncel bilgisayar saatimizdir.
                ReturnDate = null,              //ReturnDate'i Null'dır.
            };
            _rentalDal.Add(rental);     //oluşturduğumuz nesneyi Veritabanımızı ekliyoruz.

            car.IsAvailable = false; //Araba nesnesinin Kiralanabilir durumu false ise
           
            _carService.Update(car); //Update Metodu 
            return new SuccessResult(Messages.CarAdded); //Araba eklendiği senaryoda "car is Added" Mesajını döndürüyoruz.
            
        }


       
    }
}

