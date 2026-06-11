using DiGi.Communication.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Communication.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the reference value from the specified <see cref="ScatteringPointGroup"/>.
        /// </summary>
        /// <param name="scatteringPointGroup">The scattering point group to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the reference, or null if the input is null.</returns>
        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String? Reference(this ScatteringPointGroup? scatteringPointGroup)
        {
            if (scatteringPointGroup == null)
            {
                return null;
            }

            return new GH_String(scatteringPointGroup.Reference);
        }

        /// <summary>
        /// Retrieves the collection of points from the specified <see cref="ScatteringPointGroup"/>.
        /// </summary>
        /// <param name="scatteringPointGroup">The scattering point group to inspect.</param>
        /// <returns>An <see cref="IEnumerable"/> containing the converted points, or null if the input is null.</returns>
        [Inspect("Points", "Points", "Points")]
        public static IEnumerable? ScatteringPoints(this ScatteringPointGroup? scatteringPointGroup)
        {
            if (scatteringPointGroup == null)
            {
                return null;
            }

            return scatteringPointGroup.Points?.ConvertAll(x => new GooPoint3D(x));
        }
    }
}
