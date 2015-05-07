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
    public class VikingeSkibesController : ApiController
    {
        private vikingeContext db = new vikingeContext();

        // GET: api/VikingeSkibes
        public IQueryable<VikingeSkibe> GetVikingeSkibes()
        {
            return db.VikingeSkibes;
        }

        // GET: api/VikingeSkibes/5
        [ResponseType(typeof(VikingeSkibe))]
        public IHttpActionResult GetVikingeSkibe(int id)
        {
            VikingeSkibe vikingeSkibe = db.VikingeSkibes.Find(id);
            if (vikingeSkibe == null)
            {
                return NotFound();
            }

            return Ok(vikingeSkibe);
        }

        // PUT: api/VikingeSkibes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVikingeSkibe(int id, VikingeSkibe vikingeSkibe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vikingeSkibe.VikingeSkibeID)
            {
                return BadRequest();
            }

            db.Entry(vikingeSkibe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VikingeSkibeExists(id))
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

        // POST: api/VikingeSkibes
        [ResponseType(typeof(VikingeSkibe))]
        public IHttpActionResult PostVikingeSkibe(VikingeSkibe vikingeSkibe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VikingeSkibes.Add(vikingeSkibe);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vikingeSkibe.VikingeSkibeID }, vikingeSkibe);
        }

        // DELETE: api/VikingeSkibes/5
        [ResponseType(typeof(VikingeSkibe))]
        public IHttpActionResult DeleteVikingeSkibe(int id)
        {
            VikingeSkibe vikingeSkibe = db.VikingeSkibes.Find(id);
            if (vikingeSkibe == null)
            {
                return NotFound();
            }

            db.VikingeSkibes.Remove(vikingeSkibe);
            db.SaveChanges();

            return Ok(vikingeSkibe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VikingeSkibeExists(int id)
        {
            return db.VikingeSkibes.Count(e => e.VikingeSkibeID == id) > 0;
        }
    }
}