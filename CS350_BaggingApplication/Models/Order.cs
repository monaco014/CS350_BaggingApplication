using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS350_BaggingApplication.Models
{
    public class Order
    {
        public List<int> Quantities { get; set; }
        public int PackageId { get; set; }
    }
}