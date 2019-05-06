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
    public class ProcessWindowsController : ApiController
    {
        private ActivityTrackerEntities db = new ActivityTrackerEntities();

        // GET: api/ProcessWindows
        public IQueryable<ProcessWindow> GetProcessWindows()
        {
            return db.ProcessWindows;
        }

        // GET: api/ProcessWindows/5
        [ResponseType(typeof(ProcessWindow))]
        public IHttpActionResult GetProcessWindow(int id)
        {
            ProcessWindow processWindow = db.ProcessWindows.Find(id);
            if (processWindow == null)
            {
                return NotFound();
            }

            return Ok(processWindow);
        }

        // PUT: api/ProcessWindows/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProcessWindow(int id, ProcessWindow processWindow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != processWindow.processWindowTitleID)
            {
                return BadRequest();
            }

            db.Entry(processWindow).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessWindowExists(id))
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

        // POST: api/ProcessWindows
        [ResponseType(typeof(ProcessWindow))]
        public IHttpActionResult PostProcessWindow(ProcessWindow processWindow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProcessWindows.Add(processWindow);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProcessWindowExists(processWindow.processWindowTitleID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = processWindow.processWindowTitleID }, processWindow);
        }

        // DELETE: api/ProcessWindows/5
        [ResponseType(typeof(ProcessWindow))]
        public IHttpActionResult DeleteProcessWindow(int id)
        {
            ProcessWindow processWindow = db.ProcessWindows.Find(id);
            if (processWindow == null)
            {
                return NotFound();
            }

            db.ProcessWindows.Remove(processWindow);
            db.SaveChanges();

            return Ok(processWindow);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProcessWindowExists(int id)
        {
            return db.ProcessWindows.Count(e => e.processWindowTitleID == id) > 0;
        }
    }
}