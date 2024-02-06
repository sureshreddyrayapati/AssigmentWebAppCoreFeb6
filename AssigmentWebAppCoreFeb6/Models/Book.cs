using System;
using System.Collections.Generic;

namespace AssigmentWebAppCoreFeb6.Models
{
    public partial class Book
    {
        public int Bid { get; set; }
        public string Bname { get; set; } = null!;
        public double? Price { get; set; }
        public string Author { get; set; } = null!;
    }
}
