using System.Collections.Generic;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Kategori 1"},
                new Category(){Name="Kategori 2"},
                new Category(){Name="Kategori 3"}
            };
            return View(categories);

        }

    }
}