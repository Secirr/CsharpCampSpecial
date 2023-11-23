using System;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();

		Car GetCarsByBrandId(int id);

		Car GetCarsByColorId(int id);

		void Add(Car car);
    }
}

