---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowProperties

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowProperties [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< WorkflowProperties.ClassIdEnum>][-ExternalMeta< bool>][-InputDefinition< System.Collections.Generic.List`1[Model.WorkflowBaseDataType]>][-ObjectType< WorkflowProperties.ObjectTypeEnum>][-OutputDefinition< System.Collections.Generic.List`1[Model.WorkflowBaseDataType]>][-RetryCount< long>][-RetryDelay< long>][-RetryPolicy< WorkflowProperties.RetryPolicyEnum>][-SupportStatus< WorkflowProperties.SupportStatusEnum>][-Timeout< long>][-TimeoutPolicy< WorkflowProperties.TimeoutPolicyEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: WorkflowProperties.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExternalMeta
When set to false the task definition can only be used by internal system workflows. When set to true then the task can be included in user defined workflows.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkflowProperties.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OutputDefinition


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

### -RetryCount
The number of times a task should be tried before marking as failed.

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

### -RetryDelay
The delay in seconds after which the the task is re-tried.

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

### -RetryPolicy
The retry policy for the task.\n* `Fixed` - The enum specifies the option as Fixed where the task retry happens after fixed time specified by RetryDelay.

```yaml
Type: WorkflowProperties.RetryPolicyEnum
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
Type: WorkflowProperties.SupportStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Timeout
The timeout value in seconds after which task will be marked as timed out. Max allowed value is 7 days.

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

### -TimeoutPolicy
The timeout policy for the task.\n* `Timeout` - The enum specifies the option as Timeout where task will be timed out after the specified time in Timeout property.\n* `Retry` - The enum specifies the option as Retry where task will be re-tried.

```yaml
Type: WorkflowProperties.TimeoutPolicyEnum
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
PS C:\> Initialize-IntersightWorkflowProperties
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)
