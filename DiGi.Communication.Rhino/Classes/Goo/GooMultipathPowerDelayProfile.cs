using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes.Goo
{
    public class GooMultipathPowerDelayProfile : GooSerializableObject<IMultipathPowerDelayProfile>
    {
        public GooMultipathPowerDelayProfile()
            : base()
        {
        }

        public GooMultipathPowerDelayProfile(IMultipathPowerDelayProfile multipathPowerDelayProfile)
            : base()
        {
            Value = multipathPowerDelayProfile;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooMultipathPowerDelayProfile(Value);
        }

    }

    public class GooMultipathPowerDelayProfileParam : GooPresistentParam<GooMultipathPowerDelayProfile, IMultipathPowerDelayProfile>
    {
        public override Guid ComponentGuid => new Guid("f0a0fe3e-578d-43e2-8c06-cd3a23de6c1e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooMultipathPowerDelayProfileParam()
            : base()
        {
        }
    }
}
