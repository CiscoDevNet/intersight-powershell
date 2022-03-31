---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowPendingDynamicWorkflowInfo

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowPendingDynamicWorkflowInfo [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< WorkflowPendingDynamicWorkflowInfo.ClassIdEnum>][-Input< object>][-Moid< string>][-Name< string>][-ObjectType< WorkflowPendingDynamicWorkflowInfo.ObjectTypeEnum>][-PendingServices< System.Collections.Generic.List`1[string]>][-Src< string>][-Status< WorkflowPendingDynamicWorkflowInfo.StatusEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-WaitOnDuplicate< bool>][-WorkflowActionTaskLists< System.Collections.Generic.List`1[Model.WorkflowDynamicWorkflowActionTaskList]>][-WorkflowCtx< Model.WorkflowWorkflowCtx>][-WorkflowKey< string>][-WorkflowMeta< object>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: WorkflowPendingDynamicWorkflowInfo.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Input
The inputs of the workflow.

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
A name for the pending dynamic workflow.

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
Type: WorkflowPendingDynamicWorkflowInfo.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PendingServices


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

### -Src
The src is workflow owner service.

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

### -Status
The current status of the PendingDynamicWorkflowInfo.\n* `GatheringTasks` - Dynamic workflow is gathering tasks before workflow can start execution.\n* `Waiting` - Dynamic workflow is in waiting state and not yet started execution.\n* `RateLimit` - Dynamic workflow is rate limited and hasn&apos;t started execution.

```yaml
Type: WorkflowPendingDynamicWorkflowInfo.StatusEnum
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

### -WaitOnDuplicate
When set to true workflow engine will wait for a duplicate to finish before starting a new one.

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

### -WorkflowActionTaskLists


Note :- Use Initialize-IntersightWorkflowDynamicWorkflowActionTaskList to create the object of complex type WorkflowDynamicWorkflowActionTaskList

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowDynamicWorkflowActionTaskList]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WorkflowCtx
The workflow&amp;apos;s workflow context which contains initiator and target information.

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

### -WorkflowKey
This key contains workflow, initiator and target name. Workflow engine uses the key to do workflow dedup.

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

### -WorkflowMeta
The metadata of the workflow.

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
PS C:\> Initialize-IntersightWorkflowPendingDynamicWorkflowInfo
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

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightWorkflowDynamicWorkflowActionTaskList](./Initialize-IntersightWorkflowDynamicWorkflowActionTaskList.md)

[Initialize-IntersightWorkflowWorkflowCtx](./Initialize-IntersightWorkflowWorkflowCtx.md)
