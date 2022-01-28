---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Remove-IntersightWorkflowSolutionActionDefinition

## SYNOPSIS
Remove the WorkflowSolutionActionDefinition

## SYNTAX

```
Remove-IntersightWorkflowSolutionActionDefinition -Moid <String> [<CommonParameters>]
```

## DESCRIPTION
Delete a &amp;apos;WorkflowSolutionActionDefinition&amp;apos; resource.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-IntersightWorkflowSolutionActionDefinition -Moid "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
```
Above cmdlet removes the specified WorkflowSolutionActionDefinition 

### Example 2
```powershell
PS C:\>Get-IntersightWorkflowSolutionActionDefinition -Name "MoName"|  Remove-IntersightWorkflowSolutionActionDefinition
```
Above cmdlet pipes the output of Get cmdlet to Remove cmdlet

## PARAMETERS

### -Moid
Specifyies the Moid of WorkflowSolutionActionDefinition.

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

[Set-IntersightWorkflowSolutionActionDefinition](./Set-IntersightWorkflowSolutionActionDefinition.md)

[Get-IntersightWorkflowSolutionActionDefinition](./Get-IntersightWorkflowSolutionActionDefinition.md)

[New-IntersightWorkflowSolutionActionDefinition](./New-IntersightWorkflowSolutionActionDefinition.md)

