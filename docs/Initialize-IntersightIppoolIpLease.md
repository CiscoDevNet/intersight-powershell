---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightIppoolIpLease

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightIppoolIpLease [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AllocationType< IppoolIpLease.AllocationTypeEnum>][-AssignedToEntity< Model.MoBaseMoRelationship>][-BlockLease< Model.IppoolBlockLeaseRelationship>][-ClassId< IppoolIpLease.ClassIdEnum>][-IpType< IppoolIpLease.IpTypeEnum>][-IpV4Address< string>][-IpV4Config< Model.IppoolIpV4Config>][-IpV6Address< string>][-IpV6Config< Model.IppoolIpV6Config>][-Moid< string>][-ObjectType< IppoolIpLease.ObjectTypeEnum>][-Pool< Model.IppoolPoolRelationship>][-Reservation< Model.IppoolReservationReference>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Vrf< Model.VrfVrfRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AllocationType
Type of the lease allocation either static or dynamic (i.e via pool).\n* `dynamic` - Identifiers to be allocated by system.\n* `static` - Identifiers are assigned by the user.

```yaml
Type: IppoolIpLease.AllocationTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AssignedToEntity
A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.MoBaseMoRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BlockLease
A reference to a ippoolBlockLease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.IppoolBlockLeaseRelationship
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
Type: IppoolIpLease.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpType
Type of the IP address requested.\n* `IPv4` - IP V4 address type requested.\n* `IPv6` - IP V6 address type requested.

```yaml
Type: IppoolIpLease.IpTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpV4Address
IPv4 Address given as a lease to an external entity like server profiles.

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

### -IpV4Config
Netmask, Gateway and DNS settings for IPv4 addresses.

Note :- Use Initialize-IntersightIppoolIpV4Config to create the object of complex type IppoolIpV4Config

```yaml
Type: Model.IppoolIpV4Config
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpV6Address
IPv6 Address given as a lease to an external entity like server profiles.

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

### -IpV6Config
Netmask, Gateway and DNS settings for IPv6 addresses.

Note :- Use Initialize-IntersightIppoolIpV6Config to create the object of complex type IppoolIpV6Config

```yaml
Type: Model.IppoolIpV6Config
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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: IppoolIpLease.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Pool
A reference to a ippoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.IppoolPoolRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Reservation
The holder of a reference to reservation Moid and the specific details on lease condition for this reservation. Specified to allocate already reserved identities.

Note :- Use Initialize-IntersightIppoolReservationReference to create the object of complex type IppoolReservationReference

```yaml
Type: Model.IppoolReservationReference
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

### -Vrf
A reference to a vrfVrf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.VrfVrfRelationship
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
PS C:\> Initialize-IntersightIppoolIpLease
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightIppoolIpV4Config](./Initialize-IntersightIppoolIpV4Config.md)

[Initialize-IntersightIppoolIpV6Config](./Initialize-IntersightIppoolIpV6Config.md)

[Initialize-IntersightIppoolReservationReference](./Initialize-IntersightIppoolReservationReference.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
