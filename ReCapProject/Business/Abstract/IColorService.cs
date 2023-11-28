﻿using System;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IColorService
	{

        List<Color> GetAll();

        Color Get(int id);

        void Add(Color color);

        void Delete(Color color);

        void Update(Color color);

    }
}

