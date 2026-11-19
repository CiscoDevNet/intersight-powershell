---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightWorkloadBlueprint

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightWorkloadBlueprint [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssociatedRoles< System.Collections.Generic.List`1[IamRoleRelationship]>][-BaseBlueprint< BlueprintBlueprintInheritanceReference>][-BlueprintDependencies< System.Collections.Generic.List`1[BlueprintBlueprintDefinitionDependency]>][-BlueprintKind< WorkloadBlueprint.BlueprintKindEnum>][-Catalog< WorkflowCatalogRelationship>][-DefaultVersion< bool>][-Description< string>][-ExternalMeta< bool>][-GeneratedObjectDefinition< System.Collections.Generic.List`1[BlueprintGeneratedObjectMetadata]>][-InputDefinition< System.Collections.Generic.List`1[WorkflowBaseDataType]>][-InputOperationMetadata< System.Collections.Generic.List`1[BlueprintInputOperationType]>][-InputSyncEnabled< bool>][-Label< string>][-Moid< string>][[-Name]< string>][-PlatformType< WorkloadBlueprint.PlatformTypeEnum>][-ResourceDefinition< BlueprintResourceConstraints>][-Revision< long>][-ServiceItems< System.Collections.Generic.List`1[BlueprintServiceItemDefinition]>][-SupportInfo< WorkflowSupportInfo>][-Tags< System.Collections.Generic.List`1[MoTag]>][-ValidatedObjects< System.Collections.Generic.List`1[BlueprintValidatedConfigReference]>][-Version< long>][-VersionCompatibilityInfo< System.Collections.Generic.List`1[BlueprintVersionCompatibilityInfo]>][-VersionDescription< string>][-IfMatch< String>][-IfNoneMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;WorkloadBlueprint&apos; resource.

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

### -AssociatedRoles
An array of relationships to iamRole resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[IamRoleRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BaseBlueprint
The abstract base blueprint inherited by this authoring blueprint. Is optional.

Note :- Use Initialize-IntersightBlueprintBlueprintInheritanceReference to create the object of complex type BlueprintBlueprintInheritanceReference

```yaml
Type: BlueprintBlueprintInheritanceReference
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BlueprintDependencies


Note :- Use Initialize-IntersightBlueprintBlueprintDefinitionDependency to create the object of complex type BlueprintBlueprintDefinitionDependency

```yaml
Type: System.Collections.Generic.List`1[BlueprintBlueprintDefinitionDependency]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BlueprintKind
Identifies whether the authoring blueprint is an abstract inheritance source or a concrete definition. Concrete definitions are deployed through separate resolved version of the blueprint..\n* `Concrete` - The blueprint can be materialized as a separate resolved blueprint for deployment.\n* `Abstract` - The blueprint is an abstract inheritance source and is not directly deployable.

```yaml
Type: WorkloadBlueprint.BlueprintKindEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Catalog
A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowCatalogRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DefaultVersion
The flag to indicate that this is the default version of the blueprint.

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

### -Description
The description for this blueprint which provides information on what are the pre-requisites to deploy the blueprint and what features are supported on the blueprint.

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

### -ExternalMeta
When set to false the blueprint is created for use within internal services.

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

### -GeneratedObjectDefinition


Note :- Use Initialize-IntersightBlueprintGeneratedObjectMetadata to create the object of complex type BlueprintGeneratedObjectMetadata

```yaml
Type: System.Collections.Generic.List`1[BlueprintGeneratedObjectMetadata]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InputDefinition


Note :- Use Initialize-IntersightWorkflowBaseDataType to create the object of complex type WorkflowBaseDataType

```yaml
Type: System.Collections.Generic.List`1[WorkflowBaseDataType]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InputOperationMetadata


Note :- Use Initialize-IntersightBlueprintInputOperationType to create the object of complex type BlueprintInputOperationType

```yaml
Type: System.Collections.Generic.List`1[BlueprintInputOperationType]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InputSyncEnabled
The input for a blueprint referenced in a workload can be synced from another blueprint of the same type.

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

### -Label
A user friendly short name to identify the blueprint. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_).

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
The name for this blueprint. You can have multiple versions of the blueprint with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), or an underscore (_).

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

### -PlatformType
The Intersight platforms supported by this blueprint.\n* `None` - Default value is none, platform is not mentioned.\n* `UnifiedEdge` - The blueprint is created for Unified Edge platform.

```yaml
Type: WorkloadBlueprint.PlatformTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceDefinition
The resource constraint definition for the blueprint.

Note :- Use Initialize-IntersightBlueprintResourceConstraints to create the object of complex type BlueprintResourceConstraints

```yaml
Type: BlueprintResourceConstraints
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Revision
The revision of the blueprint to support compatible updates within the same version.

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

### -ServiceItems


Note :- Use Initialize-IntersightBlueprintServiceItemDefinition to create the object of complex type BlueprintServiceItemDefinition

```yaml
Type: System.Collections.Generic.List`1[BlueprintServiceItemDefinition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportInfo
The support information for this blueprint version. When the blueprint version is deprecated, this field includes the support end date and can include a replacement target version.

Note :- Use Initialize-IntersightWorkflowSupportInfo to create the object of complex type WorkflowSupportInfo

```yaml
Type: WorkflowSupportInfo
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

### -ValidatedObjects


Note :- Use Initialize-IntersightBlueprintValidatedConfigReference to create the object of complex type BlueprintValidatedConfigReference

```yaml
Type: System.Collections.Generic.List`1[BlueprintValidatedConfigReference]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
The version of the blueprint to support multiple versions.

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

### -VersionCompatibilityInfo


Note :- Use Initialize-IntersightBlueprintVersionCompatibilityInfo to create the object of complex type BlueprintVersionCompatibilityInfo

```yaml
Type: System.Collections.Generic.List`1[BlueprintVersionCompatibilityInfo]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VersionDescription
The detailed change description for this blueprint version. For new blueprint versions, this field captures a verbose description of the delta of changes in this version compared to earlier versions.

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
PS C:\> New-IntersightWorkloadBlueprint
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkloadBlueprint](./Get-IntersightWorkloadBlueprint.md)

[Initialize-IntersightBlueprintBlueprintDefinitionDependency](./Initialize-IntersightBlueprintBlueprintDefinitionDependency.md)

[Initialize-IntersightBlueprintBlueprintInheritanceReference](./Initialize-IntersightBlueprintBlueprintInheritanceReference.md)

[Initialize-IntersightBlueprintGeneratedObjectMetadata](./Initialize-IntersightBlueprintGeneratedObjectMetadata.md)

[Initialize-IntersightBlueprintInputOperationType](./Initialize-IntersightBlueprintInputOperationType.md)

[Initialize-IntersightBlueprintResourceConstraints](./Initialize-IntersightBlueprintResourceConstraints.md)

[Initialize-IntersightBlueprintServiceItemDefinition](./Initialize-IntersightBlueprintServiceItemDefinition.md)

[Initialize-IntersightBlueprintValidatedConfigReference](./Initialize-IntersightBlueprintValidatedConfigReference.md)

[Initialize-IntersightBlueprintVersionCompatibilityInfo](./Initialize-IntersightBlueprintVersionCompatibilityInfo.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-IntersightWorkflowSupportInfo](./Initialize-IntersightWorkflowSupportInfo.md)

[Initialize-IntersightWorkflowValidationInformation](./Initialize-IntersightWorkflowValidationInformation.md)

[Remove-IntersightWorkloadBlueprint](./Remove-IntersightWorkloadBlueprint.md)

[Set-IntersightWorkloadBlueprint](./Set-IntersightWorkloadBlueprint.md)
