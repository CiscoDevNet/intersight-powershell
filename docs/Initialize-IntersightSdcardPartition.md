---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightSdcardPartition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightSdcardPartition [-AdditionalProperties< Dictionary<string,object>>][-ClassId< SdcardPartition.ClassIdEnum>][-ObjectType< SdcardPartition.ObjectTypeEnum>][-Type< SdcardPartition.TypeEnum>][-VirtualDrives< List<Model.SdcardVirtualDrive>>]

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
Type: SdcardPartition.ClassIdEnum
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
Type: SdcardPartition.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Type
This specifies the type of the partition. Allowed values are OS, Utility.\n* `OS` - This partition contains virtual drives where user can install operating system.\n* `Utility` - This partition contains virtual drives for utilities such as SCU, HUU, Drivers and Diagnostics.

```yaml
Type: SdcardPartition.TypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VirtualDrives


Note :- Use Initialize-IntersightSdcardVirtualDrive to create the object of complex type SdcardVirtualDrive

```yaml
Type: System.Collections.Generic.List`1[Model.SdcardVirtualDrive]
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
PS C:\> Initialize-IntersightSdcardPartition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightSdcardVirtualDrive](./Initialize-IntersightSdcardVirtualDrive.md)
