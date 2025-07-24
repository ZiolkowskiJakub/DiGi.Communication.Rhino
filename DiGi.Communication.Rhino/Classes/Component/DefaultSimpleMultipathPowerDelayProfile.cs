using DiGi.Rhino.Core.Classes;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class DefaultSimpleMultipathPowerDelayProfile : EnumComponent<Enums.DefaultSimpleMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("c30e805f-e8b5-48ce-afec-cef8da091c62");

        /// <summary>
        /// Panel Type
        /// </summary>
        public DefaultSimpleMultipathPowerDelayProfile()
          : base("Communication")
        {
        }
    }
}

