using DiGi.Communication.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("ScatteringPointGroups", "ScatteringPointGroups", "ScatteringPointGroups")]
        public static IEnumerable ScatteringPointGroups(this Communication.Classes.Scattering scattering)
        {
            if (scattering == null)
            {
                return null;
            }

            return scattering.ScatteringPointGroups?.ConvertAll(x => new GooScatteringPointGroup(x));
        }

        [Inspect("Delay", "Delay", "Delay [μm]")]
        public static GH_Number Delay(this Communication.Classes.Scattering scattering)
        {
            if (scattering == null)
            {
                return null;
            }

            return new GH_Number(scattering.Delay * 1e6);
        }
    }
}
