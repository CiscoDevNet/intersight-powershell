---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightWorkflowServiceItemOutput

## SYNOPSIS
Remove the WorkflowServiceItemOutput

## SYNTAX

```
Remove-IntersightWorkflowServiceItemOutput -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &apos;WorkflowServiceItemOutput&apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightWorkflowServiceItemOutput -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified WorkflowServiceItemOutput 

### Example 2
```powershell
PS C:\>Get-IntersightWorkflowServiceItemOutput -Name "MoName"|  Remove-IntersightWorkflowServiceItemOutput
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of WorkflowServiceItemOutput.

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

[Set-IntersightWorkflowServiceItemOutput](./Set-IntersightWorkflowServiceItemOutput.md)

[Get-IntersightWorkflowServiceItemOutput](./Get-IntersightWorkflowServiceItemOutput.md)

[New-IntersightWorkflowServiceItemOutput](./New-IntersightWorkflowServiceItemOutput.md)

