using DiGi.Communication.Classes;
using DiGi.Communication.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("Location_1", "Location_1", "First location")]
        public static GooPoint3D Location_1(this Interfaces.IScatteringProfile scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D location = scatteringProfile.Location_1;
        
            return location == null ? null : new GooPoint3D(location);
        }

        [Inspect("Location_2", "Location_2", "Second location")]
        public static GooPoint3D Location_2(this Interfaces.IScatteringProfile scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D location = scatteringProfile.Location_2;

            return location == null ? null : new GooPoint3D(location);
        }

        [Inspect("Scatterings", "Scatterings", "Scatterings")]
        public static IEnumerable Scatterings(this Interfaces.IScatteringProfile scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            IEnumerable<Scattering> scatterings = scatteringProfile.Scatterings;
            if(scatterings == null)
            {
                return null;
            }

            List<GooScattering> result = new List<GooScattering>();
            foreach(Scattering scattering in scatterings)
            {
                result.Add(new GooScattering(scattering));
            }

            return result;
        }

        [Inspect("Ellipsoids", "Ellipsoids", "Ellipsoids")]
        public static IEnumerable Ellipsoids(this Interfaces.IScatteringProfile scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D location_1 = scatteringProfile.Location_1;
            if (location_1 == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D location_2 = scatteringProfile.Location_2;
            if (location_2 == null)
            {
                return null;
            }

            IEnumerable<Scattering> scatterings = scatteringProfile.Scatterings;
            if (scatterings == null)
            {
                return null;
            }

            List<GooEllipsoid> result = new List<GooEllipsoid>();
            foreach (Scattering scattering in scatterings)
            {
                result.Add(new GooEllipsoid(Create.Ellipsoid(location_1, location_2, scattering.Delay)));
            }

            return result;
        }

        [Inspect("Visible", "Visible", "Visible")]
        public static GH_Boolean Visible(this Interfaces.IScatteringProfile scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            return new GH_Boolean(scatteringProfile.Visible);
        }
    }
}
