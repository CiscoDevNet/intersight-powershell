---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightResourcepoolChassisQualificationPolicy

## SYNOPSIS
Remove the ResourcepoolChassisQualificationPolicy

## SYNTAX

```
Remove-IntersightResourcepoolChassisQualificationPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;ResourcepoolChassisQualificationPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightResourcepoolChassisQualificationPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified ResourcepoolChassisQualificationPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightResourcepoolChassisQualificationPolicy -Name "MoName"|  Remove-IntersightResourcepoolChassisQualificationPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of ResourcepoolChassisQualificationPolicy.

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

[Get-IntersightResourcepoolChassisQualificationPolicy](./Get-IntersightResourcepoolChassisQualificationPolicy.md)

[New-IntersightResourcepoolChassisQualificationPolicy](./New-IntersightResourcepoolChassisQualificationPolicy.md)

[Set-IntersightResourcepoolChassisQualificationPolicy](./Set-IntersightResourcepoolChassisQualificationPolicy.md)

