---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkflowRollbackWorkflow

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkflowRollbackWorkflow [-Action< WorkflowRollbackWorkflow.ActionEnum>][-AdditionalProperties< Dictionary<string,object>>][-ContinueOnTaskFailure< bool>][[-Moid]< string>][-PrimaryWorkflow< WorkflowWorkflowInfoRelationship>][-RollbackTasks< List<WorkflowRollbackWorkflowTask>>][-SelectedTasks< List<WorkflowRollbackWorkflowTask>>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Update a &apos;WorkflowRollbackWorkflow&apos; resource.

## PARAMETERS

### -Action
The action of the rollback workflow such as Create and Start.\n* `None` - If no action is set, then the default value is set to none for the action field.\n* `Create` - Create rollback workflow data for the execution of the rollback workflow.\n* `Start` - Start a new execution of the rollback workflow.

```yaml
Type: WorkflowRollbackWorkflow.ActionEnum
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

### -ContinueOnTaskFailure
When set to true, if a task in the workflow fails, the rollback workflow continues to the subsequent task. When set to false, the rollback workflow execution halts if a task fails.

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

### -PrimaryWorkflow
A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowWorkflowInfoRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RollbackTasks


Note :- Use Initialize-IntersightWorkflowRollbackWorkflowTask to create the object of complex type WorkflowRollbackWorkflowTask

```yaml
Type: System.Collections.Generic.List`1[WorkflowRollbackWorkflowTask]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SelectedTasks


Note :- Use Initialize-IntersightWorkflowRollbackWorkflowTask to create the object of complex type WorkflowRollbackWorkflowTask

```yaml
Type: System.Collections.Generic.List`1[WorkflowRollbackWorkflowTask]
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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightWorkflowRollbackWorkflow
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowRollbackWorkflow](./Get-IntersightWorkflowRollbackWorkflow.md)

[New-IntersightWorkflowRollbackWorkflow](./New-IntersightWorkflowRollbackWorkflow.md)

[Remove-IntersightWorkflowRollbackWorkflow](./Remove-IntersightWorkflowRollbackWorkflow.md)

[Initialize-IntersightWorkflowRollbackWorkflowTask](./Initialize-IntersightWorkflowRollbackWorkflowTask.md)
