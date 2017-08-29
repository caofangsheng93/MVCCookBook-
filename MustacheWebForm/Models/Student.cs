using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MustacheWebForm.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public bool Registered { get; set; }
    }
}