---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFabricFcZonePolicy

## SYNOPSIS
Remove the FabricFcZonePolicy

## SYNTAX

```
Remove-IntersightFabricFcZonePolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;FabricFcZonePolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFabricFcZonePolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FabricFcZonePolicy 

### Example 2
```powershell
PS C:\>Get-IntersightFabricFcZonePolicy -Name "MoName"|  Remove-IntersightFabricFcZonePolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FabricFcZonePolicy.

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

[Get-IntersightFabricFcZonePolicy](./Get-IntersightFabricFcZonePolicy.md)

[New-IntersightFabricFcZonePolicy](./New-IntersightFabricFcZonePolicy.md)

[Set-IntersightFabricFcZonePolicy](./Set-IntersightFabricFcZonePolicy.md)

