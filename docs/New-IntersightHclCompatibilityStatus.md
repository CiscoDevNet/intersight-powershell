---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightHclCompatibilityStatus

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightHclCompatibilityStatus [-AdditionalProperties< Dictionary<string,object>>][-Moid< string>][-ProfileList< List<HclHardwareCompatibilityProfile>>][-RequestType< HclCompatibilityStatus.RequestTypeEnum>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Create a &apos;HclCompatibilityStatus&apos; resource.

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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProfileList


Note :- Use Initialize-IntersightHclHardwareCompatibilityProfile to create the object of complex type HclHardwareCompatibilityProfile

```yaml
Type: System.Collections.Generic.List`1[HclHardwareCompatibilityProfile]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RequestType
Type of the request to be served.\n* `FillSupportedVersions` - Responds with the supported firmware and driver versions. The API doesn&amp;apos;t expect firmware and driver versions to be passed in the request and ignores if passed.\n* `CheckCompatibility` - Checks the compatibility for the given firmware and driver versions. This request type expects the firmware and driver versions to filled and the service validates the values and responds back with the error codes.\n* `GetRecommendedDrivers` - Responds with the supported drivers. The API expects firmware version to be filled. The API populates driver ISO url for the given server model. Today the link is same for all servers managed by UCSM whereas it depends on the model for Standalone servers.

```yaml
Type: HclCompatibilityStatus.RequestTypeEnum
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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightHclCompatibilityStatus
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightHclHardwareCompatibilityProfile](./Initialize-IntersightHclHardwareCompatibilityProfile.md)
