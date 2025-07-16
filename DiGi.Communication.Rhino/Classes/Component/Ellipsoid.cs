using DiGi.Communication.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class Ellipsoid : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("2e7e8de0-9110-49ae-bfd4-625b4489ab65");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Ellipsoid()
          : base("Communication.Ellipsoid", "Communication.Ellipsoid",
              "Creates Ellipsoid",
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
                result.Add(new Param(new GooAntennaParam() { Name = "Antenna_1", NickName = "Antenna_1", Description = "First antenna", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooAntennaParam() { Name = "Antenna_2", NickName = "Antenna_2", Description = "Second antenna", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_Number() { Name = "Delay", NickName = "Delay", Description = "Delay [μm]", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                Param_Number param_Number;

                param_Number = new Param_Number() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Core.Constans.Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));

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
                result.Add(new Param(new GooEllipsoidParam() { Name = "Ellipsoid", NickName = "Ellipsoid", Description = "DiGi Ellipsoid", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Antenna_1");
            IAntenna antenna_1 = null;
            if (index == -1 || !dataAccess.GetData(index, ref antenna_1) || antenna_1 == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Antenna_2");
            IAntenna antenna_2 = null;
            if (index == -1 || !dataAccess.GetData(index, ref antenna_2) || antenna_2 == null)
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

            delay *= 1E-6;

            double tolerance = Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            Geometry.Spatial.Classes.Ellipsoid ellipsoid = Create.Ellipsoid(antenna_1, antenna_2, delay, tolerance);

            index = Params.IndexOfOutputParam("Ellipsoid");
            if (index != -1)
            {
                dataAccess.SetData(index, ellipsoid == null ? null : new GooEllipsoid(ellipsoid));
            }
        }
    }
}
