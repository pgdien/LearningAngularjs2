using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LearningAngularjs2.Models;

namespace LearningAngularjs2.Areas.Admin.Controllers
{
    public class CategoryProductsAPIController : ApiController
    {
        private CMS_db db = new CMS_db();

        // GET: api/CategoryProductsAPI
        public IQueryable<CategoryProduct> GetCategoryProduct()
        {
            return db.CategoryProduct;
        }

        // GET: api/CategoryProductsAPI/5
        [ResponseType(typeof(CategoryProduct))]
        public IHttpActionResult GetCategoryProduct(int id)
        {
            CategoryProduct categoryProduct = db.CategoryProduct.Find(id);
            if (categoryProduct == null)
            {
                return NotFound();
            }

            return Ok(categoryProduct);
        }

        // PUT: api/CategoryProductsAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCategoryProduct(int id, CategoryProduct categoryProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categoryProduct.idCategory)
            {
                return BadRequest();
            }

            db.Entry(categoryProduct).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CategoryProductsAPI
        [ResponseType(typeof(CategoryProduct))]
        public IHttpActionResult PostCategoryProduct(CategoryProduct categoryProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CategoryProduct.Add(categoryProduct);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = categoryProduct.idCategory }, categoryProduct);
        }

        // DELETE: api/CategoryProductsAPI/5
        [ResponseType(typeof(CategoryProduct))]
        public IHttpActionResult DeleteCategoryProduct(int id)
        {
            CategoryProduct categoryProduct = db.CategoryProduct.Find(id);
            if (categoryProduct == null)
            {
                return NotFound();
            }

            db.CategoryProduct.Remove(categoryProduct);
            db.SaveChanges();

            return Ok(categoryProduct);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CategoryProductExists(int id)
        {
            return db.CategoryProduct.Count(e => e.idCategory == id) > 0;
        }
    }
}