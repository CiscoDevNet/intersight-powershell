---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkflowWorkflowDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkflowWorkflowDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Catalog< WorkflowCatalogRelationship>][-DefaultVersion< bool>][-Description< string>][-InputDefinition< System.Collections.Generic.List`1[WorkflowBaseDataType]>][-InputParameterSet< System.Collections.Generic.List`1[WorkflowParameterSet]>][-Label< string>][[-Moid]< string>][-Name< string>][-OutputDefinition< System.Collections.Generic.List`1[WorkflowBaseDataType]>][-OutputParameters< object>][-Properties< WorkflowWorkflowProperties>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Tasks< System.Collections.Generic.List`1[WorkflowWorkflowTask]>][-UiInputFilters< System.Collections.Generic.List`1[WorkflowUiInputFilter]>][-UiRenderingData< object>][-VariableDefinition< System.Collections.Generic.List`1[WorkflowBaseDataType]>][-Version< long>][-WorkflowMetadata< WorkflowWorkflowMetadataRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkflowWorkflowDefinition&apos; resource.

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
When true this will be the workflow version that is used when a specific workflow definition version is not specified. The default version is used when user executes a workflow without specifying a version or when workflow is included in another workflow without a specific version. The very first workflow definition created with a name will be set as the default version, after that user can explicitly set any version of the workflow definition as the default version.

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
The description for this workflow.

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

### -InputParameterSet


Note :- Use Initialize-IntersightWorkflowParameterSet to create the object of complex type WorkflowParameterSet

```yaml
Type: System.Collections.Generic.List`1[WorkflowParameterSet]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Label
A user friendly short name to identify the workflow. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), forward slash (/), or an underscore (_).

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
The name for this workflow. You can have multiple versions of the workflow with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_).

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

### -OutputDefinition


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

### -OutputParameters
The output mappings for the workflow. The schema for outputs of a workflow is defined using OutputDefinition. The outputs for workflows that we want to export out at the end of the workflow can be mapped from task outputs, workflow inputs, or workflow variables. Any task output, workflow input, or workflow variable can be mapped to a workflow output as long as the types are compatible. The format to specify the mapping is &apos;${ &apos;workflow | &lt;taskName&gt;&apos;. &apos;output |input | variable&apos;.&lt;name&gt;[.&lt;JsonPath&gt;]}&apos;. First, either the keyword &apos;workflow&apos; or the name of the task in the workflow must be given. If a task name is used, then it must be followed by the keyword &apos;output&apos;, if the keyword workflow was used, then it must be followed by the keyword &apos;input&apos; or &apos;variable&apos;. Following this &apos;&lt;name&gt;&apos; must be the name of either input, output, or variable that must be mapped as workflow output. The last part of the mapping can be an optional &lt;JsonPath&gt; to extract specific fields on the data.

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

### -Properties
Type to capture the properties of a workflow definition. Some of these properties are passed to workflow execution instance.

Note :- Use Initialize-IntersightWorkflowWorkflowProperties to create the object of complex type WorkflowWorkflowProperties

```yaml
Type: WorkflowWorkflowProperties
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

### -Tasks


Note :- Use Initialize-IntersightWorkflowWorkflowTask to create the object of complex type WorkflowWorkflowTask

```yaml
Type: System.Collections.Generic.List`1[WorkflowWorkflowTask]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UiInputFilters


Note :- Use Initialize-IntersightWorkflowUiInputFilter to create the object of complex type WorkflowUiInputFilter

```yaml
Type: System.Collections.Generic.List`1[WorkflowUiInputFilter]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UiRenderingData
This will hold the data needed for workflow to be rendered in the user interface.

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

### -VariableDefinition


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

### -Version
The version of the workflow to support multiple versions.

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

### -WorkflowMetadata
A reference to a workflowWorkflowMetadata resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowWorkflowMetadataRelationship
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
PS C:\> Set-IntersightWorkflowWorkflowDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowWorkflowDefinition](./Get-IntersightWorkflowWorkflowDefinition.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-IntersightWorkflowParameterSet](./Initialize-IntersightWorkflowParameterSet.md)

[Initialize-IntersightWorkflowUiInputFilter](./Initialize-IntersightWorkflowUiInputFilter.md)

[Initialize-IntersightWorkflowValidationInformation](./Initialize-IntersightWorkflowValidationInformation.md)

[Initialize-IntersightWorkflowWorkflowProperties](./Initialize-IntersightWorkflowWorkflowProperties.md)

[Initialize-IntersightWorkflowWorkflowTask](./Initialize-IntersightWorkflowWorkflowTask.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[New-IntersightWorkflowWorkflowDefinition](./New-IntersightWorkflowWorkflowDefinition.md)

[Remove-IntersightWorkflowWorkflowDefinition](./Remove-IntersightWorkflowWorkflowDefinition.md)
