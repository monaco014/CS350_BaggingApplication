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

    }
}