using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Joisah_Sarles.Models
{
    //The good ole' cart class
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Book book, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.Book.bookId == book.bookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Book book)
        {
            Lines.RemoveAll(x => x.Book.bookId == book.bookId);

        }
        public virtual void ClearCart() => Lines.Clear();
        public double ComputeTotalSum() => Lines.Sum(e => e.Book.price * e.Quantity);


        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }

    }
}
