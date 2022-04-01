---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFirmwareComponentMeta

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFirmwareComponentMeta [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< FirmwareComponentMeta.ClassIdEnum>][-ComponentLabel< string>][-ComponentType< FirmwareComponentMeta.ComponentTypeEnum>][-Description< string>][-Disruption< FirmwareComponentMeta.DisruptionEnum>][-ImagePath< string>][-IsOobSupported< bool>][-Model< string>][-ObjectType< FirmwareComponentMeta.ObjectTypeEnum>][-OobManageability< System.Collections.Generic.List`1[FirmwareComponentMeta.OobManageabilityEnum]>][-PackedVersion< string>][-RedfishUrl< string>][-Vendor< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: FirmwareComponentMeta.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ComponentLabel
The name of the component in the compressed HSU bundle.

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

### -ComponentType
The type of component image within the distributable.\n* `ALL` - This represents all the components.\n* `ALL,HDD` - This represents all the components plus the HDDs.\n* `Drive-U.2` - This represents the U.2 drives that are SFF/LFF drives (mostly all the drives will fall under this category).\n* `Storage` - This represents the storage controller components.\n* `None` - This represents none of the components.\n* `NXOS` - This represents NXOS components.\n* `IOM` - This represents IOM components.\n* `PSU` - This represents PSU components.\n* `CIMC` - This represents CIMC components.\n* `BIOS` - This represents BIOS components.\n* `PCIE` - This represents PCIE components.\n* `Drive` - This represents Drive components.\n* `DIMM` - This represents DIMM components.\n* `BoardController` - This represents Board Controller components.\n* `StorageController` - This represents Storage Controller components.\n* `Storage-Sasexpander` - This represents Storage Sas-Expander components.\n* `Storage-U.2` - This represents U2 Storage Controller components.\n* `HBA` - This represents HBA components.\n* `GPU` - This represents GPU components.\n* `SasExpander` - This represents SasExpander components.\n* `MSwitch` - This represents mSwitch components.\n* `CMC` - This represents CMC components.

```yaml
Type: FirmwareComponentMeta.ComponentTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
This shows the description of component image within the distributable.

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

### -Disruption
The type of disruption on each component. For example, host reboot, automatic power cycle, and manual power cycle.\n* `None` - Indicates that the component did not receive a disruption request.\n* `HostReboot` - Indicates that the component received a host reboot request.\n* `EndpointReboot` - Indicates that the component received an end point reboot request.\n* `ManualPowerCycle` - Indicates that the component received a manual power cycle request.\n* `AutomaticPowerCycle` - Indicates that the component received an automatic power cycle request.

```yaml
Type: FirmwareComponentMeta.DisruptionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ImagePath
This shows the path of component image within the distributable.

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

### -IsOobSupported
If set, the component can be updated through out-of-band management, else, is updated through host service utility boot.

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

### -Model
The model of the component image in the distributable.

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
Type: FirmwareComponentMeta.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OobManageability


```yaml
Type: System.Collections.Generic.List`1[FirmwareComponentMeta.OobManageabilityEnum]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PackedVersion
The image version of components packaged in the distributable.

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

### -RedfishUrl
The redfish target for each component.

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

### -Vendor
The version of component image in the distributable.

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
PS C:\> Initialize-IntersightFirmwareComponentMeta
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
