using DiGi.Rhino.Core.Classes;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    public class Function : EnumComponent<Enums.Function>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("0afa4bba-ed54-4a3d-839b-5156f243d754");

        /// <summary>
        /// Panel Type
        /// </summary>
        public Function()
          : base("Communication")
        {
        }
    }
}

