using CS350_BaggingApplication.Models;
using CS350_BaggingApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS350_BaggingApplication.Controllers
{
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

        public ActionResult NewItem()
        {
            var model = new ItemFormViewModel()
            {
                Id = 0,
                Name = null
            };
            return View(model); 
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

            _context.Items.Add(item);
            _context.SaveChanges();

            return View();
        }

        public ActionResult NewPackaging()
        {
            var model = new PackagingFormViewModel()
            {
                Id = 0
            };
            return View(model);
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

            _context.Packaging.Add(packaging);
            _context.SaveChanges();

            return View();
        }
    }
}