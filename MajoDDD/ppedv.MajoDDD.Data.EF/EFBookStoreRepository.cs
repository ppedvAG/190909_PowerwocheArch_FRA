using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Domain.Interfaces;
using System.Linq;

namespace ppedv.MajoDDD.Data.EF
{
    public class EFBookStoreRepository : EFUniversalRepository<BookStore>, IBookStoreRepository
    {
        public EFBookStoreRepository(EFContext context) : base(context){}

        public BookStore GetBookStoreWithHighestInventoryValue()
        {
            return context.BookStore
                          .OrderByDescending(x => x.InventoryList.Sum(inv => inv.Amount * inv.Book.Price))
                          .First();
        }

        public BookStore GetBookStoreWithMostBooksInInventory()
        {
            return context.BookStore
                          .OrderByDescending(x => x.InventoryList.Sum(inv => inv.Amount))
                          .First();
        }
    }
}
