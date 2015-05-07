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
using VIKINGEdesignWEB;

namespace VIKINGEdesignWEB.Controllers
{
    public class KundersController : ApiController
    {
        private vikingeContext db = new vikingeContext();

        // GET: api/Kunders
        public IQueryable<Kunder> GetKunders()
        {
            return db.Kunders;
        }

        // GET: api/Kunders/5
        [ResponseType(typeof(Kunder))]
        public IHttpActionResult GetKunder(int id)
        {
            Kunder kunder = db.Kunders.Find(id);
            if (kunder == null)
            {
                return NotFound();
            }

            return Ok(kunder);
        }

        // PUT: api/Kunders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKunder(int id, Kunder kunder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kunder.KundeID)
            {
                return BadRequest();
            }

            db.Entry(kunder).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KunderExists(id))
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

        // POST: api/Kunders
        [ResponseType(typeof(Kunder))]
        public IHttpActionResult PostKunder(Kunder kunder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kunders.Add(kunder);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kunder.KundeID }, kunder);
        }

        // DELETE: api/Kunders/5
        [ResponseType(typeof(Kunder))]
        public IHttpActionResult DeleteKunder(int id)
        {
            Kunder kunder = db.Kunders.Find(id);
            if (kunder == null)
            {
                return NotFound();
            }

            db.Kunders.Remove(kunder);
            db.SaveChanges();

            return Ok(kunder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KunderExists(int id)
        {
            return db.Kunders.Count(e => e.KundeID == id) > 0;
        }
    }
}