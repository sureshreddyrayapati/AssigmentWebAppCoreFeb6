using System;
using System.Collections.Generic;

namespace AssigmentWebAppCoreFeb6.Models
{
    public partial class Player
    {
        public int Pid { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? JerseyNumber { get; set; }
        public int? Posistion { get; set; }
        public string? Team { get; set; }
    }
}
