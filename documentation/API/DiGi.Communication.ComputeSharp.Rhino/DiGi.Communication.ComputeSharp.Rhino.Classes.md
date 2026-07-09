#### [DiGi\.Communication\.ComputeSharp\.Rhino](DiGi.Communication.ComputeSharp.Rhino.Overview.md 'DiGi\.Communication\.ComputeSharp\.Rhino\.Overview')

## DiGi\.Communication\.ComputeSharp\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information and metadata for the DiGi\.Communication\.ComputeSharp\.Rhino implementation\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the contact information for the author of this implementation\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author of this implementation\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets the description of this implementation\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets the icon for this implementation\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for this implementation\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of this implementation\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering'></a>

## SolveScattering Class

Component that solves scattering based on a geometrical propagation model\.

```csharp
public class SolveScattering : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → SolveScattering
### Constructors

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering.SolveScattering()'></a>

## SolveScattering\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public SolveScattering();
```
### Properties

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering.ComponentGuid'></a>

## SolveScattering\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering.Exposure'></a>

## SolveScattering\.Exposure Property

Gets the exposure of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering.Inputs'></a>

## SolveScattering\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering.Outputs'></a>

## SolveScattering\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering.SolveInstance(IGH_DataAccess)'></a>

## SolveScattering\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Communication.ComputeSharp.Rhino.Classes.SolveScattering.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.