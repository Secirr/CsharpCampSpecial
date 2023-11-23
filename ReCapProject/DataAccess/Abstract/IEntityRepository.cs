using System;
using System.Linq.Expressions;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{

    //Generic Constract
    //Class : Referans tip olabilir
    //IEntity : IEntity ya da onu implemente eden bir nesne olabilir.
	public interface IEntityRepository<T> where T:class, IEntity, new() //Referans tip olabilir(class), IEntity ya da implemente eden nesnesi olabilir. Newlenebilir yani interface kullanamaz
	{

        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Expression Linq sorguları ile filtre yapabilmemizi sağlar.

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}

