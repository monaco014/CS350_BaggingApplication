using CS350_BaggingApplication.Models;
using CS350_BaggingApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS350_BaggingApplication.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Item()
        {
            var items = _context.Items.ToList();

            var model = new ItemViewModel()
            {
                Items = items
            };

            _context.Dispose();

            return View(model);
        }

        public ActionResult NewItem()
        {
            var model = new ItemFormViewModel()
            {
                Id = 0,
                Name = null
            };
            return View(model); 
        }

        public ActionResult EditItem(int id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == id);

            if (item is null)
                return HttpNotFound();

            return View(new ItemFormViewModel(item));
        }

        public ActionResult DeleteItem(int id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == id);
            if (item is null)
                return HttpNotFound();

            _context.Items.Remove(item);

            _context.SaveChanges();

            var items = _context.Items.ToList();
            var model = new ItemViewModel()
            {
                Items = items
            };

            return View("Item", model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveItem(Item item)
        {
            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(item.Name))
            {
                var model = new ItemFormViewModel(item);
                return View("NewItem", model);
            }

            if (item.Id == 0)
            {
                _context.Items.Add(item);
            }
            else
            {
                var dbItem = _context.Items.SingleOrDefault(i => i.Id == item.Id);
                dbItem.Id = item.Id;
                dbItem.Name = item.Name;
                dbItem.Description = item.Description;
                dbItem.Length = item.Length;
                dbItem.Height = item.Height;
                dbItem.Width = item.Width;
                dbItem.Weight = item.Weight;
                dbItem.Quantity = item.Quantity;
                dbItem.Price = item.Price;
            }

            _context.SaveChanges();

            return View();
        }


        public ActionResult Packaging()
        {
            var packages = _context.Packaging.ToList();

            var model = new PackagingViewModel()
            {
                Packaging = packages
            };

            _context.Dispose();

            return View(model);
        }

        public ActionResult NewPackaging()
        {
            var model = new PackagingFormViewModel()
            {
                Id = 0
            };
            return View(model);
        }

        public ActionResult EditPackaging(int id)
        {
            var package = _context.Packaging.SingleOrDefault(i => i.Id == id);

            if (package is null)
                return HttpNotFound();

            return View(new PackagingFormViewModel(package));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SavePackaging(Packaging packaging)
        {
            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(packaging.Name))
            {
                var model = new PackagingFormViewModel(packaging);
                return View("NewPackaging", model);
            }

            if (packaging.Id == 0)
            {
                _context.Packaging.Add(packaging);
            }
            else
            {
                var dbPackage = _context.Packaging.SingleOrDefault(i => i.Id == packaging.Id);
                dbPackage.Id = packaging.Id;
                dbPackage.Name = packaging.Name;
                dbPackage.WeightCapacity = packaging.WeightCapacity;
                dbPackage.HardItemLimit = packaging.HardItemLimit;
                dbPackage.Length = packaging.Length;
                dbPackage.Height = packaging.Height;
                dbPackage.Width = packaging.Width;
            }

            _context.SaveChanges();

            return View();
        }

        public ActionResult DeletePackaging(int id)
        {
            var package = _context.Packaging.SingleOrDefault(i => i.Id == id);
            if (package is null)
                return HttpNotFound();

            _context.Packaging.Remove(package);

            _context.SaveChanges();

            var packaging = _context.Packaging.ToList();
            var model = new PackagingViewModel()
            {
                Packaging = packaging
            };

            return View("Packaging", model);
        }
    }
}