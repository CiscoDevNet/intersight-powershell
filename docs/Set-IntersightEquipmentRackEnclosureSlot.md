---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightEquipmentRackEnclosureSlot

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightEquipmentRackEnclosureSlot [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][[-Moid]< string>][-PreviousFru< EquipmentFruRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;EquipmentRackEnclosureSlot&apos; resource.

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

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreviousFru
A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: EquipmentFruRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
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
PS C:\> Set-IntersightEquipmentRackEnclosureSlot
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightEquipmentRackEnclosureSlot](./Get-IntersightEquipmentRackEnclosureSlot.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
