---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightStorageNetAppEthernetPortLag

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightStorageNetAppEthernetPortLag [-ActivePorts< System.Collections.Generic.List`1[Model.StorageNetAppPort]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< StorageNetAppEthernetPortLag.ClassIdEnum>][-DistributionPolicy< StorageNetAppEthernetPortLag.DistributionPolicyEnum>][-MemberPorts< System.Collections.Generic.List`1[Model.StorageNetAppPort]>][-Mode< StorageNetAppEthernetPortLag.ModeEnum>][-ObjectType< StorageNetAppEthernetPortLag.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -ActivePorts


Note :- Use Initialize-IntersightStorageNetAppPort to create the object of complex type StorageNetAppPort

```yaml
Type: System.Collections.Generic.List`1[Model.StorageNetAppPort]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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
Type: StorageNetAppEthernetPortLag.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DistributionPolicy
Policy for mapping flows to ports for outbound packets through a LAG (ifgrp).\n* `none` - Default unknown distribution policy type.\n* `port` - Network traffic is distributed based on the transport layer (TCP/UDP) ports.\n* `ip` - Network traffic is distributed based on IP addresses.\n* `mac` - Network traffic is distributed based on MAC addresses.\n* `sequential` - Network traffic is distributed in round-robin fashion from the list of configured, available ports.

```yaml
Type: StorageNetAppEthernetPortLag.DistributionPolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MemberPorts


Note :- Use Initialize-IntersightStorageNetAppPort to create the object of complex type StorageNetAppPort

```yaml
Type: System.Collections.Generic.List`1[Model.StorageNetAppPort]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Mode
Determines how the ports interact with the switch.\n* `none` - Default unknown lag mode type.\n* `multimode_lacp` - Bundle multiple member ports of the interface group using Link Aggregation Control Protocol.\n* `multimode` - Bundle multiple member ports of the interface group to act as a single trunked port.\n* `singlemode` - Provide port redundancy using member ports of the interface group for failover.

```yaml
Type: StorageNetAppEthernetPortLag.ModeEnum
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
Type: StorageNetAppEthernetPortLag.ObjectTypeEnum
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
PS C:\> Initialize-IntersightStorageNetAppEthernetPortLag
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightStorageNetAppPort](./Initialize-IntersightStorageNetAppPort.md)
