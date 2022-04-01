---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightNetworkElement

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightNetworkElement [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AlarmSummary< ComputeAlarmSummary>][-Chassis< string>][-ConfModTs< string>][-ConfModTsBackup< string>][-Console< System.Collections.Generic.List`1[ConsoleConsoleConfigRelationship]>][-FaultSummary< long>][-FeatureControl< System.Collections.Generic.List`1[NetworkFeatureControlRelationship]>][-InterfaceList< System.Collections.Generic.List`1[NetworkInterfaceListRelationship]>][-LicenseFile< System.Collections.Generic.List`1[NetworkLicenseFileRelationship]>][-ManagementMode< NetworkElement.ManagementModeEnum>][[-Moid]< string>][-OutOfBandIpv6Address< string>][-OutOfBandIpv6Gateway< string>][-OutOfBandIpv6Prefix< string>][-PartNumber< string>][-PortMacBindings< System.Collections.Generic.List`1[PortMacBindingRelationship]>][-PreviousFru< EquipmentFruRelationship>][-ProcessorUnit< System.Collections.Generic.List`1[ProcessorUnitRelationship]>][-Status< string>][-SupervisorCard< System.Collections.Generic.List`1[NetworkSupervisorCardRelationship]>][-SwitchType< NetworkElement.SwitchTypeEnum>][-SystemUpTime< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Thermal< NetworkElement.ThermalEnum>][-TopSystem< TopSystemRelationship>][-UcsmRunningFirmware< FirmwareRunningFirmwareRelationship>][-Version< string>][-Vrf< System.Collections.Generic.List`1[NetworkVrfRelationship]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;NetworkElement&apos; resource.

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

### -AlarmSummary
The summary of alarm counts based on the severity types (Critical or Warning).

Note :- Use Initialize-IntersightComputeAlarmSummary to create the object of complex type ComputeAlarmSummary

```yaml
Type: ComputeAlarmSummary
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Chassis
Chassis IP of the switch.

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

### -ConfModTs
Configuration modified timestamp of the switch.

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

### -ConfModTsBackup
Configuration modified backup timestamp of the switch.

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

### -Console
An array of relationships to consoleConsoleConfig resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[ConsoleConsoleConfigRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FaultSummary
The fault summary of the network Element out-of-band management interface.

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

### -FeatureControl
An array of relationships to networkFeatureControl resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[NetworkFeatureControlRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InterfaceList
An array of relationships to networkInterfaceList resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[NetworkInterfaceListRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LicenseFile
An array of relationships to networkLicenseFile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[NetworkLicenseFileRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ManagementMode
The management mode of the fabric interconnect.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation.

```yaml
Type: NetworkElement.ManagementModeEnum
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

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OutOfBandIpv6Address
The IPv6 address of the network Element out-of-band management interface.

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

### -OutOfBandIpv6Gateway
The default IPv6 gateway of the network Element out-of-band management interface.

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

### -OutOfBandIpv6Prefix
The network mask of the network Element out-of-band management interface.

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

### -PartNumber
Part number of the switch.

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

### -PortMacBindings
An array of relationships to portMacBinding resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[PortMacBindingRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreviousFru
A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: EquipmentFruRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessorUnit
An array of relationships to processorUnit resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[ProcessorUnitRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Status
The status of the switch.

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

### -SupervisorCard
An array of relationships to networkSupervisorCard resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[NetworkSupervisorCardRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SwitchType
The Switch type that the network element is a part of.\n* `FabricInterconnect` - The default Switch type of UCSM and IMM mode devices.\n* `NexusDevice` - Switch type of Nexus devices.\n* `MDSDevice` - Switch type of Nexus MDS devices.

```yaml
Type: NetworkElement.SwitchTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SystemUpTime
System up time of the switch.

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

### -Thermal
The Thermal status of the fabric interconnect.\n* `unknown` - The default state of the sensor (in case no data is received).\n* `ok` - State of the sensor indicating the sensor&apos;s temperature range is okay.\n* `upper-non-recoverable` - State of the sensor indicating that the temperature is extremely high above normal range.\n* `upper-critical` - State of the sensor indicating that the temperature is above normal range.\n* `upper-non-critical` - State of the sensor indicating that the temperature is a little above the normal range.\n* `lower-non-critical` - State of the sensor indicating that the temperature is a little below the normal range.\n* `lower-critical` - State of the sensor indicating that the temperature is below normal range.\n* `lower-non-recoverable` - State of the sensor indicating that the temperature is extremely below normal range.

```yaml
Type: NetworkElement.ThermalEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TopSystem
A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: TopSystemRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UcsmRunningFirmware
A reference to a firmwareRunningFirmware resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FirmwareRunningFirmwareRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
Firmware version of the switch.

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

### -Vrf
An array of relationships to networkVrf resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[NetworkVrfRelationship]
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
PS C:\> Set-IntersightNetworkElement
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightNetworkElement](./Get-IntersightNetworkElement.md)

[Initialize-IntersightComputeAlarmSummary](./Initialize-IntersightComputeAlarmSummary.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
