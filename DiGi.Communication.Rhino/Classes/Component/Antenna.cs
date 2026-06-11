using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Component for creating a communication antenna.
    /// </summary>
    public class Antenna : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("28e14ad3-3a74-4f27-a19e-348ddc68a002");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Gets the exposure level of the component.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Antenna()
          : base("Communication.Antenna", "Communication.Antenna",
              "Creates Antenna",
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
                    new Param(new GooPoint3DParam() { Name = "Location", NickName = "Location", Description = "Location", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooEnumParam() { Name = "Functions", NickName = "Functions", Description = "Functions", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Voluntary),
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
                    new Param(new GooAntennaParam() { Name = "Antenna", NickName = "Antenna", Description = "DiGi Communication Antenna", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("Location");
            Geometry.Spatial.Classes.Point3D? location = null;
            if (index == -1 || !dataAccess.GetData(index, ref location) || location == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Functions");
            List<Enums.Function> functions = [];
            if (index != -1)
            {
                dataAccess.GetDataList(index, functions);
            }

            if (functions == null || functions.Count == 0)
            {
                functions = [Enums.Function.Transmitter, Enums.Function.Receiver];
            }

            Communication.Classes.Antenna? antenna = new(location, [.. functions]);

            index = Params.IndexOfOutputParam("Antenna");
            if (index != -1)
            {
                dataAccess.SetData(index, antenna == null ? null : new GooAntenna(antenna));
            }
        }
    }
}
