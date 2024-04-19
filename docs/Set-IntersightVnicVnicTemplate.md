---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightVnicVnicTemplate

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightVnicVnicTemplate [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Cdn< VnicCdn>][-Description< string>][-EnableOverride< bool>][-EthAdapterPolicy< VnicEthAdapterPolicyRelationship>][-EthNetworkPolicy< VnicEthNetworkPolicyRelationship>][-EthQosPolicy< VnicEthQosPolicyRelationship>][-FabricEthNetworkControlPolicy< FabricEthNetworkControlPolicyRelationship>][-FabricEthNetworkGroupPolicy< System.Collections.Generic.List`1[FabricEthNetworkGroupPolicyRelationship]>][-FailoverEnabled< bool>][-IscsiBootPolicy< VnicIscsiBootPolicyRelationship>][-MacPool< MacpoolPoolRelationship>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-PeerVnicName< string>][-PinGroupName< string>][-SriovSettings< VnicSriovSettings>][-SwitchId< VnicVnicTemplate.SwitchIdEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TemplateActions< System.Collections.Generic.List`1[MotemplateActionEntry]>][-UsnicSettings< VnicUsnicSettings>][-VmqSettings< VnicVmqSettings>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;VnicVnicTemplate&apos; resource.

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

### -Description
Description of the vNIC template.

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

### -EnableOverride
When enabled, the configuration of the derived instances may override the template configuration.

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

Required: true
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PeerVnicName
Name of the peer vNIC which belongs to the peer FI.

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

### -SwitchId
The fabric port to which the vNICs will be associated.\n* `None` - Fabric Id is not set to either A or B for the standalone case where the server is not connected to Fabric Interconnects. The value &apos;None&apos; should be used.\n* `A` - Fabric A of the FI cluster.\n* `B` - Fabric B of the FI cluster.

```yaml
Type: VnicVnicTemplate.SwitchIdEnum
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
PS C:\> Set-IntersightVnicVnicTemplate
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVnicVnicTemplate](./Get-IntersightVnicVnicTemplate.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightMotemplateActionEntry](./Initialize-IntersightMotemplateActionEntry.md)

[Initialize-IntersightVnicCdn](./Initialize-IntersightVnicCdn.md)

[Initialize-IntersightVnicSriovSettings](./Initialize-IntersightVnicSriovSettings.md)

[Initialize-IntersightVnicUsnicSettings](./Initialize-IntersightVnicUsnicSettings.md)

[Initialize-IntersightVnicVmqSettings](./Initialize-IntersightVnicVmqSettings.md)

[New-IntersightVnicVnicTemplate](./New-IntersightVnicVnicTemplate.md)

[Remove-IntersightVnicVnicTemplate](./Remove-IntersightVnicVnicTemplate.md)
