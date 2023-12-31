﻿using BlazingShop.Shared;

namespace BlazingShop.Server.Services.CategoryService
{
	public interface ICategoryService
	{
		Task<List<Category>> GetCategories();
	}
}
