﻿using System;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
	public class CustomerManager : ICustomerService
	{

        ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
            _customerDal = customerDal;
        }


        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IDataResult<Customer> Get(int id)
        {
            return new SuccesDataResult<Customer>(_customerDal.Get(c => c.CustomerId == id));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccesDataResult<List<Customer>>(_customerDal.GetAll());
        }

        
    }
}

