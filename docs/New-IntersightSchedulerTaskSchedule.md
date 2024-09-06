---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightSchedulerTaskSchedule

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightSchedulerTaskSchedule [-Action< SchedulerTaskSchedule.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Description< string>][-Moid< string>][[-Name]< string>][-ScheduleParams< SchedulerBaseScheduleParams>][-SuspendEndTime< DateTime>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TaskRequest< SchedulerRestStimTaskRequest>][-Type< SchedulerTaskSchedule.TypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;SchedulerTaskSchedule&apos; resource.

## PARAMETERS

### -Action
The action of the scheduled task such as suspend or resume.\n* `None` - No action is set (default).\n* `Suspend` - Suspend a scheduled task indefinitely.\n* `Resume` - Resume a suspended scheduled task.\n* `SuspendTill` - Suspend the scheduled task until a specified end-date. Not supported in this release.

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

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -ScheduleParams
According to the schedule type this property is evaluated. If the property Type is set to OneTime, then the ObjectType must be scheduler.OneTimeScheduleParams. If the Type is Recurring, then the ObjectType must be scheduler.RecurringScheduleParams.

Note :- Use Initialize-IntersightSchedulerBaseScheduleParams to create the object of complex type SchedulerBaseScheduleParams

```yaml
Type: SchedulerBaseScheduleParams
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
Type: System.Collections.Generic.List`1[MoTag]
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
Type: SchedulerRestStimTaskRequest
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Type
An Enum describing the type of scheduler to use.\n* `None` - No value was set for the schedule type (Enum value None).\n* `OneTime` - Define a one-time task execution time that will not automatically repeat.\n* `Recurring` - Specify a recurring task cadence based on a predefined pattern, such as daily, weekly, monthly, or every &lt;interval&gt; pattern.

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
PS C:\> New-IntersightSchedulerTaskSchedule
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightSchedulerTaskSchedule](./Get-IntersightSchedulerTaskSchedule.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightSchedulerBaseScheduleParams](./Initialize-IntersightSchedulerBaseScheduleParams.md)

[Initialize-IntersightSchedulerRestStimTaskRequest](./Initialize-IntersightSchedulerRestStimTaskRequest.md)

[Initialize-IntersightSchedulerTaskScheduleStatus](./Initialize-IntersightSchedulerTaskScheduleStatus.md)

[Remove-IntersightSchedulerTaskSchedule](./Remove-IntersightSchedulerTaskSchedule.md)

[Set-IntersightSchedulerTaskSchedule](./Set-IntersightSchedulerTaskSchedule.md)
