#### [DiGi\.Communication\.Rhino](index.md 'index')

## DiGi\.Communication\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.Communication.Rhino.Classes.Antenna'></a>

## Antenna Class

Component for creating a communication antenna\.

```csharp
public class Antenna : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Antenna
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Antenna.Antenna()'></a>

## Antenna\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public Antenna();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Antenna.ComponentGuid'></a>

## Antenna\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Antenna.Exposure'></a>

## Antenna\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.Antenna.Inputs'></a>

## Antenna\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.Antenna.Outputs'></a>

## Antenna\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.Antenna.SolveInstance(IGH_DataAccess)'></a>

## Antenna\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.Antenna.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile'></a>

## ComplexMultipathPowerDelayProfile Class

Component for creating a complex multipath power delay profile by combining profiles for visible and hidden antenna cases\.

```csharp
public class ComplexMultipathPowerDelayProfile : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ComplexMultipathPowerDelayProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile()'></a>

## ComplexMultipathPowerDelayProfile\(\) Constructor

Initializes a new instance of the ComplexMultipathPowerDelayProfile class\.

```csharp
public ComplexMultipathPowerDelayProfile();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile.ComponentGuid'></a>

## ComplexMultipathPowerDelayProfile\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile.Exposure'></a>

## ComplexMultipathPowerDelayProfile\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile.Inputs'></a>

## ComplexMultipathPowerDelayProfile\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile.Outputs'></a>

## ComplexMultipathPowerDelayProfile\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile.SolveInstance(IGH_DataAccess)'></a>

## ComplexMultipathPowerDelayProfile\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.ComplexMultipathPowerDelayProfile.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.DefaultSimpleMultipathPowerDelayProfile'></a>

## DefaultSimpleMultipathPowerDelayProfile Class

Represents the default simple multipath power delay profile component\.

```csharp
public class DefaultSimpleMultipathPowerDelayProfile : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.Communication.Enums.DefaultSimpleMultipathPowerDelayProfile>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1')[DiGi\.Communication\.Enums\.DefaultSimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.enums.defaultsimplemultipathpowerdelayprofile 'DiGi\.Communication\.Enums\.DefaultSimpleMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1') → DefaultSimpleMultipathPowerDelayProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.DefaultSimpleMultipathPowerDelayProfile.DefaultSimpleMultipathPowerDelayProfile()'></a>

## DefaultSimpleMultipathPowerDelayProfile\(\) Constructor

