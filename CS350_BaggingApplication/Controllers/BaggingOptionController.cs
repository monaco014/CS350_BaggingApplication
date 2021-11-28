using CS350_BaggingApplication.Models;
using CS350_BaggingApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS350_BaggingApplication.Controllers
{
    public class BaggingOptionController : Controller
    {
        ApplicationDbContext _context;

        public BaggingOptionController()
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
            var pack = _context.Packaging.ToList();

            var model = new PackagingViewModel()
            {
                Packaging = pack
            };

            _context.Dispose();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var package = _context.Packaging.FirstOrDefault(i => i.Id == id);

            if (package == null)
                return HttpNotFound();

            return View(package);
        }

    }
}