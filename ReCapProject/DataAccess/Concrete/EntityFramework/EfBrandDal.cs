using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var addedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                addedEntity.State = EntityState.Added; //Bu bir eklenecek nesne
                context.SaveChanges(); // Ekle
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var deletedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                deletedEntity.State = EntityState.Deleted; //Bu bir silinecek nesne
                context.SaveChanges(); // Sil
            }
        }

        public void Update(Brand entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var updatedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                updatedEntity.State = EntityState.Modified; //Bu bir güncellenecek nesne
                context.SaveChanges(); // Güncelle
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                return context.Set<Brand>().SingleOrDefault(filter); // Car tablosundan filtre uygulanmış olarak bir tane veri getir.
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                return filter == null // Filtre null mu?
                    ? context.Set<Brand>().ToList() //evetse Veri tabanındaki Car tablosunu listeye çevir ve verilerini getir
                    : context.Set<Brand>().Where(filter).ToList(); //Değilse datayı filtreleyip getir.
            }
        }

        
    }
}

