﻿using System;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails(); //joinlediğimiz tabloların metodu
    }
}

