using CA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA1.Controllers
{
    public class AlbumController : Controller
    {
        private MvcMusicStoreEntities db = new MvcMusicStoreEntities();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        //
        // GET: /Album/

        public ActionResult AlbumsInOrder(int id)
        {
            // Show album that was in the order
            var chosenOrder = db.Orders.SingleOrDefault(ord => ord.OrderId == id);
            //var albumInOrder = from a in chosenOrder from b in db.OrderDetails.
            return View();
            
        }

       

        //
        // GET: /Album/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Album/Create

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
        // GET: /Album/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Album/Edit/5

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
        // GET: /Album/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Album/Delete/5

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
