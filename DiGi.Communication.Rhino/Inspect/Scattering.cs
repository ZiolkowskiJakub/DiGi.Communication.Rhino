using DiGi.Communication.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using System.Collections;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("ScatteringPointGroups", "ScatteringPointGroups", "ScatteringPointGroups")]
        public static IEnumerable ScatteringPoints(this Communication.Classes.Scattering scattering)
        {
            if (scattering == null)
            {
                return null;
            }

            return scattering.ScatteringPointGroups?.ConvertAll(x => new GooScatteringPointGroup(x));
        }
    }
}
