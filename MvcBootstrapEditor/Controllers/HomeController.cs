using MvcBootstrapEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapEditor.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            BookModel book = new BookModel();
            return View();
        }

        [HttpPost]
        public ActionResult Index(BookModel model)
        {
            return View(model);
        }
	}
}