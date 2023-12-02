using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Rental : IEntity
	{
        //Id, CarId, CustomerId, RentDate(Kiralama Tarihi),
        //ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.

        public int Id { get; set; }

        public int CarId { get; set; } 
        public Car? car { get; set; } //Car tablosu ile ilişki

        public int CustomerId { get; set; } 
        public Customer? customer { get; set; } //Customer tablosu ile ilişki

        public DateTime RentDate { get; set; } //Kiralama Tarihi

        public DateTime? ReturnDate { get; set; } //Teslim Tarihi

    }
}

