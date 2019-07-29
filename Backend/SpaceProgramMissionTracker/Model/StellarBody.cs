using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Model
{
    public class StellarBody
    {
        public int StellarBodyId { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        public virtual List<Mission> Missions { get; set; }
    }
}
