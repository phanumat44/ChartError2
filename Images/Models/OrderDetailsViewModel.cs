using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Images.Models
{
    public class OrderDetailsViewModel
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Amount { get; set; }
        public decimal? Total { get; set; }
    }
}