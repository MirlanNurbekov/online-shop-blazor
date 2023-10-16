using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
	public class Product
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; } = "https://via.placeholder.com/300x300";
		public decimal Price { get; set; }
		public decimal OriginalPrice { get; set; }
		public bool IsPublic { get; set; }
		public bool IsDeleted { get; set; }
		public Category Catergory { get; set; }
		public int CatergoryId { get; set; }
		public DateTime DateCreateed { get; set; } = DateTime.Now;
		public DateTime Dateupdated { get; set; }
	}
}
