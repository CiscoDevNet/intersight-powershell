---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightWorkflowAnsibleBatchExecutor

## SYNOPSIS
Remove the WorkflowAnsibleBatchExecutor

## SYNTAX

```
Remove-IntersightWorkflowAnsibleBatchExecutor -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;WorkflowAnsibleBatchExecutor&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightWorkflowAnsibleBatchExecutor -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified WorkflowAnsibleBatchExecutor 

### Example 2
```powershell
PS C:\>Get-IntersightWorkflowAnsibleBatchExecutor -Name "MoName"|  Remove-IntersightWorkflowAnsibleBatchExecutor
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of WorkflowAnsibleBatchExecutor.

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

[New-IntersightWorkflowAnsibleBatchExecutor](./New-IntersightWorkflowAnsibleBatchExecutor.md)

[Get-IntersightWorkflowAnsibleBatchExecutor](./Get-IntersightWorkflowAnsibleBatchExecutor.md)

[Set-IntersightWorkflowAnsibleBatchExecutor](./Set-IntersightWorkflowAnsibleBatchExecutor.md)

