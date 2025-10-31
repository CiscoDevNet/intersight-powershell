---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightCapabilityServerTopologyMap

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightCapabilityServerTopologyMap [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Handler< string>][-Moid< string>][[-Name]< string>][-PcieNodeDetail< CapabilityDeviceInventory>][-ServerDetail< CapabilityDeviceInventory>][-SupportedTopologyName< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-XfmDetail< CapabilityDeviceInventory>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;CapabilityServerTopologyMap&apos; resource.

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

### -Handler
Handler identifier for managing this topology configuration.

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
An unique identifer for a capability descriptor.

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

### -PcieNodeDetail
PCIe node model information for this topology configuration.

Note :- Use Initialize-IntersightCapabilityDeviceInventory to create the object of complex type CapabilityDeviceInventory

```yaml
Type: CapabilityDeviceInventory
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerDetail
Server model information for which this topology configuration is defined.

Note :- Use Initialize-IntersightCapabilityDeviceInventory to create the object of complex type CapabilityDeviceInventory

```yaml
Type: CapabilityDeviceInventory
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportedTopologyName
Server model information for which this topology configuration is defined.

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

### -XfmDetail
XFM (Switch Fabric Module) model information for this topology configuration.

Note :- Use Initialize-IntersightCapabilityDeviceInventory to create the object of complex type CapabilityDeviceInventory

```yaml
Type: CapabilityDeviceInventory
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
PS C:\> New-IntersightCapabilityServerTopologyMap
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightCapabilityServerTopologyMap](./Get-IntersightCapabilityServerTopologyMap.md)

[Initialize-IntersightCapabilityDeviceInventory](./Initialize-IntersightCapabilityDeviceInventory.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Remove-IntersightCapabilityServerTopologyMap](./Remove-IntersightCapabilityServerTopologyMap.md)

[Set-IntersightCapabilityServerTopologyMap](./Set-IntersightCapabilityServerTopologyMap.md)
