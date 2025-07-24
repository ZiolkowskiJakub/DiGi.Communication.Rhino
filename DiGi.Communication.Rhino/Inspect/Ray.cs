using DiGi.Communication.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("Vector", "Vector", "Vector")]
        public static GooVector3D Vector(this Ray ray)
        {
            if (ray == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Vector3D vector = ray.Vector;
        
            return vector == null ? null : new GooVector3D(vector);
        }

        [Inspect("Point", "Point", "Point")]
        public static GooPoint3D Point(this Ray ray)
        {
            if (ray == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D point = ray.Point;

            return point == null ? null : new GooPoint3D(point);
        }

        [Inspect("Segment", "Segment", "Segment")]
        public static GooSegment3D Segment(this Ray ray)
        {
            if (ray == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D point = ray.Point;
            Geometry.Spatial.Classes.Vector3D vector = ray.Vector;

            return point == null || vector == null ? null : new GooSegment3D(new Geometry.Spatial.Classes.Segment3D(point, vector));
        }
    }
}
