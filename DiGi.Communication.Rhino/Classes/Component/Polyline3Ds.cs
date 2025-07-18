using DiGi.Communication.Interfaces;
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
    public class Polyline3Ds : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("a8479a5e-031d-4d17-9a5d-6d433c82b756");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Polyline3Ds()
          : base("Communication.Polyline3Ds", "Communication.Polyline3Ds",
              "Creates Polyline3Ds",
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
                result.Add(new Param(new GooScatteringProfileParam() { Name = "ScatteringProfile", NickName = "ScatteringProfile", Description = "DiGi Communication ScatteringProfile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_Number() { Name = "Delay", NickName = "Delay", Description = "Delay [μm]", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                result.Add(new Param(new Param_String() { Name = "References", NickName = "References", Description = "References", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Voluntary));

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
                result.Add(new Param(new GooPolyline3DParam() { Name = "Polyline3Ds", NickName = "Polyline3Ds", Description = "DiGi Geometry Polyline3Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("ScatteringProfile");
            IScatteringProfile scatteringProfile = null;
            if (index == -1 || !dataAccess.GetData(index, ref scatteringProfile) || scatteringProfile == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double delay = double.NaN;
            index = Params.IndexOfInputParam("Delay");
            if (index == -1 || !dataAccess.GetData(index, ref delay) || double.IsNaN(delay))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            delay = Core.Query.Round(delay * 1e-6, 1e-12);


            List<string> references = new List<string>();
            index = Params.IndexOfInputParam("References");
            if(index != -1)
            {
                if(!dataAccess.GetDataList(index, references))
                {
                    references = new List<string>();
                }
            }

            if(references != null && references.Count == 0)
            {
                references = null;
            }

            List<Polyline3D> polyline3Ds = Query.Polyline3Ds(scatteringProfile, delay, references);

            index = Params.IndexOfOutputParam("Polyline3Ds");
            if (index != -1)
            {
                dataAccess.SetData(index, polyline3Ds?.ConvertAll(x => new GooPolyline3D(x)));
            }
        }
    }
}
