using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooAngularPowerDistribution : GooSerializableObject<IAngularPowerDistribution>
    {
        public GooAngularPowerDistribution()
            : base()
        {
        }

        public GooAngularPowerDistribution(IAngularPowerDistribution angularPowerDistribution)
        {
            Value = angularPowerDistribution;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooAngularPowerDistribution(Value);
        }
    }

    public class GooAngularPowerDistributionParam : GooPresistentParam<GooAngularPowerDistribution, IAngularPowerDistribution>
    {
        public override Guid ComponentGuid => new Guid("41062566-bf3b-4719-a019-31ea2d641cd1");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
