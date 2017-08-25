using MVCAjaxForm.Common;
using MVCAjaxForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjaxForm.Controllers
{
    public class HomeController :BaseController
    {
        public static List<UserModel> lstUsers = new List<UserModel>();

        public ActionResult Index()
        {
            return View(lstUsers);
        }

        public ActionResult AddUser()
        {
            UserModel model = new UserModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(UserModel model)
        {
            if (ModelState.IsValid)
            {
                lstUsers.Add(model);
                return NewtonSoftJsonResult(new ResponseData<string>() { RedirectURL =Url.Action("Index","Home") });
            }
            return CreateModelStateErrors();
        }
	}
}