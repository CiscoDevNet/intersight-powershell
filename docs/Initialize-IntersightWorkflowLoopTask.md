---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowLoopTask

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowLoopTask [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< WorkflowLoopTask.ClassIdEnum>][-Count< string>][-Description< string>][-FailurePolicy< WorkflowLoopTask.FailurePolicyEnum>][-FailureThreshold< long>][-Label< string>][-LoopStartTask< string>][-Name< string>][-NumberOfBatches< long>][-ObjectType< WorkflowLoopTask.ObjectTypeEnum>][-OnFailure< string>][-OnSuccess< string>][-Parallel< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: WorkflowLoopTask.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Count
Count value for the loop, this can be a static value defined as a constant at design time or can be a dynamic value defined as an expression that will evaluate to an integer value at execution time. Dynamic values for count must be specified as a template. For example, if a loop must run for a count which matches the length of a workflow input called StringArray, then the count must be specified using a template &apos;{{ len .global.workflow.input.StringArray }}&apos;. The count must be less than or equal to 100. If count is given as a dynamic value, and during execution time if count evaluates to be a value greater than 100, then the loop task will fail.

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

### -FailurePolicy
The policy to handle the failure of an iteration within a parallel loop.\n* `FailOnFirstFailure` - The enum specifies the option as FailOnFirstFailure where the loop task will fail if one of the iteration in the loop fails. The running iterations will be cancelled on first failure and the loop will be marked as failed.\n* `ContinueOnFailure` - The enum specifies the option as ContinueOnFailure where the loop task will continue with all iterations, even if one fails. Running iterations will not be canceled, but the loop will be marked as failed after all iterations are complete.

```yaml
Type: WorkflowLoopTask.FailurePolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FailureThreshold
The percentage of iterations that can fail before the entire loop is considered failed. The default is 0 which means all iterations must succeed.

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

### -LoopStartTask
Start task where the list of tasks will be executed multiple times based on the count or condition value.

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

### -NumberOfBatches
All iterations of the loop run in parallel within a single batch, with a maximum of 100 iterations. To run more than 100 iterations, you can increase the number of batches. The configuration is acceptable as long as the total number of iterations divided by the number of batches is less than 100. Adjusting the number of batches also allows you to control how many iterations run in parallel. For example, if the total count is 100 and you set the number of batches to 5, then 20 tasks will run in parallel across the 5 batches. It&apos;s important to note that the number of batches must be less than the total count. If the count is dynamic and falls below the number of batches, this may result in empty batches with no tasks.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkflowLoopTask.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OnFailure
This specifies the name of the next task to run if all iterations of the loop task do not succeed. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node.

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
This specifies the name of the next task to run if all iterations of the loop task succeeds. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node.

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

### -Parallel
This field is deprecated. Always set to true for parallel loop.

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
PS C:\> Initialize-IntersightWorkflowLoopTask
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
