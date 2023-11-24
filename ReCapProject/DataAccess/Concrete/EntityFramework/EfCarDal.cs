using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity) //Veri kaynağında car gönder
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var addedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                addedEntity.State = EntityState.Added; //Bu bir eklenecek nesne
                context.SaveChanges(); // Ekle
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var deletedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                deletedEntity.State = EntityState.Deleted; //Bu bir silinecek nesne
                context.SaveChanges(); // Sil
            }
        }

        public void Update(Car entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var updatedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                updatedEntity.State = EntityState.Modified; //Bu bir güncellenecek nesne
                context.SaveChanges(); // Güncelle
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null) //Filtre null da olabilir
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                return filter == null // Filtre null mu?
                    ? context.Set<Car>().ToList() //evetse Veri tabanındaki Car tablosunu listeye çevir ve verilerini getir
                    : context.Set<Car>().Where(filter).ToList(); //Değilse datayı filtreleyip getir.
            }
        }


        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                return context.Set<Car>().SingleOrDefault(filter); // Car tablosundan filtre uygulanmış olarak bir tane veri getir. Bussiness ta filtre boş geçilemez.
            }
        }

       
    }
}

