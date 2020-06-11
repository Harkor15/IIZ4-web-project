using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shopping_List.DAL;
using Shopping_List.Models;

namespace Shopping_List.Controllers
{
    public class ShoppingListsController : Controller
    {
        private ShoppingListContext db = new ShoppingListContext();

        // GET: ShoppingLists
        public ActionResult Index()
        {
            return View(db.ShoppingLists.ToList());
        }

        // GET: ShoppingLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingLists shoppingLists = db.ShoppingLists.Find(id);
            if (shoppingLists == null)
            {
                return HttpNotFound();
            }
            return View(shoppingLists);
        }

        // GET: ShoppingLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name")] ShoppingLists shoppingLists)
        {
            if (ModelState.IsValid)
            {
                db.ShoppingLists.Add(shoppingLists);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoppingLists);
        }

        // GET: ShoppingLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingLists shoppingLists = db.ShoppingLists.Find(id);
            if (shoppingLists == null)
            {
                return HttpNotFound();
            }
            return View(shoppingLists);
        }

        // POST: ShoppingLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name")] ShoppingLists shoppingLists)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoppingLists).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoppingLists);
        }

        // GET: ShoppingLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingLists shoppingLists = db.ShoppingLists.Find(id);
            if (shoppingLists == null)
            {
                return HttpNotFound();
            }
            return View(shoppingLists);
        }

        // POST: ShoppingLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoppingLists shoppingLists = db.ShoppingLists.Find(id);
            db.ShoppingLists.Remove(shoppingLists);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
