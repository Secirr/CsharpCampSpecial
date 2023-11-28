using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDemoContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            //Base de yapılan işlemlerin aynısını araba detayı için burada yazdık.
            //Burası base içinde yazmadık çünkü manuel olarak olası değişimleri kolayca buradan yapacağız.
            //İş sınıfı bu metodu çağırdığı zaman neler geleceğini belirledik.
            using (ReCapDemoContext context = new ReCapDemoContext())
            {
                var result = from c in context.Cars  //sql yolu belirtmek için newlediğimiz context'i tablonun başında belirttik.
                             join b in context.Brands //brands tablosunu joinlemek istediğimizi belirttik
                             on c.BrandId equals b.Id  //kural olarak BrandID yi kullandık çünkü brand tablosunun primary key'i BrandId
                             join cr in context.Colors //colors tablosunu joinlemek istediğimizi belirttik
                             on c.ColorId equals cr.Id //kural olarak ColorId yi kullandık çünkü colors tablosunun primary key'i ColorId
                             //sql deki = yerine equals kullanılır
                             select new CarDetailDto {
                                                       CarName = c.Name,
                                                       BrandName = b.Name,
                                                       ColorName = cr.Name,
                                                       DailyPrice = c.DailyPrice
                                                     }; //Hangi verileri hangi tablodan çekeceğimizi belirttik.
                return result.ToList(); //Listeleyerek bunların Bussiness katmanında Liste olarak çekilebilmesini sağladık.
                               
            }
        }

        //Tablolarımızın hepsini istenilen veriler doğrultusunda joinledik. (Car,Brand,Color)
        
    }
}

