---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightFabricNetFlowRecord

## SYNOPSIS
Remove the FabricNetFlowRecord

## SYNTAX

```
Remove-IntersightFabricNetFlowRecord -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;FabricNetFlowRecord&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightFabricNetFlowRecord -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified FabricNetFlowRecord 

### Example 2
```powershell
PS C:\>Get-IntersightFabricNetFlowRecord -Name "MoName"|  Remove-IntersightFabricNetFlowRecord
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of FabricNetFlowRecord.

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

[Get-IntersightFabricNetFlowRecord](./Get-IntersightFabricNetFlowRecord.md)

[New-IntersightFabricNetFlowRecord](./New-IntersightFabricNetFlowRecord.md)

[Set-IntersightFabricNetFlowRecord](./Set-IntersightFabricNetFlowRecord.md)

