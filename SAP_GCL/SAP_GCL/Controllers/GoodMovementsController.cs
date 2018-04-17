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
    public class GoodMovementsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: GoodMovements
        public ActionResult Index()
        {
            return View(db.GoodMovement.ToList());
        }

        // GET: GoodMovements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodMovement goodMovement = db.GoodMovement.Find(id);
            if (goodMovement == null)
            {
                return HttpNotFound();
            }
            return View(goodMovement);
        }

        // GET: GoodMovements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoodMovements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,pstng_date,doc_date,pr_uname,ref_doc_no,material,plant,stge_loc,move_type,po_number,po_item,entry_qnt,entry_uom,ref_doc,prod_date,mvt_ind,gm_code,SAP_quantity,move_reas")] GoodMovement goodMovement)
        {
            if (ModelState.IsValid)
            {
                db.GoodMovement.Add(goodMovement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(goodMovement);
        }

        // GET: GoodMovements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodMovement goodMovement = db.GoodMovement.Find(id);
            if (goodMovement == null)
            {
                return HttpNotFound();
            }
            return View(goodMovement);
        }

        // POST: GoodMovements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,pstng_date,doc_date,pr_uname,ref_doc_no,material,plant,stge_loc,move_type,po_number,po_item,entry_qnt,entry_uom,ref_doc,prod_date,mvt_ind,gm_code,SAP_quantity,move_reas")] GoodMovement goodMovement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goodMovement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(goodMovement);
        }

        // GET: GoodMovements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodMovement goodMovement = db.GoodMovement.Find(id);
            if (goodMovement == null)
            {
                return HttpNotFound();
            }
            return View(goodMovement);
        }

        // POST: GoodMovements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GoodMovement goodMovement = db.GoodMovement.Find(id);
            db.GoodMovement.Remove(goodMovement);
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
