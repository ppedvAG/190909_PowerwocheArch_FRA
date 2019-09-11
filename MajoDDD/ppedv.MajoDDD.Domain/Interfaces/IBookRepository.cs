namespace ppedv.MajoDDD.Domain.Interfaces
{
    public interface IBookRepository : IUniversalRepository<Book>
    {
        Book GetBookWithHighestPrice();
        int GetTotalAmountOfBooksInCirculation(Book b);
    }
}
