using DiGi.Communication.Enums;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("Location", "Location", "Location")]
        public static GooPoint3D? Location(this Interfaces.IAntenna? antenna)
        {
            if (antenna == null)
            {
                return null;
            }

            Geometry.Spatial.Classes.Point3D? location = antenna.Location;
        
            return location == null ? null : new GooPoint3D(location);
        }

        [Inspect("Functions", "Functions", "Functions")]
        public static IEnumerable? Functions(this Interfaces.IAntenna? antenna)
        {
            if(antenna?.Functions is not HashSet<Function> functions)
            {
                return null;
            }

            List<GooEnum> result = [];
            foreach (Function function in functions) 
            {
                result.Add(new GooEnum(function));
            }

            return result;
        }
    }
}
