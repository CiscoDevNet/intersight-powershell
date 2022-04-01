---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkflowBatchApiExecutor

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkflowBatchApiExecutor [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Batch< System.Collections.Generic.List`1[Intersight.Model.WorkflowApi]>][-Constraints< WorkflowTaskConstraints>][-Description< string>][-ErrorResponseHandler< WorkflowErrorResponseHandlerRelationship>][[-Moid]< string>][-Name< string>][-Outcomes< object>][-Output< object>][-RetryFromFailedApi< bool>][-SkipOnCondition< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TaskDefinition< WorkflowTaskDefinitionRelationship>][-UiRenderingData< object>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkflowBatchApiExecutor&apos; resource.

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

### -Constraints
Enter the constraints on when this task should match against the task definition.

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
A detailed description about the batch APIs.

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

### -ErrorResponseHandler
A reference to a workflowErrorResponseHandler resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowErrorResponseHandlerRelationship
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
Name for the batch API task.

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

### -Outcomes
All the possible outcomes of this task are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as &apos;true&apos;.\nThis is an optional\nproperty and if not specified the task will be marked as success.

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
Intersight Orchestrator allows the extraction of required values from API\nresponses using the API response grammar. These extracted values can be mapped\nto task output parameters defined in task definition.\nThe mapping of API output parameters to the task output parameters is provided\nas JSON in this property.

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
When an execution of a nth API in the Batch fails,\nRetry from falied API flag indicates if the execution should start from the nth API or the first API during task retry.\nBy default the value is set to false.

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
The skip expression, if provided, allows the batch API executor to skip the\ntask execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed.

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
This will hold the data needed for task to be rendered in the user interface.

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
PS C:\> Set-IntersightWorkflowBatchApiExecutor
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowBatchApiExecutor](./Get-IntersightWorkflowBatchApiExecutor.md)

[Initialize-IntersightIntersight.Model.WorkflowApi](./Initialize-IntersightIntersight.Model.WorkflowApi.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowTaskConstraints](./Initialize-IntersightWorkflowTaskConstraints.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[New-IntersightWorkflowBatchApiExecutor](./New-IntersightWorkflowBatchApiExecutor.md)

[Remove-IntersightWorkflowBatchApiExecutor](./Remove-IntersightWorkflowBatchApiExecutor.md)
