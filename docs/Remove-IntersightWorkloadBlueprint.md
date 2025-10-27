---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightWorkloadBlueprint

## SYNOPSIS
Remove the WorkloadBlueprint

## SYNTAX

```
Remove-IntersightWorkloadBlueprint -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;WorkloadBlueprint&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightWorkloadBlueprint -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified WorkloadBlueprint 

### Example 2
```powershell
PS C:\>Get-IntersightWorkloadBlueprint -Name "MoName"|  Remove-IntersightWorkloadBlueprint
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of WorkloadBlueprint.

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

[Get-IntersightWorkloadBlueprint](./Get-IntersightWorkloadBlueprint.md)

[New-IntersightWorkloadBlueprint](./New-IntersightWorkloadBlueprint.md)

[Set-IntersightWorkloadBlueprint](./Set-IntersightWorkloadBlueprint.md)

