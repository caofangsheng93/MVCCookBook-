using MustacheMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustacheMVC.Controllers
{
    public class BookController : Controller
    {
        public JsonResult GetBooksByPublishID(int id)
        {
            IEnumerable<BookModel> modelList = new List<BookModel>();
            using (var db = new BookDBEntities()) 
            {
                List<Book> lstBooks = db.Book.Where(x => x.PublisherID == id).ToList();
                modelList = lstBooks.Select(x => new BookModel()
                {
                    Title=x.Title,
                    Author=x.Auther,
                    Price=x.Price,
                    Year=x.Year

                });
            }
            return Json(modelList, JsonRequestBehavior.AllowGet);

        }
	}
}