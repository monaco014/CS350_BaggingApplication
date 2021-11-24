using CS350_BaggingApplication.Models;
using CS350_BaggingApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS350_BaggingApplication.Controllers
{
    public class OrderController : Controller
    {
        ApplicationDbContext _context;

        public OrderController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Order
        public ActionResult Index()
        {
            var model = new CalculateOrderViewModel()
            {
                Items = _context.Items.ToList(),
                Quantities = new List<int>()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult CalculateOrder(List<int> quantities)
        {
            if (quantities is null)
            {
                return View();
            }

            // This is actually the dumbest way to make a dictionary of the quantity of each item from the form, but I can't get anything else to work at the moment
            var items = _context.Items.ToList();
            var unsortedDict = new Dictionary<Item, int>();
            for (int i = 0; i < items.Count; i++)
            {
                unsortedDict.Add(items[i], quantities[i]);
            }
            var dict = new Dictionary<Item, int>();
            foreach (var item in unsortedDict)
            {
                if (item.Value > 0)
                    dict.Add(item.Key, item.Value);
            }

            // Bagging algorithm goes here

            Packaging packagingType = _context.Packaging.First();
            int neededBags = GetNumberOfNeededBags(dict, packagingType);

            var model = new CalculateOrderResultViewModel
            {
                Items = dict,
                PackagingUsed = packagingType,
                BagsNeeded = neededBags
            };

            return View(model);
        }

        private static int GetNumberOfNeededBags(Dictionary<Item, int> dict, Packaging type)
        {
            var totalItems = 0;
            var totalWeight = 0;
            foreach (var item in dict)
            {
                if (item.Value != 0)
                {
                    totalItems += item.Value;
                    totalWeight += item.Key.Weight;
                }
            }

            return 5;
        }
    }

}