---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFabricSwitchControlPolicy

## SYNOPSIS
Remove the FabricSwitchControlPolicy

## SYNTAX

```
Remove-IntersightFabricSwitchControlPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;FabricSwitchControlPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFabricSwitchControlPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FabricSwitchControlPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightFabricSwitchControlPolicy -Name "MoName"|  Remove-IntersightFabricSwitchControlPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FabricSwitchControlPolicy.

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

[Set-IntersightFabricSwitchControlPolicy](./Set-IntersightFabricSwitchControlPolicy.md)

[Get-IntersightFabricSwitchControlPolicy](./Get-IntersightFabricSwitchControlPolicy.md)

[New-IntersightFabricSwitchControlPolicy](./New-IntersightFabricSwitchControlPolicy.md)

