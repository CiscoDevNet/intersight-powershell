---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightHyperflexServerFirmwareVersion

## SYNOPSIS
Remove the HyperflexServerFirmwareVersion

## SYNTAX

```
Remove-IntersightHyperflexServerFirmwareVersion -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;HyperflexServerFirmwareVersion&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightHyperflexServerFirmwareVersion -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified HyperflexServerFirmwareVersion 

### Example 2
```powershell
PS C:\>Get-IntersightHyperflexServerFirmwareVersion -Name "MoName"|  Remove-IntersightHyperflexServerFirmwareVersion
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of HyperflexServerFirmwareVersion.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS

[Get-IntersightHyperflexServerFirmwareVersion](./Get-IntersightHyperflexServerFirmwareVersion.md)

[New-IntersightHyperflexServerFirmwareVersion](./New-IntersightHyperflexServerFirmwareVersion.md)

[Set-IntersightHyperflexServerFirmwareVersion](./Set-IntersightHyperflexServerFirmwareVersion.md)

