﻿using System.Drawing;
using Business.Abstract;
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

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }

        public Color Get(int id)
        {
            return _colorDal.Get(cr => cr.Id == id);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

       
    }
}

