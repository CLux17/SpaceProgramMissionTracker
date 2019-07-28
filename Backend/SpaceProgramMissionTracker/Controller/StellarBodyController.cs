using Microsoft.AspNetCore.Mvc;
using SpaceProgramMissionTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StellarBodyController : ControllerBase
    {
        private SiteContext db;

        public StellarBodyController(SiteContext db)
        {
            this.db = db;
        }

        // GET api/StellarBodiess
        [HttpGet]
        public ActionResult<IEnumerable<StellarBody>> Get()
        {
            return db.StellarBodies;
        }

        [HttpGet("{id}")]
        public ActionResult<StellarBody> GetById(int id)
        {
            return db.StellarBodies.Single(a => a.StellarBodyId == id);
        }

        // POST api/StellarBody
        [HttpPost]
        public ActionResult<IEnumerable<StellarBody>> Post([FromBody] StellarBody stellarbody)
        {
            db.StellarBodies.Add(stellarbody);
            db.SaveChanges();
            return db.StellarBodies.ToList();
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult<IEnumerable<StellarBody>> Put([FromBody] StellarBody stellarbody)
        {
            db.StellarBodies.Update(stellarbody);
            db.SaveChanges();
            return db.StellarBodies.ToList();
        }

        [HttpDelete]
        public ActionResult<IEnumerable<StellarBody>> Delete(StellarBody stellarbody)
        {
            db.StellarBodies.Remove(stellarbody);
            db.SaveChanges();
            return db.StellarBodies.ToList();
        }
    }
}
