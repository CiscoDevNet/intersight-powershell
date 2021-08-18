---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightKubernetesVirtualMachineNodeProfile

## SYNOPSIS
Remove the KubernetesVirtualMachineNodeProfile

## SYNTAX

```
Remove-IntersightKubernetesVirtualMachineNodeProfile -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;KubernetesVirtualMachineNodeProfile&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightKubernetesVirtualMachineNodeProfile -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified KubernetesVirtualMachineNodeProfile 

### Example 2
```powershell
PS C:\>Get-IntersightKubernetesVirtualMachineNodeProfile -Name "MoName"|  Remove-IntersightKubernetesVirtualMachineNodeProfile
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of KubernetesVirtualMachineNodeProfile.

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

[Set-IntersightKubernetesVirtualMachineNodeProfile](./Set-IntersightKubernetesVirtualMachineNodeProfile.md)

[Get-IntersightKubernetesVirtualMachineNodeProfile](./Get-IntersightKubernetesVirtualMachineNodeProfile.md)

[New-IntersightKubernetesVirtualMachineNodeProfile](./New-IntersightKubernetesVirtualMachineNodeProfile.md)

