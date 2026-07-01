using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01.Entities
{
    internal class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public CategoryStatus Status { get; set; }

        public Category(string name, string description, CategoryStatus status)
        {
            Name = name;
            Description = description;
            Status = status;
        }

    }

    enum CategoryStatus
    {
        Active,
        InActive
    }
}
