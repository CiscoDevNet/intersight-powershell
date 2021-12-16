---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFabricServerRole

## SYNOPSIS
Remove the FabricServerRole

## SYNTAX

```
Remove-IntersightFabricServerRole -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;FabricServerRole&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFabricServerRole -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FabricServerRole 

### Example 2
```powershell
PS C:\>Get-IntersightFabricServerRole -Name "MoName"|  Remove-IntersightFabricServerRole
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FabricServerRole.

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

[New-IntersightFabricServerRole](./New-IntersightFabricServerRole.md)

[Get-IntersightFabricServerRole](./Get-IntersightFabricServerRole.md)

[Set-IntersightFabricServerRole](./Set-IntersightFabricServerRole.md)

