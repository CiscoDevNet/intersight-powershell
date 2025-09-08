---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightFabricVlan

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightFabricVlan [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AutoAllowOnClusterLinks< bool>][-AutoAllowOnUplinks< bool>][-EthNetworkPolicy< FabricEthNetworkPolicyRelationship>][-IsNative< bool>][[-Moid]< string>][-MulticastPolicy< FabricMulticastPolicyRelationship>][-Name< string>][-PrimaryVlanId< long>][-SharingType< FabricVlan.SharingTypeEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-VlanId< long>][-VlanSet< FabricVlanSetRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;FabricVlan&apos; resource.

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

### -AutoAllowOnClusterLinks
Enable this option to automatically allow the VLAN on inter-cluster links. To configure disjoint Layer 2 VLANs, &apos;Disable&apos; must be specified together with &apos;AutoAllowOnUplinks.&apos; Note that &apos;AutoAllowOnClusterLinks&apos; cannot be enabled for the default VLAN 1 or the native VLAN.

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

### -AutoAllowOnUplinks
Enable to automatically allow this VLAN on all uplinks. Disable must be specified alongside AutoAllowOnClusterLinks for disjoint layer 2 VLAN configuration. Default VLAN 1 cannot be configured as disjoint layer 2 VLAN.

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

### -EthNetworkPolicy
A reference to a fabricEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricEthNetworkPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsNative
Used to define whether this VLAN is to be classified as &apos;native&apos; for traffic in this FI.

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

### -MulticastPolicy
A reference to a fabricMulticastPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricMulticastPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The &apos;name&apos; used to identify this VLAN.

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

### -PrimaryVlanId
The Primary VLAN ID of the VLAN, if the sharing type of the VLAN is Isolated or Community.

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

### -SharingType
The sharing type of this VLAN.\n* `None` - This represents a regular VLAN.\n* `Primary` - This represents a primary VLAN.\n* `Isolated` - This represents an isolated VLAN.\n* `Community` - This represents a community VLAN.

```yaml
Type: FabricVlan.SharingTypeEnum
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
The identifier for this Virtual LAN.

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

### -VlanSet
A reference to a fabricVlanSet resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricVlanSetRelationship
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
PS C:\> Set-IntersightFabricVlan
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightFabricVlan](./Get-IntersightFabricVlan.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightFabricVlan](./New-IntersightFabricVlan.md)

[Remove-IntersightFabricVlan](./Remove-IntersightFabricVlan.md)
