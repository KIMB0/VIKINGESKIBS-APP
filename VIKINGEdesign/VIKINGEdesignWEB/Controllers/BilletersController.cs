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
    public class BilletersController : ApiController
    {
        private VikingeContext db = new VikingeContext();

        // GET: api/Billeters
        public IQueryable<Billeter> GetBilleters()
        {
            return db.Billeters;
        }

        // GET: api/Billeters/5
        [ResponseType(typeof(Billeter))]
        public IHttpActionResult GetBilleter(int id)
        {
            Billeter billeter = db.Billeters.Find(id);
            if (billeter == null)
            {
                return NotFound();
            }

            return Ok(billeter);
        }

        // PUT: api/Billeters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBilleter(int id, Billeter billeter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != billeter.BilletID)
            {
                return BadRequest();
            }

            db.Entry(billeter).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BilleterExists(id))
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

        // POST: api/Billeters
        [ResponseType(typeof(Billeter))]
        public IHttpActionResult PostBilleter(Billeter billeter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Billeters.Add(billeter);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = billeter.BilletID }, billeter);
        }

        // DELETE: api/Billeters/5
        [ResponseType(typeof(Billeter))]
        public IHttpActionResult DeleteBilleter(int id)
        {
            Billeter billeter = db.Billeters.Find(id);
            if (billeter == null)
            {
                return NotFound();
            }

            db.Billeters.Remove(billeter);
            db.SaveChanges();

            return Ok(billeter);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BilleterExists(int id)
        {
            return db.Billeters.Count(e => e.BilletID == id) > 0;
        }
    }
}