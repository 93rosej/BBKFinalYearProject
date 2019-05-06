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
using TimeTrackWebAPI.Models;

namespace TimeTrackWebAPI.Controllers
{
    public class ProcessCategoriesController : ApiController
    {
        private ActivityTrackerEntities db = new ActivityTrackerEntities();

        // GET: api/ProcessCategories
        public IQueryable<ProcessCategory> GetProcessCategories()
        {
            return db.ProcessCategories;
        }

        // GET: api/ProcessCategories/5
        [ResponseType(typeof(ProcessCategory))]
        public IHttpActionResult GetProcessCategory(int id)
        {
            ProcessCategory processCategory = db.ProcessCategories.Find(id);
            if (processCategory == null)
            {
                return NotFound();
            }

            return Ok(processCategory);
        }

        // PUT: api/ProcessCategories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProcessCategory(int id, ProcessCategory processCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != processCategory.processCategoryID)
            {
                return BadRequest();
            }

            db.Entry(processCategory).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessCategoryExists(id))
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

        // POST: api/ProcessCategories
        [ResponseType(typeof(ProcessCategory))]
        public IHttpActionResult PostProcessCategory(ProcessCategory processCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProcessCategories.Add(processCategory);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProcessCategoryExists(processCategory.processCategoryID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = processCategory.processCategoryID }, processCategory);
        }

        // DELETE: api/ProcessCategories/5
        [ResponseType(typeof(ProcessCategory))]
        public IHttpActionResult DeleteProcessCategory(int id)
        {
            ProcessCategory processCategory = db.ProcessCategories.Find(id);
            if (processCategory == null)
            {
                return NotFound();
            }

            db.ProcessCategories.Remove(processCategory);
            db.SaveChanges();

            return Ok(processCategory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProcessCategoryExists(int id)
        {
            return db.ProcessCategories.Count(e => e.processCategoryID == id) > 0;
        }
    }
}