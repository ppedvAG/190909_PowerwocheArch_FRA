namespace Aspektorientiertes_Programmieren
{
    internal interface IRepository<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetByID(int ID);
        void Save();
    }
}