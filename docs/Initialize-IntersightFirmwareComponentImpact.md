---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFirmwareComponentImpact

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFirmwareComponentImpact [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< FirmwareComponentImpact.ClassIdEnum>][-Component< FirmwareComponentImpact.ComponentEnum>][-ComputationError< string>][-ComputationStatusDetail< FirmwareComponentImpact.ComputationStatusDetailEnum>][-DomainName< string>][-EndPoint< string>][-FirmwareVersion< string>][-ImpactType< FirmwareComponentImpact.ImpactTypeEnum>][-Model< string>][-ObjectType< FirmwareComponentImpact.ObjectTypeEnum>][-TargetFirmwareVersion< string>][-VersionImpact< FirmwareComponentImpact.VersionImpactEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: FirmwareComponentImpact.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Component
Impact on the component after the upgrade.\n* `ALL` - This represents all the components.\n* `ALL,HDD` - This represents all the components plus the HDDs.\n* `Drive-U.2` - This represents the U.2 drives that are SFF/LFF drives (mostly all the drives will fall under this category).\n* `Storage` - This represents the storage controller components.\n* `None` - This represents none of the components.\n* `NXOS` - This represents NXOS components.\n* `ESU` - This represents ESU components.\n* `IOM` - This represents IOM components.\n* `PSU` - This represents PSU components.\n* `CIMC` - This represents CIMC components.\n* `BIOS` - This represents BIOS components.\n* `PCIE` - This represents PCIE components.\n* `Drive` - This represents Drive components.\n* `DIMM` - This represents DIMM components.\n* `BoardController` - This represents Board Controller components.\n* `StorageController` - This represents Storage Controller components.\n* `Storage-Sasexpander` - This represents Storage Sas-Expander components.\n* `Storage-U.2` - This represents U2 Storage Controller components.\n* `HBA` - This represents HBA components.\n* `GPU` - This represents GPU components.\n* `SasExpander` - This represents SasExpander components.\n* `MSwitch` - This represents mSwitch components.\n* `CMC` - This represents CMC components.\n* `PSX` - This represents PSX components.

```yaml
Type: FirmwareComponentImpact.ComponentEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ComputationError
Details for the error that occurred during the reboot validation analysis.

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

### -ComputationStatusDetail
The computation status of the estimate operation for a component.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect.\n* `Failed` - Upgrade impact is not available due to an unknown error.

```yaml
Type: FirmwareComponentImpact.ComputationStatusDetailEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DomainName
The endpoint type or name.

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

### -EndPoint
A reference to a REST resource, uniquely identified by object type and MOID.

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

### -FirmwareVersion
The current firmware version of the component.

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

### -ImpactType
The impact type of the endpoint, whether a reboot is required or not.\n* `NoReboot` - A reboot is not required for the endpoint after upgrade.\n* `Reboot` - A reboot is required to the endpoint after upgrade.

```yaml
Type: FirmwareComponentImpact.ImpactTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Model
The model details of the component.

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
Type: FirmwareComponentImpact.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TargetFirmwareVersion
The target firmware version of the component.

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

### -VersionImpact
The change of version impact for the endpoint.\n* `None` - No change in version for the component.\n* `Upgrade` - The component will be upgraded.\n* `Downgrade` - The component will be downgraded.

```yaml
Type: FirmwareComponentImpact.VersionImpactEnum
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
PS C:\> Initialize-IntersightFirmwareComponentImpact
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
