using System;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IRentalService
	{
        IDataResult<List<Rental>> GetAll();

        IResult Add(CarRentalDto carRentalDto);

   
    }
}

