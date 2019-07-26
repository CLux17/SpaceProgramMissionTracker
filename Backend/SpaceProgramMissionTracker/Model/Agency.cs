using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Model
{
    public class Agency
    {
        public int AgencyId { get; set; }
        public string Name { get; set; }

        public virtual List<AgencyStellarBody> AgencyStellarBodyList { get; set; }
        public virtual List<Mission> Missions { get; set; }
    }
    
}
