---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightBulkMoMerger

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightBulkMoMerger [-AdditionalProperties< Dictionary<string,object>>][-MergeAction< BulkMoMerger.MergeActionEnum>][-Moid< string>][-Organization< OrganizationOrganizationRelationship>][-Responses< List<BulkRestResult>>][-Sources< List<MoBaseMo>>][-Tags< List<MoTag>>][-TargetConfig< MoBaseMo>][-Targets< List<MoBaseMo>>]

```

## DESCRIPTION
Create a &apos;BulkMoMerger&apos; resource.

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

### -MergeAction
The type of merge action to be applied on the target MOs. \n* `Merge` - The null properties/relationships of the source MO will be ignored for the target MO. The non-null properties/relationships of the source will override the target MO properties/relationships.\n* `Replace` - Merge action as described in RFC 7386. The null properties/relationships of the source MO will be deleted on the target MO.The non-null properties/relationships of the source will override the target MO properties/relationships.When source object type is different from target, only the properties common to both source and target  will be affected.Other properties on the target will be ignored.

```yaml
Type: BulkMoMerger.MergeActionEnum
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Responses


Note :- Use Initialize-IntersightBulkRestResult to create the object of complex type BulkRestResult

```yaml
Type: System.Collections.Generic.List`1[BulkRestResult]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sources


Note :- Use Initialize-IntersightMoBaseMo to create the object of complex type MoBaseMo

```yaml
Type: System.Collections.Generic.List`1[MoBaseMo]
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

### -TargetConfig
JSON document specifying the configuration, if applicable, to be applied on all the target MOs.

Note :- Use Initialize-IntersightMoBaseMo to create the object of complex type MoBaseMo

```yaml
Type: MoBaseMo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Targets


Note :- Use Initialize-IntersightMoBaseMo to create the object of complex type MoBaseMo

```yaml
Type: System.Collections.Generic.List`1[MoBaseMo]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightBulkMoMerger
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightBulkRestResult](./Initialize-IntersightBulkRestResult.md)

[Initialize-IntersightMoBaseMo](./Initialize-IntersightMoBaseMo.md)
