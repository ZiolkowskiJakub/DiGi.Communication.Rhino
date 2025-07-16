using DiGi.Communication.Classes;
using DiGi.Communication.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino.Classes
{
    public class GooScattering : GooBakeAwareSerializableObject<IScattering>
    {
        public GooScattering()
            : base()
        {
        }

        public GooScattering(IScattering scattering)
        {
            Value = scattering;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                List<ScatteringPointGroup> scatteringPointGroups = Value?.ScatteringPointGroups;
                if(scatteringPointGroups == null)
                {
                    return null;
                }

                List<IGeometry> geometries = new List<IGeometry>();
                foreach(ScatteringPointGroup scatteringPointGroup in scatteringPointGroups)
                {
                    scatteringPointGroup?.Points?.ForEach(x => geometries.Add(x));
                }

                return geometries.ToArray();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooScattering(Value);
        }

    }

    public class GooScatteringParam : GooBakeAwareSerializableParam<GooScattering, IScattering>
    {
        public override Guid ComponentGuid => new Guid("760f3e12-4622-4efb-862f-90e15b7532b8");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
