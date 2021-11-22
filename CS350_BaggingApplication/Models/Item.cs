using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS350_BaggingApplication.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public ContainerType Container { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}