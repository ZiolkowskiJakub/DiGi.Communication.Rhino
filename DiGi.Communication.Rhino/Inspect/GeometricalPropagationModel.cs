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
        /// <summary>
        /// Retrieves the angular power distribution profiles from the specified geometrical propagation model.
        /// </summary>
        /// <param name="geometricalPropagationModel">The geometrical propagation model to inspect.</param>
        /// <returns>A collection of <see cref="GooAngularPowerDistributionProfile"/> objects, or null if the model is null or contains no profiles.</returns>
        [Inspect("AngularPowerDistributionProfiles", "AngularPowerDistributionProfiles", "AngularPowerDistributionProfiles")]
        public static IEnumerable? AngularPowerDistributionProfiles(this Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IAngularPowerDistributionProfile>? angularPowerDistributionProfiles = geometricalPropagationModel.GetAngularPowerDistributionProfiles<IAngularPowerDistributionProfile>();
            if (angularPowerDistributionProfiles == null)
            {
                return null;
            }

            List<GooAngularPowerDistributionProfile> result = [];
            foreach (IAngularPowerDistributionProfile angularPowerDistributionProfile in angularPowerDistributionProfiles)
            {
                result.Add(new GooAngularPowerDistributionProfile(angularPowerDistributionProfile));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the antennas from the specified geometrical propagation model.
        /// </summary>
        /// <param name="geometricalPropagationModel">The geometrical propagation model to inspect.</param>
        /// <returns>A collection of <see cref="GooAntenna"/> objects, or null if the model is null or contains no antennas.</returns>
        [Inspect("Antennas", "Antennas", "Antennas")]
        public static IEnumerable? Antennas(this Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IAntenna>? antennas = geometricalPropagationModel.GetAntennas<IAntenna>();
            if (antennas == null)
            {
                return null;
            }

            List<GooAntenna> result = [];
            foreach (IAntenna antenna in antennas)
            {
                result.Add(new GooAntenna(antenna));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the multipath power delay profiles from the specified geometrical propagation model.
        /// </summary>
        /// <param name="geometricalPropagationModel">The geometrical propagation model to inspect.</param>
        /// <returns>A collection of <see cref="GooMultipathPowerDelayProfile"/> objects, or null if the model is null or contains no profiles.</returns>
        [Inspect("MultipathPowerDelayProfiles", "MultipathPowerDelayProfiles", "MultipathPowerDelayProfiles")]
        public static IEnumerable? MultipathPowerDelayProfiles(this Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IMultipathPowerDelayProfile>? multipathPowerDelayProfiles = geometricalPropagationModel.GetMultipathPowerDelayProfiles<IMultipathPowerDelayProfile>();
            if (multipathPowerDelayProfiles == null)
            {
                return null;
            }

            List<GooMultipathPowerDelayProfile> result = [];
            foreach (IMultipathPowerDelayProfile multipathPowerDelayProfile in multipathPowerDelayProfiles)
            {
                result.Add(new GooMultipathPowerDelayProfile(multipathPowerDelayProfile));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the scattering objects from the specified geometrical propagation model.
        /// </summary>
        /// <param name="geometricalPropagationModel">The geometrical propagation model to inspect.</param>
        /// <returns>A collection of <see cref="GooScatteringObject"/> objects, or null if the model is null or contains no objects.</returns>
        [Inspect("ScatteringObjects", "ScatteringObjects", "ScatteringObjects")]
        public static IEnumerable? ScatteringObjects(this Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IScatteringObject>? scatteringObjects = geometricalPropagationModel.GetScatteringObjects<IScatteringObject>();
            if (scatteringObjects == null)
            {
                return null;
            }

            List<GooScatteringObject> result = [];
            foreach (IScatteringObject scatteringObject in scatteringObjects)
            {
                result.Add(new GooScatteringObject(scatteringObject));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the scattering profiles from the specified geometrical propagation model.
        /// </summary>
        /// <param name="geometricalPropagationModel">The geometrical propagation model to inspect.</param>
        /// <returns>A collection of <see cref="GooScatteringProfile"/> objects, or null if the model is null or contains no profiles.</returns>
        [Inspect("ScatteringProfiles", "ScatteringProfiles", "ScatteringProfiles")]
        public static IEnumerable? ScatteringProfiles(this Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel)
        {
            if (geometricalPropagationModel == null)
            {
                return null;
            }

            List<IScatteringProfile>? scatteringProfiles = geometricalPropagationModel.GetScatteringProfiles<IScatteringProfile>();
            if (scatteringProfiles == null)
            {
                return null;
            }

            List<GooScatteringProfile> result = [];
            foreach (IScatteringProfile scatteringProfile in scatteringProfiles)
            {
                result.Add(new GooScatteringProfile(scatteringProfile));
            }

            return result;
        }
    }
}
