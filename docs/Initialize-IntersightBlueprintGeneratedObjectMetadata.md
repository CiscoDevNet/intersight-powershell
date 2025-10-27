---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBlueprintGeneratedObjectMetadata

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBlueprintGeneratedObjectMetadata [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BlueprintGeneratedObjectMetadata.ClassIdEnum>][-Conditions< System.Collections.Generic.List`1[string]>][-Name< string>][-ObjectIteration< string>][-ObjectSource< Model.BlueprintBaseGeneratedObjectSourceMetadata>][-ObjectType< BlueprintGeneratedObjectMetadata.ObjectTypeEnum>][-PreGenerateOperations< System.Collections.Generic.List`1[Model.BlueprintPreGenerateOperation]>][-PropertyIteration< System.Collections.Generic.List`1[Model.BlueprintPropertyIteration]>][-PropertyParameters< object>][-Required< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BlueprintGeneratedObjectMetadata.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Conditions


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

### -Name
Name for the generated object. The name given for reference in later parts of the blueprint definition. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character.

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

### -ObjectIteration
A template for controlling loop behavior when generating multiple instances of the generated object. The resolved value of the template is expected to be an integer which is used to determine the number of iterations in the loop. Each iteration creates a new instance of the generated object.

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

### -ObjectSource
The source object from which the object is generated.

Note :- Use Initialize-IntersightBlueprintBaseGeneratedObjectSourceMetadata to create the object of complex type BlueprintBaseGeneratedObjectSourceMetadata

```yaml
Type: Model.BlueprintBaseGeneratedObjectSourceMetadata
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
Type: BlueprintGeneratedObjectMetadata.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreGenerateOperations


Note :- Use Initialize-IntersightBlueprintPreGenerateOperation to create the object of complex type BlueprintPreGenerateOperation

```yaml
Type: System.Collections.Generic.List`1[Model.BlueprintPreGenerateOperation]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PropertyIteration


Note :- Use Initialize-IntersightBlueprintPropertyIteration to create the object of complex type BlueprintPropertyIteration

```yaml
Type: System.Collections.Generic.List`1[Model.BlueprintPropertyIteration]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PropertyParameters
A list of key value pairs where key is the property path and value is the template to derive the value.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Required
The flag to indicate if this object must be generated for this blueprint.

```yaml
Type: bool
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
PS C:\> Initialize-IntersightBlueprintGeneratedObjectMetadata
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightBlueprintBaseGeneratedObjectSourceMetadata](./Initialize-IntersightBlueprintBaseGeneratedObjectSourceMetadata.md)

[Initialize-IntersightBlueprintPreGenerateOperation](./Initialize-IntersightBlueprintPreGenerateOperation.md)

[Initialize-IntersightBlueprintPropertyIteration](./Initialize-IntersightBlueprintPropertyIteration.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
