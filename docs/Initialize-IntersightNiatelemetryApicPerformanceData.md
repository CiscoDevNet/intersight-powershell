---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightNiatelemetryApicPerformanceData

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightNiatelemetryApicPerformanceData [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< NiatelemetryApicPerformanceData.ClassIdEnum>][-DigitalOpticalMonitoring< System.Collections.Generic.List`1[Model.NiatelemetryDigitalOpticalMonitoring]>][-Dn< string>][-EqptStorageFirmware< Model.NiatelemetryEqptStorageFirmware>][-EqptcapacityPolUsage5min< Model.NiatelemetryEqptcapacityPolUsage5min>][-EqptcapacityPrefixEntries15min< Model.NiatelemetryEqptcapacityPrefixEntries15min>][-EqptcapacityPrefixEntries5min< Model.NiatelemetryEqptcapacityPrefixEntries5min>][-Moid< string>][-NodeHealth< long>][-ObjectType< NiatelemetryApicPerformanceData.ObjectTypeEnum>][-ProcSysCpu15min< Model.NiatelemetryProcSysCpu15min>][-ProcSysCpu5min< Model.NiatelemetryProcSysCpu5min>][-ProcSysMem15min< Model.NiatelemetryProcSysMem15min>][-ProcSysMem5min< Model.NiatelemetryProcSysMem5min>][-RecordType< string>][-RecordVersion< string>][-SiteName< string>][-SwitchDiskUtilization< System.Collections.Generic.List`1[Model.NiatelemetrySwitchDiskUtilization]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: NiatelemetryApicPerformanceData.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DigitalOpticalMonitoring


Note :- Use Initialize-IntersightNiatelemetryDigitalOpticalMonitoring to create the object of complex type NiatelemetryDigitalOpticalMonitoring

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetryDigitalOpticalMonitoring]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Dn
Dn of the fabric nodes in the apic.

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

### -EqptStorageFirmware
Returns disk space utilization information.

Note :- Use Initialize-IntersightNiatelemetryEqptStorageFirmware to create the object of complex type NiatelemetryEqptStorageFirmware

```yaml
Type: Model.NiatelemetryEqptStorageFirmware
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EqptcapacityPolUsage5min
Returns tcam utilization information.

Note :- Use Initialize-IntersightNiatelemetryEqptcapacityPolUsage5min to create the object of complex type NiatelemetryEqptcapacityPolUsage5min

```yaml
Type: Model.NiatelemetryEqptcapacityPolUsage5min
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EqptcapacityPrefixEntries15min
Returns lpm max utilization info in last 15 minutes.

Note :- Use Initialize-IntersightNiatelemetryEqptcapacityPrefixEntries15min to create the object of complex type NiatelemetryEqptcapacityPrefixEntries15min

```yaml
Type: Model.NiatelemetryEqptcapacityPrefixEntries15min
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EqptcapacityPrefixEntries5min
Returns lpm max utilization info in last 5 minutes.

Note :- Use Initialize-IntersightNiatelemetryEqptcapacityPrefixEntries5min to create the object of complex type NiatelemetryEqptcapacityPrefixEntries5min

```yaml
Type: Model.NiatelemetryEqptcapacityPrefixEntries5min
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

### -NodeHealth
Health of the fabric nodes in the apic.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: NiatelemetryApicPerformanceData.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcSysCpu15min
Returns cpu performance info in last 15 mintues.

Note :- Use Initialize-IntersightNiatelemetryProcSysCpu15min to create the object of complex type NiatelemetryProcSysCpu15min

```yaml
Type: Model.NiatelemetryProcSysCpu15min
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcSysCpu5min
Returns cpu performance info in last 5 mintues.

Note :- Use Initialize-IntersightNiatelemetryProcSysCpu5min to create the object of complex type NiatelemetryProcSysCpu5min

```yaml
Type: Model.NiatelemetryProcSysCpu5min
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcSysMem15min
Returns memory performance info in last 15 mintues.

Note :- Use Initialize-IntersightNiatelemetryProcSysMem15min to create the object of complex type NiatelemetryProcSysMem15min

```yaml
Type: Model.NiatelemetryProcSysMem15min
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcSysMem5min
Returns memory performance info in last 5 mintues.

Note :- Use Initialize-IntersightNiatelemetryProcSysMem5min to create the object of complex type NiatelemetryProcSysMem5min

```yaml
Type: Model.NiatelemetryProcSysMem5min
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RecordType
Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected.

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

### -RecordVersion
Version of record being pushed. This determines what was the API version for data available from the device.

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

### -SiteName
Name of the APIC site from which this data is being collected..

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

### -SwitchDiskUtilization


Note :- Use Initialize-IntersightNiatelemetrySwitchDiskUtilization to create the object of complex type NiatelemetrySwitchDiskUtilization

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetrySwitchDiskUtilization]
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
PS C:\> Initialize-IntersightNiatelemetryApicPerformanceData
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

[Initialize-IntersightNiatelemetryDigitalOpticalMonitoring](./Initialize-IntersightNiatelemetryDigitalOpticalMonitoring.md)

[Initialize-IntersightNiatelemetryEqptStorageFirmware](./Initialize-IntersightNiatelemetryEqptStorageFirmware.md)

[Initialize-IntersightNiatelemetryEqptcapacityPolUsage5min](./Initialize-IntersightNiatelemetryEqptcapacityPolUsage5min.md)

[Initialize-IntersightNiatelemetryEqptcapacityPrefixEntries15min](./Initialize-IntersightNiatelemetryEqptcapacityPrefixEntries15min.md)

[Initialize-IntersightNiatelemetryEqptcapacityPrefixEntries5min](./Initialize-IntersightNiatelemetryEqptcapacityPrefixEntries5min.md)

[Initialize-IntersightNiatelemetryProcSysCpu15min](./Initialize-IntersightNiatelemetryProcSysCpu15min.md)

[Initialize-IntersightNiatelemetryProcSysCpu5min](./Initialize-IntersightNiatelemetryProcSysCpu5min.md)

[Initialize-IntersightNiatelemetryProcSysMem15min](./Initialize-IntersightNiatelemetryProcSysMem15min.md)

[Initialize-IntersightNiatelemetryProcSysMem5min](./Initialize-IntersightNiatelemetryProcSysMem5min.md)

[Initialize-IntersightNiatelemetrySwitchDiskUtilization](./Initialize-IntersightNiatelemetrySwitchDiskUtilization.md)
