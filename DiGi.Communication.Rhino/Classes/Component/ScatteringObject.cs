using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper component that creates a scattering object for communication purposes.
    /// </summary>
    public class ScatteringObject : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("bc1c20b0-ddf9-4f6e-9c36-0ab1bb0a2753");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Gets the exposure level of the component.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the ScatteringObject class.
        /// </summary>
        public ScatteringObject()
          : base("Communication.ScatteringObject", "Communication.ScatteringObject",
              "Creates ScatteringObject",
              "DiGi", "DiGi.Communication")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooMesh3DParam() { Name = "Mesh3D", NickName = "Mesh3D", Description = "DiGi Geometry Mesh3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Param_String() { Name = "Reference", NickName = "Reference", Description = "Reference", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary),
                    new Param(new Param_Number() { Name = "RelativePermittivity", NickName = "RelativePermittivity", Description = "Relative permittivity [-]", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary),
                    new Param(new Param_Number() { Name = "ElectricalConductivity", NickName = "ElectricalConductivity", Description = "Electrical conductivity [S/m]", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary),
                ];

                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooScatteringObjectParam() { Name = "ScatteringObject", NickName = "ScatteringObject", Description = "DiGi Communication Scattering Object", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("Mesh3D");
            Mesh3D? mesh3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref mesh3D) || mesh3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            string? reference = null;
            index = Params.IndexOfInputParam("Reference");
            if (index != -1)
            {
                dataAccess.GetData(index, ref reference);
            }

            double relativePermittivity = 1;
            index = Params.IndexOfInputParam("RelativePermittivity");
            if (index != -1)
            {
                if (!dataAccess.GetData(index, ref relativePermittivity))
                {
                    relativePermittivity = 1;
                }
            }

            double electricalConductivity = 0;
            index = Params.IndexOfInputParam("ElectricalConductivity");
            if (index != -1)
            {
                if (!dataAccess.GetData(index, ref electricalConductivity))
                {
                    electricalConductivity = 0;
                }
            }

            Communication.Classes.ScatteringObject scatteringObject = new(reference, mesh3D, relativePermittivity, electricalConductivity);

            index = Params.IndexOfOutputParam("ScatteringObject");
            if (index != -1)
            {
                dataAccess.SetData(index, scatteringObject == null ? null : new GooScatteringObject(scatteringObject));
            }
        }
    }
}
