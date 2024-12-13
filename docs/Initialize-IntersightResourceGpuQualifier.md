---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightResourceGpuQualifier

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightResourceGpuQualifier [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< ResourceGpuQualifier.ClassIdEnum>][-GpuControllersRange< Model.ResourceGpuControllersRangeFilter>][-GpuEvaluationType< ResourceGpuQualifier.GpuEvaluationTypeEnum>][-ObjectType< ResourceGpuQualifier.ObjectTypeEnum>][-Pids< System.Collections.Generic.List`1[string]>][-Vendor< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: ResourceGpuQualifier.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -GpuControllersRange
The qualification of resources is based on number of GPU controllers between the minimum and maximum value.

Note :- Use Initialize-IntersightResourceGpuControllersRangeFilter to create the object of complex type ResourceGpuControllersRangeFilter

```yaml
Type: Model.ResourceGpuControllersRangeFilter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -GpuEvaluationType
The GPU qualifier used for resource qualification is based on gpuEvaluationType.\n* `ServerWithoutGpu` - It is used to specify the evaluation of a resource without a GPU.\n* `ServerWithGpu` - It is used to specify the evaluation of a resource with a GPU.\n* `Unspecified` - It is used to specify that the GPU qualifier should be ignored for the evaluation of a resource.

```yaml
Type: ResourceGpuQualifier.GpuEvaluationTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: ResourceGpuQualifier.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Pids


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Vendor
The qualification of resources is based on vendor of GPU.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightResourceGpuQualifier
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightResourceGpuControllersRangeFilter](./Initialize-IntersightResourceGpuControllersRangeFilter.md)
