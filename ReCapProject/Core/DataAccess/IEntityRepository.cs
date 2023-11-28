using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{

    //Generic Constract
    //Class : Referans tip olabilir
    //IEntity : IEntity ya da onu implemente eden bir nesne olabilir.
	public interface IEntityRepository<T> where T:class, IEntity, new() //Referans tip olabilir(class), IEntity imzasını taşımalı. Newlenebilir( yani interface kullanamaz)
	{
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Expression Linq sorguları ile filtre yapabilmemizi sağlar.

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}

