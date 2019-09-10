using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ppedv.MajoDDD.Domain;

namespace ppedv.MajoDDD.Data.EF.Tests
{
    [TestClass]
    public class EFContextTests
    {
        [TestMethod]
        public void Can_Create_EFContext()
        {
            EFContext context = new EFContext();
        }

        [TestMethod]
        public void Can_Create_Database()
        {
            EFContext context = new EFContext();

            if (context.Database.Exists())
                context.Database.Delete();

            Assert.IsFalse(context.Database.Exists());
            context.Database.Create();
            Assert.IsTrue(context.Database.Exists());
        }

        // CRUD

        [TestMethod]
        public void Can_CRUD_Book()
        {
            Book b1 = new Book { Author = "Michi Z", Pages = 3, Title = "Anleitung für DDD", Price = 9.99m };
            string newTitle = "Anleitung für UnitTests";
            // Create
            using (EFContext context = new EFContext())
            {
                context.Book.Add(b1);
                context.SaveChanges();
            }

            // Read
            using (EFContext context = new EFContext())
            {
                var loadedBook = context.Book.First(x => x.ID == b1.ID);
                Assert.AreEqual(b1.ID, loadedBook.ID);

                // Update
                loadedBook.Title = newTitle; // Veränderung wird in der DB gespeichert
                context.SaveChanges();
            }

            // Check Update
            using (EFContext context = new EFContext())
            {
                var loadedBook = context.Book.First(x => x.ID == b1.ID);
                Assert.AreEqual(newTitle,loadedBook.Title);

                // Delete
                context.Book.Remove(loadedBook);
                context.SaveChanges();
            }

            // Check Delete
            using (EFContext context = new EFContext())
            {
                Assert.IsFalse(context.Book.Any(x => x.ID == b1.ID));
            }
        }
    }
}
