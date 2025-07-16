using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("Delays", "Delays", "Delays [μm]")]
        public static IEnumerable Delays(this Interfaces.ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile)
        {
            if (simpleMultipathPowerDelayProfile == null)
            {
                return null;
            }

            HashSet<double> delays = simpleMultipathPowerDelayProfile.Delays;
            if(delays == null)
            {
                return null;
            }

            List<GH_Number> result = new List<GH_Number>();
            foreach (double delay in delays)
            {
                result.Add(new GH_Number(delay * 1e6));
            }

            return result;
        }

        [Inspect("Powers", "Powers", "Powers")]
        public static IEnumerable Powers(this Interfaces.ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile)
        {
            if (simpleMultipathPowerDelayProfile == null)
            {
                return null;
            }

            HashSet<double> delays = simpleMultipathPowerDelayProfile.Delays;
            if (delays == null)
            {
                return null;
            }

            List<GH_Number> result = new List<GH_Number>();
            foreach (double delay in delays)
            {
                result.Add(new GH_Number(simpleMultipathPowerDelayProfile.GetPower(delay)));
            }

            return result;
        }
    }
}
