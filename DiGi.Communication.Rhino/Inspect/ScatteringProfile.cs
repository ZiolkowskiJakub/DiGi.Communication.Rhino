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
        /// <summary>
        /// Gets the first location of the scattering profile as a GooPoint3D.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to inspect.</param>
        /// <returns>A <see cref="GooPoint3D"/> representing the first location, or null if the profile or location is null.</returns>
        [Inspect("Location_1", "Location_1", "First location")]
        public static GooPoint3D? Location_1(this Interfaces.IScatteringProfile? scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D? location = scatteringProfile.Location_1;

            return location == null ? null : new GooPoint3D(location);
        }

        /// <summary>
        /// Gets the second location of the scattering profile as a GooPoint3D.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to inspect.</param>
        /// <returns>A <see cref="GooPoint3D"/> representing the second location, or null if the profile or location is null.</returns>
        [Inspect("Location_2", "Location_2", "Second location")]
        public static GooPoint3D? Location_2(this Interfaces.IScatteringProfile? scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D? location = scatteringProfile.Location_2;

            return location == null ? null : new GooPoint3D(location);
        }

        /// <summary>
        /// Gets the scatterings of the scattering profile as a collection of GooScattering objects.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to inspect.</param>
        /// <returns>An <see cref="IEnumerable"/> of <see cref="GooScattering"/> objects, or null if the profile or scatterings are null.</returns>
        [Inspect("Scatterings", "Scatterings", "Scatterings")]
        public static IEnumerable? Scatterings(this Interfaces.IScatteringProfile? scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            IEnumerable<Scattering>? scatterings = scatteringProfile.Scatterings;
            if (scatterings == null)
            {
                return null;
            }

            List<GooScattering> result = [];
            foreach (Scattering scattering in scatterings)
            {
                result.Add(new GooScattering(scattering));
            }

            return result;
        }

        /// <summary>
        /// Generates ellipsoids based on the locations and scatterings of the scattering profile.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to inspect.</param>
        /// <returns>An <see cref="IEnumerable"/> of <see cref="GooEllipsoid"/> objects, or null if required data is missing.</returns>
        [Inspect("Ellipsoids", "Ellipsoids", "Ellipsoids")]
        public static IEnumerable? Ellipsoids(this Interfaces.IScatteringProfile? scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D? location_1 = scatteringProfile.Location_1;
            if (location_1 == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D? location_2 = scatteringProfile.Location_2;
            if (location_2 == null)
            {
                return null;
            }

            IEnumerable<Scattering>? scatterings = scatteringProfile.Scatterings;
            if (scatterings == null)
            {
                return null;
            }

            List<GooEllipsoid> result = [];
            foreach (Scattering scattering in scatterings)
            {
                result.Add(new GooEllipsoid(Create.Ellipsoid(location_1, location_2, scattering.Delay)));
            }

            return result;
        }

        /// <summary>
        /// Gets the visibility status of the scattering profile.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to inspect.</param>
        /// <returns>A <see cref="GH_Boolean"/> indicating if the profile is visible, or null if the profile is null.</returns>
        [Inspect("Visible", "Visible", "Visible")]
        public static GH_Boolean? Visible(this Interfaces.IScatteringProfile? scatteringProfile)
        {
            if (scatteringProfile == null)
            {
                return null;
            }

            return new GH_Boolean(scatteringProfile.Visible);
        }
    }
}
