using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;
using System.Linq;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooScattering : GooBakeAwareSerializableObject<Communication.Classes.Scattering>
    {
        public GooScattering()
            : base()
        {
        }

        public GooScattering(Communication.Classes.Scattering scattering)
        {
            Value = scattering;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                return Value?.GetPolylines()?.ToArray<IGeometry>();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooScattering(Value);
        }

    }

    public class GooScatteringParam : GooBakeAwareSerializableParam<GooScattering, Communication.Classes.Scattering>
    {
        public override Guid ComponentGuid => new Guid("760f3e12-4622-4efb-862f-90e15b7532b8");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
