using System;
namespace NLayer.Core
{
	public class ProductFeature
	{
		public int Id { get; set; }
		public string Color { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }

        // Product Id is a product entity forigen key 
        public int ProductId { get; set; }

        // once to once relation between Product and ProductFeature entity
        public Product Product { get; set; }
	}
}

