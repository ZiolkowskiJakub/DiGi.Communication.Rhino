using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes.Goo
{
    /// <summary>
    /// Represents a Goo wrapper for an <see cref="IMultipathPowerDelayProfile"/>.
    /// </summary>
    public class GooMultipathPowerDelayProfile : GooSerializableObject<IMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooMultipathPowerDelayProfile"/> class.
        /// </summary>
        public GooMultipathPowerDelayProfile()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooMultipathPowerDelayProfile"/> class with the specified multipath power delay profile.
        /// </summary>
        /// <param name="multipathPowerDelayProfile">The multipath power delay profile to wrap.</param>
        public GooMultipathPowerDelayProfile(IMultipathPowerDelayProfile? multipathPowerDelayProfile)
            : base()
        {
            Value = multipathPowerDelayProfile;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A duplicate <see cref="IGH_Goo"/> object.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooMultipathPowerDelayProfile(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for the <see cref="GooMultipathPowerDelayProfile"/>.
    /// </summary>
    public class GooMultipathPowerDelayProfileParam : GooPresistentParam<GooMultipathPowerDelayProfile, IMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("f0a0fe3e-578d-43e2-8c06-cd3a23de6c1e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooMultipathPowerDelayProfileParam"/> class.
        /// </summary>
        public GooMultipathPowerDelayProfileParam()
            : base()
        {
        }
    }
}
