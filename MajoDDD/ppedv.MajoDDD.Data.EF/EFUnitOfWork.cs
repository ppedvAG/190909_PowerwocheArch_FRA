using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ppedv.MajoDDD.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public EFUnitOfWork(EFContext context)
        {
            this.context = context;
        }
        private readonly EFContext context;



        // Variante 1) Immer ein neues Repo zurückgeben
        public IBookRepository BookRepository => new EFBookRepository(context);

        // Variante 2) Singleton
        private IBookStoreRepository bookStoreRepository;
        public IBookStoreRepository BookStoreRepository
        {
            get
            {
                // ToDo: Lock-Block für Threadsicherheit
                if (bookStoreRepository == null)
                    bookStoreRepository = new EFBookStoreRepository(context);
                return bookStoreRepository;
            }
        
        }

        public IUniversalRepository<T> GetRepository<T>() where T : Entity
        {
            return new EFUniversalRepository<T>(context);
            // Hausaufgabe: Wenn Book kommt -> BookRepository
            // Wenn BookStore -> BookStoreRepository
            // alles andere: Universal
            // Hausaufgabe 2: Cache (wenn 2 mal inventory angefragt wird)
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
