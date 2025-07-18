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
    public class GooAngularPowerDistributionProfile : GooBakeAwareSerializableObject<IAngularPowerDistributionProfile>
    {
        public GooAngularPowerDistributionProfile()
            : base()
        {
        }

        public GooAngularPowerDistributionProfile(IAngularPowerDistributionProfile angularPowerDistributionProfile)
        {
            Value = angularPowerDistributionProfile;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                IEnumerable<AngularPowerDistribution> angularPowerDistributions = Value?.AngularPowerDistributions;
                if(angularPowerDistributions == null)
                {
                    return null;
                }

                Point3D location = Value.Location;

                List<IGeometry> geometries = new List<IGeometry>();
                foreach(AngularPowerDistribution angularPowerDistribution in angularPowerDistributions)
                {
                    List<Vector3D> vector3Ds = angularPowerDistribution.Vectors;
                    if(vector3Ds == null)
                    {
                        continue;
                    }

                    foreach(Vector3D vector3D in vector3Ds)
                    {
                        geometries.Add(new Segment3D(location.GetMoved(vector3D.GetInversed()), location));
                    }
                }

                return geometries.ToArray();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooAngularPowerDistributionProfile(Value);
        }

    }

    public class GooAngularPowerDistributionProfileParam : GooBakeAwareSerializableParam<GooAngularPowerDistributionProfile, IAngularPowerDistributionProfile>
    {
        public override Guid ComponentGuid => new Guid("493c2a67-0e30-47bd-bb35-df3defbc9f0d");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
