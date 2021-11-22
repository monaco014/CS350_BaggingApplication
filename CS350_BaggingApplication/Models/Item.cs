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
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}