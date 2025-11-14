---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightVirtualizationVmwareNetwork

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightVirtualizationVmwareNetwork [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ForgedTransmits< VirtualizationVmwareNetwork.ForgedTransmitsEnum>][-Identity< string>][-MacAddressChanges< VirtualizationVmwareNetwork.MacAddressChangesEnum>][[-Moid]< string>][-Name< string>][-NicTeamingAndFailover< VirtualizationVmwareTeamingAndFailover>][-PromiscuousMode< VirtualizationVmwareNetwork.PromiscuousModeEnum>][-RegisteredDevice< AssetDeviceRegistrationRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-VlanId< long>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;VirtualizationVmwareNetwork&apos; resource.

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

### -ForgedTransmits
If forgedTransmits property value is set to reject, outbound frames with source MAC address different from the one set on the adapter are dropped. If property value is set to accept, no filtering is performed and all outbound frames are passed.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted.

```yaml
Type: VirtualizationVmwareNetwork.ForgedTransmitsEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Identity
The internally generated identity of network. This entity cannot manipulated by users. It aids in uniquely identifying the network object. For VMware, this is MOR (managed object reference).

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

### -MacAddressChanges
If macAddressChanges property value is set to reject and the MAC address of the adapter is changed to a value other than the one specified in .vmx configuration file, all inbound frames are dropped. If property value is set to accept and the MAC address is changed, inbound frames to the new MAC address are received.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted.

```yaml
Type: VirtualizationVmwareNetwork.MacAddressChangesEnum
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
User-provided name to identify the portgroup.

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

### -NicTeamingAndFailover
The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage.

Note :- Use Initialize-IntersightVirtualizationVmwareTeamingAndFailover to create the object of complex type VirtualizationVmwareTeamingAndFailover

```yaml
Type: VirtualizationVmwareTeamingAndFailover
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PromiscuousMode
If promiscuousMode property value is set to reject, incoming traffic only targeted to that network will be visible. If property value is set to accept, objects defined within the network can see all incoming traffic on the virtual switch based on the VLAN policy.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted.

```yaml
Type: VirtualizationVmwareNetwork.PromiscuousModeEnum
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
Type: AssetDeviceRegistrationRelationship
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

### -VlanId
VLAN id with which the network is associated. A value of 0 specifies that port is not associated with a VLAN.

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

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
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
PS C:\> Set-IntersightVirtualizationVmwareNetwork
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVirtualizationVmwareNetwork](./Get-IntersightVirtualizationVmwareNetwork.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightVirtualizationVmwareTeamingAndFailover](./Initialize-IntersightVirtualizationVmwareTeamingAndFailover.md)
