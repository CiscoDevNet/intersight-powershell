---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightIamIpAddress

## SYNOPSIS
Remove the IamIpAddress

## SYNTAX

```
Remove-IntersightIamIpAddress -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;IamIpAddress&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightIamIpAddress -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified IamIpAddress 

### Example 2
```powershell
PS C:\>Get-IntersightIamIpAddress -Name "MoName"|  Remove-IntersightIamIpAddress
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of IamIpAddress.

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

[Get-IntersightIamIpAddress](./Get-IntersightIamIpAddress.md)

[New-IntersightIamIpAddress](./New-IntersightIamIpAddress.md)

[Set-IntersightIamIpAddress](./Set-IntersightIamIpAddress.md)

