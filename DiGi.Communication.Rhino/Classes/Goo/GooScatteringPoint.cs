using DiGi.Communication.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooScatteringPoint : GooBakeAwareSerializableObject<ScatteringPoint>
    {
        public GooScatteringPoint()
            : base()
        {
        }

        public GooScatteringPoint(ScatteringPoint scatteringPoint)
        {
            Value = scatteringPoint;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                IGeometry geometry = Value?.Point;

                return geometry == null ? null : [geometry];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooScatteringPoint(Value);
        }

    }

    public class GooScatteringPointParam : GooBakeAwareSerializableParam<GooScatteringPoint, ScatteringPoint>
    {
        public override Guid ComponentGuid => new Guid("0994aa57-003d-4483-b565-797730c33fe0");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
