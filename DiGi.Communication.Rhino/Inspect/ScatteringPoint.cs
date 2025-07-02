using DiGi.Communication.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {
        [Inspect("Point", "Point", "Point")]
        public static GooPoint3D Point(this ScatteringPoint scatteringPoint)
        {
            if (scatteringPoint == null)
            {
                return null;
            }

            return new GooPoint3D(scatteringPoint.Point);
        }
    }
}
