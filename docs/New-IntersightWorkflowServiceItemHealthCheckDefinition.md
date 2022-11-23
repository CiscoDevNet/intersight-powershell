---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightWorkflowServiceItemHealthCheckDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightWorkflowServiceItemHealthCheckDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Category< string>][-CommonCauseAndResolution< string>][-Description< string>][-ExecutionMode< WorkflowServiceItemHealthCheckDefinition.ExecutionModeEnum>][-HealthCheckWorkflow< WorkflowServiceItemActionWorkflowDefinition>][-Label< string>][-Moid< string>][[-Name]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;WorkflowServiceItemHealthCheckDefinition&apos; resource.

## PARAMETERS

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Category
Category that the health check belongs to.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CommonCauseAndResolution
Static information detailing the common cause for the health check failure.\nIt also gives possible remediation actions that can be taken to remedy the health check failure.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the health check definition.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExecutionMode
Execution mode of the health check on service item.\n* `OnDemand` - Execute the health check on-demand.\n* `Periodic` - Execute the health check on a periodic basis.

```yaml
Type: WorkflowServiceItemHealthCheckDefinition.ExecutionModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HealthCheckWorkflow
Workflow that is associated with this health check definition. This workflow will be run on execution of the respective health check definition.

Note :- Use Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition to create the object of complex type WorkflowServiceItemActionWorkflowDefinition

```yaml
Type: WorkflowServiceItemActionWorkflowDefinition
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Label
Label for the health check definition that is displayed on UI.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Name of the health check definition.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightWorkflowServiceItemHealthCheckDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowServiceItemHealthCheckDefinition](./Get-IntersightWorkflowServiceItemHealthCheckDefinition.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition](./Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition.md)

[Remove-IntersightWorkflowServiceItemHealthCheckDefinition](./Remove-IntersightWorkflowServiceItemHealthCheckDefinition.md)

[Set-IntersightWorkflowServiceItemHealthCheckDefinition](./Set-IntersightWorkflowServiceItemHealthCheckDefinition.md)
