using ppedv.MajoDDD.Data.Access;
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
            Console.OutputEncoding = Encoding.Unicode;
            Core core = new Core(new EFUnitOfWork(new EFContext()),new AccessUnitOfWork());

            if (core.UoW.BookRepository.GetAll().Count() == 0)
                core.GenerateTestData();

            foreach (var store in core.UoW.BookStoreRepository.GetAll())
            {
                Console.WriteLine($"{store.Address}:");
                foreach (var inv in store.InventoryList)
                {
                    Console.WriteLine($"\t{inv.Book.Title}: {inv.Amount} Stück");
                    Console.WriteLine($"\t{inv.Book.Price}€, {inv.Book.Pages} Seiten");
                }
            }

            // Spezialfeatures:

            var bookPrice = core.UoW.BookRepository.GetBookWithHighestPrice();
            Console.WriteLine($"Buch mit höchstem Preis: {bookPrice.Title}");

            var stück = core.UoW.BookRepository.GetTotalAmountOfBooksInCirculation(bookPrice);
            Console.WriteLine($"Von diesem Buch gibt es insgesamt {stück} Stück");

            // Access-Features

            var allBooks = core.UoW_Access.BookRepository.GetAll();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
