using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes.Goo
{
    /// <summary>
    /// Represents a Goo wrapper for the simple multipath power delay profile.
    /// </summary>
    public class GooSimpleMultipathPowerDelayProfile : GooSerializableObject<ISimpleMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSimpleMultipathPowerDelayProfile"/> class.
        /// </summary>
        public GooSimpleMultipathPowerDelayProfile()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSimpleMultipathPowerDelayProfile"/> class with the specified profile.
        /// </summary>
        /// <param name="simpleMultipathPowerDelayProfile">The simple multipath power delay profile to wrap.</param>
        public GooSimpleMultipathPowerDelayProfile(ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile)
            : base()
        {
            Value = simpleMultipathPowerDelayProfile;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="IGH_Goo"/> containing the duplicated value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooSimpleMultipathPowerDelayProfile(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for the simple multipath power delay profile.
    /// </summary>
    public class GooSimpleMultipathPowerDelayProfileParam : GooPresistentParam<GooSimpleMultipathPowerDelayProfile, ISimpleMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("ff62f2a6-533b-498a-9b1d-fc8c7ad288dd");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSimpleMultipathPowerDelayProfileParam"/> class.
        /// </summary>
        public GooSimpleMultipathPowerDelayProfileParam()
            : base()
        {
        }
    }
}
