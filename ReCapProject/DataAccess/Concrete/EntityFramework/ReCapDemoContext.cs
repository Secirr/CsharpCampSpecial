using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore; //Base Gelen Entitframework sınıfı (DbContext)
namespace DataAccess.Concrete.EntityFramework
{
	//Context : DataBase tabloları ile classları bağlamak
	//Burada migration işlemi ile sql de classlarımıza göre tablolar oluşturacağız.
	//dbContext Entityframwork paketi eklediğimiz için otomatik gelen bir Base Sınıftır.

	public class ReCapDemoContext : DbContext //Base Gelen Entitframework sınıfı (DbContext)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //override onConfiguring
        {

            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=ReCapDemoDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate =True");

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }
    }
}

