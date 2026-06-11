using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Communication.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the reference of the scattering object as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="scatteringObject">The <see cref="Interfaces.IScatteringObject"/> to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the reference, or <c>null</c> if the scattering object is null.</returns>
        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String? Reference(this Interfaces.IScatteringObject? scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GH_String(scatteringObject.Reference);
        }

        /// <summary>
        /// Retrieves the mesh 3D geometry of the scattering object as a <see cref="GooMesh3D"/>.
        /// </summary>
        /// <param name="scatteringObject">The <see cref="Interfaces.IScatteringObject"/> to inspect.</param>
        /// <returns>A <see cref="GooMesh3D"/> representing the mesh, or <c>null</c> if the scattering object is null.</returns>
        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D? Mesh3D(this Interfaces.IScatteringObject? scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GooMesh3D(scatteringObject.Mesh3D);
        }

        /// <summary>
        /// Retrieves the scattering coefficient of the scattering object as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="scatteringObject">The <see cref="Interfaces.IScatteringObject"/> to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> containing the coefficient, or <c>null</c> if the scattering object is null.</returns>
        [Inspect("ScatteringCoefficient", "ScatteringCoefficient", "Scattering coefficient")]
        public static GH_Number? ScatteringCoefficient(this Interfaces.IScatteringObject? scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GH_Number(scatteringObject.ScatteringCoefficient);
        }
    }
}
