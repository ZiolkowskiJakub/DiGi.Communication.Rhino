using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Communication.Rhino.Classes
{
    /// <summary>Provides assembly information and metadata for the DiGi.Communication.Rhino library within the Grasshopper environment.</summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>Gets the name of this instance.</summary>
        public override string Name => "DiGi.Communication.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        /// <summary>Gets the icon associated with this instance.</summary>
        public override Bitmap? Icon => null;

        //Return a short string describing the purpose of this GHA library.
        /// <summary>Gets the description of this instance.</summary>
        public override string Description => "";

        /// <summary>Gets the unique identifier for this instance.</summary>
        public override Guid Id => new("3a71eef5-24aa-48b0-972f-ba9e5f3fe68f");

        //Return a string identifying you or your company.
        /// <summary>Gets the name of the author of this class.</summary>
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        /// <summary>Gets the contact information for the author of this class.</summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}
