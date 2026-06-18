using DiGi.Communication.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a wrapper for a Ray object to enable serialization and baking within the Rhino/Grasshopper environment.
    /// </summary>
    public class GooRay : GooBakeAwareSerializableObject<Ray>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooRay"/> class.
        /// </summary>
        public GooRay()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooRay"/> class with a specified Ray value.
        /// </summary>
        /// <param name="ray">The Ray object to wrap.</param>
        public GooRay(Ray? ray)
        {
            Value = ray;
        }

        /// <summary> Gets the geometric representations associated with this GooRay. </summary>
        public override IGeometry[]? Geometries
        {
            get
            {
                Point3D? point3D = Value?.Point;
                if (point3D == null)
                {
                    return null;
                }

                Vector3D? vector3D = Value?.Vector;
                if (vector3D == null)
                {
                    return null;
                }

                return [new Segment3D(point3D, vector3D)];
            }
        }

        /// <summary>
        /// Creates a duplicate of the current GooRay instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the Ray value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooRay(Value);
        }
    }

    /// <summary>
    /// Provides the parameter definition for handling <see cref="GooRay"/> objects in Grasshopper components.
    /// </summary>
    public class GooRayParam : GooBakeAwareSerializableParam<GooRay, Ray>
    {
        /// <summary> Gets the unique identifier for the GooRay component. </summary>
        public override Guid ComponentGuid => new("5d3b6300-2aac-4ea5-9d6e-f009857c568a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}

