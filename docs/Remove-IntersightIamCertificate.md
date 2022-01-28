---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightIamCertificate

## SYNOPSIS
Remove the IamCertificate

## SYNTAX

```
Remove-IntersightIamCertificate -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;IamCertificate&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightIamCertificate -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified IamCertificate 

### Example 2
```powershell
PS C:\>Get-IntersightIamCertificate -Name "MoName"|  Remove-IntersightIamCertificate
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of IamCertificate.

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

[Set-IntersightIamCertificate](./Set-IntersightIamCertificate.md)

[Get-IntersightIamCertificate](./Get-IntersightIamCertificate.md)

[New-IntersightIamCertificate](./New-IntersightIamCertificate.md)

