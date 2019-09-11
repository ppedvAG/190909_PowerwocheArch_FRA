using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.MajoDDD.Data.EF
{
    public class EFBookRepository : EFUniversalRepository<Book>, IBookRepository 
    {
        public EFBookRepository(EFContext context) : base(context){}

        public Book GetBookWithHighestPrice()
        {
            // LINQ
           return context.Book.OrderByDescending(x => x.Price)
                              .First();
        }

        public int GetTotalAmountOfBooksInCirculation(Book b)
        {
            return context.Inventory.Where(x => x.Book.ID == b.ID)
                                    .Sum(x => x.Amount);
        }
    }
}
