using DiGi.Communication.Rhino.Classes.Goo;
using DiGi.Rhino.Core.Classes;

namespace DiGi.Communication.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Returns a GooSimpleMultipathPowerDelayProfile for the case where antennas are visible.
        /// </summary>
        /// <param name="complexMultipathPowerDelayProfile">The complex multipath power delay profile to inspect.</param>
        /// <returns>A <see cref="GooSimpleMultipathPowerDelayProfile"/> instance if successful; otherwise, null.</returns>
        [Inspect("SimpleMultipathPowerDelayProfile_Visible", "SimpleMultipathPowerDelayProfile_Visible", "SimpleMultipathPowerDelayProfile for case where antennas are visible")]
        public static GooSimpleMultipathPowerDelayProfile? SimpleMultipathPowerDelayProfile_Visible(this Interfaces.IComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile)
        {
            if (complexMultipathPowerDelayProfile == null)
            {
                return null;
            }

            Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile = complexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(true);

            return simpleMultipathPowerDelayProfile == null ? null : new GooSimpleMultipathPowerDelayProfile(simpleMultipathPowerDelayProfile);
        }

        /// <summary>
        /// Returns a GooSimpleMultipathPowerDelayProfile for the case where antennas are hidden.
        /// </summary>
        /// <param name="complexMultipathPowerDelayProfile">The complex multipath power delay profile to inspect.</param>
        /// <returns>A <see cref="GooSimpleMultipathPowerDelayProfile"/> instance if successful; otherwise, null.</returns>
        [Inspect("SimpleMultipathPowerDelayProfile_Hidden", "SimpleMultipathPowerDelayProfile_Hidden", "SimpleMultipathPowerDelayProfile for case where antennas are hidden")]
        public static GooSimpleMultipathPowerDelayProfile? SimpleMultipathPowerDelayProfile_Hidden(this Interfaces.IComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile)
        {
            if (complexMultipathPowerDelayProfile == null)
            {
                return null;
            }

            Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile = complexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(false);

            return simpleMultipathPowerDelayProfile == null ? null : new GooSimpleMultipathPowerDelayProfile(simpleMultipathPowerDelayProfile);
        }
    }
}
