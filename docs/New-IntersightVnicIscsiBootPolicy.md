---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightVnicIscsiBootPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightVnicIscsiBootPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AutoTargetvendorName< string>][-Chap< VnicIscsiAuthProfile>][-Description< string>][-InitiatorIpPool< IppoolPoolRelationship>][-InitiatorIpSource< VnicIscsiBootPolicy.InitiatorIpSourceEnum>][-InitiatorStaticIpV4Address< string>][-InitiatorStaticIpV4Config< IppoolIpV4Config>][-IscsiAdapterPolicy< VnicIscsiAdapterPolicyRelationship>][-Moid< string>][-MutualChap< VnicIscsiAuthProfile>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-PrimaryTargetPolicy< VnicIscsiStaticTargetPolicyRelationship>][-SecondaryTargetPolicy< VnicIscsiStaticTargetPolicyRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TargetSourceType< VnicIscsiBootPolicy.TargetSourceTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;VnicIscsiBootPolicy&apos; resource.

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
Auto target interface that is represented via the Initiator name or the DHCP vendor ID. The vendor ID can be up to 32 alphanumeric characters.

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
Type: VnicIscsiAuthProfile
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
Type: IppoolPoolRelationship
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
Static IP address provided for iSCSI Initiator.

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
Type: IppoolIpV4Config
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
Type: VnicIscsiAdapterPolicyRelationship
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
Type: VnicIscsiAuthProfile
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

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
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

### -PrimaryTargetPolicy
A reference to a vnicIscsiStaticTargetPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VnicIscsiStaticTargetPolicyRelationship
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
Type: VnicIscsiStaticTargetPolicyRelationship
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
PS C:\> New-IntersightVnicIscsiBootPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVnicIscsiBootPolicy](./Get-IntersightVnicIscsiBootPolicy.md)

[Initialize-IntersightIppoolIpV4Config](./Initialize-IntersightIppoolIpV4Config.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightVnicIscsiAuthProfile](./Initialize-IntersightVnicIscsiAuthProfile.md)

[Remove-IntersightVnicIscsiBootPolicy](./Remove-IntersightVnicIscsiBootPolicy.md)

[Set-IntersightVnicIscsiBootPolicy](./Set-IntersightVnicIscsiBootPolicy.md)
