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
        /// Retrieves the relative permittivity of the scattering object as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="scatteringObject">The <see cref="Interfaces.IScatteringObject"/> to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> containing the relative permittivity [-], or <c>null</c> if the scattering object is null.</returns>
        [Inspect("RelativePermittivity", "RelativePermittivity", "Relative permittivity [-]")]
        public static GH_Number? RelativePermittivity(this Interfaces.IScatteringObject? scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GH_Number(scatteringObject.RelativePermittivity);
        }

        /// <summary>
        /// Retrieves the electrical conductivity of the scattering object as a <see cref="GH_Number"/>.
        /// </summary>
        /// <param name="scatteringObject">The <see cref="Interfaces.IScatteringObject"/> to inspect.</param>
        /// <returns>A <see cref="GH_Number"/> containing the electrical conductivity [S/m], or <c>null</c> if the scattering object is null.</returns>
        [Inspect("ElectricalConductivity", "ElectricalConductivity", "Electrical conductivity [S/m]")]
        public static GH_Number? ElectricalConductivity(this Interfaces.IScatteringObject? scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GH_Number(scatteringObject.ElectricalConductivity);
        }
    }
}
