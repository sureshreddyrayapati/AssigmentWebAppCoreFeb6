using System;
using System.Collections.Generic;

namespace AssigmentWebAppCoreFeb6.Models
{
    public partial class Detail
    {
        public int Eno { get; set; }
        public int Eid { get; set; }
        public DateTime JoingDate { get; set; }
        public string Elocation { get; set; } = null!;

        public virtual Employee EidNavigation { get; set; } = null!;
    }
}
