---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightTaskWorkflowAction

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightTaskWorkflowAction [-Action< TaskWorkflowAction.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-InputParams< string>][-IsDynamic< bool>][-Moid< string>][-Retryable< bool>][-SequenceKey< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-WaitOnDuplicate< bool>][-WorkflowContext< string>][-WorkflowFile< TaskFileDownloadInfo>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;TaskWorkflowAction&apos; resource.

## PARAMETERS

### -Action
Action for test workflow.\n* `start` - Start action for the workflow.\n* `stop` - Stop action for the workflow.

```yaml
Type: TaskWorkflowAction.ActionEnum
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

### -InputParams
Json formatted string input parameters to workflow.

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

### -IsDynamic
When true, this workflow type will be triggered as a dynamic workflow, if not it will be treated as a static workflow.

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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Retryable
When true, the retry operation can be performed on the workflow.

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

### -SequenceKey
This key can be set so that the workflow execution can be sequenced with workflows having the same key. An example usecase is say there are diferent workflows which operate on the server, and are executed at the same time on the same server and the sequence key for all the workflows are same, then workflow engine will enforce that the workflow execution are sequenced and started one after the other, based on timestamp of the arrival of the execution requests.

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

### -WaitOnDuplicate
When true, the workflow will wait for previous one to complete before starting a new one.

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

### -WorkflowContext
Json formatted string that has the contents of the workflow context used when starting a workflow.

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

### -WorkflowFile
Path to workflow metadata file that will be published and started.

Note :- Use Initialize-IntersightTaskFileDownloadInfo to create the object of complex type TaskFileDownloadInfo

```yaml
Type: TaskFileDownloadInfo
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
PS C:\> New-IntersightTaskWorkflowAction
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightTaskWorkflowAction](./Get-IntersightTaskWorkflowAction.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightTaskFileDownloadInfo](./Initialize-IntersightTaskFileDownloadInfo.md)

[Set-IntersightTaskWorkflowAction](./Set-IntersightTaskWorkflowAction.md)
