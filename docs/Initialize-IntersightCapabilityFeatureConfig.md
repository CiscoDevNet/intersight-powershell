---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCapabilityFeatureConfig

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCapabilityFeatureConfig [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< CapabilityFeatureConfig.ClassIdEnum>][-FeatureName< CapabilityFeatureConfig.FeatureNameEnum>][-MinFwVersion< string>][-ObjectType< CapabilityFeatureConfig.ObjectTypeEnum>][-SupportedFwVersions< System.Collections.Generic.List`1[string]>][-SupportedInAdapters< System.Collections.Generic.List`1[string]>][-SupportedInGenerations< System.Collections.Generic.List`1[CapabilityFeatureConfig.SupportedInGenerationsEnum]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: CapabilityFeatureConfig.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FeatureName
Name of the feature that identifies the specific adapter configuration.\n* `RoCEv2` - Capability indicator of the RDMA over Converged Ethernet (RoCE) feature version 2.\n* `RoCEv1` - Capability indicator of the RDMA over Converged Ethernet (RoCE) feature version 1.\n* `VMQ` - Capability indicator of the Virtual Machine Queue (VMQ) feature.\n* `VMMQ` - Capability indicator of the Virtual Machine Multi-Queue (VMMQ) feature.\n* `VMQInterrupts` - Capability indicator of the Virtual Machine Queue (VMQ) Interrupts feature.\n* `NVGRE` - Capability indicator of the Network Virtualization using Generic Routing Encapsulation (NVGRE) feature.\n* `ARFS` - Capability indicator of the Accelerated Receive Flow Steering (ARFS) feature.\n* `VXLAN` - Capability indicator of the Virtual Extensible LAN (VXLAN) feature.

```yaml
Type: CapabilityFeatureConfig.FeatureNameEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MinFwVersion
Firmware version from which support for this feature is available.

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
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: CapabilityFeatureConfig.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportedFwVersions


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportedInAdapters


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportedInGenerations


```yaml
Type: System.Collections.Generic.List`1[CapabilityFeatureConfig.SupportedInGenerationsEnum]
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
PS C:\> Initialize-IntersightCapabilityFeatureConfig
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
