---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowWorkflowInfo

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowWorkflowInfo [-Account< Model.IamAccountRelationship>][-Action< WorkflowWorkflowInfo.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssociatedObject< Model.MoBaseMoRelationship>][-ClassId< WorkflowWorkflowInfo.ClassIdEnum>][-FailedWorkflowCleanupDuration< long>][-Input< object>][-Moid< string>][-Name< string>][-ObjectType< WorkflowWorkflowInfo.ObjectTypeEnum>][-Organization< Model.OrganizationOrganizationRelationship>][-Permission< Model.IamPermissionRelationship>][-RetryFromTaskName< string>][-SuccessWorkflowCleanupDuration< long>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-TaskInfoUpdate< Model.WorkflowTaskInfoUpdate>][-WorkflowCtx< Model.WorkflowWorkflowCtx>][-WorkflowDefinition< Model.WorkflowWorkflowDefinitionRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -Account
A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.IamAccountRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Action
The action of the workflow such as start, cancel, retry, pause.\n* `None` - No action is set, this is the default value for action field.\n* `Create` - Create a new instance of the workflow but it does not start the execution of the workflow. Use the Start action to start execution of the workflow.\n* `Start` - Start a new execution of the workflow.\n* `Pause` - Pause the workflow, this can only be issued on workflows that are in running state. A workflow can be paused for a maximum of 180 days, after 180 days the workflow will be terminated by the system.\n* `Resume` - Resume the workflow which was previously paused through pause action on the workflow.\n* `Rerun` - Rerun the workflow that has previously reached a failed state. The workflow is run from the beginning using inputs from previous execution. Completed and currently running workflows cannot be rerun. Workflows do not have to be marked for retry to use this action.\n* `Retry` - This action has been deprecated. Please use RetryFailed, Rerun or RetryFromTask action. Retry the workflow that has previously reached a final state and has the retryable property set to true. A running or waiting workflow cannot be retried. If the property retryFromTaskName is also passed along with this action, the workflow will be started from that specific task, otherwise the workflow will be restarted from the first task.  The task name in retryFromTaskName must be one of the tasks that completed or failed in the previous run. It is not possible to retry a workflow from a task which wasn&apos;t run in the previous iteration.\n* `RetryFailed` - Retry the workflow that has failed. A running or waiting workflow or a workflow that completed successfully cannot be retried. Only the tasks that failed in the previous run will be retried and the rest of workflow will be run. This action does not restart the workflow and also does not support retrying from a specific task.\n* `RetryFromTask` - Retry the workflow that has previously reached a failed state and has the retryable property set to true. A running or waiting workflow cannot be retried. RetryFromTaskName must be passed along with this action, and the workflow will be started from that specific task. The task name in RetryFromTaskName must be one of the tasks that was executed in the previous attempt. It is not possible to retry a workflow from a task that wasn&apos;t run in the previous execution attempt.\n* `Cancel` - Cancel the workflow that is in running or waiting state.

```yaml
Type: WorkflowWorkflowInfo.ActionEnum
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

### -AssociatedObject
A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.MoBaseMoRelationship
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
Type: WorkflowWorkflowInfo.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FailedWorkflowCleanupDuration
The duration in hours after which the workflow info for failed, terminated or timed out workflow will be removed from database. The minimum is 1 hour, maximum is 365 days and default is 90 days.

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

### -Input
All the given inputs for the workflow. The schema for the inputs is defined in the InputDefinition section of the WorkflowDefinition. The InputDefinition will provide a list of input fields to be accepted, the associated datatype of the inputs and any additional constraints on the inputs. For more information please refer to InputDefinition property in the the the WorkflowDefinition resource. The inputs for a workflow are provided as a collection of key-value pairs, where key is the name of the input and value is any valid JSON data which conforms to the datatype of the input as specified in the InputDefinition. When the input passed into a workflow does not match the datatype or the constraints specified in the workflow definition, it will not be accepted. For example, if the InputDefinition specified that workflow must accept a string name &apos;key&apos; and the value passed for key must adhere to a regex pattern. If Workflow was started with input where &apos;key&apos; is not a string matching the regex pattern, an error will be generated and workflow will not start execution. During workflow definition design, the input passed into the workflow will be referred using the format &apos;workflow.input.&lt;inputName&gt;&apos;. If the input is referred directly in a mapping it will be in the format &apos;${workflow.input.&lt;inputName&gt;}&apos; or inside a template mapping in the format &apos;{{.global.workflow.input.&lt;inputName&gt;}}&apos;.

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
A name of the workflow execution instance.

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
Type: WorkflowWorkflowInfo.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Permission
A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.IamPermissionRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RetryFromTaskName
This field is required when RetryFromTask action is issued for a workflow that is in a &apos;final&apos; state. The workflow will be retried from the specified task. This field must specify a task name which is the unique name of the task within the workflow. The task name must be one of the tasks that were completed or failed in the previous run. It is not possible to retry a workflow from a task that wasn&apos;t run in the previous execution attempt.

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

### -SuccessWorkflowCleanupDuration
The duration in hours after which the workflow info for successful workflow will be removed from database. The minimum is 1 hour, maximum is 365 days and default is 90 days.

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

### -TaskInfoUpdate
Used to update a TaskInfo instance in the WorkflowInfo, it is used as a way to update status and provide user inputs for a WaitTask.

Note :- Use Initialize-IntersightWorkflowTaskInfoUpdate to create the object of complex type WorkflowTaskInfoUpdate

```yaml
Type: Model.WorkflowTaskInfoUpdate
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WorkflowCtx
The workflow context which contains initiator and target information.

Note :- Use Initialize-IntersightWorkflowWorkflowCtx to create the object of complex type WorkflowWorkflowCtx

```yaml
Type: Model.WorkflowWorkflowCtx
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WorkflowDefinition
A reference to a workflowWorkflowDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.WorkflowWorkflowDefinitionRelationship
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
PS C:\> Initialize-IntersightWorkflowWorkflowInfo
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightWorkflowTaskInfoUpdate](./Initialize-IntersightWorkflowTaskInfoUpdate.md)

[Initialize-IntersightWorkflowWorkflowCtx](./Initialize-IntersightWorkflowWorkflowCtx.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
