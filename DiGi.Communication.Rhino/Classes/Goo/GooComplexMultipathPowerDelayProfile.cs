using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes.Goo
{
    public class GooComplexMultipathPowerDelayProfile : GooSerializableObject<IComplexMultipathPowerDelayProfile>
    {
        public GooComplexMultipathPowerDelayProfile()
            : base()
        {
        }

        public GooComplexMultipathPowerDelayProfile(IComplexMultipathPowerDelayProfile complexMultipathPowerDelayProfile)
            : base()
        {
            Value = complexMultipathPowerDelayProfile;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooComplexMultipathPowerDelayProfile(Value);
        }

    }

    public class GooComplexMultipathPowerDelayProfileParam : GooPresistentParam<GooComplexMultipathPowerDelayProfile, IComplexMultipathPowerDelayProfile>
    {
        public override Guid ComponentGuid => new Guid("c3503525-933d-400b-9958-410d9bf418e3");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooComplexMultipathPowerDelayProfileParam()
            : base()
        {
        }
    }
}
