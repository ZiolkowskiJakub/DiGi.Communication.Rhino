using DiGi.Communication.Rhino.Classes.Goo;
using DiGi.Core;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class ComplexMultipathPowerDelayProfile : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f73be78e-d0a6-411b-a855-804f4a86fd97");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ComplexMultipathPowerDelayProfile()
          : base("Communication.ComplexMultipathPowerDelayProfile", "Communication.ComplexMultipathPowerDelayProfile",
              "Creates ComplexMultipathPowerDelayProfile",
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
                result.Add(new Param(new GooSimpleMultipathPowerDelayProfileParam() { Name = "SimpleMultipathPowerDelayProfileParam_Visible", NickName = "SimpleMultipathPowerDelayProfileParam_Visible", Description = "SimpleMultipathPowerDelayProfileParam for case when antennas are visible", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooSimpleMultipathPowerDelayProfileParam() { Name = "SimpleMultipathPowerDelayProfileParam_Hidden", NickName = "SimpleMultipathPowerDelayProfileParam_Hidden", Description = "SimpleMultipathPowerDelayProfileParam for case when antennas are hidden", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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
                result.Add(new Param(new GooComplexMultipathPowerDelayProfileParam() { Name = "ComplexMultipathPowerDelayProfile", NickName = "ComplexMultipathPowerDelayProfile", Description = "DiGi Communication ComplexMultipathPowerDelayProfile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Delays");
            List<double> delays = new List<double>();
            if (index == -1 || !dataAccess.GetDataList(index, delays) || delays == null || delays.Count == 0)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Powers");
            List<double> powers = new List<double>();
            if (index == -1 || !dataAccess.GetDataList(index, powers) || powers == null || powers.Count == 0)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            int count = Math.Max(delays.Count, powers.Count);
            delays.Extend(count);
            powers.Extend(count);

            Dictionary<double, double> dictionary = new Dictionary<double, double>();
            for (int i =0; i < count; i++)
            {
                dictionary[delays[i]] = powers[i];
            }

            Communication.Classes.SimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile = new Communication.Classes.SimpleMultipathPowerDelayProfile(dictionary);

            index = Params.IndexOfOutputParam("SimpleMultipathPowerDelayProfile");
            if (index != -1)
            {
                dataAccess.SetData(index, simpleMultipathPowerDelayProfile == null ? null : new GooSimpleMultipathPowerDelayProfile(simpleMultipathPowerDelayProfile));
            }
        }
    }
}
