using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooAntenna : GooBakeAwareSerializableObject<IAntenna>
    {
        public GooAntenna()
            : base()
        {
        }

        public GooAntenna(IAntenna antenna)
        {
            Value = antenna;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                Point3D point3D = Value?.Location;


                return point3D == null ? null : [point3D];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooAntenna(Value);
        }

    }

    public class GooAntennaParam : GooBakeAwareSerializableParam<GooAntenna, IAntenna>
    {
        public override Guid ComponentGuid => new Guid("adfd6214-0454-4a7c-8cdc-c8341fd41d17");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
