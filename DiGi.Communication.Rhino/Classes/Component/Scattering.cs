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
    public class Scattering : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("74c35d49-9e35-4573-bb0b-c253fec01df5");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Scattering()
          : base("GIS.Scattering", "GIS.Scattering",
              "Creates Scattering",
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
                result.Add(new Param(new GooEllipsoidalPropagationParam() { Name = "EllipsoidalPropagation", NickName = "EllipsoidalPropagation", Description = "Ellipsoidal Propagation", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooScatteringObjectParam() { Name = "ScatteringObjects", NickName = "ScatteringObjects", Description = "Scattering Objects", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));

                Param_Number param_Number;

                param_Number = new Param_Number() { Name = "PointDensity", NickName = "PointDensity", Description = "Point Density", Access = GH_ParamAccess.item, Optional = true };
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
                result.Add(new Param(new GooScatteringParam() { Name = "Scattering", NickName = "Scattering", Description = "DiGi Communication Scattering", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooMesh3DParam() { Name = "EllipsoidMesh3D", NickName = "EllipsoidMesh3D", Description = "Ellipsoid Mesh3D", Access = GH_ParamAccess.item }, ParameterVisibility.Voluntary));
                result.Add(new Param(new GooSegment3DParam() { Name = "IntersectionSegment3Ds", NickName = "IntersectionSegment3Ds", Description = "Intersection Segment3Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Voluntary));
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

            index = Params.IndexOfInputParam("EllipsoidalPropagation");
            Communication.Classes.EllipsoidalPropagation ellipsoidalPropagation = null;
            if (index == -1 || !dataAccess.GetData(index, ref ellipsoidalPropagation) || ellipsoidalPropagation == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ScatteringObjects");
            List<IScatteringObject> scatteringObjects = new List<IScatteringObject>();
            if (index == -1 || !dataAccess.GetDataList(index, scatteringObjects) || scatteringObjects == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double pointDensity = Constans.Factor.PointDensity;
            index = Params.IndexOfInputParam("PointDensity");
            if (index != -1)
            {
                dataAccess.GetData(index, ref pointDensity);
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

            Communication.Classes.Scattering scattering = Create.Scattering(ellipsoidalPropagation, scatteringObjects, out Geometry.Spatial.Classes.Mesh3D ellipsoidMesh3D, out List<Geometry.Spatial.Classes.Segment3D> intersectionSegment3Ds, pointDensity, angleFactor, tolerance);

            index = Params.IndexOfOutputParam("Scattering");
            if (index != -1)
            {
                dataAccess.SetData(index, scattering == null ? null : new GooScattering(scattering));
            }

            index = Params.IndexOfOutputParam("EllipsoidMesh3D");
            if (index != -1)
            {
                dataAccess.SetData(index, scattering == null ? null : new GooMesh3D(ellipsoidMesh3D));
            }

            index = Params.IndexOfOutputParam("IntersectionSegment3Ds");
            if (index != -1)
            {
                dataAccess.SetDataList(index, intersectionSegment3Ds?.ConvertAll(x => new GooSegment3D(x)));
            }
        }
    }
}
