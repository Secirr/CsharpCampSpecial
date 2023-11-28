using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapDemoContext>, IBrandDal
         //EfEntityRepositoryBase ile heryerde aynı kodları yazmak yerine kodları generik olarak base bir alanda topladık.
         //Bu sayede heryerde kullanabileceğiz.
    {


    }
}

