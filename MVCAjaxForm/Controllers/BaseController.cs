using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCAjaxForm.Controllers
{
    /// <summary>
    /// 基控制器 ，处理Json数据
    /// </summary>
    public class BaseController : Controller
    {
        public ActionResult NewtonSoftJsonResult(object data)
        {
            return new JsonResult()
            {
                Data = data,
                JsonRequestBehavior=JsonRequestBehavior.AllowGet
                
            };
        }

        public ActionResult CreateModelStateErrors()
        {
            StringBuilder errorSummary = new StringBuilder();
            errorSummary.Append(@"<div class=""validation-summary-errors"" data-valmsg-summary=""true""><ul>");
            var errors = ModelState.Values.SelectMany(s => s.Errors);
            foreach (var item in errors)
            {
                errorSummary.Append("<li>"+item.ErrorMessage+"</li>");
            }
            errorSummary.Append("</ul></div>");
            return Content(errorSummary.ToString());
        }
	}
}