//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MustacheMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
        public int PublisherID { get; set; }
    
        public virtual Publisher Publisher { get; set; }
    }
}
