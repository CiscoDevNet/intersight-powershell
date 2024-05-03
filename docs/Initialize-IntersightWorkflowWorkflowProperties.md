---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowWorkflowProperties

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowWorkflowProperties [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< WorkflowWorkflowProperties.ClassIdEnum>][-EnableDebug< bool>][-EnablePublishStatus< bool>][-ObjectType< WorkflowWorkflowProperties.ObjectTypeEnum>][-PublishStatus< WorkflowWorkflowProperties.PublishStatusEnum>][-Retryable< bool>][-RollbackOnCancel< bool>][-RollbackOnFailure< bool>][-SupportStatus< WorkflowWorkflowProperties.SupportStatusEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: WorkflowWorkflowProperties.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EnableDebug
Enabling this flag will capture request and response details as debug logs for tasks that are using workflow.BatchApi for implementation. For other tasks in the workflow which are not based on workflow.BatchApi logs will not be generated.

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

### -EnablePublishStatus
This flag determines if this workflow publish status is enforced or not.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkflowWorkflowProperties.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PublishStatus
The workflow publish status (Draft, Published, Archived), this property is relevant only when enablePublishStatus is set to true.\n* `Draft` - The enum specifies the option as Draft which means the meta definition is being designed and tested.\n* `Published` - The enum specifies the option as Published which means the meta definition is ready for consumption.\n* `Archived` - The enum specifies the option as Archived which means the meta definition is archived and can no longer be consumed.

```yaml
Type: WorkflowWorkflowProperties.PublishStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Retryable
When set to true, the failed workflow executions from this workflow definition can be retried for up to 2 weeks since the last modification time. After two weeks of inactivity on the workflow execution, the option to retry the failed workflow will be disabled.

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

### -RollbackOnCancel
When set to true, the changes are automatically rolled back if the workflow execution is canceled.

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

### -RollbackOnFailure
When set to true, the changes are automatically rolled back if the workflow fails to execute.

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

### -SupportStatus
Supported status of the definition.\n* `Supported` - The definition is a supported version and there will be no changes to the mandatory inputs or outputs.\n* `Beta` - The definition is a Beta version and this version can under go changes until the version is marked supported.\n* `Deprecated` - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added.

```yaml
Type: WorkflowWorkflowProperties.SupportStatusEnum
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
PS C:\> Initialize-IntersightWorkflowWorkflowProperties
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
