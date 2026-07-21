#### [DiGi\.Communication\.Rhino](DiGi.Communication.Rhino.Overview.md 'DiGi\.Communication\.Rhino\.Overview')

## DiGi\.Communication\.Rhino Namespace
### Classes

<a name='DiGi.Communication.Rhino.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.Communication.Rhino.Inspect.AngularPowerDistributionProfiles(thisDiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## Inspect\.AngularPowerDistributionProfiles\(this GeometricalPropagationModel\) Method

Retrieves the angular power distribution profiles from the specified geometrical propagation model\.

```csharp
public static System.Collections.IEnumerable? AngularPowerDistributionProfiles(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.AngularPowerDistributionProfiles(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of [GooAngularPowerDistributionProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistributionProfile') objects, or null if the model is null or contains no profiles\.

<a name='DiGi.Communication.Rhino.Inspect.AngularPowerDistributions(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile)'></a>

## Inspect\.AngularPowerDistributions\(this IAngularPowerDistributionProfile\) Method

Gets the angular power distributions from the specified angular power distribution profile\.

```csharp
public static System.Collections.IEnumerable? AngularPowerDistributions(this DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.AngularPowerDistributions(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of GooAngularPowerDistribution objects, or null if the profile is null\.

<a name='DiGi.Communication.Rhino.Inspect.Antennas(thisDiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## Inspect\.Antennas\(this GeometricalPropagationModel\) Method

Retrieves the antennas from the specified geometrical propagation model\.

```csharp
public static System.Collections.IEnumerable? Antennas(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Antennas(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of [GooAntenna](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAntenna 'DiGi\.Communication\.Rhino\.Classes\.GooAntenna') objects, or null if the model is null or contains no antennas\.

<a name='DiGi.Communication.Rhino.Inspect.Delay(thisDiGi.Communication.Classes.Scattering)'></a>

## Inspect\.Delay\(this Scattering\) Method

Retrieves the delay value from the provided scattering object, converted to micrometers \(μm\)\.

```csharp
public static GH_Number? Delay(this DiGi.Communication.Classes.Scattering? scattering);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Delay(thisDiGi.Communication.Classes.Scattering).scattering'></a>

`scattering` [DiGi\.Communication\.Classes\.Scattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scattering 'DiGi\.Communication\.Classes\.Scattering')

The scattering object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A GH\_Number representing the delay in micrometers, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.Delay(thisDiGi.Communication.Interfaces.IAngularPowerDistribution)'></a>

## Inspect\.Delay\(this IAngularPowerDistribution\) Method

Gets the delay value in micrometers for the specified angular power distribution\.

```csharp
public static GH_Number? Delay(this DiGi.Communication.Interfaces.IAngularPowerDistribution? angularPowerDistribution);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Delay(thisDiGi.Communication.Interfaces.IAngularPowerDistribution).angularPowerDistribution'></a>

`angularPowerDistribution` [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')

The angular power distribution instance\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The delay as a GH\_Number in micrometers, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.Delays(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile)'></a>

## Inspect\.Delays\(this IAngularPowerDistributionProfile\) Method

Gets the delays from the specified angular power distribution profile converted to micrometers\.

```csharp
public static System.Collections.IEnumerable? Delays(this DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Delays(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of GH\_Number objects representing delays in micrometers, or null if the profile or distributions are null\.

<a name='DiGi.Communication.Rhino.Inspect.Delays(thisDiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile)'></a>

## Inspect\.Delays\(this ISimpleMultipathPowerDelayProfile\) Method

Retrieves the delays from the provided simple multipath power delay profile, converted to micrometers\.

```csharp
public static System.Collections.IEnumerable? Delays(this DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Delays(thisDiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile'></a>

`simpleMultipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The simple multipath power delay profile instance\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of GH\_Number representing the delays in micrometers, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.ElectricalConductivity(thisDiGi.Communication.Interfaces.IScatteringObject)'></a>

## Inspect\.ElectricalConductivity\(this IScatteringObject\) Method

Retrieves the electrical conductivity of the scattering object as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? ElectricalConductivity(this DiGi.Communication.Interfaces.IScatteringObject? scatteringObject);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.ElectricalConductivity(thisDiGi.Communication.Interfaces.IScatteringObject).scatteringObject'></a>

`scatteringObject` [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')

The [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject') to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the electrical conductivity \[S/m\], or `null` if the scattering object is null\.

<a name='DiGi.Communication.Rhino.Inspect.Ellipsoids(thisDiGi.Communication.Interfaces.IScatteringProfile)'></a>

## Inspect\.Ellipsoids\(this IScatteringProfile\) Method

Generates ellipsoids based on the locations and scatterings of the scattering profile\.

```csharp
public static System.Collections.IEnumerable? Ellipsoids(this DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Ellipsoids(thisDiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable') of [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.gooellipsoid 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooEllipsoid') objects, or null if required data is missing\.

<a name='DiGi.Communication.Rhino.Inspect.Functions(thisDiGi.Communication.Interfaces.IAntenna)'></a>

## Inspect\.Functions\(this IAntenna\) Method

Retrieves the functions supported by the specified antenna\.

```csharp
public static System.Collections.IEnumerable? Functions(this DiGi.Communication.Interfaces.IAntenna? antenna);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Functions(thisDiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The antenna instance\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable') of [DiGi\.Rhino\.Core\.Classes\.GooEnum](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') representing the functions, or null if no functions are available\.

<a name='DiGi.Communication.Rhino.Inspect.Location(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile)'></a>

## Inspect\.Location\(this IAngularPowerDistributionProfile\) Method

Gets the location of the specified angular power distribution profile\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Location(this DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Location(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
A GooPoint3D object representing the location, or null if the profile is null\.

<a name='DiGi.Communication.Rhino.Inspect.Location(thisDiGi.Communication.Interfaces.IAntenna)'></a>

## Inspect\.Location\(this IAntenna\) Method

Retrieves the location of the specified antenna\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Location(this DiGi.Communication.Interfaces.IAntenna? antenna);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Location(thisDiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The antenna instance\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') representing the location, or null if the antenna or its location is null\.

<a name='DiGi.Communication.Rhino.Inspect.Location_1(thisDiGi.Communication.Interfaces.IScatteringProfile)'></a>

## Inspect\.Location\_1\(this IScatteringProfile\) Method

Gets the first location of the scattering profile as a GooPoint3D\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Location_1(this DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Location_1(thisDiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to inspect\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') representing the first location, or null if the profile or location is null\.

<a name='DiGi.Communication.Rhino.Inspect.Location_2(thisDiGi.Communication.Interfaces.IScatteringProfile)'></a>

## Inspect\.Location\_2\(this IScatteringProfile\) Method

Gets the second location of the scattering profile as a GooPoint3D\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Location_2(this DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Location_2(thisDiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to inspect\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') representing the second location, or null if the profile or location is null\.

<a name='DiGi.Communication.Rhino.Inspect.Mesh3D(thisDiGi.Communication.Interfaces.IScatteringObject)'></a>

## Inspect\.Mesh3D\(this IScatteringObject\) Method

Retrieves the mesh 3D geometry of the scattering object as a [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goomesh3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D? Mesh3D(this DiGi.Communication.Interfaces.IScatteringObject? scatteringObject);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Mesh3D(thisDiGi.Communication.Interfaces.IScatteringObject).scatteringObject'></a>

`scatteringObject` [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')

The [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject') to inspect\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goomesh3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goomesh3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D') representing the mesh, or `null` if the scattering object is null\.

<a name='DiGi.Communication.Rhino.Inspect.MultipathPowerDelayProfiles(thisDiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## Inspect\.MultipathPowerDelayProfiles\(this GeometricalPropagationModel\) Method

Retrieves the multipath power delay profiles from the specified geometrical propagation model\.

```csharp
public static System.Collections.IEnumerable? MultipathPowerDelayProfiles(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.MultipathPowerDelayProfiles(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of [GooMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooMultipathPowerDelayProfile') objects, or null if the model is null or contains no profiles\.

<a name='DiGi.Communication.Rhino.Inspect.Point(thisDiGi.Communication.Classes.Ray)'></a>

## Inspect\.Point\(this Ray\) Method

Extracts the point from the specified [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray') and converts it to a [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPoint3D? Point(this DiGi.Communication.Classes.Ray? ray);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Point(thisDiGi.Communication.Classes.Ray).ray'></a>

`ray` [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')

The [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray') to extract the point from\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopoint3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPoint3D') representing the ray's origin point, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the ray is null or the point is null\.

<a name='DiGi.Communication.Rhino.Inspect.Power(thisDiGi.Communication.Interfaces.IAngularPowerDistribution)'></a>

## Inspect\.Power\(this IAngularPowerDistribution\) Method

Gets the power value for the specified angular power distribution\.

```csharp
public static GH_Number? Power(this DiGi.Communication.Interfaces.IAngularPowerDistribution? angularPowerDistribution);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Power(thisDiGi.Communication.Interfaces.IAngularPowerDistribution).angularPowerDistribution'></a>

`angularPowerDistribution` [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')

The angular power distribution instance\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
The power as a GH\_Number, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.Powers(thisDiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile)'></a>

## Inspect\.Powers\(this ISimpleMultipathPowerDelayProfile\) Method

Retrieves the powers associated with the delays from the provided simple multipath power delay profile\.

```csharp
public static System.Collections.IEnumerable? Powers(this DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Powers(thisDiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile'></a>

`simpleMultipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The simple multipath power delay profile instance\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of GH\_Number representing the powers, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.Rays(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile)'></a>

## Inspect\.Rays\(this IAngularPowerDistributionProfile\) Method

Gets the rays associated with the specified angular power distribution profile\.

```csharp
public static System.Collections.IEnumerable? Rays(this DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Rays(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of GooRay objects, or null if the profile or location is null\.

<a name='DiGi.Communication.Rhino.Inspect.Reference(thisDiGi.Communication.Classes.ScatteringPointGroup)'></a>

## Inspect\.Reference\(this ScatteringPointGroup\) Method

Retrieves the reference value from the specified [DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')\.

```csharp
public static GH_String? Reference(this DiGi.Communication.Classes.ScatteringPointGroup? scatteringPointGroup);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Reference(thisDiGi.Communication.Classes.ScatteringPointGroup).scatteringPointGroup'></a>

`scatteringPointGroup` [DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')

The scattering point group to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the reference, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.Reference(thisDiGi.Communication.Interfaces.IScatteringObject)'></a>

## Inspect\.Reference\(this IScatteringObject\) Method

Retrieves the reference of the scattering object as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static GH_String? Reference(this DiGi.Communication.Interfaces.IScatteringObject? scatteringObject);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Reference(thisDiGi.Communication.Interfaces.IScatteringObject).scatteringObject'></a>

`scatteringObject` [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')

The [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject') to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the reference, or `null` if the scattering object is null\.

<a name='DiGi.Communication.Rhino.Inspect.RelativePermittivity(thisDiGi.Communication.Interfaces.IScatteringObject)'></a>

## Inspect\.RelativePermittivity\(this IScatteringObject\) Method

Retrieves the relative permittivity of the scattering object as a [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')\.

```csharp
public static GH_Number? RelativePermittivity(this DiGi.Communication.Interfaces.IScatteringObject? scatteringObject);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.RelativePermittivity(thisDiGi.Communication.Interfaces.IScatteringObject).scatteringObject'></a>

`scatteringObject` [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')

The [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject') to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') containing the relative permittivity \[\-\], or `null` if the scattering object is null\.

<a name='DiGi.Communication.Rhino.Inspect.ScatteringObjects(thisDiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## Inspect\.ScatteringObjects\(this GeometricalPropagationModel\) Method

Retrieves the scattering objects from the specified geometrical propagation model\.

```csharp
public static System.Collections.IEnumerable? ScatteringObjects(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.ScatteringObjects(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of [GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject') objects, or null if the model is null or contains no objects\.

<a name='DiGi.Communication.Rhino.Inspect.ScatteringPointGroups(thisDiGi.Communication.Classes.Scattering)'></a>

## Inspect\.ScatteringPointGroups\(this Scattering\) Method

Retrieves the scattering point groups from the provided scattering object and converts them to GooScatteringPointGroup instances\.

```csharp
public static System.Collections.IEnumerable? ScatteringPointGroups(this DiGi.Communication.Classes.Scattering? scattering);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.ScatteringPointGroups(thisDiGi.Communication.Classes.Scattering).scattering'></a>

`scattering` [DiGi\.Communication\.Classes\.Scattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scattering 'DiGi\.Communication\.Classes\.Scattering')

The scattering object to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of scattering point groups, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.ScatteringPoints(thisDiGi.Communication.Classes.ScatteringPointGroup)'></a>

## Inspect\.ScatteringPoints\(this ScatteringPointGroup\) Method

Retrieves the collection of points from the specified [DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')\.

```csharp
public static System.Collections.IEnumerable? ScatteringPoints(this DiGi.Communication.Classes.ScatteringPointGroup? scatteringPointGroup);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.ScatteringPoints(thisDiGi.Communication.Classes.ScatteringPointGroup).scatteringPointGroup'></a>

`scatteringPointGroup` [DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')

The scattering point group to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable') containing the converted points, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.ScatteringProfiles(thisDiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## Inspect\.ScatteringProfiles\(this GeometricalPropagationModel\) Method

Retrieves the scattering profiles from the specified geometrical propagation model\.

```csharp
public static System.Collections.IEnumerable? ScatteringProfiles(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.ScatteringProfiles(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of [GooScatteringProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringProfile 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringProfile') objects, or null if the model is null or contains no profiles\.

<a name='DiGi.Communication.Rhino.Inspect.Scatterings(thisDiGi.Communication.Interfaces.IScatteringProfile)'></a>

## Inspect\.Scatterings\(this IScatteringProfile\) Method

Gets the scatterings of the scattering profile as a collection of GooScattering objects\.

```csharp
public static System.Collections.IEnumerable? Scatterings(this DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Scatterings(thisDiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable') of [GooScattering](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScattering 'DiGi\.Communication\.Rhino\.Classes\.GooScattering') objects, or null if the profile or scatterings are null\.

<a name='DiGi.Communication.Rhino.Inspect.Segment(thisDiGi.Communication.Classes.Ray)'></a>

## Inspect\.Segment\(this Ray\) Method

Creates a segment from the specified [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray') and converts it to a [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goosegment3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooSegment3D? Segment(this DiGi.Communication.Classes.Ray? ray);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Segment(thisDiGi.Communication.Classes.Ray).ray'></a>

`ray` [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')

The [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray') used to define the segment\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goosegment3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goosegment3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooSegment3D') representing the ray's point and vector, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the ray, its point, or its vector is null\.

<a name='DiGi.Communication.Rhino.Inspect.SimpleMultipathPowerDelayProfile_Hidden(thisDiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile)'></a>

## Inspect\.SimpleMultipathPowerDelayProfile\_Hidden\(this IComplexMultipathPowerDelayProfile\) Method

Returns a GooSimpleMultipathPowerDelayProfile for the case where antennas are hidden\.

```csharp
public static DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile? SimpleMultipathPowerDelayProfile_Hidden(this DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.SimpleMultipathPowerDelayProfile_Hidden(thisDiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile).complexMultipathPowerDelayProfile'></a>

`complexMultipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')

The complex multipath power delay profile to inspect\.

#### Returns
[GooSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfile')  
A [GooSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfile') instance if successful; otherwise, null\.

<a name='DiGi.Communication.Rhino.Inspect.SimpleMultipathPowerDelayProfile_Visible(thisDiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile)'></a>

## Inspect\.SimpleMultipathPowerDelayProfile\_Visible\(this IComplexMultipathPowerDelayProfile\) Method

Returns a GooSimpleMultipathPowerDelayProfile for the case where antennas are visible\.

```csharp
public static DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile? SimpleMultipathPowerDelayProfile_Visible(this DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.SimpleMultipathPowerDelayProfile_Visible(thisDiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile).complexMultipathPowerDelayProfile'></a>

`complexMultipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')

The complex multipath power delay profile to inspect\.

#### Returns
[GooSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfile')  
A [GooSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfile') instance if successful; otherwise, null\.

<a name='DiGi.Communication.Rhino.Inspect.Vector(thisDiGi.Communication.Classes.Ray)'></a>

## Inspect\.Vector\(this Ray\) Method

Extracts the vector from the specified [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray') and converts it to a [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goovector3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooVector3D? Vector(this DiGi.Communication.Classes.Ray? ray);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Vector(thisDiGi.Communication.Classes.Ray).ray'></a>

`ray` [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')

The [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray') to extract the vector from\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goovector3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goovector3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooVector3D') representing the ray's vector, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the ray is null or the vector is null\.

<a name='DiGi.Communication.Rhino.Inspect.Vectors(thisDiGi.Communication.Interfaces.IAngularPowerDistribution)'></a>

## Inspect\.Vectors\(this IAngularPowerDistribution\) Method

Gets the vectors associated with the specified angular power distribution\.

```csharp
public static System.Collections.IEnumerable? Vectors(this DiGi.Communication.Interfaces.IAngularPowerDistribution? angularPowerDistribution);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Vectors(thisDiGi.Communication.Interfaces.IAngularPowerDistribution).angularPowerDistribution'></a>

`angularPowerDistribution` [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')

The angular power distribution instance\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
A collection of vectors converted to GooVector3D, or null if the input is null\.

<a name='DiGi.Communication.Rhino.Inspect.Visible(thisDiGi.Communication.Interfaces.IScatteringProfile)'></a>

## Inspect\.Visible\(this IScatteringProfile\) Method

Gets the visibility status of the scattering profile\.

```csharp
public static GH_Boolean? Visible(this DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Inspect.Visible(thisDiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Boolean](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_boolean 'Grasshopper\.Kernel\.Types\.GH\_Boolean')  
A [Grasshopper\.Kernel\.Types\.GH\_Boolean](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_boolean 'Grasshopper\.Kernel\.Types\.GH\_Boolean') indicating if the profile is visible, or null if the profile is null\.