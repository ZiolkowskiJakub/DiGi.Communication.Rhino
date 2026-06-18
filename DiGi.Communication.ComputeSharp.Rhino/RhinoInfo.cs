using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Communication.ComputeSharp.Rhino.Classes
{
    /// <summary>Provides assembly information and metadata for the DiGi.Communication.ComputeSharp.Rhino implementation.</summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>Gets the name of this implementation.</summary>
        public override string Name => "DiGi.Communication.ComputeSharp.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        /// <summary>Gets the icon for this implementation.</summary>
        public override Bitmap? Icon => null;

        //Return a short string describing the purpose of this GHA library.
        /// <summary>Gets the description of this implementation.</summary>
        public override string Description => "";

        /// <summary>Gets the unique identifier for this implementation.</summary>
        public override Guid Id => new("97dc83eb-e746-4838-8644-57f96b834025");

        //Return a string identifying you or your company.
        /// <summary>Gets the name of the author of this implementation.</summary>
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        /// <summary>Gets the contact information for the author of this implementation.</summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}
