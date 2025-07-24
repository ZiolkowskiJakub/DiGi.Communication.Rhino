using DiGi.Communication.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooRay : GooBakeAwareSerializableObject<Ray>
    {
        public GooRay()
            : base()
        {
        }

        public GooRay(Ray ray)
        {
            Value = ray;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                Point3D point3D = Value?.Point;
                if (point3D == null)
                {
                    return null;
                }

                Vector3D vector3D = Value.Vector;
                if (vector3D == null)
                {
                    return null;
                }

                return [new Segment3D(point3D, vector3D)];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooRay(Value);
        }

    }

    public class GooRayParam : GooBakeAwareSerializableParam<GooRay, Ray>
    {
        public override Guid ComponentGuid => new Guid("5d3b6300-2aac-4ea5-9d6e-f009857c568a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
