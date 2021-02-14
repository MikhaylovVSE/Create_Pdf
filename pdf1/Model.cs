using System;
using System.Collections.Generic;

namespace pdf1
{
    public class Report
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public List<Category> Items { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyCount { get; set; }
    }
}
