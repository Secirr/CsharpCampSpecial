using System;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface ICarDal
	{

		List<Car> GetAll();

		Car GetById(int Id);

        void Add(Car car);

		void Update(Car car);

		void Delete(int id);


    }
}

