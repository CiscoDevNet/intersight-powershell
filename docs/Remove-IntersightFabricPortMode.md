---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFabricPortMode

## SYNOPSIS
Remove the FabricPortMode

## SYNTAX

```
Remove-IntersightFabricPortMode -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;FabricPortMode&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFabricPortMode -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FabricPortMode 

### Example 2
```powershell
PS C:\>Get-IntersightFabricPortMode -Name "MoName"|  Remove-IntersightFabricPortMode
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FabricPortMode.

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

[Get-IntersightFabricPortMode](./Get-IntersightFabricPortMode.md)

[New-IntersightFabricPortMode](./New-IntersightFabricPortMode.md)

[Set-IntersightFabricPortMode](./Set-IntersightFabricPortMode.md)

