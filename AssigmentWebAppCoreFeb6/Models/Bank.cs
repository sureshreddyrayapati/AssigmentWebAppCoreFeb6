using System;
using System.Collections.Generic;

namespace AssigmentWebAppCoreFeb6.Models
{
    public partial class Bank
    {
        public decimal AccountNumber { get; set; }
        public string AadharNo { get; set; } = null!;
        public double? Balence { get; set; }
        public string PhoneNumber { get; set; } = null!;

        public virtual LogInCdt PhoneNumberNavigation { get; set; } = null!;
    }
}
