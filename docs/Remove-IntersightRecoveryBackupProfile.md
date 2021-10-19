---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightRecoveryBackupProfile

## SYNOPSIS
Remove the RecoveryBackupProfile

## SYNTAX

```
Remove-IntersightRecoveryBackupProfile -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;RecoveryBackupProfile&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightRecoveryBackupProfile -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified RecoveryBackupProfile 

### Example 2
```powershell
PS C:\>Get-IntersightRecoveryBackupProfile -Name "MoName"|  Remove-IntersightRecoveryBackupProfile
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of RecoveryBackupProfile.

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

[Set-IntersightRecoveryBackupProfile](./Set-IntersightRecoveryBackupProfile.md)

[Get-IntersightRecoveryBackupProfile](./Get-IntersightRecoveryBackupProfile.md)

[New-IntersightRecoveryBackupProfile](./New-IntersightRecoveryBackupProfile.md)

