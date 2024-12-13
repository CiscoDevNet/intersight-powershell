---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFunctionsRuntime

## SYNOPSIS
Remove the FunctionsRuntime

## SYNTAX

```
Remove-IntersightFunctionsRuntime -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;FunctionsRuntime&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFunctionsRuntime -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FunctionsRuntime 

### Example 2
```powershell
PS C:\>Get-IntersightFunctionsRuntime -Name "MoName"|  Remove-IntersightFunctionsRuntime
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FunctionsRuntime.

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

[Get-IntersightFunctionsRuntime](./Get-IntersightFunctionsRuntime.md)

[New-IntersightFunctionsRuntime](./New-IntersightFunctionsRuntime.md)

[Set-IntersightFunctionsRuntime](./Set-IntersightFunctionsRuntime.md)

