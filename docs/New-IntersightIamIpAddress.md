---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightIamIpAddress

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightIamIpAddress [-AdditionalProperties< Dictionary<string,object>>][-Address< string>][-Description< string>][-Moid< string>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Create a &apos;IamIpAddress&apos; resource.

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

### -Address
The Trusted IP range&apos;s address. IP address, CIDR range, and IP address range formats are supported. For example &apos;12.13.14.15&apos;, &apos;12.13.14.0/24&apos;, and &apos;12.13.14.15-12.13.14.200&apos;. Reserved IP ranges &apos;127.0.0.1&apos;, &apos;10.0.0.0/8&apos;, &apos;172.16.0.0/12&apos;, and &apos;192.168.0.0/16&apos; are not allowed.

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
Description of Trusted IP address range.

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
PS C:\> New-IntersightIamIpAddress
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightIamIpAddress](./Get-IntersightIamIpAddress.md)

[Set-IntersightIamIpAddress](./Set-IntersightIamIpAddress.md)

[Remove-IntersightIamIpAddress](./Remove-IntersightIamIpAddress.md)
