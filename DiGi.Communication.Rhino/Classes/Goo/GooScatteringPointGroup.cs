using DiGi.Communication.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;
using System.Linq;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for a scattering point group, enabling its use within the Grasshopper environment.
    /// </summary>
    public class GooScatteringPointGroup : GooBakeAwareSerializableObject<ScatteringPointGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooScatteringPointGroup"/> class.
        /// </summary>
        public GooScatteringPointGroup()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooScatteringPointGroup"/> class with the specified scattering point group.
        /// </summary>
        /// <param name="scatteringPointGroup">The scattering point group to assign as the value.</param>
        public GooScatteringPointGroup(ScatteringPointGroup? scatteringPointGroup)
        {
            Value = scatteringPointGroup;
        }

        /// <summary>
        /// Gets the collection of geometries associated with the scattering point group.
        /// </summary>
        /// <returns>An array of <see cref="IGeometry"/> objects, or null if no value is present.</returns>
        public override IGeometry[]? Geometries
        {
            get
            {
                return Value?.Points?.ToArray<IGeometry>();
            }
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="IGH_Goo"/> containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooScatteringPointGroup(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for scattering point groups.
    /// </summary>
    public class GooScatteringPointGroupParam : GooBakeAwareSerializableParam<GooScatteringPointGroup, ScatteringPointGroup>
    {
        /// <summary>
        /// Gets the unique identifier for the scattering point group component.
        /// </summary>
        public override Guid ComponentGuid => new("b7f65893-bb53-46f1-8538-cdb9d0ac5c81");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
