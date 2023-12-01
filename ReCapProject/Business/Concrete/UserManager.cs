using System;
using System.Drawing;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {

        IUserDal _userdal;

        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
        }

        public IResult Add(User user)
        {
            _userdal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _userdal.Delete(user);
            return new SuccessResult();
        }

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult();
        }

        public IDataResult<User> Get(int id)
        {
            return new SuccesDataResult<User>(_userdal.Get(u=> u.Id == id));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccesDataResult<List<User>>(_userdal.GetAll());
        }

        
    }
}

