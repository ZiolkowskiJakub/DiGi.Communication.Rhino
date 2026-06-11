using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for an <see cref="IScatteringObject"/>.
    /// </summary>
    public class GooScatteringObject : GooBakeAwareSerializableObject<IScatteringObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooScatteringObject"/> class.
        /// </summary>
        public GooScatteringObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooScatteringObject"/> class with the specified scattering object.
        /// </summary>
        /// <param name="scattering">The scattering object to wrap.</param>
        public GooScatteringObject(IScatteringObject? scattering)
        {
            Value = scattering;
        }

        /// <summary>
        /// Gets the geometries associated with the scattering object.
        /// </summary>
        public override IGeometry[]? Geometries
        {
            get
            {
                Mesh3D? mesh3D = Value?.Mesh3D;

                return mesh3D == null ? null : [mesh3D];
            }
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooScatteringObject"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooScatteringObject(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for <see cref="GooScatteringObject"/>.
    /// </summary>
    public class GooScatteringObjectParam : GooBakeAwareSerializableParam<GooScatteringObject, IScatteringObject>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("dcaba3c2-38c2-4520-817d-a6f157277457");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
