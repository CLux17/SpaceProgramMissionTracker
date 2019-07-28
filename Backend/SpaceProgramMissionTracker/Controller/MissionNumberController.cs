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
    public class MissionNumberController : ControllerBase
    {
        private SiteContext db;

        public MissionNumberController(SiteContext db)
        {
            this.db = db;
        }

        // GET api/MissionNumbers
        [HttpGet]
        public ActionResult<IEnumerable<MissionNumber>> Get()
        {
            return db.MissionNumbers;
        }

        [HttpGet("{id}")]
        public ActionResult<MissionNumber> GetById(int id)
        {
            return db.MissionNumbers.Single(a => a.MissionNumberId == id);
        }

        // POST api/MissionNumber
        [HttpPost]
        public ActionResult<IEnumerable<MissionNumber>> Post([FromBody] MissionNumber missionnumber)
        {
            db.MissionNumbers.Add(missionnumber);
            db.SaveChanges();
            return db.MissionNumbers.ToList();
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult<IEnumerable<MissionNumber>> Put([FromBody] MissionNumber missionnumber)
        {
            db.MissionNumbers.Update(missionnumber);
            db.SaveChanges();
            return db.MissionNumbers.ToList();
        }

        [HttpDelete]
        public ActionResult<IEnumerable<MissionNumber>> Delete(MissionNumber missionnumber)
        {
            db.MissionNumbers.Remove(missionnumber);
            db.SaveChanges();
            return db.MissionNumbers.ToList();
        }
    }
}
