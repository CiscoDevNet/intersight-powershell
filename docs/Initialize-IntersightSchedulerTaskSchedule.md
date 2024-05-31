---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightSchedulerTaskSchedule

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightSchedulerTaskSchedule [-Action< SchedulerTaskSchedule.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< SchedulerTaskSchedule.ClassIdEnum>][-Description< string>][-Moid< string>][-Name< string>][-ObjectType< SchedulerTaskSchedule.ObjectTypeEnum>][-ScheduleParams< Model.SchedulerBaseScheduleParams>][-SuspendEndTime< DateTime>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-TaskRequest< Model.SchedulerRestStimTaskRequest>][-Type< SchedulerTaskSchedule.TypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -Action
The action of the scheduled task such as suspend or resume.\n* `None` - No action is set (default).\n* `Suspend` - Suspend a scheduled task indefinitely.\n* `Resume` - Resume a suspended scheduled task.\n* `SuspendTill` - Suspend the scheduled task until a specified end-date.

```yaml
Type: SchedulerTaskSchedule.ActionEnum
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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: SchedulerTaskSchedule.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
A description to describe the schedule for easier identification.

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
A schedule name for easier identification (not required to be unique).

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
Type: SchedulerTaskSchedule.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ScheduleParams
According to the schedule type this property is evaluated. If the property Type is set to OneTime, then the ObjectType must be scheduler.OneTimeScheduleParams.

Note :- Use Initialize-IntersightSchedulerBaseScheduleParams to create the object of complex type SchedulerBaseScheduleParams

```yaml
Type: Model.SchedulerBaseScheduleParams
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SuspendEndTime
Suspend a task until an end date. this applies only to the action suspendTill.

```yaml
Type: DateTime
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

### -TaskRequest
According to the schedule type the recurring params are populated.

Note :- Use Initialize-IntersightSchedulerRestStimTaskRequest to create the object of complex type SchedulerRestStimTaskRequest

```yaml
Type: Model.SchedulerRestStimTaskRequest
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Type
An Enum describing the type of scheduler to use.\n* `None` - No value was set for the schedule type (Enum value None).\n* `OneTime` - Define a one-time task execution time that will not automatically repeat.\n* `Recurring` - Specify a recurring task cadence based on a predefined pattern, such as daily, weekly, monthly, yearly, or every &lt;interval&gt; pattern. This option is not currently supported.

```yaml
Type: SchedulerTaskSchedule.TypeEnum
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
PS C:\> Initialize-IntersightSchedulerTaskSchedule
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightSchedulerBaseScheduleParams](./Initialize-IntersightSchedulerBaseScheduleParams.md)

[Initialize-IntersightSchedulerRestStimTaskRequest](./Initialize-IntersightSchedulerRestStimTaskRequest.md)
