using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Joisah_Sarles.Models
{
    public interface IFamazonRepo
    {
        IQueryable<Book> books { get; }
    }
}
