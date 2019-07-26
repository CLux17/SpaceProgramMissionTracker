using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Model
{
    public class Mission
    {
        public int MissionId { get; set; }
        public string Name { get; set; }
                     
        public virtual int AgencyId { get; set; }
    }
}
