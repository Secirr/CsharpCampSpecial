using System;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IBrandService
	{

        List<Brand> GetAll();

        Brand Get(int id);

        void Add(Brand brand);

        void Delete(Brand brand);

        void Update(Brand brand);
    }
}


