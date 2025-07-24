using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class ScatteringObjectByBrep : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("736b1a41-efe1-4e70-b04e-94b27db8ddf9");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ScatteringObjectByBrep()
          : base("Communication.ScatteringObjectByBrep", "Communication.ScatteringObjectByBrep",
              "Creates ScatteringObject by brep",
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
                result.Add(new Param(new Param_Brep() { Name = "Brep", NickName = "Brep", Description = "Brep", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_String() { Name = "Reference", NickName = "Reference", Description = "Reference", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));

                result.Add(new Param(new Param_Number() { Name = "ScatteringCoefficient", NickName = "ScatteringCoefficient", Description = "ScatteringCoefficient", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));

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
                result.Add(new Param(new GooScatteringObjectParam() { Name = "ScatteringObjects", NickName = "ScatteringObjects", Description = "DiGi Communication Scattering Objects", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Brep");
            global::Rhino.Geometry.Brep brep = null;
            if (index == -1 || !dataAccess.GetData(index, ref brep) || brep == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            string reference = null;
            index = Params.IndexOfInputParam("Reference");
            if (index != -1)
            {
                dataAccess.GetData(index, ref reference);
            }

            double scatteringCoefficient = 1;
            index = Params.IndexOfInputParam("ScatteringCoefficient");
            if (index != -1)
            {
                if (!dataAccess.GetData(index, ref scatteringCoefficient))
                {
                    scatteringCoefficient = 1;
                }
            }

            global::Rhino.Geometry.Mesh[] meshes = global::Rhino.Geometry.Mesh.CreateFromBrep(brep, new global::Rhino.Geometry.MeshingParameters(0.5));

            List<Communication.Classes.ScatteringObject> scatteringObjects = null;
            if(meshes != null)
            {
                scatteringObjects = new List<Communication.Classes.ScatteringObject>();
                foreach (global::Rhino.Geometry.Mesh mesh in meshes)
                {
                    Mesh3D mesh3D = DiGi.Rhino.Geometry.Spatial.Convert.ToDiGi(mesh);
                    if (mesh3D == null)
                    {
                        continue;
                    }

                    Communication.Classes.ScatteringObject scatteringObject = new Communication.Classes.ScatteringObject(reference, mesh3D, scatteringCoefficient);
                    scatteringObjects.Add(scatteringObject);
                }
            }

            index = Params.IndexOfOutputParam("ScatteringObjects");
            if (index != -1)
            {
                dataAccess.SetDataList(index, scatteringObjects?.ConvertAll(x => new GooScatteringObject(x)));
            }
        }
    }
}
