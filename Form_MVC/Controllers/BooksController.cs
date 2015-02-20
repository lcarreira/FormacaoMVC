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
            List<EntityModels.Book> BookList = BibliotecaService.GetBooks();

            ViewBag.Books = BookList;
            return View();
        }
    }
}