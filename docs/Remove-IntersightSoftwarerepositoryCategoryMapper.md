---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightSoftwarerepositoryCategoryMapper

## SYNOPSIS
Remove the SoftwarerepositoryCategoryMapper

## SYNTAX

```
Remove-IntersightSoftwarerepositoryCategoryMapper -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;SoftwarerepositoryCategoryMapper&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightSoftwarerepositoryCategoryMapper -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified SoftwarerepositoryCategoryMapper 

### Example 2
```powershell
PS C:\>Get-IntersightSoftwarerepositoryCategoryMapper -Name "MoName"|  Remove-IntersightSoftwarerepositoryCategoryMapper
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of SoftwarerepositoryCategoryMapper.

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

[Set-IntersightSoftwarerepositoryCategoryMapper](./Set-IntersightSoftwarerepositoryCategoryMapper.md)

[Get-IntersightSoftwarerepositoryCategoryMapper](./Get-IntersightSoftwarerepositoryCategoryMapper.md)

[New-IntersightSoftwarerepositoryCategoryMapper](./New-IntersightSoftwarerepositoryCategoryMapper.md)

