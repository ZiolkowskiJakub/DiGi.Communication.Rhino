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
    /// <summary>
    /// Represents a Goo wrapper for an <see cref="IScatteringProfile"/>.
    /// </summary>
    public class GooScatteringProfile : GooBakeAwareSerializableObject<IScatteringProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooScatteringProfile"/> class.
        /// </summary>
        public GooScatteringProfile()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooScatteringProfile"/> class with the specified scattering profile.
        /// </summary>
        /// <param name="scatteringProfile">The scattering profile to assign.</param>
        public GooScatteringProfile(IScatteringProfile? scatteringProfile)
        {
            Value = scatteringProfile;
        }

        /// <summary> Gets the geometries associated with the scattering profile. </summary>
        public override IGeometry[]? Geometries
        {
            get
            {
                IEnumerable<Scattering>? scatterings = Value?.Scatterings;
                if (scatterings == null)
                {
                    return null;
                }

                if (Value?.Location_1 is not Point3D location_1)
                {
                    return null;
                }

                if (Value?.Location_2 is not Point3D location_2)
                {
                    return null;
                }

                List<IGeometry> geometries = [];
                foreach (Scattering scattering in scatterings)
                {
                    List<ScatteringPointGroup>? scatteringPointGroups = scattering.ScatteringPointGroups;
                    if (scatteringPointGroups == null)
                    {
                        continue;
                    }

                    foreach (ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
                    {
                        List<Point3D>? point3Ds = scatteringPointGroup?.Points;
                        if (point3Ds == null)
                        {
                            continue;
                        }

                        foreach (Point3D point3D in point3Ds)
                        {
                            geometries.Add(new Polyline3D([location_1, point3D, location_2], false));
                        }
                    }
                }

                return [.. geometries];
            }
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing a copy of the value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooScatteringProfile(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for <see cref="GooScatteringProfile"/>.
    /// </summary>
    public class GooScatteringProfileParam : GooBakeAwareSerializableParam<GooScatteringProfile, IScatteringProfile>
    {
        /// <summary> Gets the unique identifier for the component. </summary>
        public override Guid ComponentGuid => new("6568b5cb-7b25-4ff7-ad94-613e3562db78");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}

