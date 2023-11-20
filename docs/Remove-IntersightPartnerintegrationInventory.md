---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightPartnerintegrationInventory

## SYNOPSIS
Remove the PartnerintegrationInventory

## SYNTAX

```
Remove-IntersightPartnerintegrationInventory -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;PartnerintegrationInventory&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightPartnerintegrationInventory -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified PartnerintegrationInventory 

### Example 2
```powershell
PS C:\>Get-IntersightPartnerintegrationInventory -Name "MoName"|  Remove-IntersightPartnerintegrationInventory
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of PartnerintegrationInventory.

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

[Get-IntersightPartnerintegrationInventory](./Get-IntersightPartnerintegrationInventory.md)

[New-IntersightPartnerintegrationInventory](./New-IntersightPartnerintegrationInventory.md)

[Set-IntersightPartnerintegrationInventory](./Set-IntersightPartnerintegrationInventory.md)

