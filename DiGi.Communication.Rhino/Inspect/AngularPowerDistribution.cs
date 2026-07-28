using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the vectors associated with the specified angular power distribution.
        /// </summary>
        /// <param name="angularPowerDistribution">The angular power distribution instance.</param>
        /// <returns>A collection of vectors converted to GooVector3D, or null if the input is null.</returns>
        [Inspect("Vectors", "Vectors", "Vectors")]
        public static IEnumerable? Vectors(this Interfaces.IAngularPowerDistribution? angularPowerDistribution)
        {
            if (angularPowerDistribution == null) 
            {
                return null;
            }

            if (angularPowerDistribution.Vectors is not IEnumerable<Geometry.Spatial.Classes.Vector3D> vector3Ds)
            {
                return null;
            }

            List<GooVector3D> result = [];

            foreach(Geometry.Spatial.Classes.Vector3D vector3D in vector3Ds)
            {
                result.Add(new GooVector3D(vector3D));
            }

            return result;
            //return angularPowerDistribution.Vectors?.ConvertAll(x => new GooVector3D(x));
        }

        /// <summary>
        /// Gets the delay value in micrometers for the specified angular power distribution.
        /// </summary>
        /// <param name="angularPowerDistribution">The angular power distribution instance.</param>
        /// <returns>The delay as a GH_Number in micrometers, or null if the input is null.</returns>
        [Inspect("Delay", "Delay", "Delay [μm]")]
        public static GH_Number? Delay(this Interfaces.IAngularPowerDistribution? angularPowerDistribution)
        {
            if (angularPowerDistribution == null)
            {
                return null;
            }

            return new GH_Number(angularPowerDistribution.Delay * 1e6);
        }
    }
}
