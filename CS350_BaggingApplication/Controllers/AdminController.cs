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


        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewItem()
        {
            var model = new ItemFormViewModel()
            { 
                Id = 0
            };
            return View(model); 
        }
        
        [HttpPost]
        public ActionResult SaveItem(Item item)
        {
            if (!ModelState.IsValid)
            {
                var model = new ItemFormViewModel(item);
                return View("NewItem", model);
            }

            _context.Items.Add(item);
            _context.SaveChanges();

            return View("CreatedItem");
        }

        public ActionResult CreatedItem()
        {
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
        public ActionResult SavePackaging(Packaging pack)
        {
            if (!ModelState.IsValid)
            {
                var model = new PackagingFormViewModel(pack);
                return View("Newpackaging", model);
            }

            _context.Packaging.Add(pack);
            _context.SaveChanges();

            return View("CreatedPackaging");
        }

        public ActionResult CreatedPackaging()
        {
            return View();
        }

    }
}