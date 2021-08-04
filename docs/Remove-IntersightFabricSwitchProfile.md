---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFabricSwitchProfile

## SYNOPSIS
Remove the FabricSwitchProfile

## SYNTAX

```
Remove-IntersightFabricSwitchProfile -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;FabricSwitchProfile&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFabricSwitchProfile -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FabricSwitchProfile 

### Example 2
```powershell
PS C:\>Get-IntersightFabricSwitchProfile -Name "MoName"|  Remove-IntersightFabricSwitchProfile
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FabricSwitchProfile.

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

[Set-IntersightFabricSwitchProfile](./Set-IntersightFabricSwitchProfile.md)

[Get-IntersightFabricSwitchProfile](./Get-IntersightFabricSwitchProfile.md)

[New-IntersightFabricSwitchProfile](./New-IntersightFabricSwitchProfile.md)

