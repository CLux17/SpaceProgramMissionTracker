using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker.Model
{
    public class AgencyStellarBody
    {
        public int AgencyStellarBodyId { get; set; }
        public virtual int StellarBodyId { get; set; }
        public virtual int AgencyId { get; set; }

        public virtual Agency Agency { get; set; }
        public virtual StellarBody StellarBody { get; set; }
    }
}
