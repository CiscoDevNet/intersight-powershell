---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightIamLdapProvider

## SYNOPSIS
Remove the IamLdapProvider

## SYNTAX

```
Remove-IntersightIamLdapProvider -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;IamLdapProvider&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightIamLdapProvider -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified IamLdapProvider 

### Example 2
```powershell
PS C:\>Get-IntersightIamLdapProvider -Name "MoName"|  Remove-IntersightIamLdapProvider
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of IamLdapProvider.

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

[Set-IntersightIamLdapProvider](./Set-IntersightIamLdapProvider.md)

[New-IntersightIamLdapProvider](./New-IntersightIamLdapProvider.md)

[Get-IntersightIamLdapProvider](./Get-IntersightIamLdapProvider.md)

