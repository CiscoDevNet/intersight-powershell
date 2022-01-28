---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFirmwareMswitchDescriptor

## SYNOPSIS
Remove the FirmwareMswitchDescriptor

## SYNTAX

```
Remove-IntersightFirmwareMswitchDescriptor -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;FirmwareMswitchDescriptor&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFirmwareMswitchDescriptor -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FirmwareMswitchDescriptor 

### Example 2
```powershell
PS C:\>Get-IntersightFirmwareMswitchDescriptor -Name "MoName"|  Remove-IntersightFirmwareMswitchDescriptor
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FirmwareMswitchDescriptor.

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

[Get-IntersightFirmwareMswitchDescriptor](./Get-IntersightFirmwareMswitchDescriptor.md)

[New-IntersightFirmwareMswitchDescriptor](./New-IntersightFirmwareMswitchDescriptor.md)

[Set-IntersightFirmwareMswitchDescriptor](./Set-IntersightFirmwareMswitchDescriptor.md)

