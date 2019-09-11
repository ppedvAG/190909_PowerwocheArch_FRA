namespace ppedv.MajoDDD.Domain.Interfaces
{
    public interface IBookStoreRepository : IUniversalRepository<BookStore>
    {
        BookStore GetBookStoreWithHighestInventoryValue();
        BookStore GetBookStoreWithMostBooksInInventory();
    }
}
