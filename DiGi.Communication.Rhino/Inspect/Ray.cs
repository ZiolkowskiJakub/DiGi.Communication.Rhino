using DiGi.Communication.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;

namespace DiGi.Communication.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the vector from the specified <see cref="Ray"/> and converts it to a <see cref="GooVector3D"/>.
        /// </summary>
        /// <param name="ray">The <see cref="Ray"/> to extract the vector from.</param>
        /// <returns>A <see cref="GooVector3D"/> representing the ray's vector, or <see langword="null"/> if the ray is null or the vector is null.</returns>
        [Inspect("Vector", "Vector", "Vector")]
        public static GooVector3D? Vector(this Ray? ray)
        {
            if (ray == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Vector3D? vector = ray.Vector;

            return vector == null ? null : new GooVector3D(vector);
        }

        /// <summary>
        /// Extracts the point from the specified <see cref="Ray"/> and converts it to a <see cref="GooPoint3D"/>.
        /// </summary>
        /// <param name="ray">The <see cref="Ray"/> to extract the point from.</param>
        /// <returns>A <see cref="GooPoint3D"/> representing the ray's origin point, or <see langword="null"/> if the ray is null or the point is null.</returns>
        [Inspect("Point", "Point", "Point")]
        public static GooPoint3D? Point(this Ray? ray)
        {
            if (ray == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D? point = ray.Point;

            return point == null ? null : new GooPoint3D(point);
        }

        /// <summary>
        /// Creates a segment from the specified <see cref="Ray"/> and converts it to a <see cref="GooSegment3D"/>.
        /// </summary>
        /// <param name="ray">The <see cref="Ray"/> used to define the segment.</param>
        /// <returns>A <see cref="GooSegment3D"/> representing the ray's point and vector, or <see langword="null"/> if the ray, its point, or its vector is null.</returns>
        [Inspect("Segment", "Segment", "Segment")]
        public static GooSegment3D? Segment(this Ray? ray)
        {
            if (ray == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D? point = ray.Point;
            Geometry.Spatial.Classes.Vector3D? vector = ray.Vector;

            return point == null || vector == null ? null : new GooSegment3D(new Geometry.Spatial.Classes.Segment3D(point, vector));
        }
    }
}
