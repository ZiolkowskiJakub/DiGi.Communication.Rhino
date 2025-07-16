using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooScatteringProfile : GooBakeAwareSerializableObject<IScatteringProfile>
    {
        public GooScatteringProfile()
            : base()
        {
        }

        public GooScatteringProfile(IScatteringProfile scatteringProfile)
        {
            Value = scatteringProfile;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                IEnumerable<Scattering> scatterings = Value?.Scatterings;
                if(scatterings == null)
                {
                    return null;
                }

                Point3D location_1 = Value.Location_1;
                Point3D location_2 = Value.Location_2;

                List<IGeometry> geometries = new List<IGeometry>();
                foreach(Scattering scattering in scatterings)
                {
                    List<ScatteringPointGroup> scatteringPointGroups = scattering.ScatteringPointGroups;
                    if(scatteringPointGroups == null)
                    {
                        continue;
                    }

                    foreach(ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
                    {
                        List<Point3D> point3Ds = scatteringPointGroup?.Points;
                        if(point3Ds == null)
                        {
                            continue;
                        }

                        foreach(Point3D point3D in point3Ds)
                        {
                            geometries.Add(new Polyline3D([location_1, point3D, location_2], false));
                        }
                    }
                }

                return geometries.ToArray();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooScatteringProfile(Value);
        }

    }

    public class GooScatteringProfileParam : GooBakeAwareSerializableParam<GooScatteringProfile, IScatteringProfile>
    {
        public override Guid ComponentGuid => new Guid("6568b5cb-7b25-4ff7-ad94-613e3562db78");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
