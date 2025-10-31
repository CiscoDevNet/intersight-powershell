---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightCapabilityServerPcieConnectivityCatalog

## SYNOPSIS
Remove the CapabilityServerPcieConnectivityCatalog

## SYNTAX

```
Remove-IntersightCapabilityServerPcieConnectivityCatalog -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;CapabilityServerPcieConnectivityCatalog&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightCapabilityServerPcieConnectivityCatalog -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified CapabilityServerPcieConnectivityCatalog 

### Example 2
```powershell
PS C:\>Get-IntersightCapabilityServerPcieConnectivityCatalog -Name "MoName"|  Remove-IntersightCapabilityServerPcieConnectivityCatalog
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of CapabilityServerPcieConnectivityCatalog.

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

[Get-IntersightCapabilityServerPcieConnectivityCatalog](./Get-IntersightCapabilityServerPcieConnectivityCatalog.md)

[New-IntersightCapabilityServerPcieConnectivityCatalog](./New-IntersightCapabilityServerPcieConnectivityCatalog.md)

[Set-IntersightCapabilityServerPcieConnectivityCatalog](./Set-IntersightCapabilityServerPcieConnectivityCatalog.md)

