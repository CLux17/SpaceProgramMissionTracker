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
    public class AgencyStellarBodyController : ControllerBase
    {
        private SiteContext db;

        public AgencyStellarBodyController(SiteContext db)
        {
            this.db = db;
        }

        // GET api/Agenciess
        [HttpGet]
        public ActionResult<IEnumerable<AgencyStellarBody>> Get()
        {
            return db.AgencyStellarBodies;
        }

        [HttpGet("{id}")]
        public ActionResult<Agency> GetById(int id)
        {
            return db.Agencies.Single(a => a.AgencyId == id);
        }

        // POST api/Agency
        [HttpPost]
        public ActionResult<IEnumerable<Agency>> Post([FromBody] Agency agency)
        {
            db.Agencies.Add(agency);
            db.SaveChanges();
            return db.Agencies.ToList();
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult<IEnumerable<Agency>> Put([FromBody] Agency agency)
        {
            db.Agencies.Update(agency);
            db.SaveChanges();
            return db.Agencies.ToList();
        }

        [HttpDelete]
        public ActionResult<IEnumerable<Agency>> Delete(Agency agency)
        {
            db.Agencies.Remove(agency);
            db.SaveChanges();
            return db.Agencies.ToList();
        }
    }
}
