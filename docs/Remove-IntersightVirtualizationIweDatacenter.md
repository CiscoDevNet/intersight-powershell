---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightVirtualizationIweDatacenter

## SYNOPSIS
Remove the VirtualizationIweDatacenter

## SYNTAX

```
Remove-IntersightVirtualizationIweDatacenter -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;VirtualizationIweDatacenter&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightVirtualizationIweDatacenter -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified VirtualizationIweDatacenter 

### Example 2
```powershell
PS C:\>Get-IntersightVirtualizationIweDatacenter -Name "MoName"|  Remove-IntersightVirtualizationIweDatacenter
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of VirtualizationIweDatacenter.

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

[Set-IntersightVirtualizationIweDatacenter](./Set-IntersightVirtualizationIweDatacenter.md)

[Get-IntersightVirtualizationIweDatacenter](./Get-IntersightVirtualizationIweDatacenter.md)

[New-IntersightVirtualizationIweDatacenter](./New-IntersightVirtualizationIweDatacenter.md)

