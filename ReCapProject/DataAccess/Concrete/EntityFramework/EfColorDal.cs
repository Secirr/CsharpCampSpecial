using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var addedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                addedEntity.State = EntityState.Added; //Bu bir eklenecek nesne
                context.SaveChanges(); // Ekle
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var deletedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                deletedEntity.State = EntityState.Deleted; //Bu bir silinecek nesne
                context.SaveChanges(); // sil
            }
        }

        public void Update(Color entity)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                var updatedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                updatedEntity.State = EntityState.Modified; //Bu bir güncellenecek nesne
                context.SaveChanges(); // güncelle
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                return context.Set<Color>().SingleOrDefault(filter); // Car tablosundan filtre uygulanmış olarak bir tane veri getir.
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapDemoContext context = new ReCapDemoContext()) //Garbec Collector using'i işi bitince hemen siler ve performans artar
            {
                return filter == null // Filtre null mu?
                    ? context.Set<Color>().ToList() //evetse Veri tabanındaki Car tablosunu listeye çevir ve verilerini getir
                    : context.Set<Color>().Where(filter).ToList(); //Değilse datayı filtreleyip getir.
            }
        }

        
    }
}

