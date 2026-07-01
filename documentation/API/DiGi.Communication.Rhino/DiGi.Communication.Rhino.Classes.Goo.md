#### [DiGi\.Communication\.Rhino](index.md 'index')

## DiGi\.Communication\.Rhino\.Classes\.Goo Namespace
### Classes

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile'></a>

## GooComplexMultipathPowerDelayProfile Class

Represents a Goo wrapper for a complex multipath power delay profile\.

```csharp
public class GooComplexMultipathPowerDelayProfile : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooComplexMultipathPowerDelayProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile.GooComplexMultipathPowerDelayProfile()'></a>

## GooComplexMultipathPowerDelayProfile\(\) Constructor

Initializes a new instance of the [GooComplexMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooComplexMultipathPowerDelayProfile') class\.

```csharp
public GooComplexMultipathPowerDelayProfile();
```

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile.GooComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile)'></a>

## GooComplexMultipathPowerDelayProfile\(IComplexMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [GooComplexMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooComplexMultipathPowerDelayProfile') class with the specified value\.

```csharp
public GooComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile.GooComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile).complexMultipathPowerDelayProfile'></a>

`complexMultipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')

The complex multipath power delay profile to wrap\.
### Methods

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile.Duplicate()'></a>

## GooComplexMultipathPowerDelayProfile\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicated [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance\.

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfileParam'></a>

## GooComplexMultipathPowerDelayProfileParam Class

Represents a Grasshopper parameter for the complex multipath power delay profile\.

```csharp
public class GooComplexMultipathPowerDelayProfileParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile, DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooComplexMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooComplexMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooComplexMultipathPowerDelayProfileParam
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfileParam.GooComplexMultipathPowerDelayProfileParam()'></a>

## GooComplexMultipathPowerDelayProfileParam\(\) Constructor

Initializes a new instance of the [GooComplexMultipathPowerDelayProfileParam](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfileParam 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooComplexMultipathPowerDelayProfileParam') class\.

```csharp
public GooComplexMultipathPowerDelayProfileParam();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Goo.GooComplexMultipathPowerDelayProfileParam.ComponentGuid'></a>

## GooComplexMultipathPowerDelayProfileParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile'></a>

## GooMultipathPowerDelayProfile Class

Represents a Goo wrapper for an [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')\.

```csharp
public class GooMultipathPowerDelayProfile : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Communication.Interfaces.IMultipathPowerDelayProfile>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooMultipathPowerDelayProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile.GooMultipathPowerDelayProfile()'></a>

## GooMultipathPowerDelayProfile\(\) Constructor

Initializes a new instance of the [GooMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooMultipathPowerDelayProfile') class\.

```csharp
public GooMultipathPowerDelayProfile();
```

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile.GooMultipathPowerDelayProfile(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile)'></a>

## GooMultipathPowerDelayProfile\(IMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [GooMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooMultipathPowerDelayProfile') class with the specified multipath power delay profile\.

```csharp
public GooMultipathPowerDelayProfile(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile.GooMultipathPowerDelayProfile(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to wrap\.
### Methods

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile.Duplicate()'></a>

## GooMultipathPowerDelayProfile\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicate [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object\.

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfileParam'></a>

## GooMultipathPowerDelayProfileParam Class

Represents a Grasshopper parameter for the [GooMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooMultipathPowerDelayProfile')\.

```csharp
public class GooMultipathPowerDelayProfileParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooMultipathPowerDelayProfileParam
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfileParam.GooMultipathPowerDelayProfileParam()'></a>

## GooMultipathPowerDelayProfileParam\(\) Constructor

Initializes a new instance of the [GooMultipathPowerDelayProfileParam](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfileParam 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooMultipathPowerDelayProfileParam') class\.

```csharp
public GooMultipathPowerDelayProfileParam();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Goo.GooMultipathPowerDelayProfileParam.ComponentGuid'></a>

## GooMultipathPowerDelayProfileParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile'></a>

## GooSimpleMultipathPowerDelayProfile Class

Represents a Goo wrapper for the simple multipath power delay profile\.

```csharp
public class GooSimpleMultipathPowerDelayProfile : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooSimpleMultipathPowerDelayProfile
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile.GooSimpleMultipathPowerDelayProfile()'></a>

## GooSimpleMultipathPowerDelayProfile\(\) Constructor

Initializes a new instance of the [GooSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfile') class\.

```csharp
public GooSimpleMultipathPowerDelayProfile();
```

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile.GooSimpleMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile)'></a>

## GooSimpleMultipathPowerDelayProfile\(ISimpleMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [GooSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfile') class with the specified profile\.

```csharp
public GooSimpleMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile.GooSimpleMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile'></a>

`simpleMultipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The simple multipath power delay profile to wrap\.
### Methods

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile.Duplicate()'></a>

## GooSimpleMultipathPowerDelayProfile\.Duplicate\(\) Method

Creates a duplicate of this Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') containing the duplicated value\.

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfileParam'></a>

## GooSimpleMultipathPowerDelayProfileParam Class

Represents a Grasshopper parameter for the simple multipath power delay profile\.

```csharp
public class GooSimpleMultipathPowerDelayProfileParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile, DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooSimpleMultipathPowerDelayProfile](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooSimpleMultipathPowerDelayProfileParam
### Constructors

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfileParam.GooSimpleMultipathPowerDelayProfileParam()'></a>

## GooSimpleMultipathPowerDelayProfileParam\(\) Constructor

Initializes a new instance of the [GooSimpleMultipathPowerDelayProfileParam](DiGi.Communication.Rhino.Classes.Goo.md#DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfileParam 'DiGi\.Communication\.Rhino\.Classes\.Goo\.GooSimpleMultipathPowerDelayProfileParam') class\.

```csharp
public GooSimpleMultipathPowerDelayProfileParam();
```
### Properties

<a name='DiGi.Communication.Rhino.Classes.Goo.GooSimpleMultipathPowerDelayProfileParam.ComponentGuid'></a>

## GooSimpleMultipathPowerDelayProfileParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')