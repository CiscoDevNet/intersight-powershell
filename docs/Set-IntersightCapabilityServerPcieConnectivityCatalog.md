---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightCapabilityServerPcieConnectivityCatalog

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightCapabilityServerPcieConnectivityCatalog [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][[-Moid]< string>][-Name< string>][-SupportedLayouts< System.Collections.Generic.List`1[CapabilityServerPcieConnectivityLayout]>][-SupportedNumberOfGpus< System.Collections.Generic.List`1[long]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;CapabilityServerPcieConnectivityCatalog&apos; resource.

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

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportedLayouts


Note :- Use Initialize-IntersightCapabilityServerPcieConnectivityLayout to create the object of complex type CapabilityServerPcieConnectivityLayout

```yaml
Type: System.Collections.Generic.List`1[CapabilityServerPcieConnectivityLayout]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportedNumberOfGpus


```yaml
Type: System.Collections.Generic.List`1[long]
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
PS C:\> Set-IntersightCapabilityServerPcieConnectivityCatalog
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightCapabilityServerPcieConnectivityCatalog](./Get-IntersightCapabilityServerPcieConnectivityCatalog.md)

[Initialize-IntersightCapabilityServerPcieConnectivityLayout](./Initialize-IntersightCapabilityServerPcieConnectivityLayout.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightCapabilityServerPcieConnectivityCatalog](./New-IntersightCapabilityServerPcieConnectivityCatalog.md)

[Remove-IntersightCapabilityServerPcieConnectivityCatalog](./Remove-IntersightCapabilityServerPcieConnectivityCatalog.md)
