using System;
namespace NLayer.Core
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public int Stock { get; set; }
		public decimal Price { get; set; }

		// once to many relation between category and product entity
		// Category Id is a category entity forigen key 
		public int CategoryId { get; set; }
		// this property say to entity framework once relation from product to category
		public Category Category { get; set; }

        // // this property say to entity framework once relation from product to ProductFeature
        public ProductFeature ProductFeature { get; set; }
	}
}

