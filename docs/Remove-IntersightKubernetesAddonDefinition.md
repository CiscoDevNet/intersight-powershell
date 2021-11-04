---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightKubernetesAddonDefinition

## SYNOPSIS
Remove the KubernetesAddonDefinition

## SYNTAX

```
Remove-IntersightKubernetesAddonDefinition -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;KubernetesAddonDefinition&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightKubernetesAddonDefinition -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified KubernetesAddonDefinition 

### Example 2
```powershell
PS C:\>Get-IntersightKubernetesAddonDefinition -Name "MoName"|  Remove-IntersightKubernetesAddonDefinition
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of KubernetesAddonDefinition.

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

[Set-IntersightKubernetesAddonDefinition](./Set-IntersightKubernetesAddonDefinition.md)

[Get-IntersightKubernetesAddonDefinition](./Get-IntersightKubernetesAddonDefinition.md)

[New-IntersightKubernetesAddonDefinition](./New-IntersightKubernetesAddonDefinition.md)

