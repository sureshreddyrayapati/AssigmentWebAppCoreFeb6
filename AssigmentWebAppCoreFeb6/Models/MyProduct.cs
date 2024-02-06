using System;
using System.Collections.Generic;

namespace AssigmentWebAppCoreFeb6.Models
{
    public partial class MyProduct
    {
        public int Pid { get; set; }
        public string Pname { get; set; } = null!;
        public double? Pprice { get; set; }
        public DateTime? Pmd { get; set; }
        public DateTime? Ped { get; set; }
    }
}
