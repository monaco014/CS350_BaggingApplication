using CS350_BaggingApplication.Models;
using CS350_BaggingApplication.ViewModels;
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

            Dictionary<Item, int> dict = ConvertToItemQuantityDictionary(quantities);
            Packaging packagingType = _context.Packaging.First();

            IBaggingAlgorithm baggingAlgorithm = new SimpleBaggingAlgorithm();
            int neededBags = baggingAlgorithm.GetNumberOfNeededBags(dict, packagingType);

            int totalWeight = GetTotalWeight(dict);
            int totalItems = GetTotalItems(dict);

            var model = new CalculateOrderResultViewModel
            {
                TotalItems = totalItems,
                TotalWeight = totalWeight,
                Items = dict,
                PackagingUsed = packagingType,
                BagsNeeded = neededBags
            };

            return View(model);
        }

        private static int GetTotalWeight(Dictionary<Item, int> dict)
        {
            int totalWeight = 0;
            foreach (var item in dict)
            {
                if (item.Value != 0)
                {
                    totalWeight += item.Key.Weight;
                }
            }

            return totalWeight;
        }

        private static int GetTotalItems(Dictionary<Item, int> dict)
        {
            int totalItems = 0;
            foreach (var item in dict)
            {
                if (item.Value != 0)
                {
                    totalItems += item.Value;
                }
            }

            return totalItems;
        }

        private Dictionary<Item, int> ConvertToItemQuantityDictionary(List<int> quantities)
        {
            var items = _context.Items.ToList();
            var unsortedDict = new Dictionary<Item, int>();
            for (int i = 0; i < items.Count; i++)
            {
                unsortedDict.Add(items[i], quantities[i]);
            }

            var sortedDict = new Dictionary<Item, int>();
            foreach (var item in unsortedDict)
            {
                if (item.Value > 0)
                    sortedDict.Add(item.Key, item.Value);
            }

            return sortedDict;
        }
    }

}