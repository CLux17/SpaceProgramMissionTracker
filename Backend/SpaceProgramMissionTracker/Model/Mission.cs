using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Model
{
    public class Mission
    {
        public int MissionId { get; set; }
        public string MissionName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        public virtual int AgencyId { get; set; }
        public virtual int StellarBodyId { get; set; }
        //public virtual List<MissionNumber> MissionNumbers { get; set; }
    }
}
