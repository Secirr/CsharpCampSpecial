using System;
using Core.Entities;

namespace Entities.DTOs
{
	public class CarDetailDto : IDto //DTO: Data Transfer Object
									 //Tabloları joinleyerek tüm tablolardan istenilen veriyi çekebileceğimiz ara katman
									 //Aşağıda çekeceğimiz kolon isimlerini belirledik.
	{
		public int CarId { get; set; }

		public string CarName { get; set; }

		public string BrandName { get; set; }

		public string ColorName { get; set; }

		public decimal DailyPrice { get; set; }
	}
}

