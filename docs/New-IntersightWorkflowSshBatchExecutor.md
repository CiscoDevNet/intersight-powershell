---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightWorkflowSshBatchExecutor

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightWorkflowSshBatchExecutor [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Batch< System.Collections.Generic.List`1[Intersight.Model.WorkflowApi]>][-CancelAction< System.Collections.Generic.List`1[Intersight.Model.WorkflowApi]>][-Constraints< WorkflowTaskConstraints>][-Description< string>][-Moid< string>][[-Name]< string>][-Outcomes< object>][-Output< object>][-RetryFromFailedApi< bool>][-SkipOnCondition< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TaskDefinition< WorkflowTaskDefinitionRelationship>][-UiRenderingData< object>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;WorkflowSshBatchExecutor&apos; resource.

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

### -Batch


Note :- Use Initialize-IntersightIntersight.Model.WorkflowApi to create the object of complex type Intersight.Model.WorkflowApi

```yaml
Type: System.Collections.Generic.List`1[Intersight.Model.WorkflowApi]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CancelAction


Note :- Use Initialize-IntersightIntersight.Model.WorkflowApi to create the object of complex type Intersight.Model.WorkflowApi

```yaml
Type: System.Collections.Generic.List`1[Intersight.Model.WorkflowApi]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Constraints
Constraints for matching this task against the task definition.

Note :- Use Initialize-IntersightWorkflowTaskConstraints to create the object of complex type WorkflowTaskConstraints

```yaml
Type: WorkflowTaskConstraints
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Detailed description of the batch APIs.

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
Name of the batch API task.

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

### -Outcomes
Collection of possible task outcomes, represented as workflow.Outcome objects. Outcomes can be mapped to messages and are evaluated in the given order. \nA catch-all success or failure outcome with condition &apos;true&apos; can be included at the end. Optional property; if not specified, the task defaults to success.

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

### -Output
JSON mapping of extracted API response values to task output parameters, using API response grammar defined in Intersight Orchestrator.

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

### -RetryFromFailedApi
Flag indicating if the retry task should from the failed API or the first API in the batch execution; default value is false.

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

### -SkipOnCondition
Optional skip expression allowing the batch API executor to skip task execution when the provided Go template expression evaluates to true. \nIf not specified, the API will always be executed.

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

### -TaskDefinition
A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowTaskDefinitionRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UiRenderingData
Data required for rendering the task in the user interface.

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
PS C:\> New-IntersightWorkflowSshBatchExecutor
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowSshBatchExecutor](./Get-IntersightWorkflowSshBatchExecutor.md)

[Initialize-IntersightIntersight.Model.WorkflowApi](./Initialize-IntersightIntersight.Model.WorkflowApi.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowTaskConstraints](./Initialize-IntersightWorkflowTaskConstraints.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[Remove-IntersightWorkflowSshBatchExecutor](./Remove-IntersightWorkflowSshBatchExecutor.md)

[Set-IntersightWorkflowSshBatchExecutor](./Set-IntersightWorkflowSshBatchExecutor.md)
