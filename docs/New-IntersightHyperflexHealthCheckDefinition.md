---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightHyperflexHealthCheckDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightHyperflexHealthCheckDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Category< string>][-CommonCauses< string>][-Configuration< string>][-Description< string>][-HealthImpact< string>][-InternalName< string>][-MinimumHyperFlexVersion< string>][-Moid< string>][[-Name]< string>][-Reference< string>][-Resolution< string>][-ScriptExecutionMode< HyperflexHealthCheckDefinition.ScriptExecutionModeEnum>][-ScriptExecutionOnComputeNodes< bool>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TargetExecutionType< HyperflexHealthCheckDefinition.TargetExecutionTypeEnum>][-Timeout< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &amp;apos;HyperflexHealthCheckDefinition&amp;apos; resource.

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

### -CommonCauses
Static information detailing the common causes for the health check failure.

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

### -Configuration
Execution configuration fo the health check script.

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

### -HealthImpact
Static information detailing the health impact of the health check failure.

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

### -InternalName
Internal name of the health check definition.

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

### -MinimumHyperFlexVersion
Minimum HyperFlex version that the check is supported on. Defaults to version 3.0.1.

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

### -Reference
Static information containing additional reference for the health check.

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

### -Resolution
Static information detailing the possible remediation actions that can be taken to remedy the health check failure.

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

### -ScriptExecutionMode
Execution mode of the health script on the HyperFlex cluster.\n* `ON_DEMAND` - Execute the health check on-demand.\n* `SCHEDULED` - Execute the health check on a scheduled interval.

```yaml
Type: HyperflexHealthCheckDefinition.ScriptExecutionModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ScriptExecutionOnComputeNodes
Indicates if the script needs to be executed on HyperFlex compute nodes. |\nTypically, scripts are only executed on the storage Nodes.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
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

### -TargetExecutionType
Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster.\n* `EXECUTE_ON_LEADER_NODE` - Execute the health check script only on the HyperFlex cluster&amp;apos;s leader node.\n* `EXECUTE_ON_ALL_NODES` - Execute health check on all nodes and aggregate the results.\n* `EXECUTE_ON_ALL_NODES_AND_AGGREGATE` - Execute the health check on all Nodes and perform custom aggregation.

```yaml
Type: HyperflexHealthCheckDefinition.TargetExecutionTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Timeout
Health check script execution timeout.

```yaml
Type: long
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
PS C:\> New-IntersightHyperflexHealthCheckDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightHyperflexHealthCheckDefinition](./Set-IntersightHyperflexHealthCheckDefinition.md)

[Remove-IntersightHyperflexHealthCheckDefinition](./Remove-IntersightHyperflexHealthCheckDefinition.md)

[Get-IntersightHyperflexHealthCheckDefinition](./Get-IntersightHyperflexHealthCheckDefinition.md)

[Initialize-IntersightHyperflexHealthCheckScriptInfo](./Initialize-IntersightHyperflexHealthCheckScriptInfo.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
