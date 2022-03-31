---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowSubWorkflowTask

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowSubWorkflowTask [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-CatalogMoid< string>][-ClassId< WorkflowSubWorkflowTask.ClassIdEnum>][-Description< string>][-InputParameters< object>][-Label< string>][-Name< string>][-ObjectType< WorkflowSubWorkflowTask.ObjectTypeEnum>][-OnFailure< string>][-OnSuccess< string>][-RollbackDisabled< bool>][-UseDefault< bool>][-VariableParameters< object>][-Version< long>][-WorkflowDefinitionName< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

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

### -CatalogMoid
Specify the catalog moid that this task belongs.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: WorkflowSubWorkflowTask.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
The description of this task instance in the workflow.

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

### -InputParameters
JSON formatted key-value pairs that define the inputs given to the task. Mapping for task inputs can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as &apos;${Source.&amp;lt; input | output | variable&amp;gt;.&amp;lt;JSONPath&amp;gt;}&apos;. &apos;Source&apos; can be either workflow or the name of an earlier task within the workflow. You can map the task input to either a workflow input, a task output or a variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \&quot;InputParameters\&quot;:{ \&quot;input1\&quot;:\&quot;${workflow.variable.var1}\&quot;, \&quot;input2\&quot;:\&quot;prefixStr_{{.global.workflow.input.input1}}\&quot; } where task input1 is mapped directly to variable var1 and task input2 is using a template to prefix a string to workflow input1 and then assign that value.

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

### -Label
A user defined label identifier of the workflow task used for UI display.

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
The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks.

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
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkflowSubWorkflowTask.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OnFailure
This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node.

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

### -OnSuccess
This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node.

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

### -RollbackDisabled
The task is disabled/enabled for rollback operation in this workflow if the task has rollback support.

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

### -UseDefault
UseDefault when set to true, means the default version of the task or workflow will be used at the time of execution. When this property is set then version for task or subworkflow cannot be set. When workflow is created or updated the default version of task or subworkflow will be used for validation, but when the workflow is executed the default version that that time will be used for validation and subsequent execution.

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

### -VariableParameters
JSON formatted key-value pairs that perform variable update at the end of the task execution. Mapping for variables can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as &apos;${Source.&amp;lt; input | output | variable&amp;gt;.&amp;lt;JSONPath&amp;gt;}&apos;. &apos;Source&apos; can be either workflow or the name of the current or an earlier task within the workflow. You can map the variable to either a workflow input, a task output or another variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \&quot;VariableParameters\&quot;:{ \&quot;var1\&quot;:\&quot;${task1.output.output1}\&quot;, \&quot;var2\&quot;:\&quot;{{ Itoa .global.workflow.variable.varInt}}\&quot; } where variable var1 is mapped directly to output1 of task1 and variable var2 is using a template to convert another variable varInt to string and assign that value.

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

### -Version
The workflow definition version to use as subworkflow. When no version is specified then the default version of the workflow at the time of creating or updating this workflow is used.

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

### -WorkflowDefinitionName
The qualified name of workflow that should be executed as a task.

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
PS C:\> Initialize-IntersightWorkflowSubWorkflowTask
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
