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
            var model = new GoodMovementSelectionViewModel();
            foreach (var goodMovement in db.GoodMovement)
            {
                var editorViewModel = new SelectGoodMovementEditorViewModel()
                {
                    ID = goodMovement.ID,
                    ChangedBy = goodMovement.ChangedBy,
                    Changed_Quantity = goodMovement.Changed_Quantity,
                    Changed_Weight = goodMovement.Changed_Weight,
                    doc_date = goodMovement.doc_date,
                    entry_qnt = goodMovement.entry_qnt,
                    entry_uom = goodMovement.entry_uom,
                    gm_code = goodMovement.gm_code,
                    material = goodMovement.material,
                    move_reas = goodMovement.move_reas,
                    move_type = goodMovement.move_type,
                    mvt_ind = goodMovement.mvt_ind,
                    plant = goodMovement.plant,
                    po_item = goodMovement.po_item,
                    po_number = goodMovement.po_number,
                    pr_uname = goodMovement.pr_uname,
                    pstng_date = goodMovement.pstng_date,
                    ReasonForChange = goodMovement.ReasonForChange,
                    ref_doc_no = goodMovement.ref_doc_no,
                    SAP_quantity = goodMovement.SAP_quantity,
                    stge_loc = goodMovement.stge_loc,
                    Selected = true
                };
                model.GoodMovements.Add(editorViewModel);
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult SubmitSelected(GoodMovementSelectionViewModel model)
        {
            // get the ids of the items selected:
            var selectedIds = model.getSelectedIds();
            // Use the ids to retrieve the records for the selected people
            // from the database:
            var selectedGoodsMovement = from x in db.GoodMovement
                                 where selectedIds.Contains(x.ID)
                                 select x;
            // Process according to your requirements:
           /* foreach (var person in selectedPeople)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format("{0} {1}", person.firstName, person.LastName));
            }*/
            // Redirect somewhere meaningful (probably to somewhere showing 
            // the results of your processing):
            return RedirectToAction("Index");
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
