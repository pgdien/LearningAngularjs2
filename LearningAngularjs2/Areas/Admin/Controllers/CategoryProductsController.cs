using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LearningAngularjs2.Models;

namespace LearningAngularjs2.Areas.Admin.Controllers
{
    public class CategoryProductsController : Controller
    {
        private CMS_db db = new CMS_db();

        // GET: Admin/CategoryProducts
        public ActionResult Index()
        {
            return View(db.CategoryProduct.ToList());
        }

        [AllowAnonymous]
        public JsonResult GetCategoryProduct()
        {
            db.Configuration.ProxyCreationEnabled = false;

            var model = db.CategoryProduct.Where(p => p.idCategoryParent == 1);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/CategoryProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryProduct categoryProduct = db.CategoryProduct.Find(id);
            if (categoryProduct == null)
            {
                return HttpNotFound();
            }
            return View(categoryProduct);
        }

        // GET: Admin/CategoryProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CategoryProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCategory,idCategoryParent,idUserCreated,idUserModified,timeCreated,timeModified,title,alias,note,description,published,image,tags,version,deleted,metadescription,metakewords,author,robots")] CategoryProduct categoryProduct)
        {
            if (ModelState.IsValid)
            {
                db.CategoryProduct.Add(categoryProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryProduct);
        }

        // GET: Admin/CategoryProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryProduct categoryProduct = db.CategoryProduct.Find(id);
            if (categoryProduct == null)
            {
                return HttpNotFound();
            }
            return View(categoryProduct);
        }

        // POST: Admin/CategoryProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCategory,idCategoryParent,idUserCreated,idUserModified,timeCreated,timeModified,title,alias,note,description,published,image,tags,version,deleted,metadescription,metakewords,author,robots")] CategoryProduct categoryProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryProduct);
        }

        // GET: Admin/CategoryProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryProduct categoryProduct = db.CategoryProduct.Find(id);
            if (categoryProduct == null)
            {
                return HttpNotFound();
            }
            return View(categoryProduct);
        }

        // POST: Admin/CategoryProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoryProduct categoryProduct = db.CategoryProduct.Find(id);
            db.CategoryProduct.Remove(categoryProduct);
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
