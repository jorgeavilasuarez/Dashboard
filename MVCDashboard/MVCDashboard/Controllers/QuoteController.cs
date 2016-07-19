using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDashboard.Models;

namespace MVCDashboard.Controllers
{
    public class QuoteController : Controller
    {
        private OfficeERPEntities db = new OfficeERPEntities();

        // GET: Quotes
        public ActionResult Index()
        {
            var quotes = db.Quote.Include(q => q.UserProduct);
            return View(quotes.ToList());
        }

        // GET: Quotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quote quote = db.Quote.Find(id);
            if (quote == null)
            {
                return HttpNotFound();
            }
            return View(quote);
        }

        // GET: Quotes/Create
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(db.UserProduct, "Id", "AspNetUserId");
            return View();
        }

        // POST: Quotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ClientEmail,ProductId,Quantity,Comment,Phone,CellPhone,Name")] Quote quote)
        {
            if (ModelState.IsValid)
            {
                db.Quote.Add(quote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductId = new SelectList(db.UserProduct, "Id", "AspNetUserId", quote.ProductId);
            return View(quote);
        }

        // GET: Quotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quote quote = db.Quote.Find(id);
            if (quote == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(db.UserProduct, "Id", "AspNetUserId", quote.ProductId);
            return View(quote);
        }

        // POST: Quotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClientEmail,ProductId,Quantity,Comment,Phone,CellPhone,Name")] Quote quote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.UserProduct, "Id", "AspNetUserId", quote.ProductId);
            return View(quote);
        }

        // GET: Quotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quote quotes = db.Quote.Find(id);
            if (quotes == null)
            {
                return HttpNotFound();
            }
            return View(quotes);
        }

        // POST: Quotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quote quote = db.Quote.Find(id);
            db.Quote.Remove(quote);
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
