using SpaceProgramMissionTracker.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private SiteContext db;

        public AgencyController(SiteContext db)
        {
            this.db = db;
        }

        // GET api/Agenciess
        [HttpGet]
        public ActionResult<IEnumerable<Agency>> Get()
        {
            return db.Agencies;
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
