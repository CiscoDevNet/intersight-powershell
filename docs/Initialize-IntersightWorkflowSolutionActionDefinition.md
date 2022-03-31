---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowSolutionActionDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowSolutionActionDefinition [-ActionType< WorkflowSolutionActionDefinition.ActionTypeEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AllowedInstanceStates< System.Collections.Generic.List`1[WorkflowSolutionActionDefinition.AllowedInstanceStatesEnum]>][-ClassId< WorkflowSolutionActionDefinition.ClassIdEnum>][-CoreWorkflows< System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]>][-Description< string>][-InputDefinition< System.Collections.Generic.List`1[Model.WorkflowBaseDataType]>][-Label< string>][-Moid< string>][-Name< string>][-ObjectType< WorkflowSolutionActionDefinition.ObjectTypeEnum>][-OutputParameters< object>][-Periodicity< long>][-PostCoreWorkflows< System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]>][-PreCoreWorkflows< System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]>][-SolutionDefinition< Model.WorkflowSolutionDefinitionRelationship>][-StopWorkflows< System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-ValidationWorkflows< System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

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
Type: System.Collections.Generic.List`1[WorkflowSolutionActionDefinition.AllowedInstanceStatesEnum]
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
Type: WorkflowSolutionActionDefinition.ClassIdEnum
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
Type: System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]
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
Type: System.Collections.Generic.List`1[Model.WorkflowBaseDataType]
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

Required: false
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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: WorkflowSolutionActionDefinition.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OutputParameters
The output mappings from workflows in the action definition to the solution output definition. Any output from core or post-core workflow can be mapped to solution output definition. The output can be referred using the name of the workflow definition and the output name in the following format &apos;${&amp;lt;ActionWorkflowDefinition.Name&amp;gt;.output.&amp;lt;outputName&amp;gt;&apos;.

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
Type: System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]
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
Type: System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]
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
Type: Model.WorkflowSolutionDefinitionRelationship
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
Type: System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]
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
Type: System.Collections.Generic.List`1[Model.MoTag]
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
Type: System.Collections.Generic.List`1[Model.WorkflowActionWorkflowDefinition]
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
PS C:\> Initialize-IntersightWorkflowSolutionActionDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightWorkflowActionWorkflowDefinition](./Initialize-IntersightWorkflowActionWorkflowDefinition.md)

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
