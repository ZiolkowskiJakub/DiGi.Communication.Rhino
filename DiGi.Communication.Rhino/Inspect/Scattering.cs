using DiGi.Communication.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Communication.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the scattering point groups from the provided scattering object and converts them to GooScatteringPointGroup instances.
        /// </summary>
        /// <param name="scattering">The scattering object to inspect.</param>
        /// <returns>A collection of scattering point groups, or null if the input is null.</returns>
        [Inspect("ScatteringPointGroups", "ScatteringPointGroups", "ScatteringPointGroups")]
        public static IEnumerable? ScatteringPointGroups(this Communication.Classes.Scattering? scattering)
        {
            if (scattering == null)
            {
                return null;
            }

            return scattering.ScatteringPointGroups?.ConvertAll(x => new GooScatteringPointGroup(x));
        }

        /// <summary>
        /// Retrieves the delay value from the provided scattering object, converted to micrometers (μm).
        /// </summary>
        /// <param name="scattering">The scattering object to inspect.</param>
        /// <returns>A GH_Number representing the delay in micrometers, or null if the input is null.</returns>
        [Inspect("Delay", "Delay", "Delay [μm]")]
        public static GH_Number? Delay(this Communication.Classes.Scattering? scattering)
        {
            if (scattering == null)
            {
                return null;
            }

            return new GH_Number(scattering.Delay * 1e6);
        }
    }
}
