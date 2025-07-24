using DiGi.Communication.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class CalculateAngularPowerDistribution : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("25da38ff-35dd-418d-8d0e-b961ed9995e2");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public CalculateAngularPowerDistribution()
          : base("Communication.CalculateAngularPowerDistribution", "Communication.CalculateAngularPowerDistribution",
              "Calculates angular power distribution",
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
                result.Add(new Param(new GooGeometricalPropagationModelParam() { Name = "GeometricalPropagationModel", NickName = "GeometricalPropagationModel", Description = "GeometricalPropagationModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                Param_Integer param_Integer = new Param_Integer() { Name = "RayCount", NickName = "RayCount", Description = "Ray count", Access = GH_ParamAccess.item, Optional = true };
                param_Integer.SetPersistentData(1);
                result.Add(new Param(param_Integer, ParameterVisibility.Voluntary));

                Param_Number param_Number = new Param_Number() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Integer.SetPersistentData(Core.Constans.Tolerance.Distance);
                result.Add(new Param(param_Integer, ParameterVisibility.Voluntary));

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
                result.Add(new Param(new GooGeometricalPropagationModelParam() { Name = "GeometricalPropagationModel", NickName = "GeometricalPropagationModel", Description = "DiGi Communication GeometricalPropagationModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooAngularPowerDistributionProfileParam() { Name = "AngularPowerDistributionProfiles", NickName = "AngularPowerDistributionProfiles", Description = "DiGi Communication AngularPowerDistributionProfiles", Access = GH_ParamAccess.list }, ParameterVisibility.Voluntary));
                result.Add(new Param(new Param_Boolean() { Name = "Succeeded", NickName = "Succeeded", Description = "Succeeded", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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
            int index_Succeeded = Params.IndexOfOutputParam("Succeeded");
            if(index_Succeeded != -1)
            {
                dataAccess.SetData(index_Succeeded, false);
            }

            int index;

            index = Params.IndexOfInputParam("GeometricalPropagationModel");
            Communication.Classes.GeometricalPropagationModel geometricalPropagationModel = null;
            if (index == -1 || !dataAccess.GetData(index, ref geometricalPropagationModel) || geometricalPropagationModel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            int rayCount = 1;
            index = Params.IndexOfInputParam("RayCount");
            if (index != -1)
            {
                dataAccess.GetData(index, ref rayCount);
            }

            double tolerance = Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            geometricalPropagationModel = new Communication.Classes.GeometricalPropagationModel(geometricalPropagationModel);

            Communication.Classes.AngularPowerDistributionCalculatorOptions angularPowerDistributionCalculatorOptions = new Communication.Classes.AngularPowerDistributionCalculatorOptions()
            {
                RayCount = rayCount,
                Tolerance = tolerance,
            };

            Communication.Classes.AngularPowerDistributionCalculator angularPowerDistributionCalculator = new Communication.Classes.AngularPowerDistributionCalculator()
            {
                GeometricalPropagationModel = geometricalPropagationModel,
                AngularPowerDistributionCalculatorOptions = angularPowerDistributionCalculatorOptions

            };

            bool succedded = angularPowerDistributionCalculator.Calculate();

            index = Params.IndexOfOutputParam("GeometricalPropagationModel");
            if (index != -1)
            {
                dataAccess.SetData(index, geometricalPropagationModel == null ? null : new GooGeometricalPropagationModel(geometricalPropagationModel));
            }

            index = Params.IndexOfOutputParam("AngularPowerDistributionProfiles");
            if (index != -1)
            {
                dataAccess.SetDataList(index, angularPowerDistributionCalculator?.AngularPowerDistributionProfiles?.ConvertAll(x => new GooAngularPowerDistributionProfile(x)));
            }

            if (index_Succeeded != -1)
            {
                dataAccess.SetData(index_Succeeded, succedded);
            }
        }
    }
}