Initializes a new instance of the [DefaultSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.DefaultSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.DefaultSimpleMultipathPowerDelayProfile') class\.

```csharp
public DefaultSimpleMultipathPowerDelayProfile();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.DefaultSimpleMultipathPowerDelayProfile.ComponentGuid'></a>

## DefaultSimpleMultipathPowerDelayProfile\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid'></a>

## Ellipsoid Class

Represents a Grasshopper component that creates an ellipsoid based on two antennas and a time delay\.

```csharp
public class Ellipsoid : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Ellipsoid
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid.Ellipsoid()'></a>

## Ellipsoid\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public Ellipsoid();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid.ComponentGuid'></a>

## Ellipsoid\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid.Exposure'></a>

## Ellipsoid\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid.Inputs'></a>

## Ellipsoid\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid.Outputs'></a>

## Ellipsoid\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid.SolveInstance(IGH_DataAccess)'></a>

## Ellipsoid\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.Ellipsoid.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.Function'></a>

## Function Class

Represents the function component within the Rhino communication system\.

```csharp
public class Function : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.Communication.Enums.Function>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1')[DiGi\.Communication\.Enums\.Function](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.enums.function 'DiGi\.Communication\.Enums\.Function')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1') → Function
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Function.Function()'></a>

## Function\(\) Constructor

Initializes a new instance of the [Function](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.Function 'DiGi\.Communication\.Rhino\.Classes\.Function') class\.

```csharp
public Function();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Function.ComponentGuid'></a>

## Function\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel'></a>

## GeometricalPropagationModel Class

Component that creates a geometrical propagation model based on antennas and multipath power delay profiles\.

```csharp
public class GeometricalPropagationModel : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → GeometricalPropagationModel
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel.GeometricalPropagationModel()'></a>

## GeometricalPropagationModel\(\) Constructor

Initializes a new instance of the GeometricalPropagationModel class\.

```csharp
public GeometricalPropagationModel();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel.ComponentGuid'></a>

## GeometricalPropagationModel\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel.Exposure'></a>

## GeometricalPropagationModel\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel.Inputs'></a>

## GeometricalPropagationModel\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel.Outputs'></a>

## GeometricalPropagationModel\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel.SolveInstance(IGH_DataAccess)'></a>

## GeometricalPropagationModel\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GeometricalPropagationModel.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution'></a>

## GooAngularPowerDistribution Class

Represents a Goo wrapper for the [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution') interface to enable its use within Grasshopper\.

```csharp
public class GooAngularPowerDistribution : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Communication.Interfaces.IAngularPowerDistribution>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooAngularPowerDistribution
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution.GooAngularPowerDistribution()'></a>

## GooAngularPowerDistribution\(\) Constructor

Initializes a new instance of the [GooAngularPowerDistribution](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistribution') class\.

```csharp
public GooAngularPowerDistribution();
```

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution.GooAngularPowerDistribution(DiGi.Communication.Interfaces.IAngularPowerDistribution)'></a>

## GooAngularPowerDistribution\(IAngularPowerDistribution\) Constructor

Initializes a new instance of the [GooAngularPowerDistribution](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistribution') class with the specified angular power distribution\.

```csharp
public GooAngularPowerDistribution(DiGi.Communication.Interfaces.IAngularPowerDistribution? angularPowerDistribution);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution.GooAngularPowerDistribution(DiGi.Communication.Interfaces.IAngularPowerDistribution).angularPowerDistribution'></a>

`angularPowerDistribution` [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')

The [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution') instance to be wrapped\.
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution.Duplicate()'></a>

## GooAngularPowerDistribution\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionParam'></a>

## GooAngularPowerDistributionParam Class

The Grasshopper parameter component used to handle and transport [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution') data\.

```csharp
public class GooAngularPowerDistributionParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution, DiGi.Communication.Interfaces.IAngularPowerDistribution>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooAngularPowerDistribution](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistribution 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistribution')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooAngularPowerDistributionParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionParam.ComponentGuid'></a>

## GooAngularPowerDistributionParam\.ComponentGuid Property

Gets the unique identifier for the [GooAngularPowerDistributionParam](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionParam 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistributionParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile'></a>

## GooAngularPowerDistributionProfile Class

Represents a Goo wrapper for an angular power distribution profile\.

```csharp
public class GooAngularPowerDistributionProfile : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Interfaces.IAngularPowerDistributionProfile>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooAngularPowerDistributionProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile.GooAngularPowerDistributionProfile()'></a>

## GooAngularPowerDistributionProfile\(\) Constructor

Initializes a new instance of the [GooAngularPowerDistributionProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistributionProfile') class\.

```csharp
public GooAngularPowerDistributionProfile();
```

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile.GooAngularPowerDistributionProfile(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile)'></a>

## GooAngularPowerDistributionProfile\(IAngularPowerDistributionProfile\) Constructor

Initializes a new instance of the [GooAngularPowerDistributionProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistributionProfile') class with the specified angular power distribution profile\.

```csharp
public GooAngularPowerDistributionProfile(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile.GooAngularPowerDistributionProfile(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to assign\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile.Geometries'></a>

## GooAngularPowerDistributionProfile\.Geometries Property

Gets the geometries associated with the angular power distribution profile\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile.Duplicate()'></a>

## GooAngularPowerDistributionProfile\.Duplicate\(\) Method

Creates a duplicate of this object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same value\.

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfileParam'></a>

## GooAngularPowerDistributionProfileParam Class

Represents the Grasshopper parameter for an angular power distribution profile\.

```csharp
public class GooAngularPowerDistributionProfileParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile, DiGi.Communication.Interfaces.IAngularPowerDistributionProfile>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooAngularPowerDistributionProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooAngularPowerDistributionProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooAngularPowerDistributionProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfile 'DiGi\.Communication\.Rhino\.Classes\.GooAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooAngularPowerDistributionProfileParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooAngularPowerDistributionProfileParam.ComponentGuid'></a>

## GooAngularPowerDistributionProfileParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooAntenna'></a>

## GooAntenna Class

Represents a Grasshopper\-compatible wrapper for an antenna object\.

```csharp
public class GooAntenna : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Interfaces.IAntenna>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooAntenna
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooAntenna.GooAntenna()'></a>

## GooAntenna\(\) Constructor

Initializes a new instance of the [GooAntenna](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAntenna 'DiGi\.Communication\.Rhino\.Classes\.GooAntenna') class\.

```csharp
public GooAntenna();
```

<a name='DiGi.Communication.Rhino.Classes.GooAntenna.GooAntenna(DiGi.Communication.Interfaces.IAntenna)'></a>

## GooAntenna\(IAntenna\) Constructor

Initializes a new instance of the [GooAntenna](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAntenna 'DiGi\.Communication\.Rhino\.Classes\.GooAntenna') class with the specified antenna\.

```csharp
public GooAntenna(DiGi.Communication.Interfaces.IAntenna? antenna);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooAntenna.GooAntenna(DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The antenna to wrap\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooAntenna.Geometries'></a>

## GooAntenna\.Geometries Property

Gets the geometry associated with the antenna, typically its location point\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooAntenna.Duplicate()'></a>

## GooAntenna\.Duplicate\(\) Method

Creates a duplicate of the current [GooAntenna](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAntenna 'DiGi\.Communication\.Rhino\.Classes\.GooAntenna') object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance representing the duplicated antenna\.

<a name='DiGi.Communication.Rhino.Classes.GooAntennaParam'></a>

## GooAntennaParam Class

Represents the Grasshopper parameter type for antennas\.

```csharp
public class GooAntennaParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooAntenna, DiGi.Communication.Interfaces.IAntenna>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooAntenna](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAntenna 'DiGi\.Communication\.Rhino\.Classes\.GooAntenna')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooAntenna](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAntenna 'DiGi\.Communication\.Rhino\.Classes\.GooAntenna')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooAntenna](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooAntenna 'DiGi\.Communication\.Rhino\.Classes\.GooAntenna')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooAntennaParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooAntennaParam.ComponentGuid'></a>

## GooAntennaParam\.ComponentGuid Property

Gets the unique identifier for the antenna component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel'></a>

## GooGeometricalPropagationModel Class

Represents a Goo wrapper for the geometrical propagation model, enabling its use within the Rhino and Grasshopper environment\.

```csharp
public class GooGeometricalPropagationModel : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Classes.GeometricalPropagationModel>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooGeometricalPropagationModel
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel.GooGeometricalPropagationModel()'></a>

## GooGeometricalPropagationModel\(\) Constructor

Initializes a new instance of the [GooGeometricalPropagationModel](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel 'DiGi\.Communication\.Rhino\.Classes\.GooGeometricalPropagationModel') class\.

```csharp
public GooGeometricalPropagationModel();
```

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel.GooGeometricalPropagationModel(DiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## GooGeometricalPropagationModel\(GeometricalPropagationModel\) Constructor

Initializes a new instance of the [GooGeometricalPropagationModel](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel 'DiGi\.Communication\.Rhino\.Classes\.GooGeometricalPropagationModel') class with the specified geometrical propagation model\.

```csharp
public GooGeometricalPropagationModel(DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel.GooGeometricalPropagationModel(DiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The [DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') to wrap\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel.Geometries'></a>

## GooGeometricalPropagationModel\.Geometries Property

Gets the collection of geometries derived from the scattering objects within the propagation model\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel.Duplicate()'></a>

## GooGeometricalPropagationModel\.Duplicate\(\) Method

Creates a duplicate of the current [GooGeometricalPropagationModel](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel 'DiGi\.Communication\.Rhino\.Classes\.GooGeometricalPropagationModel') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the propagation model\.

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModelParam'></a>

## GooGeometricalPropagationModelParam Class

Represents the Grasshopper parameter type for the geometrical propagation model\.

```csharp
public class GooGeometricalPropagationModelParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel, DiGi.Communication.Classes.GeometricalPropagationModel>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooGeometricalPropagationModel](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel 'DiGi\.Communication\.Rhino\.Classes\.GooGeometricalPropagationModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooGeometricalPropagationModel](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel 'DiGi\.Communication\.Rhino\.Classes\.GooGeometricalPropagationModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooGeometricalPropagationModel](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModel 'DiGi\.Communication\.Rhino\.Classes\.GooGeometricalPropagationModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooGeometricalPropagationModelParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooGeometricalPropagationModelParam.ComponentGuid'></a>

## GooGeometricalPropagationModelParam\.ComponentGuid Property

Gets the unique identifier for the Grasshopper component associated with this parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooRay'></a>

## GooRay Class

Represents a wrapper for a Ray object to enable serialization and baking within the Rhino/Grasshopper environment\.

```csharp
public class GooRay : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Classes.Ray>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooRay
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooRay.GooRay()'></a>

## GooRay\(\) Constructor

Initializes a new instance of the [GooRay](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooRay 'DiGi\.Communication\.Rhino\.Classes\.GooRay') class\.

```csharp
public GooRay();
```

<a name='DiGi.Communication.Rhino.Classes.GooRay.GooRay(DiGi.Communication.Classes.Ray)'></a>

## GooRay\(Ray\) Constructor

Initializes a new instance of the [GooRay](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooRay 'DiGi\.Communication\.Rhino\.Classes\.GooRay') class with a specified Ray value\.

```csharp
public GooRay(DiGi.Communication.Classes.Ray? ray);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooRay.GooRay(DiGi.Communication.Classes.Ray).ray'></a>

`ray` [DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')

The Ray object to wrap\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooRay.Geometries'></a>

## GooRay\.Geometries Property

Gets the geometric representations associated with this GooRay\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooRay.Duplicate()'></a>

## GooRay\.Duplicate\(\) Method

Creates a duplicate of the current GooRay instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the Ray value\.

<a name='DiGi.Communication.Rhino.Classes.GooRayParam'></a>

## GooRayParam Class

Provides the parameter definition for handling [GooRay](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooRay 'DiGi\.Communication\.Rhino\.Classes\.GooRay') objects in Grasshopper components\.

```csharp
public class GooRayParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooRay, DiGi.Communication.Classes.Ray>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooRay](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooRay 'DiGi\.Communication\.Rhino\.Classes\.GooRay')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooRay](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooRay 'DiGi\.Communication\.Rhino\.Classes\.GooRay')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooRay](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooRay 'DiGi\.Communication\.Rhino\.Classes\.GooRay')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Classes\.Ray](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooRayParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooRayParam.ComponentGuid'></a>

## GooRayParam\.ComponentGuid Property

Gets the unique identifier for the GooRay component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooScattering'></a>

## GooScattering Class

Represents a Goo wrapper for scattering data\.

```csharp
public class GooScattering : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Interfaces.IScattering>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooScattering
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooScattering.GooScattering()'></a>

## GooScattering\(\) Constructor

Initializes a new instance of the [GooScattering](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScattering 'DiGi\.Communication\.Rhino\.Classes\.GooScattering') class\.

```csharp
public GooScattering();
```

<a name='DiGi.Communication.Rhino.Classes.GooScattering.GooScattering(DiGi.Communication.Interfaces.IScattering)'></a>

## GooScattering\(IScattering\) Constructor

Initializes a new instance of the [GooScattering](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScattering 'DiGi\.Communication\.Rhino\.Classes\.GooScattering') class with the specified scattering value\.

```csharp
public GooScattering(DiGi.Communication.Interfaces.IScattering? scattering);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooScattering.GooScattering(DiGi.Communication.Interfaces.IScattering).scattering'></a>

`scattering` [DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering')

The scattering object to wrap\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScattering.Geometries'></a>

## GooScattering\.Geometries Property

Gets the collection of geometries associated with the scattering point groups\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooScattering.Duplicate()'></a>

## GooScattering\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicate instance as an [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')\.

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObject'></a>

## GooScatteringObject Class

Represents a Goo wrapper for an [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')\.

```csharp
public class GooScatteringObject : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Interfaces.IScatteringObject>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooScatteringObject
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObject.GooScatteringObject()'></a>

## GooScatteringObject\(\) Constructor

Initializes a new instance of the [GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject') class\.

```csharp
public GooScatteringObject();
```

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObject.GooScatteringObject(DiGi.Communication.Interfaces.IScatteringObject)'></a>

## GooScatteringObject\(IScatteringObject\) Constructor

Initializes a new instance of the [GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject') class with the specified scattering object\.

```csharp
public GooScatteringObject(DiGi.Communication.Interfaces.IScatteringObject? scattering);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObject.GooScatteringObject(DiGi.Communication.Interfaces.IScatteringObject).scattering'></a>

`scattering` [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')

The scattering object to wrap\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObject.Geometries'></a>

## GooScatteringObject\.Geometries Property

Gets the geometries associated with the scattering object\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObject.Duplicate()'></a>

## GooScatteringObject\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject') containing the same value\.

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObjectParam'></a>

## GooScatteringObjectParam Class

Represents the Grasshopper parameter type for [GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject')\.

```csharp
public class GooScatteringObjectParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooScatteringObject, DiGi.Communication.Interfaces.IScatteringObject>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooScatteringObject](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringObject 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooScatteringObjectParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScatteringObjectParam.ComponentGuid'></a>

## GooScatteringObjectParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooScatteringParam'></a>

## GooScatteringParam Class

Represents the Grasshopper parameter for scattering data\.

```csharp
public class GooScatteringParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooScattering, DiGi.Communication.Interfaces.IScattering>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooScattering](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScattering 'DiGi\.Communication\.Rhino\.Classes\.GooScattering')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooScattering](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScattering 'DiGi\.Communication\.Rhino\.Classes\.GooScattering')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooScattering](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScattering 'DiGi\.Communication\.Rhino\.Classes\.GooScattering')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooScatteringParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScatteringParam.ComponentGuid'></a>

## GooScatteringParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroup'></a>

## GooScatteringPointGroup Class

Represents a Goo wrapper for a scattering point group, enabling its use within the Grasshopper environment\.

```csharp
public class GooScatteringPointGroup : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Classes.ScatteringPointGroup>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooScatteringPointGroup
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroup.GooScatteringPointGroup()'></a>

## GooScatteringPointGroup\(\) Constructor

Initializes a new instance of the [GooScatteringPointGroup](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringPointGroup 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringPointGroup') class\.

```csharp
public GooScatteringPointGroup();
```

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroup.GooScatteringPointGroup(DiGi.Communication.Classes.ScatteringPointGroup)'></a>

## GooScatteringPointGroup\(ScatteringPointGroup\) Constructor

Initializes a new instance of the [GooScatteringPointGroup](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringPointGroup 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringPointGroup') class with the specified scattering point group\.

```csharp
public GooScatteringPointGroup(DiGi.Communication.Classes.ScatteringPointGroup? scatteringPointGroup);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroup.GooScatteringPointGroup(DiGi.Communication.Classes.ScatteringPointGroup).scatteringPointGroup'></a>

`scatteringPointGroup` [DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')

The scattering point group to assign as the value\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroup.Geometries'></a>

## GooScatteringPointGroup\.Geometries Property

Gets the collection of geometries associated with the scattering point group\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroup.Duplicate()'></a>

## GooScatteringPointGroup\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') containing a copy of the original value\.

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroupParam'></a>

## GooScatteringPointGroupParam Class

Represents the Grasshopper parameter type for scattering point groups\.

```csharp
public class GooScatteringPointGroupParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooScatteringPointGroup, DiGi.Communication.Classes.ScatteringPointGroup>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooScatteringPointGroup](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringPointGroup 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringPointGroup')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooScatteringPointGroup](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringPointGroup 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringPointGroup')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooScatteringPointGroup](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringPointGroup 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringPointGroup')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Classes\.ScatteringPointGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringpointgroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooScatteringPointGroupParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScatteringPointGroupParam.ComponentGuid'></a>

## GooScatteringPointGroupParam\.ComponentGuid Property

Gets the unique identifier for the scattering point group component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfile'></a>

## GooScatteringProfile Class

Represents a Goo wrapper for an [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')\.

```csharp
public class GooScatteringProfile : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Communication.Interfaces.IScatteringProfile>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooScatteringProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfile.GooScatteringProfile()'></a>

## GooScatteringProfile\(\) Constructor

Initializes a new instance of the [GooScatteringProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringProfile 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringProfile') class\.

```csharp
public GooScatteringProfile();
```

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfile.GooScatteringProfile(DiGi.Communication.Interfaces.IScatteringProfile)'></a>

## GooScatteringProfile\(IScatteringProfile\) Constructor

Initializes a new instance of the [GooScatteringProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringProfile 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringProfile') class with the specified scattering profile\.

```csharp
public GooScatteringProfile(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfile.GooScatteringProfile(DiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to assign\.
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfile.Geometries'></a>

## GooScatteringProfile\.Geometries Property

Gets the geometries associated with the scattering profile\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfile.Duplicate()'></a>

## GooScatteringProfile\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing a copy of the value\.

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfileParam'></a>

## GooScatteringProfileParam Class

Represents the Grasshopper parameter type for [GooScatteringProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringProfile 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringProfile')\.

```csharp
public class GooScatteringProfileParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Communication.Rhino.Classes.GooScatteringProfile, DiGi.Communication.Interfaces.IScatteringProfile>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooScatteringProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringProfile 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooScatteringProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringProfile 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooScatteringProfile](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.GooScatteringProfile 'DiGi\.Communication\.Rhino\.Classes\.GooScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooScatteringProfileParam
### Properties

<a name='DiGi.Communication.Rhino.Classes.GooScatteringProfileParam.ComponentGuid'></a>

## GooScatteringProfileParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds'></a>

## Polyline3Ds Class

Represents a Grasshopper component that generates 3D polylines based on scattering profiles and delay parameters\.

```csharp
public class Polyline3Ds : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Polyline3Ds
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds.Polyline3Ds()'></a>

## Polyline3Ds\(\) Constructor

Initializes a new instance of the [Polyline3Ds](DiGi.Communication.Rhino.Classes.md#DiGi.Communication.Rhino.Classes.Polyline3Ds 'DiGi\.Communication\.Rhino\.Classes\.Polyline3Ds') class\.

```csharp
public Polyline3Ds();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds.ComponentGuid'></a>

## Polyline3Ds\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds.Exposure'></a>

## Polyline3Ds\.Exposure Property

Gets or sets the exposure of the component in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds.Inputs'></a>

## Polyline3Ds\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds.Outputs'></a>

## Polyline3Ds\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds.SolveInstance(IGH_DataAccess)'></a>

## Polyline3Ds\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.Polyline3Ds.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.Rays'></a>

## Rays Class

Component that calculates rays based on an angular power distribution profile and delay\.

```csharp
public class Rays : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Rays
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Rays.Rays()'></a>

## Rays\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public Rays();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Rays.ComponentGuid'></a>

## Rays\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Rays.Exposure'></a>

## Rays\.Exposure Property

Gets the exposure of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.Rays.Inputs'></a>

## Rays\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.Rays.Outputs'></a>

## Rays\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.Rays.SolveInstance(IGH_DataAccess)'></a>

## Rays\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.Rays.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information and metadata for the DiGi\.Communication\.Rhino library within the Grasshopper environment\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Communication.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the contact information for the author of this class\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author of this class\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets the description of this instance\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets the icon associated with this instance\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Communication.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for this instance\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of this instance\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject'></a>

## ScatteringObject Class

Represents a Grasshopper component that creates a scattering object for communication purposes\.

```csharp
public class ScatteringObject : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ScatteringObject
### Constructors

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject.ScatteringObject()'></a>

## ScatteringObject\(\) Constructor

Initializes a new instance of the ScatteringObject class\.

```csharp
public ScatteringObject();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject.ComponentGuid'></a>

## ScatteringObject\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject.Exposure'></a>

## ScatteringObject\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject.Inputs'></a>

## ScatteringObject\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject.Outputs'></a>

## ScatteringObject\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject.SolveInstance(IGH_DataAccess)'></a>

## ScatteringObject\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.ScatteringObject.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep'></a>

## ScatteringObjectByBrep Class

Component that creates scattering objects based on Brep geometry for DiGi communication\.

```csharp
public class ScatteringObjectByBrep : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ScatteringObjectByBrep
### Constructors

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep.ScatteringObjectByBrep()'></a>

## ScatteringObjectByBrep\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public ScatteringObjectByBrep();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep.ComponentGuid'></a>

## ScatteringObjectByBrep\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep.Exposure'></a>

## ScatteringObjectByBrep\.Exposure Property

Gets or sets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep.Inputs'></a>

## ScatteringObjectByBrep\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep.Outputs'></a>

## ScatteringObjectByBrep\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep.SolveInstance(IGH_DataAccess)'></a>

## ScatteringObjectByBrep\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.ScatteringObjectByBrep.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile'></a>

## SimpleMultipathPowerDelayProfile Class

Component that creates a Simple Multipath Power Delay Profile based on a selected default profile\.

```csharp
public class SimpleMultipathPowerDelayProfile : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → SimpleMultipathPowerDelayProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile()'></a>

## SimpleMultipathPowerDelayProfile\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public SimpleMultipathPowerDelayProfile();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile.ComponentGuid'></a>

## SimpleMultipathPowerDelayProfile\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile.Exposure'></a>

## SimpleMultipathPowerDelayProfile\.Exposure Property

Gets the exposure of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile.Inputs'></a>

## SimpleMultipathPowerDelayProfile\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile.Outputs'></a>

## SimpleMultipathPowerDelayProfile\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile.SolveInstance(IGH_DataAccess)'></a>

## SimpleMultipathPowerDelayProfile\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfile.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays'></a>

## SimpleMultipathPowerDelayProfileByDelays Class

A component that creates a SimpleMultipathPowerDelayProfile using lists of delay and power values\.

```csharp
public class SimpleMultipathPowerDelayProfileByDelays : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → SimpleMultipathPowerDelayProfileByDelays
### Constructors

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays.SimpleMultipathPowerDelayProfileByDelays()'></a>

## SimpleMultipathPowerDelayProfileByDelays\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public SimpleMultipathPowerDelayProfileByDelays();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays.ComponentGuid'></a>

## SimpleMultipathPowerDelayProfileByDelays\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays.Exposure'></a>

## SimpleMultipathPowerDelayProfileByDelays\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays.Inputs'></a>

## SimpleMultipathPowerDelayProfileByDelays\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays.Outputs'></a>

## SimpleMultipathPowerDelayProfileByDelays\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays.SolveInstance(IGH_DataAccess)'></a>

## SimpleMultipathPowerDelayProfileByDelays\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.SimpleMultipathPowerDelayProfileByDelays.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution'></a>

## SolveAngularPowerDistribution Class

Solves angular power distribution for a geometrical propagation model\.

```csharp
public class SolveAngularPowerDistribution : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → SolveAngularPowerDistribution
### Constructors

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution.SolveAngularPowerDistribution()'></a>

## SolveAngularPowerDistribution\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public SolveAngularPowerDistribution();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution.ComponentGuid'></a>

## SolveAngularPowerDistribution\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution.Exposure'></a>

## SolveAngularPowerDistribution\.Exposure Property

Gets the exposure of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution.Inputs'></a>

## SolveAngularPowerDistribution\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution.Outputs'></a>

## SolveAngularPowerDistribution\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution.SolveInstance(IGH_DataAccess)'></a>

## SolveAngularPowerDistribution\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.SolveAngularPowerDistribution.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.