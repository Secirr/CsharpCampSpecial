using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() //kısıtlama kuralları:
                                              //Class: Bu bir referans tutucu olmalı,
                                              //IEntity: Bir IEntity imzası taşımalı,
                                              //new(): burada interface kullanımını engellemek için new()
                                              //komutunu kullanıyoruz. Çünkü interfaceler newlenemez :)

        where TContext : DbContext, new() //DbContext: Nuget "EntityFramework for sql server" paketinden gelir.
                                          //DbContext'i burada olduğu gibi contexlerimizin imzası olarak kullanabiliriz.
                                          //new(): Aynı yukarıdaki gibi burada da kullandık ki Interface yazılamasın.
    {
        public void Add(TEntity entity) //Car,Brand,Color ... Bütün EntityFrameworkDataAccesLayer(Ef..Dal) katmanları generik olarak kullanabilir 
        {
            using (TContext context = new TContext()) //Yapılan iş bitince performanslı bir çalışma için Garbec Collector'e 
            {                                         //using kodu ile burayı belirtiyoruz o da hemen burayı siliyor.)
                var addedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                addedEntity.State = EntityState.Added; //Bu bir eklenecek nesne
                context.SaveChanges(); // Ekle
            }
        }

        public void Delete(TEntity entity) //TEntity = Car,Brand,Color ... Bütün EntityFrameworkDataAccesLayer(Ef..Dal) katmanları generik olarak kullanabilir
        {
            using (TContext context = new TContext()) //Yapılan iş bitince performanslı bir çalışma için Garbec Collector'e 
            {                                         //using kodu ile burayı belirtiyoruz o da hemen burayı siliyor.)
                var deletedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                deletedEntity.State = EntityState.Deleted; //Bu bir silinecek nesne
                context.SaveChanges(); // Sil
            }
        }

        public void Update(TEntity entity) //Car,Brand,Color ... Bütün EntityFrameworkDataAccesLayer(Ef..Dal) katmanları generik olarak kullanabilir
        {
            using (TContext context = new TContext()) //Yapılan iş bitince performanslı bir çalışma için Garbec Collector'e 
            {                                         //using kodu ile burayı belirtiyoruz o da hemen burayı siliyor.)
                var updatedEntity = context.Entry(entity); //Veri kaynağındaki nesnenin referansını yakala
                updatedEntity.State = EntityState.Modified; //Bu bir güncellenecek nesne
                context.SaveChanges(); // Güncelle
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null) //Filtre null da olabilir | Car,Brand,Color ... Bütün EntityFrameworkDataAccesLayer(Ef..Dal) katmanları generik olarak kullanabilir
        {
            using (TContext context = new TContext()) //Yapılan iş bitince performanslı bir çalışma için Garbec Collector'e 
            {                                         //using kodu ile burayı belirtiyoruz o da hemen burayı siliyor.)
                return filter == null // Filtre null mu?
                    ? context.Set<TEntity>().ToList() //evetse: Veri tabanındaki belirtilen(TEntity) tobloyu listeye çevir ve verilerini getir
                    : context.Set<TEntity>().Where(filter).ToList(); //Değilse: datayı filtreleyip getir.
            }
        }


        public TEntity Get(Expression<Func<TEntity, bool>> filter) //filtre null olamaz | Car,Brand,Color ... Bütün EntityFrameworkDataAccesLayer(Ef..Dal) katmanları generik olarak kullanabilir
        {
            using (TContext context = new TContext()) //Yapılan iş bitince performanslı bir çalışma için Garbec Collector'e 
            {                                         //using kodu ile burayı belirtiyoruz o da hemen burayı siliyor.)
                return context.Set<TEntity>().SingleOrDefault(filter); // Belirtilen(TEntity) tablodan filtre uygulanmış olarak bir tane veri getir. Bussiness ta filtre boş geçilemez.
            }
        }
    }
}

