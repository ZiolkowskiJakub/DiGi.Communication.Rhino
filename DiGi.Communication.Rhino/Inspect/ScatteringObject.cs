using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {
        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String Reference(this Interfaces.IScatteringObject scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GH_String(scatteringObject.Reference);
        }

        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D Mesh3D(this Interfaces.IScatteringObject scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GooMesh3D(scatteringObject.Mesh3D);
        }

        [Inspect("ScatteringCoefficient", "ScatteringCoefficient", "Scattering coefficient")]
        public static GH_Number ScatteringCoefficient(this Interfaces.IScatteringObject scatteringObject)
        {
            if (scatteringObject == null)
            {
                return null;
            }

            return new GH_Number(scatteringObject.ScatteringCoefficient);
        }
    }
}
