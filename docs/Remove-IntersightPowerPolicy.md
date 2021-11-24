---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightPowerPolicy

## SYNOPSIS
Remove the PowerPolicy

## SYNTAX

```
Remove-IntersightPowerPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;PowerPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightPowerPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified PowerPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightPowerPolicy -Name "MoName"|  Remove-IntersightPowerPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of PowerPolicy.

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

[Get-IntersightPowerPolicy](./Get-IntersightPowerPolicy.md)

[New-IntersightPowerPolicy](./New-IntersightPowerPolicy.md)

[Set-IntersightPowerPolicy](./Set-IntersightPowerPolicy.md)

