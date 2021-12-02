using CS350_BaggingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS350_BaggingApplication.ViewModels
{
    public class CalculateOrderResultViewModel
    {
        public Dictionary<Item, int> Items { get; set; }
        public Packaging PackagingUsed { get; set; }
        public double TotalWeight { get; set; }
        public int TotalItems { get; set; }
        public int BagsNeeded { get; set; }
    }
}