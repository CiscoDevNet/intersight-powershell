---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBlueprintGeneratedObjectSourceLookup

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBlueprintGeneratedObjectSourceLookup [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BlueprintGeneratedObjectSourceLookup.ClassIdEnum>][-LookupType< BlueprintGeneratedObjectSourceLookup.LookupTypeEnum>][-ObjectType< BlueprintGeneratedObjectSourceLookup.ObjectTypeEnum>][-SourceSelectors< System.Collections.Generic.List`1[Model.BlueprintGeneratedObjectSourceSelector]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: BlueprintGeneratedObjectSourceLookup.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LookupType
The type of the object being looked up.\n* `Cloned` - The generated object that is being looked up is a result of a deep clone from a previous step.\n* `PreCreated` - The generated object that is being looked up is an existing or pre-created object from the system catalog or from the user account.

```yaml
Type: BlueprintGeneratedObjectSourceLookup.LookupTypeEnum
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
Type: BlueprintGeneratedObjectSourceLookup.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SourceSelectors


Note :- Use Initialize-IntersightBlueprintGeneratedObjectSourceSelector to create the object of complex type BlueprintGeneratedObjectSourceSelector

```yaml
Type: System.Collections.Generic.List`1[Model.BlueprintGeneratedObjectSourceSelector]
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
PS C:\> Initialize-IntersightBlueprintGeneratedObjectSourceLookup
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightBlueprintGeneratedObjectSourceSelector](./Initialize-IntersightBlueprintGeneratedObjectSourceSelector.md)
