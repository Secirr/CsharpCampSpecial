﻿using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{

        IDataResult<List<User>> GetAll();

        IDataResult<User> Get(int id);

        IResult Add(User user);

        IResult Delete(User user);

        IResult Update(User user);

    }
}

