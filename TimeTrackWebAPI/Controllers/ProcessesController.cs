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
    public class ProcessesController : ApiController
    {
        private ActivityTrackerEntities db = new ActivityTrackerEntities();

        // GET: api/Processes
        public IQueryable<Process> GetProcesses()
        {
            return db.Processes;
        }

        // GET: api/Processes/5
        [ResponseType(typeof(Process))]
        public IHttpActionResult GetProcess(int id)
        {
            Process process = db.Processes.Find(id);
            if (process == null)
            {
                return NotFound();
            }

            return Ok(process);
        }

        // PUT: api/Processes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProcess(int id, Process process)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != process.processID)
            {
                return BadRequest();
            }

            db.Entry(process).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessExists(id))
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

        // POST: api/Processes
        [ResponseType(typeof(Process))]
        public IHttpActionResult PostProcess(Process process)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Processes.Add(process);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProcessExists(process.processID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = process.processID }, process);
        }

        // DELETE: api/Processes/5
        [ResponseType(typeof(Process))]
        public IHttpActionResult DeleteProcess(int id)
        {
            Process process = db.Processes.Find(id);
            if (process == null)
            {
                return NotFound();
            }

            db.Processes.Remove(process);
            db.SaveChanges();

            return Ok(process);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProcessExists(int id)
        {
            return db.Processes.Count(e => e.processID == id) > 0;
        }
    }
}