using System;
using Core.Entities;

namespace Entities.DTOs
{
	public class CarRentalDto : IDto
	{
		public int CarId { get; set; }

		public int CustomerId { get; set; }

	}
}

