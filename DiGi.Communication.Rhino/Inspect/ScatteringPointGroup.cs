using DiGi.Communication.Classes;
using DiGi.Communication.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {
        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String Reference(this ScatteringPointGroup scatteringPointGroup)
        {
            if (scatteringPointGroup == null)
            {
                return null;
            }

            return new GH_String(scatteringPointGroup.Reference);
        }

        [Inspect("ScatteringPoints", "ScatteringPoints", "ScatteringPoints")]
        public static IEnumerable ScatteringPoints(this ScatteringPointGroup scatteringPointGroup)
        {
            if (scatteringPointGroup == null)
            {
                return null;
            }

            return scatteringPointGroup.ScatteringPoints?.ConvertAll(x => new GooScatteringPoint(x));
        }
    }
}
