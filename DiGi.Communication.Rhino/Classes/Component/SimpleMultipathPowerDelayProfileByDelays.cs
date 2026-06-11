using DiGi.Communication.Rhino.Classes.Goo;
using DiGi.Core;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// A component that creates a SimpleMultipathPowerDelayProfile using lists of delay and power values.
    /// </summary>
    public class SimpleMultipathPowerDelayProfileByDelays : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("03574bd6-d400-4f85-841b-97b0e630d7da");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Gets the exposure level of the component.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public SimpleMultipathPowerDelayProfileByDelays()
          : base("Communication.SimpleMultipathPowerDelayProfileByDelays", "Communication.SimpleMultipathPowerDelayProfileByDelays",
              "Creates SimpleMultipathPowerDelayProfile by delay and power values",
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
                List<Param> result = [];
                result.Add(new Param(new Param_Number() { Name = "Delays", NickName = "Delays", Description = "Delays", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_Number() { Name = "Powers", NickName = "Powers", Description = "Powers", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));

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
                List<Param> result = [];
                result.Add(new Param(new GooSimpleMultipathPowerDelayProfileParam() { Name = "SimpleMultipathPowerDelayProfile", NickName = "SimpleMultipathPowerDelayProfile", Description = "DiGi Communication SimpleMultipathPowerDelayProfile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Delays");
            List<double> delays = [];
            if (index == -1 || !dataAccess.GetDataList(index, delays) || delays == null || delays.Count == 0)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Powers");
            List<double> powers = [];
            if (index == -1 || !dataAccess.GetDataList(index, powers) || powers == null || powers.Count == 0)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            delays = delays.ConvertAll(x => Core.Query.Round(x * 1e-6, 1e-12));

            int count = Math.Max(delays.Count, powers.Count);
            delays.Extend(count);
            powers.Extend(count);

            Dictionary<double, double> dictionary = [];
            for (int i = 0; i < count; i++)
            {
                dictionary[delays[i]] = powers[i];
            }

            Communication.Classes.SimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile = new(dictionary);

            index = Params.IndexOfOutputParam("SimpleMultipathPowerDelayProfile");
            if (index != -1)
            {
                dataAccess.SetData(index, simpleMultipathPowerDelayProfile == null ? null : new GooSimpleMultipathPowerDelayProfile(simpleMultipathPowerDelayProfile));
            }
        }
    }
}
