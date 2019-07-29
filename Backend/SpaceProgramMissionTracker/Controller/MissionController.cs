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
    public class MissionController : ControllerBase
    {
        private SiteContext db;

        public MissionController(SiteContext db)
        {
            this.db = db;
        }

        // GET api/Missions
        [HttpGet]
        public ActionResult<IEnumerable<Mission>> Get()
        {
            return db.Missions;
        }

        [HttpGet("{id}")]
        public ActionResult<Mission> GetById(int id)
        {
            return db.Missions.Single(a => a.MissionId == id);
        }

        // POST api/Mission
        [HttpPost]
        public ActionResult<IEnumerable<Mission>> Post([FromBody] Mission mission)
        {
            db.Missions.Add(mission);
            db.SaveChanges();
            return db.Missions.ToList();
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult<IEnumerable<Mission>> Put([FromBody] Mission mission)
        {
            db.Missions.Update(mission);
            db.SaveChanges();
            return db.Missions.ToList();
        }

        [HttpDelete]
        public ActionResult<IEnumerable<Mission>> Delete(Mission mission)
        {
            db.Missions.Remove(mission);
            db.SaveChanges();
            return db.Missions.ToList();
        }
    }
}
