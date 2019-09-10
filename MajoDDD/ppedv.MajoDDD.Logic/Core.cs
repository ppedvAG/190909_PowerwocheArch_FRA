using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Domain.Interfaces;
using System;

namespace ppedv.MajoDDD.Logic
{
    public class Core
    {
        public Core(IRepository Repository)
        {
            this.Repository = Repository;
        }
        public IRepository Repository { get; set; }

        public void GenerateTestData()
        {
            Book b1 = new Book { Title = "Mein Garten", Author = "Tom Ate", Pages = 100, Price = 10 };
            Book b2 = new Book { Title = "Urlaub in der Karibik", Author = "Anna Nass", Pages = 200, Price = 15 };
            Book b3 = new Book { Title = "Küchen 101", Author = "Peter Silie", Pages = 12, Price = 0.99m };
            Book b4 = new Book { Title = "Reiseführer Paris", Author = "Franz Ose", Pages = 2, Price = 4.99m };
            Book b5 = new Book { Title = "Faktencheck: Namen", Author = "Klara Fall", Pages = 999, Price = 23 };

            BookStore bs1 = new BookStore { Address = "Hauptstraße 1" };
            bs1.InventoryList.Add(new Inventory { Book = b1, Amount = 10 });
            bs1.InventoryList.Add(new Inventory { Book = b2, Amount = 20 });
            bs1.InventoryList.Add(new Inventory { Book = b3, Amount = 30 });

            BookStore bs2 = new BookStore { Address = "Seitengasse 2" };
            bs2.InventoryList.Add(new Inventory { Book = b2, Amount = 50 });
            bs2.InventoryList.Add(new Inventory { Book = b3, Amount = 10 });
            bs2.InventoryList.Add(new Inventory { Book = b4, Amount = 3 });

            BookStore bs3 = new BookStore { Address = "Feldweg 3" };
            bs3.InventoryList.Add(new Inventory { Book = b3, Amount = 12 });
            bs3.InventoryList.Add(new Inventory { Book = b4, Amount = 21 });
            bs3.InventoryList.Add(new Inventory { Book = b5, Amount = 99 });

            Repository.Add(bs1);
            Repository.Add(bs2);
            Repository.Add(bs3);

            Repository.Save();
        }
    }
}
