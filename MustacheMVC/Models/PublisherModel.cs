using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustacheMVC.Models
{
    /// <summary>
    /// 出版商
    /// </summary>
    public class PublisherModel
    {
        public PublisherModel()
        {
            PublishList = new List<SelectListItem>();
        }
        [Display(Name="Publisher")]
        public int ID { get; set; }

        public IEnumerable<SelectListItem> PublishList { get; set; }


    }
}