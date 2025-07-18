using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("Vectors", "Vectors", "Vectors")]
        public static IEnumerable Vectors(this Interfaces.IAngularPowerDistribution angularPowerDistribution)
        {
            if (angularPowerDistribution == null)
            {
                return null;
            }

            return angularPowerDistribution.Vectors?.ConvertAll(x => new GooVector3D(x));
        }

        [Inspect("Delay", "Delay", "Delay [μm]")]
        public static GH_Number Delay(this Interfaces.IAngularPowerDistribution angularPowerDistribution)
        {
            if (angularPowerDistribution == null)
            {
                return null;
            }

            return new GH_Number(angularPowerDistribution.Delay * 1e6);
        }

        [Inspect("Power", "Power", "Power")]
        public static GH_Number Power(this Interfaces.IAngularPowerDistribution angularPowerDistribution)
        {
            if (angularPowerDistribution == null)
            {
                return null;
            }

            return new GH_Number(angularPowerDistribution.GetPower());
        }
    }
}
