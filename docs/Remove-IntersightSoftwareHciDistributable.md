---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightSoftwareHciDistributable

## SYNOPSIS
Remove the SoftwareHciDistributable

## SYNTAX

```
Remove-IntersightSoftwareHciDistributable -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;SoftwareHciDistributable&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightSoftwareHciDistributable -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified SoftwareHciDistributable 

### Example 2
```powershell
PS C:\>Get-IntersightSoftwareHciDistributable -Name "MoName"|  Remove-IntersightSoftwareHciDistributable
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of SoftwareHciDistributable.

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

[Get-IntersightSoftwareHciDistributable](./Get-IntersightSoftwareHciDistributable.md)

[New-IntersightSoftwareHciDistributable](./New-IntersightSoftwareHciDistributable.md)

[Set-IntersightSoftwareHciDistributable](./Set-IntersightSoftwareHciDistributable.md)

