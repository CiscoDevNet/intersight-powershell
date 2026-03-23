---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFabricNetFlowRecord

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFabricNetFlowRecord [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< FabricNetFlowRecord.ClassIdEnum>][-FlowNonKey< Model.FabricFlowNonKey>][-Ipv4FlowKey< Model.FabricIpv4FlowKey>][-Ipv6FlowKey< Model.FabricIpv6FlowKey>][-L2FlowKey< Model.FabricL2FlowKey>][-Moid< string>][-Name< string>][-NetFlowPolicy< Model.FabricNetFlowPolicyRelationship>][-ObjectType< FabricNetFlowRecord.ObjectTypeEnum>][-RecordType< FabricNetFlowRecord.RecordTypeEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: FabricNetFlowRecord.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FlowNonKey
Flow Non-Key (byte counter, packet counter, first system uptime and last system uptime).

Note :- Use Initialize-IntersightFabricFlowNonKey to create the object of complex type FabricFlowNonKey

```yaml
Type: Model.FabricFlowNonKey
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ipv4FlowKey
IPv4 Flow Key (source address, destination address, protocol, source port, destination port and tos).

Note :- Use Initialize-IntersightFabricIpv4FlowKey to create the object of complex type FabricIpv4FlowKey

```yaml
Type: Model.FabricIpv4FlowKey
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ipv6FlowKey
IPv6 Flow Key (source address, destination address, protocol, source port and destination port).

Note :- Use Initialize-IntersightFabricIpv6FlowKey to create the object of complex type FabricIpv6FlowKey

```yaml
Type: Model.FabricIpv6FlowKey
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -L2FlowKey
L2 Flow Key (source mac-address, destination mac-address and ether-type).

Note :- Use Initialize-IntersightFabricL2FlowKey to create the object of complex type FabricL2FlowKey

```yaml
Type: Model.FabricL2FlowKey
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
Netflow record name. Must be a maximum of 63 characters, without spacing.

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

### -NetFlowPolicy
A reference to a fabricNetFlowPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.FabricNetFlowPolicyRelationship
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
Type: FabricNetFlowRecord.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RecordType
Netflow Record Type IPv4, IPv6 and L2.\n* `Invalid` - Netflow record invlaid type.\n* `IPv4` - Netflow record type for IPv4 packet.\n* `IPv6` - Netflow record type for IPv6 packet.\n* `L2` - Netflow record type for L2 packet.

```yaml
Type: FabricNetFlowRecord.RecordTypeEnum
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
PS C:\> Initialize-IntersightFabricNetFlowRecord
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightFabricFlowNonKey](./Initialize-IntersightFabricFlowNonKey.md)

[Initialize-IntersightFabricIpv4FlowKey](./Initialize-IntersightFabricIpv4FlowKey.md)

[Initialize-IntersightFabricIpv6FlowKey](./Initialize-IntersightFabricIpv6FlowKey.md)

[Initialize-IntersightFabricL2FlowKey](./Initialize-IntersightFabricL2FlowKey.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
