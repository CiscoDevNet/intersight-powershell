---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightCommHttpProxyPolicy

## SYNOPSIS
Remove the CommHttpProxyPolicy

## SYNTAX

```
Remove-IntersightCommHttpProxyPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;CommHttpProxyPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightCommHttpProxyPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified CommHttpProxyPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightCommHttpProxyPolicy -Name "MoName"|  Remove-IntersightCommHttpProxyPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of CommHttpProxyPolicy.

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

[New-IntersightCommHttpProxyPolicy](./New-IntersightCommHttpProxyPolicy.md)

[Get-IntersightCommHttpProxyPolicy](./Get-IntersightCommHttpProxyPolicy.md)

[Set-IntersightCommHttpProxyPolicy](./Set-IntersightCommHttpProxyPolicy.md)

