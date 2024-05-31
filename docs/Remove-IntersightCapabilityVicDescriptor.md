---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightCapabilityVicDescriptor

## SYNOPSIS
Remove the CapabilityVicDescriptor

## SYNTAX

```
Remove-IntersightCapabilityVicDescriptor -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;CapabilityVicDescriptor&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightCapabilityVicDescriptor -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified CapabilityVicDescriptor 

### Example 2
```powershell
PS C:\>Get-IntersightCapabilityVicDescriptor -Name "MoName"|  Remove-IntersightCapabilityVicDescriptor
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of CapabilityVicDescriptor.

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

[Get-IntersightCapabilityVicDescriptor](./Get-IntersightCapabilityVicDescriptor.md)

[New-IntersightCapabilityVicDescriptor](./New-IntersightCapabilityVicDescriptor.md)

[Set-IntersightCapabilityVicDescriptor](./Set-IntersightCapabilityVicDescriptor.md)

