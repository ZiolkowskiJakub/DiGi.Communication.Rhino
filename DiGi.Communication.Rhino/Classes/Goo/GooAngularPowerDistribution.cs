using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for the <see cref="IAngularPowerDistribution"/> interface to enable its use within Grasshopper.
    /// </summary>
    public class GooAngularPowerDistribution : GooSerializableObject<IAngularPowerDistribution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooAngularPowerDistribution"/> class.
        /// </summary>
        public GooAngularPowerDistribution()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAngularPowerDistribution"/> class with the specified angular power distribution.
        /// </summary>
        /// <param name="angularPowerDistribution">The <see cref="IAngularPowerDistribution"/> instance to be wrapped.</param>
        public GooAngularPowerDistribution(IAngularPowerDistribution? angularPowerDistribution)
        {
            Value = angularPowerDistribution;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooAngularPowerDistribution(Value);
        }
    }

    /// <summary>
    /// The Grasshopper parameter component used to handle and transport <see cref="IAngularPowerDistribution"/> data.
    /// </summary>
    public class GooAngularPowerDistributionParam : GooPresistentParam<GooAngularPowerDistribution, IAngularPowerDistribution>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooAngularPowerDistributionParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("41062566-bf3b-4719-a019-31ea2d641cd1");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
