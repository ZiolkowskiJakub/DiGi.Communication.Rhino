using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Communication.Rhino.Classes;
using DiGi.Core.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.ComputeSharp.Rhino.Classes
{
    public class CalculateScattering : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f22be95a-de19-4379-a31f-966b65ea9884");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public CalculateScattering()
          : base("Communication.CalculateScattering", "Communication.CalculateScattering",
              "Calculates Scattering",
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

                Param_Number param_Number;

                param_Number = new Param_Number() { Name = "PointDensityFactor", NickName = "PointDensityFactor", Description = "Point Density Factor", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Constans.Factor.PointDensity);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));

                param_Number = new Param_Number() { Name = "AngleFactor", NickName = "AngleFactor", Description = "Angle Factor", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Constans.Factor.Angle);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));

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
                result.Add(new Param(new GooGeometricalPropagationModelParam() { Name = "GeometricalPropagationModel", NickName = "GeometricalPropagationModel", Description = "DiGi Communication GeometricalPropagationModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooScatteringProfileParam() { Name = "ScatteringProfiles", NickName = "ScatteringProfiles", Description = "DiGi Communication ScatteringProfiles", Access = GH_ParamAccess.list }, ParameterVisibility.Voluntary));
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

            double pointDensityFactor = Constans.Factor.PointDensity;
            index = Params.IndexOfInputParam("PointDensityFactor");
            if (index != -1)
            {
                dataAccess.GetData(index, ref pointDensityFactor);
            }

            double angleFactor = Constans.Factor.Angle;
            index = Params.IndexOfInputParam("AngleFactor");
            if (index != -1)
            {
                dataAccess.GetData(index, ref angleFactor);
            }

            double tolerance = Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            geometricalPropagationModel = new Communication.Classes.GeometricalPropagationModel(geometricalPropagationModel);

            ComputeSharp.Classes.ScatteringCalculatorOptions scatteringCalculatorOptions = new ComputeSharp.Classes.ScatteringCalculatorOptions()
            {
                PointDensityFactor = pointDensityFactor,
                AngleFactor = angleFactor,
                Tolerance = tolerance,
            };

            ComputeSharp.Classes.ScatteringCalculator scatteringCalculator = new ComputeSharp.Classes.ScatteringCalculator()
            {
                GeometricalPropagationModel = geometricalPropagationModel,
                ScatteringCalculatorOptions = scatteringCalculatorOptions

            };

            bool succedded = scatteringCalculator.Calculate();

            index = Params.IndexOfOutputParam("GeometricalPropagationModel");
            if (index != -1)
            {
                dataAccess.SetData(index, geometricalPropagationModel == null ? null : new GooGeometricalPropagationModel(geometricalPropagationModel));
            }

            index = Params.IndexOfOutputParam("ScatteringProfiles");
            if (index != -1)
            {
                dataAccess.SetDataList(index, scatteringCalculator?.ScatteringProfiles?.ConvertAll(x => new GooScatteringProfile(x)));
            }

            if (index_Succeeded != -1)
            {
                dataAccess.SetData(index_Succeeded, succedded);
            }
        }
    }
}
