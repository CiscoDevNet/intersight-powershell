---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightSoftwareHclMeta

## SYNOPSIS
Remove the SoftwareHclMeta

## SYNTAX

```
Remove-IntersightSoftwareHclMeta -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;SoftwareHclMeta&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightSoftwareHclMeta -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified SoftwareHclMeta 

### Example 2
```powershell
PS C:\>Get-IntersightSoftwareHclMeta -Name "MoName"|  Remove-IntersightSoftwareHclMeta
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of SoftwareHclMeta.

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

[Set-IntersightSoftwareHclMeta](./Set-IntersightSoftwareHclMeta.md)

[Get-IntersightSoftwareHclMeta](./Get-IntersightSoftwareHclMeta.md)

[New-IntersightSoftwareHclMeta](./New-IntersightSoftwareHclMeta.md)

