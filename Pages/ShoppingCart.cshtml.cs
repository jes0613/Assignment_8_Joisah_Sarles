using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_8_Joisah_Sarles.Infrastructure;
using Assignment_8_Joisah_Sarles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_8_Joisah_Sarles.Pages
{

    //Page model for Shopping cart, used throughout the session, can add a cart item or remove one. 
    public class ShoppingCartModel : PageModel
    {
        private IFamazonRepo _repo;

        public ShoppingCartModel (IFamazonRepo repo, Cart cartservice)
        {
            _repo = repo;
            Cart = cartservice;
        }

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }


        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";

        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = _repo.books.FirstOrDefault(p => p.bookId == bookId);

            Cart.AddItem(book, 1);

            return RedirectToPage(new {returnUrl = returnUrl});
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(p =>
                p.Book.bookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }


    }
}
