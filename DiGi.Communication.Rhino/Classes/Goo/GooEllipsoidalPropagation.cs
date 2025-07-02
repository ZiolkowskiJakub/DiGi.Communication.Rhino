using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooEllipsoidalPropagation : GooBakeAwareSerializableObject<Communication.Classes.EllipsoidalPropagation>
    {
        public GooEllipsoidalPropagation()
            : base()
        {
        }

        public GooEllipsoidalPropagation(Communication.Classes.EllipsoidalPropagation ellipsoidalPropagation)
        {
            Value = ellipsoidalPropagation;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                IGeometry geometry = Value?.GetEllipsoid();

                return geometry == null ? null : [geometry];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooEllipsoidalPropagation(Value);
        }

        public override bool CastFrom(object source)
        {
            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {
            //if (typeof(Y) == typeof(Communication.Classes.EllipsoidalPropagation))
            //{
            //    target = (Y)(object)Value;
            //    return true;
            //}

            //if (typeof(Y) == typeof(object))
            //{
            //    target = (Y)(object)Value;
            //    return true;
            //}

            //if (typeof(Y) == typeof(Geometry.Spatial.Classes.Ellipsoid))
            //{
            //    target = (Y)(object)Value?.GetEllipsoid();
            //    return true;
            //}

            return base.CastTo(ref target);
        }

    }

    public class GooEllipsoidalPropagationParam : GooBakeAwareSerializableParam<GooEllipsoidalPropagation, Communication.Classes.EllipsoidalPropagation>
    {
        public override Guid ComponentGuid => new Guid("87105436-f43a-4bf9-9c69-53d55caa8137");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
