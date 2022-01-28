---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightCapabilityAdapterUnitDescriptor

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightCapabilityAdapterUnitDescriptor [-AdapterGeneration< CapabilityAdapterUnitDescriptor.AdapterGenerationEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Capabilities< System.Collections.Generic.List`1[CapabilityCapabilityRelationship]>][-ConnectivityOrder< string>][-Description< string>][-EthernetPortSpeed< long>][-Features< System.Collections.Generic.List`1[CapabilityFeatureConfig]>][-FibreChannelPortSpeed< long>][-FibreChannelScsiIoqLimit< long>][-IsAzureQosSupported< bool>][-IsGeneveSupported< bool>][-MaxRocev2Interfaces< long>][-Model< string>][-Moid< string>][-NumDcePorts< long>][-PciLink< long>][-PromCardType< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Vendor< string>][-Version< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;CapabilityAdapterUnitDescriptor&apos; resource.

## PARAMETERS

### -AdapterGeneration
Generation of the adapter.\n* `4` - Fourth generation adapters (14xx). The PIDs of these adapters end with the string 04.\n* `2` - Second generation VIC adapters (12xx). The PIDs of these adapters end with the string 02.\n* `3` - Third generation adapters (13xx). The PIDs of these adapters end with the string 03.\n* `5` - Fifth generation adapters (15xx). The PIDs of these adapters contain the V5 string.

```yaml
Type: CapabilityAdapterUnitDescriptor.AdapterGenerationEnum
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

### -Capabilities
An array of relationships to capabilityCapability resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[CapabilityCapabilityRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConnectivityOrder
Order in which the ports are connected; sequential or cyclic.

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

### -Description
Detailed information about the endpoint.

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

### -EthernetPortSpeed
The port speed for ethernet ports in Mbps.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Features


Note :- Use Initialize-IntersightCapabilityFeatureConfig to create the object of complex type CapabilityFeatureConfig

```yaml
Type: System.Collections.Generic.List`1[CapabilityFeatureConfig]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FibreChannelPortSpeed
The port speed for fibre channel ports in Mbps.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FibreChannelScsiIoqLimit
The number of SCSI I/O Queue resources to allocate.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsAzureQosSupported
Indicates that the Azure Stack Host QoS feature is supported by this adapter.

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

### -IsGeneveSupported
Indicates that the GENEVE offload feature is supported by this adapter.

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

### -MaxRocev2Interfaces
Maximum number of vNIC interfaces that can be RoCEv2 enabled.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Model
The model of the endpoint, for which this capability information is applicable.

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

### -NumDcePorts
Number of Dce Ports for the adapter.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PciLink
Indicates PCI Link status of adapter.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PromCardType
Prom card type for the adapter.

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

### -Vendor
The vendor of the endpoint, for which this capability information is applicable.

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

### -Version
The firmware or software version of the endpoint, for which this capability information is applicable.

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
PS C:\> New-IntersightCapabilityAdapterUnitDescriptor
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightCapabilityAdapterUnitDescriptor](./Set-IntersightCapabilityAdapterUnitDescriptor.md)

[Remove-IntersightCapabilityAdapterUnitDescriptor](./Remove-IntersightCapabilityAdapterUnitDescriptor.md)

[Get-IntersightCapabilityAdapterUnitDescriptor](./Get-IntersightCapabilityAdapterUnitDescriptor.md)

[Initialize-IntersightCapabilityFeatureConfig](./Initialize-IntersightCapabilityFeatureConfig.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
