using DiGi.Communication.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for the geometrical propagation model, enabling its use within the Rhino and Grasshopper environment.
    /// </summary>
    public class GooGeometricalPropagationModel : GooBakeAwareSerializableObject<Communication.Classes.GeometricalPropagationModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometricalPropagationModel"/> class.
        /// </summary>
        public GooGeometricalPropagationModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGeometricalPropagationModel"/> class with the specified geometrical propagation model.
        /// </summary>
        /// <param name="geometricalPropagationModel">The <see cref="Communication.Classes.GeometricalPropagationModel"/> to wrap.</param>
        public GooGeometricalPropagationModel(Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel)
        {
            Value = geometricalPropagationModel;
        }

        /// <summary> Gets the collection of geometries derived from the scattering objects within the propagation model. </summary>
        public override IGeometry[]? Geometries
        {
            get
            {
                return Value?.GetScatteringObjects<IScatteringObject>()?.ConvertAll(x => x.Mesh3D as IGeometry)?.FilterNulls()?.ToArray();
            }
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooGeometricalPropagationModel"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the propagation model.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGeometricalPropagationModel(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for the geometrical propagation model.
    /// </summary>
    public class GooGeometricalPropagationModelParam : GooBakeAwareSerializableParam<GooGeometricalPropagationModel, Communication.Classes.GeometricalPropagationModel>
    {
        /// <summary> Gets the unique identifier for the Grasshopper component associated with this parameter. </summary>
        public override Guid ComponentGuid => new("c88cfd89-5b8b-4303-a40a-dd83fff05d8a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}

