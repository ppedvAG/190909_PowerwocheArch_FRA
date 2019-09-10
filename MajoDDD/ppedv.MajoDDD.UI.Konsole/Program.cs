using ppedv.MajoDDD.Data.EF;
using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.MajoDDD.UI.Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Core core = new Core(new EFRepository(new EFContext()));

            if (core.Repository.GetAll<Book>().Count() == 0)
                core.GenerateTestData();

            foreach (var store in core.Repository.GetAll<BookStore>())
            {
                Console.WriteLine($"{store.Address}:");
                foreach (var inv in store.InventoryList)
                {
                    Console.WriteLine($"\t{inv.Book.Title}: {inv.Amount} Stück");
                }
            }


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
