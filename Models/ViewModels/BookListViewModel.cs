using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Joisah_Sarles.Models.ViewModels
{
    public class BookListViewModel
    {

        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }

        //Added a currentcategory variable
        public string CurrentCategory { get; set; }
    }
}
