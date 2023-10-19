using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazingShop.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		[HttpGet]
		public async Task<ActionResult<List<Category>>> GetCategories()
		{
			return Ok(new List<Category>
			{
				new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
				new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
				new Category { Id = 3, Name = "video Games", Url = "video-games", Icon = "aperture" }
			});
		}
	}
}
