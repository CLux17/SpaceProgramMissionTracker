using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Model
{
    public class MissionNumber
    {
        public int MissionNumberId { get; set; }
        public string MissionIterationName { get; set; }

        public virtual int MissionId { get; set; }
    }
}
