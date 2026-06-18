using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper-compatible wrapper for an antenna object.
    /// </summary>
    public class GooAntenna : GooBakeAwareSerializableObject<IAntenna>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooAntenna"/> class.
        /// </summary>
        public GooAntenna()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAntenna"/> class with the specified antenna.
        /// </summary>
        /// <param name="antenna">The antenna to wrap.</param>
        public GooAntenna(IAntenna? antenna)
        {
            Value = antenna;
        }

        /// <summary> Gets the geometry associated with the antenna, typically its location point. </summary>
        public override IGeometry[]? Geometries
        {
            get
            {
                Point3D? point3D = Value?.Location;

                return point3D == null ? null : [point3D];
            }
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooAntenna"/> object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance representing the duplicated antenna.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooAntenna(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for antennas.
    /// </summary>
    public class GooAntennaParam : GooBakeAwareSerializableParam<GooAntenna, IAntenna>
    {
        /// <summary>
        /// Gets the unique identifier for the antenna component.
        /// </summary>
        public override Guid ComponentGuid => new("adfd6214-0454-4a7c-8cdc-c8341fd41d17");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}

