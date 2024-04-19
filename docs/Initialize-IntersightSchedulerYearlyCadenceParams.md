---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightSchedulerYearlyCadenceParams

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightSchedulerYearlyCadenceParams [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< SchedulerYearlyCadenceParams.ClassIdEnum>][-CustomDayOfMonth< SchedulerYearlyCadenceParams.CustomDayOfMonthEnum>][-DayOfMonth< System.Collections.Generic.List`1[long]>][-MonthOfYear< System.Collections.Generic.List`1[SchedulerYearlyCadenceParams.MonthOfYearEnum]>][-ObjectType< SchedulerYearlyCadenceParams.ObjectTypeEnum>][-WeekDayFormat< Model.SchedulerMonthlyWeekDayFormat>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: SchedulerYearlyCadenceParams.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CustomDayOfMonth
Significant business days, such as days when reports are generated for analysis.\n* `None` - Placeholder. One of the following two fields must be selected.\n* `FirstWeekDay` - First week day of the month.\n* `MonthLastDay` - The last day of the month.

```yaml
Type: SchedulerYearlyCadenceParams.CustomDayOfMonthEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DayOfMonth


```yaml
Type: System.Collections.Generic.List`1[long]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MonthOfYear


```yaml
Type: System.Collections.Generic.List`1[SchedulerYearlyCadenceParams.MonthOfYearEnum]
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
Type: SchedulerYearlyCadenceParams.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WeekDayFormat
A format with the week and specific days as arguments.

Note :- Use Initialize-IntersightSchedulerMonthlyWeekDayFormat to create the object of complex type SchedulerMonthlyWeekDayFormat

```yaml
Type: Model.SchedulerMonthlyWeekDayFormat
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
PS C:\> Initialize-IntersightSchedulerYearlyCadenceParams
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightSchedulerMonthlyWeekDayFormat](./Initialize-IntersightSchedulerMonthlyWeekDayFormat.md)
