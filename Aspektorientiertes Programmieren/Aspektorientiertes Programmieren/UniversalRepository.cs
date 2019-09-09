using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspektorientiertes_Programmieren
{
    class UniversalRepository<T> : IRepository<T>
    {
        public void Add(T item)
        {
            Console.WriteLine($"Füge Element hinzu: {item}");
        }

        public void Delete(T item)
        {
            Console.WriteLine($"Lösche Element: {item}");
        }

        public T GetByID(int ID)
        {
            Console.WriteLine($"Suche nach Element: {ID}");
            return default(T);
        }

        public void Save()
        {
            Console.WriteLine($"Speichern...");
        }

        public void Update(T item)
        {
            Console.WriteLine($"Update für das Element: {item}");

        }
    }
}
