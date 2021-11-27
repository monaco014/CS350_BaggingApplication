using CS350_BaggingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CS350_BaggingApplication.Controllers.Api
{
    public class ItemController : ApiController
    {
        private ApplicationDbContext _context;

        public ItemController()
        {
            _context = new ApplicationDbContext();
        }


        public IEnumerable<Item> GetItems()
        {
            return _context.Items.ToList();
        }

        public Item GetItem(int id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == id);

            if (item is null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return item;
        }

    }
}
