---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightCapabilityDimmsEndpointDescriptor

## SYNOPSIS
Remove the CapabilityDimmsEndpointDescriptor

## SYNTAX

```
Remove-IntersightCapabilityDimmsEndpointDescriptor -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;CapabilityDimmsEndpointDescriptor&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightCapabilityDimmsEndpointDescriptor -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified CapabilityDimmsEndpointDescriptor 

### Example 2
```powershell
PS C:\>Get-IntersightCapabilityDimmsEndpointDescriptor -Name "MoName"|  Remove-IntersightCapabilityDimmsEndpointDescriptor
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of CapabilityDimmsEndpointDescriptor.

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

[Get-IntersightCapabilityDimmsEndpointDescriptor](./Get-IntersightCapabilityDimmsEndpointDescriptor.md)

[New-IntersightCapabilityDimmsEndpointDescriptor](./New-IntersightCapabilityDimmsEndpointDescriptor.md)

[Set-IntersightCapabilityDimmsEndpointDescriptor](./Set-IntersightCapabilityDimmsEndpointDescriptor.md)

