---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVirtualizationEsxiVmConfiguration

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVirtualizationEsxiVmConfiguration [-AdditionalProperties< Dictionary<string,object>>][-Annotation< string>][-ClassId< VirtualizationEsxiVmConfiguration.ClassIdEnum>][-Compute< Model.VirtualizationEsxiVmComputeConfiguration>][-Customspec< Model.VirtualizationBaseCustomSpec>][-Datacenter< string>][-Folder< string>][-Image< string>][-Network< Model.VirtualizationEsxiVmNetworkConfiguration>][-ObjectType< VirtualizationEsxiVmConfiguration.ObjectTypeEnum>][-Storage< Model.VirtualizationEsxiVmStorageConfiguration>][-Template< string>]

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

### -Annotation
Specify annotation (optional) for the virtual machine.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: VirtualizationEsxiVmConfiguration.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Compute
ESXi virtual machine compute specification.

Note :- Use Initialize-IntersightVirtualizationEsxiVmComputeConfiguration to create the object of complex type VirtualizationEsxiVmComputeConfiguration

```yaml
Type: Model.VirtualizationEsxiVmComputeConfiguration
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Customspec
ESXi virtual machine custom specification.

Note :- Use Initialize-IntersightVirtualizationBaseCustomSpec to create the object of complex type VirtualizationBaseCustomSpec

```yaml
Type: Model.VirtualizationBaseCustomSpec
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Datacenter
Datacenter where virtual machine is deployed.

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

### -Folder
Folder where virtual machine is deployed.

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

### -Image
Image path of OVA (The image can be from any location).

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

### -Network
ESXi virtual machine network specification.

Note :- Use Initialize-IntersightVirtualizationEsxiVmNetworkConfiguration to create the object of complex type VirtualizationEsxiVmNetworkConfiguration

```yaml
Type: Model.VirtualizationEsxiVmNetworkConfiguration
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
Type: VirtualizationEsxiVmConfiguration.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Storage
ESXi virtual machine storage specification.

Note :- Use Initialize-IntersightVirtualizationEsxiVmStorageConfiguration to create the object of complex type VirtualizationEsxiVmStorageConfiguration

```yaml
Type: Model.VirtualizationEsxiVmStorageConfiguration
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Template
Template to be used for clone.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightVirtualizationEsxiVmConfiguration
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightVirtualizationEsxiVmComputeConfiguration](./Initialize-IntersightVirtualizationEsxiVmComputeConfiguration.md)

[Initialize-IntersightVirtualizationBaseCustomSpec](./Initialize-IntersightVirtualizationBaseCustomSpec.md)

[Initialize-IntersightVirtualizationEsxiVmNetworkConfiguration](./Initialize-IntersightVirtualizationEsxiVmNetworkConfiguration.md)

[Initialize-IntersightVirtualizationEsxiVmStorageConfiguration](./Initialize-IntersightVirtualizationEsxiVmStorageConfiguration.md)
