using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class EllipsoidalPropagation : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("fe68eb23-b2f6-458d-91fc-e6750a75f47e");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public EllipsoidalPropagation()
          : base("GIS.EllipsoidalPropagation", "GIS.EllipsoidalPropagation",
              "Creates EllipsoidalPropagation",
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
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooPoint3DParam() { Name = "Location_1", NickName = "Location_1", Description = "Antenna location 1", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPoint3DParam() { Name = "Location_2", NickName = "Location_2", Description = "Antenna location 2", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_Number() { Name = "B", NickName = "B", Description = "B", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooEllipsoidalPropagationParam() { Name = "EllipsoidalPropagation", NickName = "EllipsoidalPropagation", Description = "DiGi Communication EllipsoidalPropagation", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                return result.ToArray();
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

            index = Params.IndexOfInputParam("Location_1");
            Geometry.Spatial.Classes.Point3D location_1 = null;
            if (index == -1 || !dataAccess.GetData(index, ref location_1) || location_1 == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Location_2");
            Geometry.Spatial.Classes.Point3D location_2 = null;
            if (index == -1 || !dataAccess.GetData(index, ref location_2) || location_2 == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("B");
            double b = 0;
            if (index != -1)
            {
                dataAccess.GetData(index, ref b);
            }

            Communication.Classes.EllipsoidalPropagation ellipsoidalPropagation = new Communication.Classes.EllipsoidalPropagation(location_1, location_2, b);

            index = Params.IndexOfOutputParam("EllipsoidalPropagation");
            if (index != -1)
            {
                dataAccess.SetData(index, ellipsoidalPropagation == null ? null : new GooEllipsoidalPropagation(ellipsoidalPropagation));
            }
        }
    }
}
