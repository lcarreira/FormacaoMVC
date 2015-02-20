using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form_MVC.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            FromWCF.BibliotecaServiceClient BibliotecaService = new FromWCF.BibliotecaServiceClient();
            List<EntityModels.BookAuthors> BookList = BibliotecaService.GetBooks();


            //List<EntityModels.Author> AuthorList = BookList[0].Authors.ToList();


            ViewBag.Books = BookList;
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book b)
        {
            FromWCF.BibliotecaServiceClient BibliotecaService = new FromWCF.BibliotecaServiceClient();
            b = BibliotecaService.InsertBook(b);


            return RedirectToAction("Index");
        }
    }
}