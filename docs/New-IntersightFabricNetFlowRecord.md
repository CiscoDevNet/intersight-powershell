---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightFabricNetFlowRecord

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightFabricNetFlowRecord [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-FlowNonKey< FabricFlowNonKey>][-Ipv4FlowKey< FabricIpv4FlowKey>][-Ipv6FlowKey< FabricIpv6FlowKey>][-L2FlowKey< FabricL2FlowKey>][-Moid< string>][[-Name]< string>][-NetFlowPolicy< FabricNetFlowPolicyRelationship>][-RecordType< FabricNetFlowRecord.RecordTypeEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-IfMatch< String>][-IfNoneMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;FabricNetFlowRecord&apos; resource.

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

### -FlowNonKey
Flow Non-Key (byte counter, packet counter, first system uptime and last system uptime).

Note :- Use Initialize-IntersightFabricFlowNonKey to create the object of complex type FabricFlowNonKey

```yaml
Type: FabricFlowNonKey
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
Type: FabricIpv4FlowKey
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
Type: FabricIpv6FlowKey
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
Type: FabricL2FlowKey
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

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -NetFlowPolicy
A reference to a fabricNetFlowPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricNetFlowPolicyRelationship
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
Type: System.Collections.Generic.List`1[MoTag]
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

### -IfNoneMatch
For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&apos;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&apos;s ETag doesn&apos;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&apos;t have to be identical byte for byte.

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
PS C:\> New-IntersightFabricNetFlowRecord
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightFabricNetFlowRecord](./Get-IntersightFabricNetFlowRecord.md)

[Initialize-IntersightFabricFlowNonKey](./Initialize-IntersightFabricFlowNonKey.md)

[Initialize-IntersightFabricIpv4FlowKey](./Initialize-IntersightFabricIpv4FlowKey.md)

[Initialize-IntersightFabricIpv6FlowKey](./Initialize-IntersightFabricIpv6FlowKey.md)

[Initialize-IntersightFabricL2FlowKey](./Initialize-IntersightFabricL2FlowKey.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Remove-IntersightFabricNetFlowRecord](./Remove-IntersightFabricNetFlowRecord.md)

[Set-IntersightFabricNetFlowRecord](./Set-IntersightFabricNetFlowRecord.md)
