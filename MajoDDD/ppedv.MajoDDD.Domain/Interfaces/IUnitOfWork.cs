namespace ppedv.MajoDDD.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        // Spezial:
        IBookRepository BookRepository { get; }
        IBookStoreRepository BookStoreRepository { get; }

        // Repository-Factory:
        IUniversalRepository<T> GetRepository<T>() where T : Entity;

        // Alle Repositorys teilen sich einen einzelnen EFContext
        void Save();
    }
}
