---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightHyperflexServerModel

## SYNOPSIS
Remove the HyperflexServerModel

## SYNTAX

```
Remove-IntersightHyperflexServerModel -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;HyperflexServerModel&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightHyperflexServerModel -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified HyperflexServerModel 

### Example 2
```powershell
PS C:\>Get-IntersightHyperflexServerModel -Name "MoName"|  Remove-IntersightHyperflexServerModel
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of HyperflexServerModel.

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

[Set-IntersightHyperflexServerModel](./Set-IntersightHyperflexServerModel.md)

[Get-IntersightHyperflexServerModel](./Get-IntersightHyperflexServerModel.md)

[New-IntersightHyperflexServerModel](./New-IntersightHyperflexServerModel.md)

