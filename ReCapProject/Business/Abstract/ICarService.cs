using System;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{

	//Data Dönen değerlerde IDataResult
	//Data Dönmeyen yerlerde(void) IResult
	public interface ICarService
	{
		IDataResult<List<Car>> GetAll(); //Liste = Liste olarak data döner bir data dönüşü var yani IDataResult

		IDataResult<List<CarDetailDto>> GetCarDetailDtos(); //İstenilen Joinleri ile verileri Liste olarak içeren tablonun metodu

		IDataResult<Car> Get(int id);  //Car türünde veri dönüyor yani IDataResult

        IDataResult<List<Car>> GetCarsByBrandId(int id); //Car türünde veri dönüyor yani IDataResult

        IDataResult<List<Car>> GetCarsByColorId(int id); //Car türünde veri dönüyor yani IDataResult

        IResult Add(Car car); //Bir değer döndürmeyen metot yani void, bu durumda sadece succes controlü yapılabilir bu yüzden IResult

        IResult Delete(Car car); //Bir değer döndürmeyen metot yani void, bu durumda sadece succes controlü yapılabilir bu yüzden IResult

        IResult Update(Car car); //Bir değer döndürmeyen metot yani void, bu durumda sadece succes controlü yapılabilir bu yüzden IResult

    }
}

