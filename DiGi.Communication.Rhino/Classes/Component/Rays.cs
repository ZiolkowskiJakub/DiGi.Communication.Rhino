using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Component that calculates rays based on an angular power distribution profile and delay.
    /// </summary>
    public class Rays : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("77978b5a-9aa0-43e8-af02-9f44a42f052e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Gets the exposure of the component.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Rays()
          : base("Communication.Rays", "Communication.Rays",
              "Gets Rays",
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
                    new Param(new GooAngularPowerDistributionProfileParam() { Name = "AngularPowerDistributionProfile", NickName = "AngularPowerDistributionProfile", Description = "AngularPowerDistributionProfile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Param_Number() { Name = "Delay", NickName = "Delay", Description = "Delay [μm]", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Param_Number() { Name = "Factor", NickName = "Factor", Description = "Factor", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary),
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
                    new Param(new GooRayParam() { Name = "Rays", NickName = "Rays", Description = "DiGi Rays", Access = GH_ParamAccess.list }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("AngularPowerDistributionProfile");
            IAngularPowerDistributionProfile? angularPowerDistributionProfile = null;
            if (index == -1 || !dataAccess.GetData(index, ref angularPowerDistributionProfile) || angularPowerDistributionProfile == null)
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

            double factor = 1.0;
            index = Params.IndexOfInputParam("Factor");
            if (index != -1)
            {
                if (!dataAccess.GetData(index, ref factor) || double.IsNaN(factor))
                {
                    factor = 1.0;
                }
            }

            delay = Core.Query.Round(delay * 1e-6, 1e-12);

            List<Ray>? rays = Query.Scale(angularPowerDistributionProfile.GetRays(delay), factor);

            index = Params.IndexOfOutputParam("Rays");
            if (index != -1)
            {
                dataAccess.SetDataList(index, rays?.ConvertAll(x => new GooRay(x)));
            }
        }
    }
}
