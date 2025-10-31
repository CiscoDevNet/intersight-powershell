---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightIppoolPool

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightIppoolPool [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssignmentOrder< IppoolPool.AssignmentOrderEnum>][-ClassId< IppoolPool.ClassIdEnum>][-Description< string>][-EnableBlockLevelSubnetConfig< bool>][-IpV4Blocks< System.Collections.Generic.List`1[Model.IppoolIpV4Block]>][-IpV4Config< Model.IppoolIpV4Config>][-IpV6Blocks< System.Collections.Generic.List`1[Model.IppoolIpV6Block]>][-IpV6Config< Model.IppoolIpV6Config>][-Moid< string>][-Name< string>][-ObjectType< IppoolPool.ObjectTypeEnum>][-Organization< Model.OrganizationOrganizationRelationship>][-Reservations< System.Collections.Generic.List`1[Model.IppoolReservationRelationship]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AssignmentOrder
Property is deprecated. Sequential is the only assignment order supported.\n* `sequential` - Identifiers are assigned in a sequential order.\n* `default` - Assignment order is decided by the system.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: IppoolPool.ClassIdEnum
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
Type: System.Collections.Generic.List`1[Model.IppoolIpV4Block]
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

### -IpV6Blocks


Note :- Use Initialize-IntersightIppoolIpV6Block to create the object of complex type IppoolIpV6Block

```yaml
Type: System.Collections.Generic.List`1[Model.IppoolIpV6Block]
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
Type: IppoolPool.ObjectTypeEnum
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

### -Reservations
An array of relationships to ippoolReservation resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[Model.IppoolReservationRelationship]
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
PS C:\> Initialize-IntersightIppoolPool
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightIppoolIpV4Block](./Initialize-IntersightIppoolIpV4Block.md)

[Initialize-IntersightIppoolIpV4Config](./Initialize-IntersightIppoolIpV4Config.md)

[Initialize-IntersightIppoolIpV6Block](./Initialize-IntersightIppoolIpV6Block.md)

[Initialize-IntersightIppoolIpV6Config](./Initialize-IntersightIppoolIpV6Config.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
