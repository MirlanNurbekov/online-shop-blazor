using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
	public class ProductService : IProductService
	{
		public List<Product> Products { get; set; } = new List<Product>();

		public void LoadProducts()
		{
			Products = new List<Product>
			{
				new Product
				{
					Id = 1,
					CatergoryId = 1,
					Title = "Luci",
					Description ="Good movie",
					Image = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/41d3b880123243.5cd86d80c4873.jpg",
					Price = 9.99m,
					OriginalPrice= 19.99m,
				},
				new Product
				{
					Id = 2,
					CatergoryId = 1,
					Title = "Luci1212",
					Description ="Good movie",
					Image = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/41d3b880123243.5cd86d80c4873.jpg",
					Price = 92.99m,
					OriginalPrice= 192.99m,
				},
				new Product
				{
					Id = 2,
					CatergoryId = 2,
					Title = "NOT BOOK",
					Description ="Good movie",
					Image = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/41d3b880123243.5cd86d80c4873.jpg",
					Price = 92.99m,
					OriginalPrice= 192.99m,
				},
				new Product
				{
					Id = 2,
					CatergoryId = 3,
					Title = "Definetly not book",
					Description ="Good movie",
					Image = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/41d3b880123243.5cd86d80c4873.jpg",
					Price = 92.99m,
					OriginalPrice= 192.99m,
				},
			};
		}
	}
}
