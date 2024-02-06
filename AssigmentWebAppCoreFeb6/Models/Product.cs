using System;
using System.Collections.Generic;

namespace AssigmentWebAppCoreFeb6.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; } = null!;
        public double? Pprice { get; set; }
        public DateTime? Pmfd { get; set; }
    }
}
