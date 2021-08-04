---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightCapabilityIoCardDescriptor

## SYNOPSIS
Remove the CapabilityIoCardDescriptor

## SYNTAX

```
Remove-IntersightCapabilityIoCardDescriptor -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;CapabilityIoCardDescriptor&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightCapabilityIoCardDescriptor -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified CapabilityIoCardDescriptor 

### Example 2
```powershell
PS C:\>Get-IntersightCapabilityIoCardDescriptor -Name "MoName"|  Remove-IntersightCapabilityIoCardDescriptor
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of CapabilityIoCardDescriptor.

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

[Get-IntersightCapabilityIoCardDescriptor](./Get-IntersightCapabilityIoCardDescriptor.md)

[New-IntersightCapabilityIoCardDescriptor](./New-IntersightCapabilityIoCardDescriptor.md)

[Set-IntersightCapabilityIoCardDescriptor](./Set-IntersightCapabilityIoCardDescriptor.md)

