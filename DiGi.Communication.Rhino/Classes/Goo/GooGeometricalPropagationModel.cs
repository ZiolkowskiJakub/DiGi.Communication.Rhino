using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooGeometricalPropagationModel : GooBakeAwareSerializableObject<Communication.Classes.GeometricalPropagationModel>
    {
        public GooGeometricalPropagationModel()
            : base()
        {
        }

        public GooGeometricalPropagationModel(Communication.Classes.GeometricalPropagationModel geometricalPropagationModel)
        {
            Value = geometricalPropagationModel;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                return Value?.GetScatteringObjects<IScatteringObject>().ConvertAll(x => x.Mesh3D as IGeometry)?.ToArray();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGeometricalPropagationModel(Value);
        }

    }

    public class GooGeometricalPropagationModelParam : GooBakeAwareSerializableParam<GooGeometricalPropagationModel, Communication.Classes.GeometricalPropagationModel>
    {
        public override Guid ComponentGuid => new Guid("c88cfd89-5b8b-4303-a40a-dd83fff05d8a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
