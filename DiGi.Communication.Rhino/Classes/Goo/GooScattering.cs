using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for scattering data.
    /// </summary>
    public class GooScattering : GooBakeAwareSerializableObject<IScattering>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooScattering"/> class.
        /// </summary>
        public GooScattering()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooScattering"/> class with the specified scattering value.
        /// </summary>
        /// <param name="scattering">The scattering object to wrap.</param>
        public GooScattering(IScattering? scattering)
        {
            Value = scattering;
        }

        /// <summary> Gets the collection of geometries associated with the scattering point groups. </summary>
        public override IGeometry[]? Geometries
        {
            get
            {
                List<ScatteringPointGroup>? scatteringPointGroups = Value?.ScatteringPointGroups;
                if (scatteringPointGroups == null)
                {
                    return null;
                }

                List<IGeometry> geometries = [];
                foreach (ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
                {
                    scatteringPointGroup?.Points?.ForEach(x => geometries.Add(x));
                }

                return [.. geometries];
            }
        }

        /// <summary>
        /// Creates a duplicate of this Goo object.
        /// </summary>
        /// <returns>A duplicate instance as an <see cref="IGH_Goo"/>.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooScattering(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter for scattering data.
    /// </summary>
    public class GooScatteringParam : GooBakeAwareSerializableParam<GooScattering, IScattering>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("760f3e12-4622-4efb-862f-90e15b7532b8");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}

