---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightVnicEthIf

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightVnicEthIf [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Cdn< VnicCdn>][-EthAdapterPolicy< VnicEthAdapterPolicyRelationship>][-EthNetworkPolicy< VnicEthNetworkPolicyRelationship>][-EthQosPolicy< VnicEthQosPolicyRelationship>][-FabricEthNetworkControlPolicy< FabricEthNetworkControlPolicyRelationship>][-FabricEthNetworkGroupPolicy< System.Collections.Generic.List`1[FabricEthNetworkGroupPolicyRelationship]>][-FailoverEnabled< bool>][-IpLease< IppoolIpLeaseRelationship>][-IscsiBootPolicy< VnicIscsiBootPolicyRelationship>][-LanConnectivityPolicy< VnicLanConnectivityPolicyRelationship>][-MacAddressType< VnicEthIf.MacAddressTypeEnum>][-MacLease< MacpoolLeaseRelationship>][-MacPool< MacpoolPoolRelationship>][-Moid< string>][[-Name]< string>][-Order< long>][-PinGroupName< string>][-Placement< VnicPlacementSettings>][-Profile< PolicyAbstractConfigProfileRelationship>][-SrcTemplate< VnicVnicTemplateRelationship>][-SriovSettings< VnicSriovSettings>][-StaticMacAddress< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TemplateActions< System.Collections.Generic.List`1[MotemplateActionEntry]>][-UsnicSettings< VnicUsnicSettings>][-VmqSettings< VnicVmqSettings>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;VnicEthIf&apos; resource.

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

### -Cdn
Consistent Device Naming configuration for the virtual NIC.

Note :- Use Initialize-IntersightVnicCdn to create the object of complex type VnicCdn

```yaml
Type: VnicCdn
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EthAdapterPolicy
A reference to a vnicEthAdapterPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VnicEthAdapterPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EthNetworkPolicy
A reference to a vnicEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VnicEthNetworkPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EthQosPolicy
A reference to a vnicEthQosPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VnicEthQosPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FabricEthNetworkControlPolicy
A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricEthNetworkControlPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FabricEthNetworkGroupPolicy
An array of relationships to fabricEthNetworkGroupPolicy resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[FabricEthNetworkGroupPolicyRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FailoverEnabled
Enabling failover ensures that traffic from the vNIC automatically fails over to the secondary Fabric Interconnect, in case the specified Fabric Interconnect path goes down. Failover applies only to Cisco VICs that are connected to a Fabric Interconnect cluster.

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

### -IpLease
A reference to a ippoolIpLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IppoolIpLeaseRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IscsiBootPolicy
A reference to a vnicIscsiBootPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VnicIscsiBootPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LanConnectivityPolicy
A reference to a vnicLanConnectivityPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VnicLanConnectivityPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MacAddressType
Type of allocation selected to assign a MAC address for the vnic.\n* `POOL` - The user selects a pool from which the mac/wwn address will be leased for the Virtual Interface.\n* `STATIC` - The user assigns a static mac/wwn address for the Virtual Interface.

```yaml
Type: VnicEthIf.MacAddressTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MacLease
A reference to a macpoolLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: MacpoolLeaseRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MacPool
A reference to a macpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: MacpoolPoolRelationship
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
Name of the virtual ethernet interface.

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

### -Order
The order in which the virtual interface is brought up. The order assigned to an interface should be unique for all the Ethernet and Fibre-Channel interfaces on each PCI link on a VIC adapter. The order should start from zero with no overlaps. The maximum value of PCI order is limited by the number of virtual interfaces (Ethernet and Fibre-Channel) on each PCI link on a VIC adapter. All VIC adapters have a single PCI link except VIC 1340, VIC 1380 and VIC 1385 which have two.

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

### -PinGroupName
Pingroup name associated to vNIC for static pinning. LCP deploy will resolve pingroup name and fetches the correspoding uplink port/port channel to pin the vNIC traffic.

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

### -Placement
Placement Settings for the virtual interface.

Note :- Use Initialize-IntersightVnicPlacementSettings to create the object of complex type VnicPlacementSettings

```yaml
Type: VnicPlacementSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Profile
A reference to a policyAbstractConfigProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: PolicyAbstractConfigProfileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SrcTemplate
A reference to a vnicVnicTemplate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VnicVnicTemplateRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SriovSettings
Single Root Input Output Virtualization (SR-IOV) Settings that enable one physical ethernet socket to appear as multiple NICs to the hypervisor.

Note :- Use Initialize-IntersightVnicSriovSettings to create the object of complex type VnicSriovSettings

```yaml
Type: VnicSriovSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StaticMacAddress
The MAC address must be in hexadecimal format xx:xx:xx:xx:xx:xx.\nTo ensure uniqueness of MACs in the LAN fabric, you are strongly encouraged to use the\nfollowing MAC prefix 00:25:B5:xx:xx:xx.

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

### -TemplateActions


Note :- Use Initialize-IntersightMotemplateActionEntry to create the object of complex type MotemplateActionEntry

```yaml
Type: System.Collections.Generic.List`1[MotemplateActionEntry]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UsnicSettings
User Space NIC Settings that enable low-latency and higher throughput by bypassing the kernel layer when sending/receiving packets.

Note :- Use Initialize-IntersightVnicUsnicSettings to create the object of complex type VnicUsnicSettings

```yaml
Type: VnicUsnicSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmqSettings
Virtual Machine Queue Settings for the virtual interface that allow efficient transfer of network traffic to the guest OS.

Note :- Use Initialize-IntersightVnicVmqSettings to create the object of complex type VnicVmqSettings

```yaml
Type: VnicVmqSettings
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
PS C:\> New-IntersightVnicEthIf
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVnicEthIf](./Get-IntersightVnicEthIf.md)

[Initialize-IntersightIppoolIpV4Config](./Initialize-IntersightIppoolIpV4Config.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightMotemplateActionEntry](./Initialize-IntersightMotemplateActionEntry.md)

[Initialize-IntersightMotemplateSyncError](./Initialize-IntersightMotemplateSyncError.md)

[Initialize-IntersightVnicCdn](./Initialize-IntersightVnicCdn.md)

[Initialize-IntersightVnicPlacementSettings](./Initialize-IntersightVnicPlacementSettings.md)

[Initialize-IntersightVnicSriovSettings](./Initialize-IntersightVnicSriovSettings.md)

[Initialize-IntersightVnicUsnicSettings](./Initialize-IntersightVnicUsnicSettings.md)

[Initialize-IntersightVnicVmqSettings](./Initialize-IntersightVnicVmqSettings.md)

[Remove-IntersightVnicEthIf](./Remove-IntersightVnicEthIf.md)

[Set-IntersightVnicEthIf](./Set-IntersightVnicEthIf.md)
