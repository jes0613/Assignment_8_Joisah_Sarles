using Assignment_8_Joisah_Sarles.Models;
using Assignment_8_Joisah_Sarles.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Joisah_Sarles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Added a private repository
        private IFamazonRepo _repo;
        public int PageSize = 5;

        // recieves the logger and the repository then sets the private values
        public HomeController(ILogger<HomeController> logger, IFamazonRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // sends the _repo.books to the view to be used to print on the index page
        public IActionResult Index(string category, int page = 1)
        {

            //UPdate the new to include category filtering adn uppdates the page numbering depending on how many pages there actually are. 
            return View(new BookListViewModel
            {
                Books = _repo.books
                    .Where(p => category == null || p.category == category)
                    .OrderBy(p => p.bookId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repo.books.Count() :
                        _repo.books.Where (x => x.category == category).Count()
                },
                CurrentCategory = category

            });

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
