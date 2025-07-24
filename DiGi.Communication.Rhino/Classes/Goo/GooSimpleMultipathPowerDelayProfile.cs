using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes.Goo
{
    public class GooSimpleMultipathPowerDelayProfile : GooSerializableObject<ISimpleMultipathPowerDelayProfile>
    {
        public GooSimpleMultipathPowerDelayProfile()
            : base()
        {
        }

        public GooSimpleMultipathPowerDelayProfile(ISimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile)
            : base()
        {
            Value = simpleMultipathPowerDelayProfile;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooSimpleMultipathPowerDelayProfile(Value);
        }

    }

    public class GooSimpleMultipathPowerDelayProfileParam : GooPresistentParam<GooSimpleMultipathPowerDelayProfile, ISimpleMultipathPowerDelayProfile>
    {
        public override Guid ComponentGuid => new Guid("ff62f2a6-533b-498a-9b1d-fc8c7ad288dd");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooSimpleMultipathPowerDelayProfileParam()
            : base()
        {
        }
    }
}
