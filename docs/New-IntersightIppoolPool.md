---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightIppoolPool

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightIppoolPool [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssignmentOrder< IppoolPool.AssignmentOrderEnum>][-Description< string>][-EnableBlockLevelSubnetConfig< bool>][-IpV4Blocks< System.Collections.Generic.List`1[IppoolIpV4Block]>][-IpV4Config< IppoolIpV4Config>][-IpV6Blocks< System.Collections.Generic.List`1[IppoolIpV6Block]>][-IpV6Config< IppoolIpV6Config>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Reservations< System.Collections.Generic.List`1[IppoolReservationRelationship]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;IppoolPool&apos; resource.

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

### -AssignmentOrder
Assignment order decides the order in which the next identifier is allocated.\n* `sequential` - Identifiers are assigned in a sequential order.\n* `default` - Assignment order is decided by the system.

```yaml
Type: IppoolPool.AssignmentOrderEnum
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

### -EnableBlockLevelSubnetConfig
Enables subnet configuration at the block level.

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

### -IpV4Blocks


Note :- Use Initialize-IntersightIppoolIpV4Block to create the object of complex type IppoolIpV4Block

```yaml
Type: System.Collections.Generic.List`1[IppoolIpV4Block]
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
Type: IppoolIpV4Config
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpV6Blocks


Note :- Use Initialize-IntersightIppoolIpV6Block to create the object of complex type IppoolIpV6Block

```yaml
Type: System.Collections.Generic.List`1[IppoolIpV6Block]
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
Type: IppoolIpV6Config
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

### -Reservations
An array of relationships to ippoolReservation resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[IppoolReservationRelationship]
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
PS C:\> New-IntersightIppoolPool
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightIppoolPool](./Get-IntersightIppoolPool.md)

[Initialize-IntersightIppoolIpV4Block](./Initialize-IntersightIppoolIpV4Block.md)

[Initialize-IntersightIppoolIpV4Config](./Initialize-IntersightIppoolIpV4Config.md)

[Initialize-IntersightIppoolIpV6Block](./Initialize-IntersightIppoolIpV6Block.md)

[Initialize-IntersightIppoolIpV6Config](./Initialize-IntersightIppoolIpV6Config.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Remove-IntersightIppoolPool](./Remove-IntersightIppoolPool.md)

[Set-IntersightIppoolPool](./Set-IntersightIppoolPool.md)
