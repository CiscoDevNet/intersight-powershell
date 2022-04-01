---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightNiatelemetryNiaInventory

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightNiatelemetryNiaInventory [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< NiatelemetryNiaInventory.ClassIdEnum>][-ControllerIpAddress< string>][-Cpu< float>][-CrashResetLogs< string>][-CustomerDeviceConnector< string>][-DcnmLicenseState< string>][-DeviceDiscovery< string>][-DeviceHealth< long>][-DeviceId< string>][-DeviceName< string>][-DeviceType< string>][-DeviceUpTime< long>][-Disk< Model.NiatelemetryDiskinfo>][-Dn< string>][-FabricName< string>][-FexCount< long>][-InfraWiNodeCount< long>][-Interface< System.Collections.Generic.List`1[Model.NiatelemetryInterfaceElement]>][-IpAddress< string>][-IsVirtualNode< string>][-LastRebootTime< string>][-LastResetReason< string>][-LicenseState< Model.NiatelemetryNiaLicenseStateRelationship>][-LicenseType< string>][-LogInTime< string>][-LogOutTime< string>][-MacSecCount< long>][-MacSecFabCount< long>][-MacsecTotalCount< long>][-Memory< long>][-Moid< string>][-NodeId< string>][-NxosBgpEvpn< Model.NiatelemetryNxosBgpEvpn>][-NxosBgpMvpn< Model.NiatelemetryNxosBgpMvpn>][-NxosBootflashDetails< Model.NiatelemetryBootflashDetails>][-NxosDciInterfaceStatus< string>][-NxosInterfaceBrief< Model.NiatelemetryInterface>][-NxosNveInterfaceStatus< string>][-NxosNvePacketCounters< Model.NiatelemetryNvePacketCounters>][-NxosNveVni< Model.NiatelemetryNveVni>][-NxosOspfNeighbors< long>][-NxosPimNeighbors< string>][-NxosTelnet< string>][-NxosTotalRoutes< long>][-NxosVtp< Model.NiatelemetryNxosVtp>][-ObjectType< NiatelemetryNiaInventory.ObjectTypeEnum>][-RecordType< string>][-RecordVersion< string>][-RoutePrefixCount< long>][-RoutePrefixV4Count< long>][-RoutePrefixV6Count< long>][-Serial< string>][-SiteName< string>][-SmartAccountId< long>][-SoftwareDownload< string>][-SystemUpTime< string>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Version< string>][-VniStatus< System.Collections.Generic.List`1[Model.NiatelemetryVniStatus]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: NiatelemetryNiaInventory.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ControllerIpAddress
Returns controller&apos;s IP address details.

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

### -Cpu
CPU usage of device being inventoried. This determines the percentage of CPU resources used.

```yaml
Type: float
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CrashResetLogs
Last crash reset reason of device being inventoried. This determines the last reason for a device&apos;s restart due to crash of the system.

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

### -CustomerDeviceConnector
Returns the value of the customerDeviceConnector field.

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

### -DcnmLicenseState
Returns the License state of the device.

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

### -DeviceDiscovery
Returns the value of the deviceDiscovery field.

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

### -DeviceHealth
Returns the device health.

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

### -DeviceId
Returns the value of the deviceId field.

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

### -DeviceName
Name of device being inventoried. The name the user assigns to the device is inventoried here.

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

### -DeviceType
Type of device being inventoried. This determines whether the device is a controller, leaf or spine.

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

### -DeviceUpTime
Returns the device up time.

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

### -Disk
Disk Usage of device being inventoried. This determines the amount of disk usage.

Note :- Use Initialize-IntersightNiatelemetryDiskinfo to create the object of complex type NiatelemetryDiskinfo

```yaml
Type: Model.NiatelemetryDiskinfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Dn
Dn for the inventories present.

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

### -FabricName
Name of the fabric of the device being inventoried.

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

### -FexCount
Number of fabric extendors utilized.

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

### -InfraWiNodeCount
Number of appliances as physical device that are wired into the cluster.

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

### -Interface


Note :- Use Initialize-IntersightNiatelemetryInterfaceElement to create the object of complex type NiatelemetryInterfaceElement

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetryInterfaceElement]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpAddress
The IP address of the device being inventoried.

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

### -IsVirtualNode
Flag to specify if the node is virtual.

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

### -LastRebootTime
Returns the last reboot Time of the device.

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

### -LastResetReason
Returns the last reset reason of the device.

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

### -LicenseState
A reference to a niatelemetryNiaLicenseState resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.NiatelemetryNiaLicenseStateRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LicenseType
Returns the License type of the device.

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

### -LogInTime
Last log in time device being inventoried. This determines the last login time on the device.

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

### -LogOutTime
Last log out time of device being inventoried. This determines the last logout time on the device.

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

### -MacSecCount
Number of Macsec configured interfaces on a TOR.

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

### -MacSecFabCount
Number of Macsec configured interfaces on a Spine.

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

