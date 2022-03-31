---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightKubernetesBaremetalNodeProfile

## SYNOPSIS
Remove the KubernetesBaremetalNodeProfile

## SYNTAX

```
Remove-IntersightKubernetesBaremetalNodeProfile -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;KubernetesBaremetalNodeProfile&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightKubernetesBaremetalNodeProfile -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified KubernetesBaremetalNodeProfile 

### Example 2
```powershell
PS C:\>Get-IntersightKubernetesBaremetalNodeProfile -Name "MoName"|  Remove-IntersightKubernetesBaremetalNodeProfile
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of KubernetesBaremetalNodeProfile.

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

[New-IntersightKubernetesBaremetalNodeProfile](./New-IntersightKubernetesBaremetalNodeProfile.md)

[Get-IntersightKubernetesBaremetalNodeProfile](./Get-IntersightKubernetesBaremetalNodeProfile.md)

[Set-IntersightKubernetesBaremetalNodeProfile](./Set-IntersightKubernetesBaremetalNodeProfile.md)

