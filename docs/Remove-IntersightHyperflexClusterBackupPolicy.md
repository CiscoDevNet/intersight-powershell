---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightHyperflexClusterBackupPolicy

## SYNOPSIS
Remove the HyperflexClusterBackupPolicy

## SYNTAX

```
Remove-IntersightHyperflexClusterBackupPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;HyperflexClusterBackupPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightHyperflexClusterBackupPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified HyperflexClusterBackupPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightHyperflexClusterBackupPolicy -Name "MoName"|  Remove-IntersightHyperflexClusterBackupPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of HyperflexClusterBackupPolicy.

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

[Set-IntersightHyperflexClusterBackupPolicy](./Set-IntersightHyperflexClusterBackupPolicy.md)

[New-IntersightHyperflexClusterBackupPolicy](./New-IntersightHyperflexClusterBackupPolicy.md)

[Get-IntersightHyperflexClusterBackupPolicy](./Get-IntersightHyperflexClusterBackupPolicy.md)

