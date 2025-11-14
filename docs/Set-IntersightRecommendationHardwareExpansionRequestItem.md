---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightRecommendationHardwareExpansionRequestItem

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightRecommendationHardwareExpansionRequestItem [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ItemType< RecommendationHardwareExpansionRequestItem.ItemTypeEnum>][-MaxValue< float>][-MaxValueUnit< RecommendationHardwareExpansionRequestItem.MaxValueUnitEnum>][[-Moid]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UnitType< RecommendationHardwareExpansionRequestItem.UnitTypeEnum>][-Value< float>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;RecommendationHardwareExpansionRequestItem&apos; resource.

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

### -ItemType
Type of hardware item for which the capacity increase is requested by the user. For example, CPU.\n* `None` - The Enum value None represents that no value was set for the hardware type.\n* `CPU` - The Enum value CPU represents that the hardware type requested for expansion is a physical CPU.\n* `Memory` - The Enum value Memory represents that the hardware type requested for expansion is a memory unit.\n* `Storage` - The Enum value Storage represents that the hardware type requested for expansion is a storage unit, ie, storage drives.

```yaml
Type: RecommendationHardwareExpansionRequestItem.ItemTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MaxValue
The maximum value allowed for expansion for the hardware type on the referred registered device.

```yaml
Type: float
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MaxValueUnit
Unit type for the maximum value of the resource. For example, TB, GB, MB.\n* `TB` - The Enum value TB represents that the measurement unit is in terabytes.\n* `MB` - The Enum value MB represents that the measurement unit is in megabytes.\n* `GB` - The Enum value GB represents that the measurement unit is in gigabytes.\n* `MHz` - The Enum value MHz represents that the measurement unit is in megahertz.\n* `GHz` - The Enum value GHz represents that the measurement unit is in gigahertz.\n* `Percentage` - The Enum value Percentage represents that the expansion request is in the percentage of resource increase. For example, a 20% increase in CPU capacity.

```yaml
Type: RecommendationHardwareExpansionRequestItem.MaxValueUnitEnum
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

### -UnitType
Unit type for the expansion request, i.e., if the increase is requested as a raw value in TB, GB, etc., or in percentage increase.\n* `TB` - The Enum value TB represents that the measurement unit is in terabytes.\n* `MB` - The Enum value MB represents that the measurement unit is in megabytes.\n* `GB` - The Enum value GB represents that the measurement unit is in gigabytes.\n* `MHz` - The Enum value MHz represents that the measurement unit is in megahertz.\n* `GHz` - The Enum value GHz represents that the measurement unit is in gigahertz.\n* `Percentage` - The Enum value Percentage represents that the expansion request is in the percentage of resource increase. For example, a 20% increase in CPU capacity.

```yaml
Type: RecommendationHardwareExpansionRequestItem.UnitTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Value
Value of the expansion request which can be absolute value or percentage increase.

```yaml
Type: float
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
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
PS C:\> Set-IntersightRecommendationHardwareExpansionRequestItem
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightRecommendationHardwareExpansionRequestItem](./Get-IntersightRecommendationHardwareExpansionRequestItem.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightRecommendationHardwareExpansionRequestItem](./New-IntersightRecommendationHardwareExpansionRequestItem.md)
