---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightComputeAdapterUnitPropFilter

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightComputeAdapterUnitPropFilter [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< ComputeAdapterUnitPropFilter.ClassIdEnum>][-Count< long>][-Model< ComputeAdapterUnitPropFilter.ModelEnum>][-ObjectType< ComputeAdapterUnitPropFilter.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: ComputeAdapterUnitPropFilter.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Count
Number of Adapters to be selected.

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
Specific Adapter model to select.\n* `Any` - To select any Adapter model available in XFM.\n* `UCSC-P-N7S400GF` - Cisco UCS X-Series Adapter with 400G capability and dual port configuration.\n* `UCSC-P-N7D200GF` - Cisco UCS X-Series Adapter with 200G capability and dual port configuration.\n* `UCSC-P-N3140H` - Cisco UCS X-Series Adapter with 200G capability and single port configuration.\n* `UCSC-P-N7S400GFO` - Cisco UCS X-Series SmartNIC with 400G QSFP112 PCIe Gen5 NIC.\n* `UCSC-P-N7D200GFO` - Cisco UCS X-Series SmartNIC with 200G QSFP112 PCIe Gen5 NIC.

```yaml
Type: ComputeAdapterUnitPropFilter.ModelEnum
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
Type: ComputeAdapterUnitPropFilter.ObjectTypeEnum
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
PS C:\> Initialize-IntersightComputeAdapterUnitPropFilter
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
