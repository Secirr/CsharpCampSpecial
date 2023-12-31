﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Car : IEntity
	{
        public int Id { get; set; }
       
        public int BrandId { get; set; }
        public Brand? brand { get; set; }

        public int ColorId { get; set; }
        public Color? color { get; set; }

        public string? Name { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime? ModelYear { get; set; } 

        public decimal DailyPrice { get; set; }

        public string? Description { get; set; }
    }
}

