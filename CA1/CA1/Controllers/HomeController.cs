using CA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA1
{
    public class HomeController : Controller
    {
        private MvcMusicStoreEntities db = new MvcMusicStoreEntities();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        //
        // GET: /Home/

        public ActionResult Index(string searchTerm)
        {
            var allOrders = db.Orders
                .Where(ar=>searchTerm==null || ar.LastName.Contains(searchTerm))
                .OrderBy(a => a.LastName);
            return View(allOrders);
        }

        /*
        public ActionResult Search(string searchTerm)
        {
            var findArtists = db.Artists.Where(a => a.Name.Contains(searchTerm));
            return View("Index",findArtists);
        }*/


        //
        // GET: /Home/Albums/5
        
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult SortDate()
        {
            var allOrders = from o in db.Orders orderby o.OrderDate select o;
            return View(allOrders);
        }

        public ActionResult SortValue()
        {
            var allOrders = from s in db.Orders
                            orderby s.Total
                            select s;

            var allOrders2 = from od in db.Orders
                            join z in db.OrderDetails on od.OrderId equals z.OrderId
                            orderby ((z.Quantity) * (z.UnitPrice))
                            select z;
            return View(allOrders);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
