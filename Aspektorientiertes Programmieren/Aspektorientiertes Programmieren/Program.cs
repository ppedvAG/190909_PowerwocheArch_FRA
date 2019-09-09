using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspektorientiertes_Programmieren
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Person> personenRepo = new AuthRepository<Person>(new LoggingRepository<Person>(
                                                                         new UniversalRepository<Person>()),
                                                                         User.Admin);

            // FactoryMethod: RepoFactory.GetLoggingRepo<Person>();
            // Builder:
            // var repo = UniversalRepo()
            //            .WithLogger()
            //            .WithAuth();
            //            .Get();

            Person p1 = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 100 };

            personenRepo.Add(p1);
            personenRepo.Update(p1);
            personenRepo.Delete(p1);
            personenRepo.GetByID(12);
            personenRepo.Save();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
