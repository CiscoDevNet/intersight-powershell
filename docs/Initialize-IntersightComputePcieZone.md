---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightComputePcieZone

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightComputePcieZone [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< ComputePcieZone.ClassIdEnum>][-ObjectType< ComputePcieZone.ObjectTypeEnum>][-PcieEndpoints< System.Collections.Generic.List`1[Model.ComputePcieEndpointConfig]>][-RootPcieEndpoint< Model.ComputeRootPcieEndpointConfig>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: ComputePcieZone.ClassIdEnum
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
Type: ComputePcieZone.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieEndpoints


Note :- Use Initialize-IntersightComputePcieEndpointConfig to create the object of complex type ComputePcieEndpointConfig

```yaml
Type: System.Collections.Generic.List`1[Model.ComputePcieEndpointConfig]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RootPcieEndpoint
Root PCIe endpoint device in a zone.

Note :- Use Initialize-IntersightComputeRootPcieEndpointConfig to create the object of complex type ComputeRootPcieEndpointConfig

```yaml
Type: Model.ComputeRootPcieEndpointConfig
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
PS C:\> Initialize-IntersightComputePcieZone
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightComputePcieEndpointConfig](./Initialize-IntersightComputePcieEndpointConfig.md)

[Initialize-IntersightComputeRootPcieEndpointConfig](./Initialize-IntersightComputeRootPcieEndpointConfig.md)
