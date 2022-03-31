---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightSoftwareUcsdDistributable

## SYNOPSIS
Remove the SoftwareUcsdDistributable

## SYNTAX

```
Remove-IntersightSoftwareUcsdDistributable -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;SoftwareUcsdDistributable&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightSoftwareUcsdDistributable -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified SoftwareUcsdDistributable 

### Example 2
```powershell
PS C:\>Get-IntersightSoftwareUcsdDistributable -Name "MoName"|  Remove-IntersightSoftwareUcsdDistributable
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of SoftwareUcsdDistributable.

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

[Get-IntersightSoftwareUcsdDistributable](./Get-IntersightSoftwareUcsdDistributable.md)

[New-IntersightSoftwareUcsdDistributable](./New-IntersightSoftwareUcsdDistributable.md)

[Set-IntersightSoftwareUcsdDistributable](./Set-IntersightSoftwareUcsdDistributable.md)

