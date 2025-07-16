using DiGi.Communication.Interfaces;
using DiGi.Communication.Rhino.Classes;
using DiGi.Communication.Rhino.Classes.Goo;
using DiGi.Rhino.Core.Classes;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Communication.Rhino
{

    public static partial class Inspect
    {

        [Inspect("Antennas", "Antennas", "Antennas")]
        public static IEnumerable Antennas(this Communication.Classes.GeometricalPropagationModel geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IAntenna> antennas = geometricalPropagationModel.GetAntennas<IAntenna>();
            if(antennas == null)
            {
                return null;
            }

            List<GooAntenna> result = new List<GooAntenna>();
            foreach(IAntenna antenna in antennas)
            {
                result.Add(new GooAntenna(antenna));
            }

            return result;
        }

        [Inspect("ScatteringObjects", "ScatteringObjects", "ScatteringObjects")]
        public static IEnumerable ScatteringObjects(this Communication.Classes.GeometricalPropagationModel geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IScatteringObject> scatteringObjects = geometricalPropagationModel.GetScatteringObjects<IScatteringObject>();
            if (scatteringObjects == null)
            {
                return null;
            }

            List<GooScatteringObject> result = new List<GooScatteringObject>();
            foreach (IScatteringObject scatteringObject in scatteringObjects)
            {
                result.Add(new GooScatteringObject(scatteringObject));
            }

            return result;
        }

        [Inspect("MultipathPowerDelayProfiles", "MultipathPowerDelayProfiles", "MultipathPowerDelayProfiles")]
        public static IEnumerable MultipathPowerDelayProfiles(this Communication.Classes.GeometricalPropagationModel geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IMultipathPowerDelayProfile> multipathPowerDelayProfiles = geometricalPropagationModel.GetMultipathPowerDelayProfiles<IMultipathPowerDelayProfile>();
            if (multipathPowerDelayProfiles == null)
            {
                return null;
            }

            List<GooMultipathPowerDelayProfile> result = new List<GooMultipathPowerDelayProfile>();
            foreach (IMultipathPowerDelayProfile multipathPowerDelayProfile in multipathPowerDelayProfiles)
            {
                result.Add(new GooMultipathPowerDelayProfile(multipathPowerDelayProfile));
            }

            return result;
        }

        [Inspect("ScatteringProfiles", "ScatteringProfiles", "ScatteringProfiles")]
        public static IEnumerable ScatteringProfiles(this Communication.Classes.GeometricalPropagationModel geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IScatteringProfile> scatteringProfiles = geometricalPropagationModel.GetScatteringProfiles<IScatteringProfile>();
            if (scatteringProfiles == null)
            {
                return null;
            }

            List<GooScatteringProfile> result = new List<GooScatteringProfile>();
            foreach (IScatteringProfile scatteringProfile in scatteringProfiles)
            {
                result.Add(new GooScatteringProfile(scatteringProfile));
            }

            return result;
        }
    }
}
