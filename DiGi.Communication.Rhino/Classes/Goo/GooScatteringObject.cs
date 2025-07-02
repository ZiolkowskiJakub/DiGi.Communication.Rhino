using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooScatteringObject : GooBakeAwareSerializableObject<IScatteringObject>
    {
        public GooScatteringObject()
            : base()
        {
        }

        public GooScatteringObject(IScatteringObject scattering)
        {
            Value = scattering;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                Mesh3D mesh3D = Value?.Mesh3D;

                return mesh3D == null ? null : [mesh3D];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooScatteringObject(Value);
        }

    }

    public class GooScatteringObjectParam : GooBakeAwareSerializableParam<GooScatteringObject, IScatteringObject>
    {
        public override Guid ComponentGuid => new Guid("dcaba3c2-38c2-4520-817d-a6f157277457");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
