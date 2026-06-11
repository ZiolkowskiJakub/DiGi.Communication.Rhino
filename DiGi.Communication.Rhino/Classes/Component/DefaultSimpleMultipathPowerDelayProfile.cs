using DiGi.Rhino.Core.Classes;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents the default simple multipath power delay profile component.
    /// </summary>
    public class DefaultSimpleMultipathPowerDelayProfile : EnumComponent<Enums.DefaultSimpleMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("c30e805f-e8b5-48ce-afec-cef8da091c62");

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSimpleMultipathPowerDelayProfile"/> class.
        /// </summary>
        public DefaultSimpleMultipathPowerDelayProfile()
          : base("Communication")
        {
        }
    }
}
