using DiGi.Communication.Rhino.Classes.Goo;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class SimpleMultipathPowerDelayProfile : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("e970f03b-2557-4407-8551-601ae19ab301");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public SimpleMultipathPowerDelayProfile()
          : base("Communication.SimpleMultipathPowerDelayProfile", "Communication.SimpleMultipathPowerDelayProfile",
              "Creates SimpleMultipathPowerDelayProfile",
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
                result.Add(new Param(new GooEnumParam() { Name = "DefaultSimpleMultipathPowerDelayProfile", NickName = "DefaultSimpleMultipathPowerDelayProfile", Description = "DefaultSimpleMultipathPowerDelayProfile Enum", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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
                result.Add(new Param(new GooSimpleMultipathPowerDelayProfileParam() { Name = "SimpleMultipathPowerDelayProfile", NickName = "SimpleMultipathPowerDelayProfile", Description = "DiGi Communication SimpleMultipathPowerDelayProfile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("DefaultSimpleMultipathPowerDelayProfile");
            Enums.DefaultSimpleMultipathPowerDelayProfile defaultSimpleMultipathPowerDelayProfile = Enums.DefaultSimpleMultipathPowerDelayProfile.TypicalUrban;
            if (index == -1 || !dataAccess.GetData(index, ref defaultSimpleMultipathPowerDelayProfile))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Communication.Classes.SimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile = Create.SimpleMultipathPowerDelayProfile(defaultSimpleMultipathPowerDelayProfile);

            index = Params.IndexOfOutputParam("SimpleMultipathPowerDelayProfile");
            if (index != -1)
            {
                dataAccess.SetData(index, simpleMultipathPowerDelayProfile == null ? null : new GooSimpleMultipathPowerDelayProfile(simpleMultipathPowerDelayProfile));
            }
        }
    }
}
