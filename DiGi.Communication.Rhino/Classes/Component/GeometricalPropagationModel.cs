using DiGi.Communication.Interfaces;
using DiGi.Communication.Rhino.Classes.Goo;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class GeometricalPropagationModel : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("7b5a71e5-d703-48b7-9138-abf958e3e8f6");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public GeometricalPropagationModel()
          : base("Communication.GeometricalPropagationModel", "Communication.GeometricalPropagationModel",
              "Creates GeometricalPropagationModel",
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
                result.Add(new Param(new GooMultipathPowerDelayProfileParam() { Name = "MultipathPowerDelayProfile", NickName = "MultipathPowerDelayProfile", Description = "MultipathPowerDelayProfile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooScatteringObjectParam() { Name = "ScatteringObjects", NickName = "ScatteringObjects", Description = "ScatteringObjects", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Binding));

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

            index = Params.IndexOfInputParam("MultipathPowerDelayProfile");
            IMultipathPowerDelayProfile multipathPowerDelayProfile = null;
            if (index == -1 || !dataAccess.GetData(index, ref multipathPowerDelayProfile) || multipathPowerDelayProfile == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ScatteringObjects");
            List<IScatteringObject> scatteringObjects = new List<IScatteringObject>();
            if (index != -1)
            {
                dataAccess.GetDataList(index, scatteringObjects);
            }


            Communication.Classes.GeometricalPropagationModel geometricalPropagationModel = new Communication.Classes.GeometricalPropagationModel();
            geometricalPropagationModel.Assign(multipathPowerDelayProfile, antenna_1, antenna_2);

            if(scatteringObjects != null)
            {
                foreach(IScatteringObject scatteringObject in scatteringObjects)
                {
                    geometricalPropagationModel.Update(scatteringObject);
                }
            }

            index = Params.IndexOfOutputParam("GeometricalPropagationModel");
            if (index != -1)
            {
                dataAccess.SetData(index, geometricalPropagationModel == null ? null : new GooGeometricalPropagationModel(geometricalPropagationModel));
            }
        }
    }
}
