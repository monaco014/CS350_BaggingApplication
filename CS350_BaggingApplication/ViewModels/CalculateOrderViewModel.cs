using CS350_BaggingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS350_BaggingApplication.ViewModels
{
    public class CalculateOrderViewModel
    {
        public List<Item> Items { get; set; }
        public List<int> Quantities { get; set; }
    }
}