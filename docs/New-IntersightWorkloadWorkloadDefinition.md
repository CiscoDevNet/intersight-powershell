---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightWorkloadWorkloadDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightWorkloadWorkloadDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Blueprints< System.Collections.Generic.List`1[WorkloadBlueprintReference]>][-Description< string>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-PlatformType< System.Collections.Generic.List`1[WorkloadWorkloadDefinition.PlatformTypeEnum]>][-PreferredVersion< bool>][-PreferredVersionRolloutStrategy< WorkloadRolloutStrategy>][-Status< WorkloadWorkloadDefinition.StatusEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Version< long>][-IfMatch< String>][-IfNoneMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;WorkloadWorkloadDefinition&apos; resource.

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

### -Blueprints


Note :- Use Initialize-IntersightWorkloadBlueprintReference to create the object of complex type WorkloadBlueprintReference

```yaml
Type: System.Collections.Generic.List`1[WorkloadBlueprintReference]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
The description for this workload definition.

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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name for this Workload. You can have multiple versions of the Workload with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). A refName is generated from the given name, and that along with the version must be unique within an Organization.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
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

### -PlatformType


```yaml
Type: System.Collections.Generic.List`1[WorkloadWorkloadDefinition.PlatformTypeEnum]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreferredVersion
The flag to indicate that this is the preferred (default) version of the workload.

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

### -PreferredVersionRolloutStrategy
The strategy used for rolling out deployment changes when this workload version is marked as the preferred version.

Note :- Use Initialize-IntersightWorkloadRolloutStrategy to create the object of complex type WorkloadRolloutStrategy

```yaml
Type: WorkloadRolloutStrategy
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Status
The status of the definition.\n* `Inactive` - The definition is in an inactive state and there are no workload instances associated with this workload. Changes to input parameters within the workload are allowed in this state.\n* `Active` - The definition is active and associated with one or more workload instances.

```yaml
Type: WorkloadWorkloadDefinition.StatusEnum
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

### -Version
The version of the workload to support multiple versions.

```yaml
Type: long
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

### -IfNoneMatch
For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&apos;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&apos;s ETag doesn&apos;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&apos;t have to be identical byte for byte.

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
PS C:\> New-IntersightWorkloadWorkloadDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkloadWorkloadDefinition](./Get-IntersightWorkloadWorkloadDefinition.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowValidationInformation](./Initialize-IntersightWorkflowValidationInformation.md)

[Initialize-IntersightWorkloadBlueprintReference](./Initialize-IntersightWorkloadBlueprintReference.md)

[Initialize-IntersightWorkloadRolloutStrategy](./Initialize-IntersightWorkloadRolloutStrategy.md)

[Initialize-IntersightWorkloadStateAggregation](./Initialize-IntersightWorkloadStateAggregation.md)

[Initialize-IntersightWorkloadWorkloadDefinition.PlatformTypeEnum](./Initialize-IntersightWorkloadWorkloadDefinition.PlatformTypeEnum.md)

[Remove-IntersightWorkloadWorkloadDefinition](./Remove-IntersightWorkloadWorkloadDefinition.md)

[Set-IntersightWorkloadWorkloadDefinition](./Set-IntersightWorkloadWorkloadDefinition.md)
