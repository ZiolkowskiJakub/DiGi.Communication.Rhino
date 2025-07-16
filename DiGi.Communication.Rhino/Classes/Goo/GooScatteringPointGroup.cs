using DiGi.Communication.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;
using System.Linq;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooScatteringPointGroup : GooBakeAwareSerializableObject<ScatteringPointGroup>
    {
        public GooScatteringPointGroup()
            : base()
        {
        }

        public GooScatteringPointGroup(ScatteringPointGroup scatteringPointGroup)
        {
            Value = scatteringPointGroup;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                return Value?.Points?.ToArray<IGeometry>();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooScatteringPointGroup(Value);
        }

    }

    public class GooScatteringPointGroupParam : GooBakeAwareSerializableParam<GooScatteringPointGroup, ScatteringPointGroup>
    {
        public override Guid ComponentGuid => new Guid("b7f65893-bb53-46f1-8538-cdb9d0ac5c81");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
