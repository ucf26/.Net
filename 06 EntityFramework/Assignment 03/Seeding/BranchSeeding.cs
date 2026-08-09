
using Assignment_03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Seeding
{
    internal class BranchSeeding
    {
        

        public List<Branch> GenerateDate()
        {
             var branches = new List<Branch>()
             {
            
                new Branch
                {
                    //BranchCode = 101,
                    Name = "Downtown Main Branch",
                    Address = "123 Main Street, Cairo",
                    PhoneNumber = 2001234567,
                    //Manager = _managers[0]
                },
                new Branch
                {
                    //BranchCode = 102,
                    Name = "Zamalek Branch",
                    Address = "456 Zamalek Avenue, Giza",
                    PhoneNumber = 2002345678,
                    //Manager = _managers[1]
                },
                new Branch
                {
                    //BranchCode = 103,
                    Name = "Heliopolis Branch",
                    Address = "789 Heliopolis Street, Cairo",
                    PhoneNumber = 2003456789,
                    //Manager = _managers[2]
                }
            };
            return branches;
        }
    }
}