### -MacsecTotalCount
Number of total Macsec configured interfaces for all nodes.

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

### -Memory
Memory usage of device being inventoried. This determines the percentage of memory resources used.

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

### -NodeId
The ID of the device being inventoried.

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

### -NxosBgpEvpn
Returns Nxos EVPN BGP details.

Note :- Use Initialize-IntersightNiatelemetryNxosBgpEvpn to create the object of complex type NiatelemetryNxosBgpEvpn

```yaml
Type: Model.NiatelemetryNxosBgpEvpn
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NxosBgpMvpn
Returns the value of the nxosTrmConfigs field.

Note :- Use Initialize-IntersightNiatelemetryNxosBgpMvpn to create the object of complex type NiatelemetryNxosBgpMvpn

```yaml
Type: Model.NiatelemetryNxosBgpMvpn
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NxosBootflashDetails
Returns the value of the nxosBootflashDetails field.

Note :- Use Initialize-IntersightNiatelemetryBootflashDetails to create the object of complex type NiatelemetryBootflashDetails

```yaml
Type: Model.NiatelemetryBootflashDetails
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NxosDciInterfaceStatus
Returns the status of dci interface configured.

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

### -NxosInterfaceBrief
Returns the value of the nxosInterfaceBrief field.

Note :- Use Initialize-IntersightNiatelemetryInterface to create the object of complex type NiatelemetryInterface

```yaml
Type: Model.NiatelemetryInterface
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NxosNveInterfaceStatus
Returns the value of the nxosNveInterface field.

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

### -NxosNvePacketCounters
Returns the value of the nxosNvePacketCounters field.

Note :- Use Initialize-IntersightNiatelemetryNvePacketCounters to create the object of complex type NiatelemetryNvePacketCounters

```yaml
Type: Model.NiatelemetryNvePacketCounters
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NxosNveVni
Returns the value of the nxosNveVni field.

Note :- Use Initialize-IntersightNiatelemetryNveVni to create the object of complex type NiatelemetryNveVni

```yaml
Type: Model.NiatelemetryNveVni
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NxosOspfNeighbors
Total number of ospf neighbors per switch in DCNM.

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

### -NxosPimNeighbors
Total number of pim neighbors per switch in DCNM.

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

### -NxosTelnet
Returns the value of the nxosTelnet field.

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

### -NxosTotalRoutes
Total number of routes configured in the DCNM.

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

### -NxosVtp
Returns the value of the nxosVtpStatus field.

Note :- Use Initialize-IntersightNiatelemetryNxosVtp to create the object of complex type NiatelemetryNxosVtp

```yaml
Type: Model.NiatelemetryNxosVtp
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
Type: NiatelemetryNiaInventory.ObjectTypeEnum
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

### -RoutePrefixCount
Total nuumber of v4 and v6 routes per node.

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

### -RoutePrefixV4Count
Number of v4 routes per node.

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

### -RoutePrefixV6Count
Number of v6 routes per node.

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

### -Serial
Serial number of device being invetoried. The serial number is unique per device and will be used as the key.

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
Name of fabric domain of the controller.

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

### -SmartAccountId
Returns the value of the smartAccountId/CustomerId field.

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

### -SoftwareDownload
Last software downloaded of device being inventoried. This determines if software download API was used.

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

### -SystemUpTime
The amount of time that the device being inventoried been up.

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
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
Software version of device being inventoried. The various software version values for each device are available on cisco.com.

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

### -VniStatus


Note :- Use Initialize-IntersightNiatelemetryVniStatus to create the object of complex type NiatelemetryVniStatus

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetryVniStatus]
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
PS C:\> Initialize-IntersightNiatelemetryNiaInventory
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

[Initialize-IntersightNiatelemetryBootflashDetails](./Initialize-IntersightNiatelemetryBootflashDetails.md)

[Initialize-IntersightNiatelemetryDiskinfo](./Initialize-IntersightNiatelemetryDiskinfo.md)

[Initialize-IntersightNiatelemetryInterface](./Initialize-IntersightNiatelemetryInterface.md)

[Initialize-IntersightNiatelemetryInterfaceElement](./Initialize-IntersightNiatelemetryInterfaceElement.md)

[Initialize-IntersightNiatelemetryNvePacketCounters](./Initialize-IntersightNiatelemetryNvePacketCounters.md)

[Initialize-IntersightNiatelemetryNveVni](./Initialize-IntersightNiatelemetryNveVni.md)

[Initialize-IntersightNiatelemetryNxosBgpEvpn](./Initialize-IntersightNiatelemetryNxosBgpEvpn.md)

[Initialize-IntersightNiatelemetryNxosBgpMvpn](./Initialize-IntersightNiatelemetryNxosBgpMvpn.md)

[Initialize-IntersightNiatelemetryNxosVtp](./Initialize-IntersightNiatelemetryNxosVtp.md)

[Initialize-IntersightNiatelemetryVniStatus](./Initialize-IntersightNiatelemetryVniStatus.md)
