using System;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();

		List<CarDetailDto> GetCarDetailDtos(); //İstenilen Joinleri ile verileri Liste olarak içeren tablonun metodu

		Car Get(int id);

		Car GetCarsByBrandId(int id);

		Car GetCarsByColorId(int id);

		void Add(Car car);

		void Delete(Car car);

		void Update(Car car);
    }
}

