using ppedv.MajoDDD.Data.EF;
using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ppedv.MajoDDD.UI.ASP.Controllers
{
    public class BookController : Controller
    {
        public BookController()
        {
            core = new Core(new EFRepository(new EFContext()));
        }
        private Core core;

        // GET: Book
        public ActionResult Index()
        {
            return View(core.Repository.GetAll<Book>());
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View(core.Repository.GetByID<Book>(id));
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View(new Book { Title = "Unbenannt", Author = "Unbekannt" });
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book newBook)
        {
            try
            {
                core.Repository.Add(newBook);
                core.Repository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View(core.Repository.GetByID<Book>(id));
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book editedBook)
        {
            try
            {
                core.Repository.Update(editedBook);
                core.Repository.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View(core.Repository.GetByID<Book>(id));
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Book deleteMe)
        {
            try
            {
                core.Repository.Delete(deleteMe);
                core.Repository.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
