using DiGi.Rhino.Core.Classes;
using System;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>
    /// Represents the function component within the Rhino communication system.
    /// </summary>
    public class Function : EnumComponent<Enums.Function>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("0afa4bba-ed54-4a3d-839b-5156f243d754");

        /// <summary>
        /// Initializes a new instance of the <see cref="Function"/> class.
        /// </summary>
        // Panel Type
        public Function()
          : base("Communication")
        {
        }
    }
}
