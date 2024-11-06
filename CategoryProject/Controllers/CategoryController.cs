using System;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CategoryProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<string> { "Electronics", "Books", "Clothing", "Furniture" };
            return View(categories);
        }
    }
}

