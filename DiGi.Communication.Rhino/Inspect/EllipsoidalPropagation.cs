using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {
        [Inspect("B", "B", "B")]
        public static GH_Number B(this Communication.Classes.EllipsoidalPropagation ellipsoidalPropagation)
        {
            if (ellipsoidalPropagation == null)
            {
                return null;
            }

            return new GH_Number(ellipsoidalPropagation.B);
        }

        [Inspect("Ellipsoid", "Ellipsoid", "Ellipsoid")]
        public static GooEllipsoid Ellipsoid(this Communication.Classes.EllipsoidalPropagation ellipsoidalPropagation)
        {
            if (ellipsoidalPropagation == null)
            {
                return null;
            }

            return new GooEllipsoid(ellipsoidalPropagation.GetEllipsoid());
        }

        [Inspect("Location_1", "Location_1", "Location_1")]
        public static GooPoint3D Location_1(this Communication.Classes.EllipsoidalPropagation ellipsoidalPropagation)
        {
            if (ellipsoidalPropagation == null)
            {
                return null;
            }

            return new GooPoint3D(ellipsoidalPropagation.Location_1);
        }

        [Inspect("Location_2", "Location_2", "Location_2")]
        public static GooPoint3D Location_2(this Communication.Classes.EllipsoidalPropagation ellipsoidalPropagation)
        {
            if (ellipsoidalPropagation == null)
            {
                return null;
            }

            return new GooPoint3D(ellipsoidalPropagation.Location_2);
        }
    }
}
