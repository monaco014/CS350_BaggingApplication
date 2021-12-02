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
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}