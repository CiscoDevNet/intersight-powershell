---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightSnmpPolicy

## SYNOPSIS
Remove the SnmpPolicy

## SYNTAX

```
Remove-IntersightSnmpPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;SnmpPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightSnmpPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified SnmpPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightSnmpPolicy -Name "MoName"|  Remove-IntersightSnmpPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of SnmpPolicy.

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

[New-IntersightSnmpPolicy](./New-IntersightSnmpPolicy.md)

[Get-IntersightSnmpPolicy](./Get-IntersightSnmpPolicy.md)

[Set-IntersightSnmpPolicy](./Set-IntersightSnmpPolicy.md)

