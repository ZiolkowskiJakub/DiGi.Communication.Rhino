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
                result.Add(new Param(new GooSimpleMultipathPowerDelayProfileParam() { Name = "SimpleMultipathPowerDelayProfile_Visible", NickName = "SimpleMultipathPowerDelayProfile_Visible", Description = "SimpleMultipathPowerDelayProfile for case when antennas are visible", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooSimpleMultipathPowerDelayProfileParam() { Name = "SimpleMultipathPowerDelayProfile_Hidden", NickName = "SimpleMultipathPowerDelayProfile_Hidden", Description = "SimpleMultipathPowerDelayProfile for case when antennas are hidden", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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

            index = Params.IndexOfInputParam("SimpleMultipathPowerDelayProfile_Visible");
            Communication.Classes.SimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Visible = null;
            if (index == -1 || !dataAccess.GetData(index, ref simpleMultipathPowerDelayProfile_Visible) || simpleMultipathPowerDelayProfile_Visible == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("SimpleMultipathPowerDelayProfile_Hidden");
            Communication.Classes.SimpleMultipathPowerDelayProfile simpleMultipathPowerDelayProfile_Hidden = null;
            if (index == -1 || !dataAccess.GetData(index, ref simpleMultipathPowerDelayProfile_Hidden) || simpleMultipathPowerDelayProfile_Hidden == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Communication.Classes.ComplexMultipathPowerDelayProfile complexMultipathPowerDelayProfile = new Communication.Classes.ComplexMultipathPowerDelayProfile(simpleMultipathPowerDelayProfile_Visible, simpleMultipathPowerDelayProfile_Hidden);

            index = Params.IndexOfOutputParam("ComplexMultipathPowerDelayProfile");
            if (index != -1)
            {
                dataAccess.SetData(index, complexMultipathPowerDelayProfile == null ? null : new GooComplexMultipathPowerDelayProfile(complexMultipathPowerDelayProfile));
            }
        }
    }
}
