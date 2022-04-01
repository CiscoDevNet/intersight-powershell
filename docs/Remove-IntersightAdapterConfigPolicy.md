---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightAdapterConfigPolicy

## SYNOPSIS
Remove the AdapterConfigPolicy

## SYNTAX

```
Remove-IntersightAdapterConfigPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;AdapterConfigPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightAdapterConfigPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified AdapterConfigPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightAdapterConfigPolicy -Name "MoName"|  Remove-IntersightAdapterConfigPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of AdapterConfigPolicy.

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

[Get-IntersightAdapterConfigPolicy](./Get-IntersightAdapterConfigPolicy.md)

[New-IntersightAdapterConfigPolicy](./New-IntersightAdapterConfigPolicy.md)

[Set-IntersightAdapterConfigPolicy](./Set-IntersightAdapterConfigPolicy.md)

