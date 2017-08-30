using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MustacheMVC.Models
{
    public class BookModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Year { get; set; }

        public decimal Price { get; set; }
    }
}