﻿using System;
namespace NLayer.Core
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}
}

