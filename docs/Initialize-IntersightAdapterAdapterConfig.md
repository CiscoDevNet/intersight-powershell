---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightAdapterAdapterConfig

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightAdapterAdapterConfig [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< AdapterAdapterConfig.ClassIdEnum>][-DceInterfaceSettings< System.Collections.Generic.List`1[Model.AdapterDceInterfaceSettings]>][-EthSettings< Model.AdapterEthSettings>][-FcSettings< Model.AdapterFcSettings>][-ObjectType< AdapterAdapterConfig.ObjectTypeEnum>][-PortChannelSettings< Model.AdapterPortChannelSettings>][-SlotId< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: AdapterAdapterConfig.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DceInterfaceSettings


Note :- Use Initialize-IntersightAdapterDceInterfaceSettings to create the object of complex type AdapterDceInterfaceSettings

```yaml
Type: System.Collections.Generic.List`1[Model.AdapterDceInterfaceSettings]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EthSettings
Global Ethernet settings for this adapter.

Note :- Use Initialize-IntersightAdapterEthSettings to create the object of complex type AdapterEthSettings

```yaml
Type: Model.AdapterEthSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcSettings
Global Fibre Channel settings for this adapter.

Note :- Use Initialize-IntersightAdapterFcSettings to create the object of complex type AdapterFcSettings

```yaml
Type: Model.AdapterFcSettings
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
Type: AdapterAdapterConfig.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortChannelSettings
Port Channel settings for this adapter.

Note :- Use Initialize-IntersightAdapterPortChannelSettings to create the object of complex type AdapterPortChannelSettings

```yaml
Type: Model.AdapterPortChannelSettings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SlotId
PCIe slot where the VIC adapter is installed. Supported values are (1-15) and MLOM.

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
PS C:\> Initialize-IntersightAdapterAdapterConfig
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightAdapterDceInterfaceSettings](./Initialize-IntersightAdapterDceInterfaceSettings.md)

[Initialize-IntersightAdapterEthSettings](./Initialize-IntersightAdapterEthSettings.md)

[Initialize-IntersightAdapterFcSettings](./Initialize-IntersightAdapterFcSettings.md)

[Initialize-IntersightAdapterPortChannelSettings](./Initialize-IntersightAdapterPortChannelSettings.md)
