---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightWorkflowTemplateEvaluation

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightWorkflowTemplateEvaluation [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ExpectedOutputDataType< WorkflowBaseDataType>][-Moid< string>][-Stages< System.Collections.Generic.List`1[TemplateTransformationStage]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Values< object>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;WorkflowTemplateEvaluation&apos; resource.

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

### -ExpectedOutputDataType
Expected output type of the template. Required to type cast the output.

Note :- Use Initialize-IntersightWorkflowBaseDataType to create the object of complex type WorkflowBaseDataType

```yaml
Type: WorkflowBaseDataType
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

### -Stages


Note :- Use Initialize-IntersightTemplateTransformationStage to create the object of complex type TemplateTransformationStage

```yaml
Type: System.Collections.Generic.List`1[TemplateTransformationStage]
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

### -Values
Values to be fed to the template for execution.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
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
PS C:\> New-IntersightWorkflowTemplateEvaluation
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[Initialize-IntersightTemplateTransformationStage](./Initialize-IntersightTemplateTransformationStage.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
