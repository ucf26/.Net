using Assignment_03.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Models
{
    internal class CustomerAccount
    {
        public DateTime OwnershipStartDate { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public OwnershipType OwnershipType { get; set; }

        // ========================================================
        // Relations
        // ========================================================

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int AccountNumber { get; set; }
        public Account Account { get; set; }

    }
}
