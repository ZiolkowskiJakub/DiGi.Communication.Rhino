using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes.Goo
{
    /// <summary>
    /// Represents a Goo wrapper for a complex multipath power delay profile.
    /// </summary>
    public class GooComplexMultipathPowerDelayProfile : GooSerializableObject<IComplexMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooComplexMultipathPowerDelayProfile"/> class.
        /// </summary>
        public GooComplexMultipathPowerDelayProfile()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooComplexMultipathPowerDelayProfile"/> class with the specified value.
        /// </summary>
        /// <param name="complexMultipathPowerDelayProfile">The complex multipath power delay profile to wrap.</param>
        public GooComplexMultipathPowerDelayProfile(IComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile)
            : base()
        {
            Value = complexMultipathPowerDelayProfile;
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A duplicated <see cref="IGH_Goo"/> instance.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooComplexMultipathPowerDelayProfile(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for the complex multipath power delay profile.
    /// </summary>
    public class GooComplexMultipathPowerDelayProfileParam : GooPresistentParam<GooComplexMultipathPowerDelayProfile, IComplexMultipathPowerDelayProfile>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        /// <returns>The unique <see cref="Guid"/> of the component.</returns>
        public override Guid ComponentGuid => new("c3503525-933d-400b-9958-410d9bf418e3");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooComplexMultipathPowerDelayProfileParam"/> class.
        /// </summary>
        public GooComplexMultipathPowerDelayProfileParam()
            : base()
        {
        }
    }
}
