﻿using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IRentalService
	{
        IResult Add(Car car, int customerId);

    }
}

