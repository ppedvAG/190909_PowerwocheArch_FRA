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
            core = new Core(new EFUnitOfWork(new EFContext()));
        }
        private Core core;

        // GET: Book
        public ActionResult Index()
        {
            return View(core.UoW.BookRepository.GetAll());
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View(core.UoW.BookRepository.GetByID(id));
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
                core.UoW.BookRepository.Add(newBook);
                core.UoW.Save();
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
            return View(core.UoW.BookRepository.GetByID(id));
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book editedBook)
        {
            try
            {
                core.UoW.BookRepository.Update(editedBook);
                core.UoW.Save();

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
            return View(core.UoW.BookRepository.GetByID(id));
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Book deleteMe)
        {
            try
            {
                core.UoW.BookRepository.Delete(deleteMe);
                core.UoW.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
