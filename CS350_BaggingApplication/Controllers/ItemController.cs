using CS350_BaggingApplication.Models;
using CS350_BaggingApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS350_BaggingApplication.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        ApplicationDbContext _context;

        public ItemController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        { 
            _context.Dispose();
        }

        // GET: Item
        public ActionResult Index()
        {
            var items = _context.Items.ToList();

            var model = new ItemViewModel()
            {
                Items = items
            };

            _context.Dispose();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
                return HttpNotFound();

            return Content(item.Name);
        }

    }
}