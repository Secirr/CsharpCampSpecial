using System;
using System.Security.Claims;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

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

        public IResult Add(CarRentalDto carRentalDto) //kullanıcıdan car tipinde bir parametre ve bir int değerinde Id istiyoruz.
        {

            var controlCarTable = _carService.Get(carRentalDto.CarId);

            if (controlCarTable == null) // IsAvailable true ve car tablosunda araç yok ise
            {
                return new ErrorDataResult<Rental>("Car is not found"); //bu durumda hata mesajını döndürüyoruz. 
            }

            var car = controlCarTable.Data;

            if (car.IsAvailable == true)
            {
                return new ErrorDataResult<Rental>(Messages.CarNotAvailable); //bu durumda hata mesajını döndürüyoruz. 
            }

            var rental = new Rental() //eğer if e girmezse Rental türünde bir rental nesnesi oluşturuyoruz.
            {
                //oluşturduğumuz nesnenin
                CarId = carRentalDto.CarId,                 //CarId'si carRentalDto nesnesinin Id'sidir.
                CustomerId = carRentalDto.CustomerId,        //CustomerId'si carRentalDto'dan gelen customerId'dir.
                RentDate = DateTime.Now,        //RentDate'i Şuanki güncel bilgisayar saatimizdir.
                ReturnDate = null,              //ReturnDate'i Null'dır.
            };
            _rentalDal.Add(rental);     //oluşturduğumuz nesneyi Veritabanımıza ekliyoruz.

            car.IsAvailable = true;
            
            _carService.Update(car);

            return new SuccessResult(Messages.CarAdded); //Araba eklendiği senaryoda "car is Added" Mesajını döndürüyoruz.
           

        }


        public IDataResult<List<Rental>> GetAll()
        {
                return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll());
        }
    }

}
