---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightCertificatemanagementPolicy

## SYNOPSIS
Remove the CertificatemanagementPolicy

## SYNTAX

```
Remove-IntersightCertificatemanagementPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;CertificatemanagementPolicy&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightCertificatemanagementPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified CertificatemanagementPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightCertificatemanagementPolicy -Name "MoName"|  Remove-IntersightCertificatemanagementPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of CertificatemanagementPolicy.

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

[Get-IntersightCertificatemanagementPolicy](./Get-IntersightCertificatemanagementPolicy.md)

[New-IntersightCertificatemanagementPolicy](./New-IntersightCertificatemanagementPolicy.md)

[Set-IntersightCertificatemanagementPolicy](./Set-IntersightCertificatemanagementPolicy.md)

