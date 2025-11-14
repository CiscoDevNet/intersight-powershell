---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkloadBlueprint

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkloadBlueprint [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-BlueprintDependencies< System.Collections.Generic.List`1[BlueprintBlueprintDefinitionDependency]>][-Catalog< WorkflowCatalogRelationship>][-DefaultVersion< bool>][-Description< string>][-ExternalMeta< bool>][-GeneratedObjectDefinition< System.Collections.Generic.List`1[BlueprintGeneratedObjectMetadata]>][-InputDefinition< System.Collections.Generic.List`1[WorkflowBaseDataType]>][-InputOperationMetadata< System.Collections.Generic.List`1[BlueprintInputOperationType]>][-Label< string>][[-Moid]< string>][-Name< string>][-PlatformType< WorkloadBlueprint.PlatformTypeEnum>][-ResourceDefinition< BlueprintResourceConstraints>][-ServiceItems< System.Collections.Generic.List`1[BlueprintServiceItemDefinition]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Version< long>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkloadBlueprint&apos; resource.

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

Required: true
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
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
PS C:\> Set-IntersightWorkloadBlueprint
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

[Initialize-IntersightBlueprintGeneratedObjectMetadata](./Initialize-IntersightBlueprintGeneratedObjectMetadata.md)

[Initialize-IntersightBlueprintInputOperationType](./Initialize-IntersightBlueprintInputOperationType.md)

[Initialize-IntersightBlueprintResourceConstraints](./Initialize-IntersightBlueprintResourceConstraints.md)

[Initialize-IntersightBlueprintServiceItemDefinition](./Initialize-IntersightBlueprintServiceItemDefinition.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-IntersightWorkflowValidationInformation](./Initialize-IntersightWorkflowValidationInformation.md)

[New-IntersightWorkloadBlueprint](./New-IntersightWorkloadBlueprint.md)

[Remove-IntersightWorkloadBlueprint](./Remove-IntersightWorkloadBlueprint.md)
