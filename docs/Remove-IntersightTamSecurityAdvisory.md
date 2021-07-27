---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightTamSecurityAdvisory

## SYNOPSIS
Remove the TamSecurityAdvisory

## SYNTAX

```
Remove-IntersightTamSecurityAdvisory -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;TamSecurityAdvisory&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightTamSecurityAdvisory -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified TamSecurityAdvisory 

### Example 2
```powershell
PS C:\>Get-IntersightTamSecurityAdvisory -Name "MoName"|  Remove-IntersightTamSecurityAdvisory
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of TamSecurityAdvisory.

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

[Set-IntersightTamSecurityAdvisory](./Set-IntersightTamSecurityAdvisory.md)

[Get-IntersightTamSecurityAdvisory](./Get-IntersightTamSecurityAdvisory.md)

[New-IntersightTamSecurityAdvisory](./New-IntersightTamSecurityAdvisory.md)

