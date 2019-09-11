using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.MajoDDD.Domain.Interfaces
{
    // "Standard"-Repository mit den Features, die jeder Datentyp können muss
    public interface IUniversalRepository<T> where T : Entity
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetByID(int ID);
        IEnumerable<T> GetAll();
        // Für LINQ:
        IQueryable<T> Query();
    }
}
