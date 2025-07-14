---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVnicIscsiBootPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVnicIscsiBootPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AutoTargetvendorName< string>][-Chap< Model.VnicIscsiAuthProfile>][-ClassId< VnicIscsiBootPolicy.ClassIdEnum>][-Description< string>][-InitiatorIpPool< Model.IppoolPoolRelationship>][-InitiatorIpSource< VnicIscsiBootPolicy.InitiatorIpSourceEnum>][-InitiatorStaticIpV4Address< string>][-InitiatorStaticIpV4Config< Model.IppoolIpV4Config>][-InitiatorStaticIpV6Address< string>][-InitiatorStaticIpV6Config< Model.IppoolIpV6Config>][-IscsiAdapterPolicy< Model.VnicIscsiAdapterPolicyRelationship>][-IscsiIpType< VnicIscsiBootPolicy.IscsiIpTypeEnum>][-Moid< string>][-MutualChap< Model.VnicIscsiAuthProfile>][-Name< string>][-ObjectType< VnicIscsiBootPolicy.ObjectTypeEnum>][-Organization< Model.OrganizationOrganizationRelationship>][-PrimaryTargetPolicy< Model.VnicIscsiStaticTargetPolicyRelationship>][-SecondaryTargetPolicy< Model.VnicIscsiStaticTargetPolicyRelationship>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-TargetSourceType< VnicIscsiBootPolicy.TargetSourceTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AutoTargetvendorName
Auto target interface that is represented via the Initiator name or the DHCP vendor ID. The vendor ID can be up to 64 characters.

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

### -Chap
CHAP authentication parameters for iSCSI Target.

Note :- Use Initialize-IntersightVnicIscsiAuthProfile to create the object of complex type VnicIscsiAuthProfile

```yaml
Type: Model.VnicIscsiAuthProfile
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
Type: VnicIscsiBootPolicy.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the policy.

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

### -InitiatorIpPool
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

### -InitiatorIpSource
Source Type of Initiator IP Address - Auto/Static/Pool.\n* `DHCP` - The IP address is assigned using DHCP, if available.\n* `Static` - Static IPv4 address is assigned to the iSCSI boot interface based on the information entered in this area.\n* `Pool` - An IPv4 address is assigned to the iSCSI boot interface from the management IP address pool.

```yaml
Type: VnicIscsiBootPolicy.InitiatorIpSourceEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InitiatorStaticIpV4Address
Static IPv4 address provided for iSCSI Initiator.

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

### -InitiatorStaticIpV4Config
IPV4 configurations such as Netmask, Gateway and DNS for iSCSI Initiator.

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

### -InitiatorStaticIpV6Address
Static IPv6 address provided for iSCSI Initiator.

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

### -InitiatorStaticIpV6Config
IPv6 configurations such as Prefix, Gateway and DNS for iSCSI Initiator.

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

### -IscsiAdapterPolicy
A reference to a vnicIscsiAdapterPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.VnicIscsiAdapterPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IscsiIpType
Type of the IP address requested for iSCSI vNIC - IPv4/IPv6.\n* `IPv4` - IP V4 address type requested.\n* `IPv6` - IP V6 address type requested.

```yaml
Type: VnicIscsiBootPolicy.IscsiIpTypeEnum
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

### -MutualChap
Mutual CHAP authentication parameters for iSCSI Initiator. Two-way CHAP mechanism.

Note :- Use Initialize-IntersightVnicIscsiAuthProfile to create the object of complex type VnicIscsiAuthProfile

```yaml
Type: Model.VnicIscsiAuthProfile
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Name of the concrete policy.

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
Type: VnicIscsiBootPolicy.ObjectTypeEnum
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
Type: Model.OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PrimaryTargetPolicy
A reference to a vnicIscsiStaticTargetPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.VnicIscsiStaticTargetPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SecondaryTargetPolicy
A reference to a vnicIscsiStaticTargetPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.VnicIscsiStaticTargetPolicyRelationship
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

### -TargetSourceType
Source Type of Targets - Auto/Static.\n* `Static` - Type indicates that static target interface is assigned to iSCSI boot.\n* `Auto` - Type indicates that the system selects the target interface automatically during iSCSI boot.

```yaml
Type: VnicIscsiBootPolicy.TargetSourceTypeEnum
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
PS C:\> Initialize-IntersightVnicIscsiBootPolicy
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

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightVnicIscsiAuthProfile](./Initialize-IntersightVnicIscsiAuthProfile.md)
