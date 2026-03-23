---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightMetricThresholdCondition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightMetricThresholdCondition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< MetricThresholdCondition.ClassIdEnum>][-Filters< System.Collections.Generic.List`1[Model.CondFilterRule]>][-Granularity< MetricThresholdCondition.GranularityEnum>][-GroupBy< MetricThresholdCondition.GroupByEnum>][-InstrumentName< string>][-MetricName< string>][-ObjectType< MetricThresholdCondition.ObjectTypeEnum>][-RollUpAggregate< MetricThresholdCondition.RollUpAggregateEnum>][-SeverityCriteria< System.Collections.Generic.List`1[Model.MetricSeverityCriteria]>][-TotalDataPoints< long>][-TriggerCount< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: MetricThresholdCondition.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Filters


Note :- Use Initialize-IntersightCondFilterRule to create the object of complex type CondFilterRule

```yaml
Type: System.Collections.Generic.List`1[Model.CondFilterRule]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Granularity
Defines the interval at which alarm condition is evaluated.\n* `PT10M` - Duration of 10 minutes in the ISO 8601 duration format.\n* `PT1M` - Duration of 1 minute in the ISO 8601 duration format.\n* `PT30M` - Duration of 30 minutes in the ISO 8601 duration format.\n* `PT1H` - Duration of 1 hour in the ISO 8601 duration format.

```yaml
Type: MetricThresholdCondition.GranularityEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -GroupBy
A set of metric attributes used for grouping the metric data. Currently, this can be the &apos;id&apos; or &apos;host.id&apos; attributes, as alarms must be generated for Intersight-managed object.\n* `host.id` - The API path of the host associated with the resource component for which the metric is reported.\n* `id` - The API path of the resource component for which the metric is reported.

```yaml
Type: MetricThresholdCondition.GroupByEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InstrumentName
The instrument to which the metric belongs to.

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

### -MetricName
The metric on which condition is specified.

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
Type: MetricThresholdCondition.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RollUpAggregate
Aggregation function to be applied to the grouped metric values. Example - \&quot;Avg\&quot; network utilization across all uplink ports in FI.\n* `Last` - Last value observed within a time duration - for example, last temperature reading.\n* `Average` - Arithmetic mean of the metric measurements collected over time, calculated as the sum of all metric measurements divided by the count. For example - Average temperature over time.\n* `AverageRate` - Rate of the metric measurements collected over time, calculated as the sum of all metric measurements divided by the duration of collection. For example - Average rate of network CRC errors over time.\n* `Minimum` - Smallest of all the metric values collected over time.\n* `MinimumRate` - Smallest of all the metric rate values collected over time.\n* `Maximum` - Maximum of all metric values collected over time.\n* `MaximumRate` - Maximum of all the metric rate values collected over time.\n* `Sum` - Sum of the metric values, like energy consumed over time.\n* `SumRate` - Sum of the metric rate values over time.

```yaml
Type: MetricThresholdCondition.RollUpAggregateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SeverityCriteria


Note :- Use Initialize-IntersightMetricSeverityCriteria to create the object of complex type MetricSeverityCriteria

```yaml
Type: System.Collections.Generic.List`1[Model.MetricSeverityCriteria]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TotalDataPoints
Total number of data points for which the alarm should be evaluated for this condition.

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

### -TriggerCount
The minimum number of instances that must satisfy the alarm criteria.

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
PS C:\> Initialize-IntersightMetricThresholdCondition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightCondFilterRule](./Initialize-IntersightCondFilterRule.md)

[Initialize-IntersightMetricSeverityCriteria](./Initialize-IntersightMetricSeverityCriteria.md)
