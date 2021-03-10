using Assignment_8_Joisah_Sarles.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Joisah_Sarles.Components
{
    // NavigationMenu View Compnent, outputs a partial view for the navigation and allows for the highlighting of the category currently selected
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IFamazonRepo _repo;

        public NavigationMenuViewComponent (IFamazonRepo r)
        {
            _repo = r;
        }
         
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(
                _repo.books
                .Select(x => x.category)
                .Distinct()
                .OrderBy(x => x)
                );
        }
    }
}
