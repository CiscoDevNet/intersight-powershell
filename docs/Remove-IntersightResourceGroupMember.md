---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightResourceGroupMember

## SYNOPSIS
Remove the ResourceGroupMember

## SYNTAX

```
Remove-IntersightResourceGroupMember -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;ResourceGroupMember&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightResourceGroupMember -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified ResourceGroupMember 

### Example 2
```powershell
PS C:\>Get-IntersightResourceGroupMember -Name "MoName"|  Remove-IntersightResourceGroupMember
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of ResourceGroupMember.

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

[Get-IntersightResourceGroupMember](./Get-IntersightResourceGroupMember.md)

