---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightIamUserGroup

## SYNOPSIS
Remove the IamUserGroup

## SYNTAX

```
Remove-IntersightIamUserGroup -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;IamUserGroup&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightIamUserGroup -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified IamUserGroup 

### Example 2
```powershell
PS C:\>Get-IntersightIamUserGroup -Name "MoName"|  Remove-IntersightIamUserGroup
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of IamUserGroup.

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

[Set-IntersightIamUserGroup](./Set-IntersightIamUserGroup.md)

[Get-IntersightIamUserGroup](./Get-IntersightIamUserGroup.md)

[New-IntersightIamUserGroup](./New-IntersightIamUserGroup.md)

