using DiGi.Communication.Classes;
using DiGi.Communication.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("AngularPowerDistributions", "AngularPowerDistributions", "AngularPowerDistributions")]
        public static IEnumerable AngularPowerDistributions(this Interfaces.IAngularPowerDistributionProfile angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile == null)
            {
                return null;
            }

            return angularPowerDistributionProfile.AngularPowerDistributions?.ToList().ConvertAll(x => new GooAngularPowerDistribution(x));
        }

        [Inspect("Delays", "Delays", "Delays [μm]")]
        public static IEnumerable Delays(this Interfaces.IAngularPowerDistributionProfile angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile == null)
            {
                return null;
            }

            IEnumerable<AngularPowerDistribution> angularPowerDistributions = angularPowerDistributionProfile.AngularPowerDistributions;
            if (angularPowerDistributions == null)
            {
                return null;
            }

            List<GH_Number> result = new List<GH_Number>();
            foreach (AngularPowerDistribution angularPowerDistribution in angularPowerDistributions)
            {
                result.Add(new GH_Number(angularPowerDistribution.Delay * 1e6));
            }

            return result;
        }

        [Inspect("Location", "Location", "Location")]
        public static GooPoint3D Location(this Interfaces.IAngularPowerDistributionProfile angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile == null)
            {
                return null;
            }

            return new GooPoint3D(angularPowerDistributionProfile.Location);
        }
        
        [Inspect("Rays", "Rays", "Rays")]
        public static IEnumerable Rays(this Interfaces.IAngularPowerDistributionProfile angularPowerDistributionProfile)
        {
            if (angularPowerDistributionProfile == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D location = angularPowerDistributionProfile.Location;
            if(location == null)
            {
                return null;
            }

            IEnumerable<AngularPowerDistribution> angularPowerDistributions = angularPowerDistributionProfile.AngularPowerDistributions;
            if(angularPowerDistributions == null)
            {
                return null;
            }

            List<Geometry.Spatial.Classes.Vector3D> vector3Ds = new List<Geometry.Spatial.Classes.Vector3D>();
            foreach (AngularPowerDistribution angularPowerDistribution in angularPowerDistributions)
            {
                List< Geometry.Spatial.Classes.Vector3D> vector3Ds_Temp = angularPowerDistribution?.Vectors;
                if(vector3Ds_Temp == null)
                {
                    continue;
                }

                vector3Ds.AddRange(vector3Ds_Temp);
            }

            return vector3Ds.ConvertAll(x => new GooRay(new Ray(location, x)));
        }
    }
}
