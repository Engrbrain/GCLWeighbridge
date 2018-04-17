using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SAP_GCL.Models;

namespace SAP_GCL.Controllers
{
    public class GoodRecieptNotesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GoodRecieptNotes
        public ActionResult Index()
        {
            return View(db.GoodRecieptNotes.ToList());
        }

        // GET: GoodRecieptNotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodRecieptNote goodRecieptNote = db.GoodRecieptNotes.Find(id);
            if (goodRecieptNote == null)
            {
                return HttpNotFound();
            }
            return View(goodRecieptNote);
        }

        // GET: GoodRecieptNotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoodRecieptNotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,pstng_date,doc_date,pr_uname,ref_doc_no,material,plant,stge_loc,move_type,po_number,po_item,entry_qnt,entry_uom,ref_doc,prod_date,mvt_ind,gm_code,SAP_quantity")] GoodRecieptNote goodRecieptNote)
        {
            if (ModelState.IsValid)
            {
                db.GoodRecieptNotes.Add(goodRecieptNote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(goodRecieptNote);
        }

        // GET: GoodRecieptNotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodRecieptNote goodRecieptNote = db.GoodRecieptNotes.Find(id);
            if (goodRecieptNote == null)
            {
                return HttpNotFound();
            }
            return View(goodRecieptNote);
        }

        // POST: GoodRecieptNotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,pstng_date,doc_date,pr_uname,ref_doc_no,material,plant,stge_loc,move_type,po_number,po_item,entry_qnt,entry_uom,ref_doc,prod_date,mvt_ind,gm_code,SAP_quantity")] GoodRecieptNote goodRecieptNote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goodRecieptNote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(goodRecieptNote);
        }

        // GET: GoodRecieptNotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodRecieptNote goodRecieptNote = db.GoodRecieptNotes.Find(id);
            if (goodRecieptNote == null)
            {
                return HttpNotFound();
            }
            return View(goodRecieptNote);
        }

        // POST: GoodRecieptNotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GoodRecieptNote goodRecieptNote = db.GoodRecieptNotes.Find(id);
            db.GoodRecieptNotes.Remove(goodRecieptNote);
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
