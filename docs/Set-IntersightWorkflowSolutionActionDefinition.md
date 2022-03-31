---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkflowSolutionActionDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkflowSolutionActionDefinition [-ActionType< WorkflowSolutionActionDefinition.ActionTypeEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AllowedInstanceStates< System.Collections.Generic.List`1[string]>][-CoreWorkflows< System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]>][-Description< string>][-InputDefinition< System.Collections.Generic.List`1[WorkflowBaseDataType]>][-Label< string>][[-Moid]< string>][-Name< string>][-OutputParameters< object>][-Periodicity< long>][-PostCoreWorkflows< System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]>][-PreCoreWorkflows< System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]>][-SolutionDefinition< WorkflowSolutionDefinitionRelationship>][-StopWorkflows< System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-ValidationWorkflows< System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkflowSolutionActionDefinition&apos; resource.

## PARAMETERS

### -ActionType
Type of actionDefinition which decides on how to trigger the action.\n* `External` - External actions definition can be triggered by enduser to perform actions on the solution. Once action is completed successfully (eg. create/deploy), user cannot re-trigger that action again.\n* `Internal` - Internal action definition is used to trigger periodic actions on the solution instance.\n* `Repetitive` - Repetitive action definition is an external action that can be triggered by enduser to perform repetitive actions (eg. Edit/Update/Perform health check) on the created solution.

```yaml
Type: WorkflowSolutionActionDefinition.ActionTypeEnum
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

### -AllowedInstanceStates


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

### -CoreWorkflows


Note :- Use Initialize-IntersightWorkflowActionWorkflowDefinition to create the object of complex type WorkflowActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
The description for this action which provides information on what are the pre-requisites to use this action on the solution and what features are supported by this action.

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

### -Label
A user friendly short name to identify the action. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_).

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
The name for this action definition. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:) or an underscore (_). Name of the action must be unique within a solution definition.

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

### -OutputParameters
The output mappings from workflows in the action definition to the solution output definition. Any output from core or post-core workflow can be mapped to solution output definition. The output can be referred using the name of the workflow definition and the output name in the following format &apos;${&lt;ActionWorkflowDefinition.Name&amp;gt;.output.&lt;outputName&amp;gt;&apos;.

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

### -Periodicity
Value in seconds to specify the periodicity of the workflows. A zero value indicate the workflow will not execute periodically. A non-zero value indicate, the workflow will be executed periodically with this periodicity.

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

### -PostCoreWorkflows


Note :- Use Initialize-IntersightWorkflowActionWorkflowDefinition to create the object of complex type WorkflowActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreCoreWorkflows


Note :- Use Initialize-IntersightWorkflowActionWorkflowDefinition to create the object of complex type WorkflowActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SolutionDefinition
A reference to a workflowSolutionDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowSolutionDefinitionRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StopWorkflows


Note :- Use Initialize-IntersightWorkflowActionWorkflowDefinition to create the object of complex type WorkflowActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]
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

### -ValidationWorkflows


Note :- Use Initialize-IntersightWorkflowActionWorkflowDefinition to create the object of complex type WorkflowActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[WorkflowActionWorkflowDefinition]
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
PS C:\> Set-IntersightWorkflowSolutionActionDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowSolutionActionDefinition](./Get-IntersightWorkflowSolutionActionDefinition.md)

[New-IntersightWorkflowSolutionActionDefinition](./New-IntersightWorkflowSolutionActionDefinition.md)

[Remove-IntersightWorkflowSolutionActionDefinition](./Remove-IntersightWorkflowSolutionActionDefinition.md)

[Initialize-IntersightWorkflowActionWorkflowDefinition](./Initialize-IntersightWorkflowActionWorkflowDefinition.md)

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[Initialize-IntersightWorkflowValidationInformation](./Initialize-IntersightWorkflowValidationInformation.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
