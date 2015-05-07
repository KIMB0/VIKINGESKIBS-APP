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
    public class PrisersController : ApiController
    {
        private vikingeContext db = new vikingeContext();

        // GET: api/Prisers
        public IQueryable<Priser> GetPrisers()
        {
            return db.Prisers;
        }

        // GET: api/Prisers/5
        [ResponseType(typeof(Priser))]
        public IHttpActionResult GetPriser(int id)
        {
            Priser priser = db.Prisers.Find(id);
            if (priser == null)
            {
                return NotFound();
            }

            return Ok(priser);
        }

        // PUT: api/Prisers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPriser(int id, Priser priser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != priser.PrisID)
            {
                return BadRequest();
            }

            db.Entry(priser).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriserExists(id))
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

        // POST: api/Prisers
        [ResponseType(typeof(Priser))]
        public IHttpActionResult PostPriser(Priser priser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Prisers.Add(priser);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = priser.PrisID }, priser);
        }

        // DELETE: api/Prisers/5
        [ResponseType(typeof(Priser))]
        public IHttpActionResult DeletePriser(int id)
        {
            Priser priser = db.Prisers.Find(id);
            if (priser == null)
            {
                return NotFound();
            }

            db.Prisers.Remove(priser);
            db.SaveChanges();

            return Ok(priser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PriserExists(int id)
        {
            return db.Prisers.Count(e => e.PrisID == id) > 0;
        }
    }
}