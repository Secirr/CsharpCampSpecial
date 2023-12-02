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

        public RentalManager(IRentalDal rentalDal) 
        {
            _rentalDal = rentalDal; 
        }

        public IResult Add(Rental rental) 
        {
            var result = _rentalDal.Get(r => r.ReturnDate == null && r.CarId == rental.CarId);
            
            if (result != null)
            {
                return new ErrorResult(Messages.CarNotAvailable); //Araba eklenmediği senaryoda "car is not Added" Mesajını döndürüyoruz.
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarAdded); //Araba eklendiği senaryoda "car is Added" Mesajını döndürüyoruz.

        }


        public IDataResult<List<Rental>> GetAll()
        {
            var result = _rentalDal.GetAll();
            return new SuccesDataResult<List<Rental>>(result);
        }
    }
}

