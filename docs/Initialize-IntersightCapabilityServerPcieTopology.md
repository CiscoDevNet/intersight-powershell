---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCapabilityServerPcieTopology

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCapabilityServerPcieTopology [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< CapabilityServerPcieTopology.ClassIdEnum>][-ConnectedAdapter< System.Collections.Generic.List`1[Model.CapabilityAdapterConnectionPoint]>][-ConnectedGpu< System.Collections.Generic.List`1[Model.CapabilityGpuConnectionPoint]>][-ObjectType< CapabilityServerPcieTopology.ObjectTypeEnum>][-PcieSwitchId< long>][-XfmId< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: CapabilityServerPcieTopology.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConnectedAdapter


Note :- Use Initialize-IntersightCapabilityAdapterConnectionPoint to create the object of complex type CapabilityAdapterConnectionPoint

```yaml
Type: System.Collections.Generic.List`1[Model.CapabilityAdapterConnectionPoint]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConnectedGpu


Note :- Use Initialize-IntersightCapabilityGpuConnectionPoint to create the object of complex type CapabilityGpuConnectionPoint

```yaml
Type: System.Collections.Generic.List`1[Model.CapabilityGpuConnectionPoint]
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
Type: CapabilityServerPcieTopology.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PcieSwitchId
Unique identifier for the physical PCIe switch in the server topology.

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

### -XfmId
Unique identifier for the XFM (Switch Fabric Module) in the server topology.

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
PS C:\> Initialize-IntersightCapabilityServerPcieTopology
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightCapabilityAdapterConnectionPoint](./Initialize-IntersightCapabilityAdapterConnectionPoint.md)

[Initialize-IntersightCapabilityGpuConnectionPoint](./Initialize-IntersightCapabilityGpuConnectionPoint.md)
