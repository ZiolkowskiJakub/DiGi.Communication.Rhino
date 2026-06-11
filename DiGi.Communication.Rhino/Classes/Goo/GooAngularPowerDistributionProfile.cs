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
    /// Represents a Goo wrapper for an angular power distribution profile.
    /// </summary>
    public class GooAngularPowerDistributionProfile : GooBakeAwareSerializableObject<IAngularPowerDistributionProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooAngularPowerDistributionProfile"/> class.
        /// </summary>
        public GooAngularPowerDistributionProfile()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAngularPowerDistributionProfile"/> class with the specified angular power distribution profile.
        /// </summary>
        /// <param name="angularPowerDistributionProfile">The angular power distribution profile to assign.</param>
        public GooAngularPowerDistributionProfile(IAngularPowerDistributionProfile? angularPowerDistributionProfile)
        {
            Value = angularPowerDistributionProfile;
        }

        /// <summary>
        /// Gets the geometries associated with the angular power distribution profile.
        /// </summary>
        /// <returns>An array of <see cref="IGeometry"/> objects, or null if no value is present.</returns>
        public override IGeometry[]? Geometries
        {
            get
            {
                IEnumerable<AngularPowerDistribution>? angularPowerDistributions = Value?.AngularPowerDistributions;
                if (angularPowerDistributions == null)
                {
                    return null;
                }

                Point3D? location = Value?.Location;

                List<IGeometry> geometries = [];
                foreach (AngularPowerDistribution angularPowerDistribution in angularPowerDistributions)
                {
                    List<Vector3D>? vector3Ds = angularPowerDistribution.Vectors;
                    if (vector3Ds == null)
                    {
                        continue;
                    }

                    foreach (Vector3D vector3D in vector3Ds)
                    {
                        geometries.Add(new Segment3D(location?.GetMoved(vector3D.GetInversed()), location));
                    }
                }

                return [.. geometries];
            }
        }

        /// <summary>
        /// Creates a duplicate of this object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooAngularPowerDistributionProfile(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter for an angular power distribution profile.
    /// </summary>
    public class GooAngularPowerDistributionProfileParam : GooBakeAwareSerializableParam<GooAngularPowerDistributionProfile, IAngularPowerDistributionProfile>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        /// <returns>The <see cref="Guid"/> of the component.</returns>
        public override Guid ComponentGuid => new("493c2a67-0e30-47bd-bb35-df3defbc9f0d");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
