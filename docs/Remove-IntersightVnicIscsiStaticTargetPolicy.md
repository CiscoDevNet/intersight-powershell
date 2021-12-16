---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightVnicIscsiStaticTargetPolicy

## SYNOPSIS
Remove the VnicIscsiStaticTargetPolicy

## SYNTAX

```
Remove-IntersightVnicIscsiStaticTargetPolicy -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;VnicIscsiStaticTargetPolicy&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightVnicIscsiStaticTargetPolicy -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified VnicIscsiStaticTargetPolicy 

### Example 2
```powershell
PS C:\>Get-IntersightVnicIscsiStaticTargetPolicy -Name "MoName"|  Remove-IntersightVnicIscsiStaticTargetPolicy
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of VnicIscsiStaticTargetPolicy.

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

[Set-IntersightVnicIscsiStaticTargetPolicy](./Set-IntersightVnicIscsiStaticTargetPolicy.md)

[Get-IntersightVnicIscsiStaticTargetPolicy](./Get-IntersightVnicIscsiStaticTargetPolicy.md)

[New-IntersightVnicIscsiStaticTargetPolicy](./New-IntersightVnicIscsiStaticTargetPolicy.md)

