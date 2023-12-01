using System.Drawing;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Color = Entities.Concrete.Color;

namespace Business.Concrete
{
	public class ColorManager : IColorService
	{

        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }

        public IDataResult<Color> Get(int id)
        {
            return new SuccesDataResult<Color>(_colorDal.Get(cr => cr.Id == id));
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccesDataResult<List<Color>>(_colorDal.GetAll());
        }

       
    }
}

