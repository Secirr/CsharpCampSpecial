using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Customer : IEntity
	{
        //UserId,CompanyName

        public int CustomerId { get; set; }

        public int  UserId { get; set; }
        public User user { get; set; } //User tablosu ile ilişki
   
        public string CompanyName { get; set; }
    }
}

