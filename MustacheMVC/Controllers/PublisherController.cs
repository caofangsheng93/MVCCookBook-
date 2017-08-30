using MustacheMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustacheMVC.Controllers
{
    public class PublisherController : Controller
    {
        ///主视图
        //
        // GET: /Publisher/
        public ActionResult Index()
        {
            PublisherModel model = new PublisherModel();
            using (var db = new BookDBEntities())
            {
               List<Publisher> lstPublish= db.Publisher.ToList();
               model.PublishList = lstPublish.Select(x => new SelectListItem()
               {
                  Text=x.Name,
                  Value=x.ID.ToString()
                
               });
            }
            return View(model);
        }
	}
}