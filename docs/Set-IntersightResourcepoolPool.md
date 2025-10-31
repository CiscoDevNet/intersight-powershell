---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightResourcepoolPool

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightResourcepoolPool [-Action< ResourcepoolPool.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssignmentOrder< ResourcepoolPool.AssignmentOrderEnum>][-Description< string>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-PoolType< ResourcepoolPool.PoolTypeEnum>][-QualificationPolicies< System.Collections.Generic.List`1[ResourceAbstractResourceQualificationPolicyRelationship]>][-ResourcePoolParameters< ResourcepoolResourcePoolParameters>][-ResourceType< ResourcepoolPool.ResourceTypeEnum>][-Selectors< System.Collections.Generic.List`1[ResourceSelector]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;ResourcepoolPool&apos; resource.

## PARAMETERS

### -Action
The pool is evaluated for resources with associated policies based on action. This action will help users to re-sync the resources for a pool.\n* `None` - The pool will not be considered for evaluation.\n* `ReEvaluate` - The resources in the pool will be re-evaluated against the server pool qualification associated with it.

```yaml
Type: ResourcepoolPool.ActionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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

### -AssignmentOrder
Property is deprecated. Sequential is the only assignment order supported.\n* `sequential` - Identifiers are assigned in a sequential order.\n* `default` - Assignment order is decided by the system.

```yaml
Type: ResourcepoolPool.AssignmentOrderEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the policy.

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

### -Name
Name of the concrete policy.

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

### -PoolType
The resource management type in the pool, it can be either static or dynamic.\n* `Static` - The resources in the pool will not be changed until user manually update it.\n* `Dynamic` - The resources in the pool will be updated dynamically based on the condition.\n* `Hybrid` - The resources in the pool can be added by the user statically or dynamically, based on the matching conditions of the qualification policy. If the pool contains both statically added resources and resources added based on the qualification policy, the pool type can be classified as hybrid.

```yaml
Type: ResourcepoolPool.PoolTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QualificationPolicies
An array of relationships to resourceAbstractResourceQualificationPolicy resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[ResourceAbstractResourceQualificationPolicyRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourcePoolParameters
The pool specific parameters.

Note :- Use Initialize-IntersightResourcepoolResourcePoolParameters to create the object of complex type ResourcepoolResourcePoolParameters

```yaml
Type: ResourcepoolResourcePoolParameters
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceType
The type of the resource present in the pool, example &apos;server&apos; its combination of RackUnit and Blade.\n* `Server` - Resource Pool holds the server kind of resources, example - RackServer, Blade.\n* `Mixed` - Resource Pool holds the resources like Rack Server, Blade or Chassis.\n* `None` - The resource cannot consider for Resource Pool.

```yaml
Type: ResourcepoolPool.ResourceTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Selectors


Note :- Use Initialize-IntersightResourceSelector to create the object of complex type ResourceSelector

```yaml
Type: System.Collections.Generic.List`1[ResourceSelector]
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
PS C:\> Set-IntersightResourcepoolPool
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightResourcepoolPool](./Get-IntersightResourcepoolPool.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightResourceSelector](./Initialize-IntersightResourceSelector.md)

[Initialize-IntersightResourcepoolResourceEvaluationStatus](./Initialize-IntersightResourcepoolResourceEvaluationStatus.md)

[Initialize-IntersightResourcepoolResourcePoolParameters](./Initialize-IntersightResourcepoolResourcePoolParameters.md)

[New-IntersightResourcepoolPool](./New-IntersightResourcepoolPool.md)

[Remove-IntersightResourcepoolPool](./Remove-IntersightResourcepoolPool.md)
