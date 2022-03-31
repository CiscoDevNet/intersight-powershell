---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVirtualizationVmwareDistributedSwitch

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVirtualizationVmwareDistributedSwitch [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< VirtualizationVmwareDistributedSwitch.ClassIdEnum>][-Description< string>][-DiscoveryProtocol< Model.VirtualizationVmwareDiscoveryProtocol>][-Identity< string>][-MaxPort< long>][-Moid< string>][-Mtu< long>][-Name< string>][-NetworkIoControl< bool>][-NicTeamingAndFailover< Model.VirtualizationVmwareTeamingAndFailover>][-NumHosts< long>][-NumNetworks< long>][-NumStandAlonePorts< long>][-NumUplinks< long>][-ObjectType< VirtualizationVmwareDistributedSwitch.ObjectTypeEnum>][-RegisteredDevice< Model.AssetDeviceRegistrationRelationship>][-ResourceAllocationSystemTraffic< System.Collections.Generic.List`1[Model.VirtualizationVmwareResourceAllocationSystemTrafficTypes]>][-SwitchCapacity< Model.VirtualizationStorageCapacity>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Uuid< string>][-Version< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: VirtualizationVmwareDistributedSwitch.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Switch description (user provided), if any.

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

### -DiscoveryProtocol
Discovery protocol helps to determine which port of the physical switch connected to standard switch or distributed switch.

Note :- Use Initialize-IntersightVirtualizationVmwareDiscoveryProtocol to create the object of complex type VirtualizationVmwareDiscoveryProtocol

```yaml
Type: Model.VirtualizationVmwareDiscoveryProtocol
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Identity
The internally generated identity of this switch. This entity is not manipulated by users. It aids in uniquely identifying the switch object. For VMware, this is MOR (managed object reference).

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

### -MaxPort
Maximum number of ports allowed on this distributed virtual switch.

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

### -Mtu
Maximum transmission unit configured on a distributed virtual switch.

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

### -Name
User-provided name to identify the switch.

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

### -NetworkIoControl
If network io control is enabled, will set the value as true.

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

### -NicTeamingAndFailover
The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage.

Note :- Use Initialize-IntersightVirtualizationVmwareTeamingAndFailover to create the object of complex type VirtualizationVmwareTeamingAndFailover

```yaml
Type: Model.VirtualizationVmwareTeamingAndFailover
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NumHosts
The total number of hosts attached to the distributed virtual switch.

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

### -NumNetworks
The total number of distributed networks in the distributed virtual switch.

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

### -NumStandAlonePorts
Number of stand-alone ports in use.

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

### -NumUplinks
Number of uplinks configured in this distributed virtual switch.

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
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: VirtualizationVmwareDistributedSwitch.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RegisteredDevice
A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.AssetDeviceRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceAllocationSystemTraffic


Note :- Use Initialize-IntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes to create the object of complex type VirtualizationVmwareResourceAllocationSystemTrafficTypes

```yaml
Type: System.Collections.Generic.List`1[Model.VirtualizationVmwareResourceAllocationSystemTrafficTypes]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SwitchCapacity
Capacity and consumption information about this distributed virtual switch, if available.

Note :- Use Initialize-IntersightVirtualizationStorageCapacity to create the object of complex type VirtualizationStorageCapacity

```yaml
Type: Model.VirtualizationStorageCapacity
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

### -Uuid
Universally Unique Id of this distributed virtual switch.

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

### -Version
The running config&apos;s version details are represented.

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
PS C:\> Initialize-IntersightVirtualizationVmwareDistributedSwitch
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightVirtualizationVmwareDiscoveryProtocol](./Initialize-IntersightVirtualizationVmwareDiscoveryProtocol.md)

[Initialize-IntersightVirtualizationVmwareTeamingAndFailover](./Initialize-IntersightVirtualizationVmwareTeamingAndFailover.md)

[Initialize-IntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes](./Initialize-IntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes.md)

[Initialize-IntersightVirtualizationStorageCapacity](./Initialize-IntersightVirtualizationStorageCapacity.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
