---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkflowUiDisplayMetadata

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkflowUiDisplayMetadata [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-MetaDefinition< MoBaseMoRelationship>][[-Moid]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UiFormConfigs< System.Collections.Generic.List`1[WorkflowUiFormConfig]>][-UiViewConfigs< System.Collections.Generic.List`1[WorkflowUiViewConfig]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkflowUiDisplayMetadata&apos; resource.

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

### -MetaDefinition
A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: MoBaseMoRelationship
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

Required: true
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

### -UiFormConfigs


Note :- Use Initialize-IntersightWorkflowUiFormConfig to create the object of complex type WorkflowUiFormConfig

```yaml
Type: System.Collections.Generic.List`1[WorkflowUiFormConfig]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UiViewConfigs


Note :- Use Initialize-IntersightWorkflowUiViewConfig to create the object of complex type WorkflowUiViewConfig

```yaml
Type: System.Collections.Generic.List`1[WorkflowUiViewConfig]
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
PS C:\> Set-IntersightWorkflowUiDisplayMetadata
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowUiDisplayMetadata](./Get-IntersightWorkflowUiDisplayMetadata.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkflowUiFormConfig](./Initialize-IntersightWorkflowUiFormConfig.md)

[Initialize-IntersightWorkflowUiViewConfig](./Initialize-IntersightWorkflowUiViewConfig.md)

[New-IntersightWorkflowUiDisplayMetadata](./New-IntersightWorkflowUiDisplayMetadata.md)

[Remove-IntersightWorkflowUiDisplayMetadata](./Remove-IntersightWorkflowUiDisplayMetadata.md)
