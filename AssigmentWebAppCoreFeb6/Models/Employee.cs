using System;
using System.Collections.Generic;

namespace AssigmentWebAppCoreFeb6.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Details = new HashSet<Detail>();
        }

        public int Eid { get; set; }
        public string Ename { get; set; } = null!;
        public int Eage { get; set; }
        public string? Eadd { get; set; }
        public double? Esal { get; set; }
        public string? Desgnation { get; set; }

        public virtual ICollection<Detail> Details { get; set; }
    }
}
