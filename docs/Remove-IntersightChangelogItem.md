---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightChangelogItem

## SYNOPSIS
Remove the ChangelogItem

## SYNTAX

```
Remove-IntersightChangelogItem -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;ChangelogItem&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightChangelogItem -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified ChangelogItem 

### Example 2
```powershell
PS C:\>Get-IntersightChangelogItem -Name "MoName"|  Remove-IntersightChangelogItem
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of ChangelogItem.

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

[Get-IntersightChangelogItem](./Get-IntersightChangelogItem.md)

[New-IntersightChangelogItem](./New-IntersightChangelogItem.md)

[Set-IntersightChangelogItem](./Set-IntersightChangelogItem.md)

