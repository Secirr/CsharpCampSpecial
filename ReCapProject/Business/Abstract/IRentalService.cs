using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IRentalService
	{
        IResult Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
    }
}

